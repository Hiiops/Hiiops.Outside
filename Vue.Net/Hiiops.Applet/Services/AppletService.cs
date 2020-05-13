using Hiiops.Applet.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using System.Threading.Tasks;
using VOL.Core.Utilities;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore;
using VOL.Core.Configuration;
using VOL.Core.Extensions;
using VOL.Core.Enums;
using VOL.Entity.DomainModels.Cart;
using VOL.Core.UserManager;
using VOL.Core.Services;
using System.Linq;

namespace Hiiops.Applet.Services
{
    public class AppletService : BaseService, IAppletLoginService, IDependency
    {

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
                Hiiops_Cart_SellerUser user = await db.FirstAsync(x => x.Phone == loginInfo.UserName || x.OpenId == loginInfo.UserName || x.Account == loginInfo.UserName);

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

                var a = await DbContext.Set<Hiiops_Cart_SellerUser>().FirstAsync(x => x.Id == userId);
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
        /// <param name="loginInfo"></param>
        /// <param name="verificationCode"></param>
        /// <returns></returns>
        public Task<WebResponseContent> Resign(LoginInfo loginInfo, string verificationCode)
        {
            throw new NotImplementedException();
        }
    }
}
