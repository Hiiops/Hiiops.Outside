using DotNet.Utilities;
using Hiiops.Applet.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using VOL.Core.BaseProvider;
using VOL.Core.Configuration;
using VOL.Core.Enums;
using VOL.Core.Extensions;
using VOL.Core.Extensions.AutofacManager;
using VOL.Core.Services;
using VOL.Core.UserManager;
using VOL.Core.Utilities;
using VOL.Entity.DomainModels;
using VOL.Entity.DomainModels.Cart;

namespace Hiiops.Applet.Services
{
    public class AppletService : BaseService, IAppletLoginService, IDependency
    {
        public AppletService()
        {

        }
        public static IAppletLoginService Instance
        {
            get { return AutofacContainerModule.GetService<IAppletLoginService>(); }
        }


        /// <summary>
        /// WebApi登陆
        /// </summary>
        /// <param name="loginInfo"></param>
        /// <param name="verificationCode"></param>
        /// <returns></returns>
        public async Task<WebResponseContent> Login(LoginInfo loginInfo)
        {
            string msg = string.Empty;
            WebResponseContent responseContent = new WebResponseContent();
            try
            {

                var db = DbContext.Set<Hiiops_Cart_SellerUser>();
                var user = await db.Where(x => x.Phone == loginInfo.UserName ||
                x.OpenId == loginInfo.UserName || x.Account == loginInfo.UserName).FirstOrDefaultAsync();
                if (user == null || loginInfo.PassWord.Trim() != (user.Password ?? "").DecryptDES(AppSetting.Secret.User))
                    return responseContent.Error(ResponseType.LoginError);

                string token = JwtHelper.IssueJwt(user.Id.ToString());
                user.Token = token;
                responseContent.Data = new { token, user.NickName, user.Phone, user.Account, user.Country, user.HeadImgUrl, user.Id, user.Name, user.Privilege, user.Province, user.Remark, user.SearchKey, user.Sex, user.Status };
                db.Update(user);

                SellerContent.Current.LogOut(user.Id);

                loginInfo.PassWord = string.Empty;

                return responseContent.OK(ResponseType.LoginSuccess);
            }
            catch (Exception ex)
            {
                msg = ex.Message + ex.StackTrace;
                return responseContent.Error(ResponseType.ServerError);
            }
            finally
            {
                Logger.Info(LoggerType.Login, loginInfo.Serialize(), responseContent.Message, msg);
            }
        }

        /// <summary>
        ///当token将要过期时，提前置换一个新的token
        /// </summary>
        /// <returns></returns>
        public async Task<WebResponseContent> ReplaceToken()
        {
            var db = DbContext.Set<Hiiops_Cart_SellerUser>();
            WebResponseContent responseContent = new WebResponseContent();
            string error = "";
            Hiiops_Cart_LoginInfo loginInfo = null;
            try
            {
                string requestToken = HttpContext.Current.Request.Headers[AppSetting.TokenHeaderName];
                requestToken = requestToken?.Replace("Bearer ", "");
                if (SellerContent.Current.Token != requestToken) return responseContent.Error("Token已失效!");

                if (JwtHelper.IsExp(requestToken)) return responseContent.Error("Token已过期!");

                int Id = SellerContent.Current.Id;
                loginInfo = await db.Where(x => x.Id == Id).Select(s => new Hiiops_Cart_LoginInfo()
                {
                    Id = Id,
                    Account = s.Account,
                    UnionId = s.UnionId,
                    NickNme = s.NickName,
                    OpenId = s.OpenId,
                    Phone = s.Phone,
                    Enable = s.Status,
                    Token = s.Token,
                    UserName = s.Name
                }).FirstAsync();

                if (loginInfo == null) return responseContent.Error("未查到用户信息!");

                string token = JwtHelper.IssueJwt(Id.ToString());
                //移除当前缓存
                base.CacheContext.Remove(Id.GetUserIdKey());
                //只更新的token字段 
                DbContext.Database.ExecuteSqlRaw($"UPDATA Hiiops_Cart_SellerUser SET Token = '{token}'");
                responseContent.OK(null, token);
            }
            catch (Exception ex)
            {
                error = ex.Message + ex.StackTrace + ex.Source;
                responseContent.Error("token替换出错了..");
            }
            finally
            {
                Logger.Info(LoggerType.ReplaceToeken, ($"用户Id:{loginInfo?.Id},用户{loginInfo?.UserName}")
                    + (responseContent.Status ? "token替换成功" : "token替换失败"), null, error);
            }
            return responseContent;
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<WebResponseContent> ModifyPwd(string oldPwd, string newPwd, string verificationCode)
        {
            oldPwd = oldPwd?.Trim();
            newPwd = newPwd?.Trim();
            string message = "";
            WebResponseContent webResponse = new WebResponseContent();
            try
            {
                if (string.IsNullOrEmpty(oldPwd)) return webResponse.Error("旧密码不能为空");
                if (string.IsNullOrEmpty(newPwd)) return webResponse.Error("新密码不能为空");
                if (newPwd.Length < 6) return webResponse.Error("密码不能少于6位");

                int userId = SellerContent.Current.Id;

                var a = await DbContext.Set<Hiiops_Cart_SellerUser>().Where(x => x.Id == userId).FirstOrDefaultAsync();
                string userCurrentPwd = a.Password;

                string _oldPwd = oldPwd.EncryptDES(AppSetting.Secret.User);
                if (_oldPwd != userCurrentPwd) return webResponse.Error("旧密码不正确");

                string _newPwd = newPwd.EncryptDES(AppSetting.Secret.User);
                if (userCurrentPwd == _newPwd) return webResponse.Error("新密码不能与旧密码相同");

                await Task.Run(() =>
                {
                    DbContext.Database.ExecuteSqlRaw($"UPDATA Hiiops_Cart_SellerUser SET Password = '{_newPwd}' , ModifyDate = '{DateTime.Now}'");

                });

                webResponse.OK("密码修改成功");
            }
            catch (Exception ex)
            {
                message = ex.Message;
                webResponse.Error("服务器了点问题,请稍后再试");
            }
            finally
            {
                if (message == "")
                {
                    Logger.OK(LoggerType.ApiModifyPwd, "密码修改成功");
                }
                else
                {
                    Logger.Error(LoggerType.ApiModifyPwd, message);
                }
            }
            return webResponse;
        }
        /// <summary>
        /// 个人中心获取当前用户信息
        /// </summary>
        /// <returns></returns>
        public async Task<WebResponseContent> GetCurrentLoginInfo()
        {
            var data = await DbContext.Set<Hiiops_Cart_SellerUser>()
                .Where(x => x.Id == SellerContent.Current.Id)
                .Select(s => new
                {
                    s.Id,
                    s.Account,
                    s.UnionId,
                    NickNme = s.NickName,
                    s.OpenId,
                    s.Phone,
                    Enable = s.Status,
                    s.Token,
                    UserName = s.Name
                })
                .FirstOrDefaultAsync();
            return new WebResponseContent().OK(null, data);
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="ResinInfo">resinInfo</param> 
        /// <returns></returns>
        public async Task<WebResponseContent> Resign(Hiiops_Cart_SellerUser hiiops_Cart_SellerUser)
        {
            //判断一下系统是否存在账户
            var seller = DbContext.Set<Hiiops_Cart_SellerUser>()
                .Where(x => x.Account == hiiops_Cart_SellerUser.Account || x.OpenId == hiiops_Cart_SellerUser.OpenId || x.Phone == hiiops_Cart_SellerUser.Phone || x.Email == hiiops_Cart_SellerUser.Email)
                .FirstOrDefaultAsync();
            if (seller != null)
                return new WebResponseContent().Error("账户已经存在,请直接登录");


            hiiops_Cart_SellerUser.Password = hiiops_Cart_SellerUser.Password.EncryptDES(AppSetting.Secret.User);
            hiiops_Cart_SellerUser.SetCreateDefaultVal();

            //await DbContext.AddAsync<Hiiops_Cart_SellerUser>(hiiops_Cart_SellerUser);
            DbContext.Entry(hiiops_Cart_SellerUser).State = EntityState.Added;
            int result = await DbContext.SaveChangesAsync();
            if (result > 0)
            {
                string token = JwtHelper.IssueJwt(hiiops_Cart_SellerUser.Id.ToString());
                hiiops_Cart_SellerUser.Token = token;
                //更新一下Token
                await Task.Run(() =>
               {
                   DbContext.Database.ExecuteSqlRaw($"UPDATA Hiiops_Cart_SellerUser SET Token = '{token}' , ModifyDate = '{DateTime.Now}'");

               });
                return new WebResponseContent().OK(message: "注册成功", data: new { token, hiiops_Cart_SellerUser.NickName, hiiops_Cart_SellerUser.Phone, hiiops_Cart_SellerUser.Account, hiiops_Cart_SellerUser.Country, hiiops_Cart_SellerUser.HeadImgUrl, hiiops_Cart_SellerUser.Id, hiiops_Cart_SellerUser.Name, hiiops_Cart_SellerUser.Privilege, hiiops_Cart_SellerUser.Province, hiiops_Cart_SellerUser.Remark, hiiops_Cart_SellerUser.SearchKey, hiiops_Cart_SellerUser.Sex, hiiops_Cart_SellerUser.Status });
            }
            return new WebResponseContent().Error("注册失败");
        }

        /// <summary>
        /// 获取图片验证码
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public WebResponseContent ValidateCode()
        {
            var data = VierificationCodeServices.Create(out string code, 4);//获取4位验证码并生图片
            string guid = Guid.NewGuid().ToString();
            CacheContext.Add(guid, code, expiresIn: DateTime.Now.AddMinutes(10).GetTimeSpan());//10分钟有效
            return new WebResponseContent().OK(message: "获取成功", data: new { img = $"data:image/jpeg;base64,{Convert.ToBase64String(data.ToArray())}", sessionKey = guid });
        }


        /// <summary>
        /// 获取短信验证码
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public WebResponseContent ValidateSMSCode()
        {
            var data = VierificationCodeServices.Create(out string code, 4);//获取4位验证码并生图片
            string guid = Guid.NewGuid().ToString();
            CacheContext.Add(guid, code, expiresIn: DateTime.Now.AddMinutes(10).GetTimeSpan());//10分钟有效
            return new WebResponseContent().OK(message: "获取成功", data: new { img = $"data:image/jpeg;base64,{Convert.ToBase64String(data.ToArray())}", sessionKey = guid });
        }


        /// <summary>
        /// 找回密码
        /// </summary>
        /// <param name="phone">手机号码</param>
        /// <param name="code">验证码</param>
        /// <param name="sessionKey">提交表单验证码</param>
        /// <param name="newPassWord">新密码</param>
        /// <param name="againPassWord">重复密码</param>
        /// <returns></returns>
        public WebResponseContent FindPassword(string phone, string code, string sessionKey, string newPassWord, string againPassWord)
        {
            WebResponseContent webResponseContent = new WebResponseContent();
            if (string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(code) || string.IsNullOrEmpty(newPassWord) || string.IsNullOrEmpty(againPassWord))
                return webResponseContent.Error("请输入完整信息");
            if (!phone.IsPhoneNo())
                return webResponseContent.Error("请输入正确的手机号码");
            if (string.IsNullOrEmpty(CacheContext.Get(sessionKey)))
                return webResponseContent.Error("请先获取验证码");
            if (CacheContext.Get(sessionKey) != code)
                return webResponseContent.Error("请输入正确的验证码");
            if (!newPassWord.Equals(againPassWord))
                return webResponseContent.Error("两次输入的密码不一致");
            var seller = DbContext.Set<Hiiops_Cart_SellerUser>().Where(x => x.Phone == phone).FirstOrDefault();
            if (seller == null)
                return webResponseContent.Error("手机号未注册");

            string token = JwtHelper.IssueJwt(seller.Id.ToString());
            seller.Token = token;
            seller.Password = newPassWord.EncryptDES(AppSetting.Secret.User);
            DbContext.Update(seller);
            if (DbContext.SaveChanges() > 0)
                return webResponseContent.OK("密码修改成功", data: new { token = seller.Token });
            return webResponseContent.Error("密码修改失败");
        }

    }
}
