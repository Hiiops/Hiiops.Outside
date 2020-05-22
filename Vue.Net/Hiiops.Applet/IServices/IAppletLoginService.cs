using System.Threading.Tasks;
using VOL.Core.Utilities;
using VOL.Entity.DomainModels;
using VOL.Entity.DomainModels.ApiEntity;

namespace Hiiops.Applet.IServices
{
    /// <summary>
    /// 小程序登录 
    /// </summary>
    public interface IAppletLoginService : VOL.Core.BaseInterface.IServices
    {
        /// <summary>
        /// 小程序注册接口
        /// </summary>
        /// <param name="loginInfo"></param>
        /// <param name="verificationCode"></param>
        /// <returns></returns>

        Task<WebResponseContent> Resign(Hiiops_Cart_SellerUser hiiops_Cart_SellerUser);

        /// <summary>
        /// 小程序-账户密码登录接口
        /// </summary>
        /// <param name="loginInfo"></param> 
        /// <returns></returns>
        Task<WebResponseContent> Login(LoginInfo loginInfo);
        /// <summary>
        /// 小程序-通过OpenId快捷登录
        /// </summary>
        /// <param name="code">微信临时code</param> 
        /// <returns></returns>
        Task<WebResponseContent> Login(string code);
        /// <summary>
        /// 手机验证码登录
        /// </summary>
        /// <param name="code">验证码</param> 
        /// <param name="phone">手机号码</param>
        /// <returns></returns>
        Task<WebResponseContent> Login(string code, string phone);

        /// <summary>
        /// 小程序-刷新Token
        /// </summary>
        /// <returns></returns>
        Task<WebResponseContent> ReplaceToken();
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="oldPwd">旧密码</param>
        /// <param name="newPwd">新密码</param
        /// <param name="verificationCode">验证码</param>
        /// <returns></returns>
        Task<WebResponseContent> ModifyPwd(string oldPwd, string newPwd, string verificationCode);
        
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <param name="newPwd">新密码</param>
        /// <param name="verificationCode">验证码</param>
        /// <param name="code">短信验证码</param>
        /// <param name="sessionKey">获取图片验证码的ID</param>
        /// <returns></returns>
        Task<WebResponseContent> ModifyPwd(string phone, string newPwd, string verificationCode, string code, string sessionKey);
        /// <summary>
        /// 获取登录信息
        /// </summary>
        /// <returns></returns>
        Task<WebResponseContent> GetCurrentLoginInfo();
        /// <summary>
        /// 获取图片验证码
        /// </summary>
        /// <returns></returns>
        WebResponseContent ValidateCode();

        /// <summary>
        /// 获取短信验证码
        /// </summary>
        /// <param name="sessionKey">图形验证码KEY</param>
        /// <param name="code">验证码</param>
        /// <param name="phone">手机号</param>
        /// <returns></returns>
        WebResponseContent ValidateSMSCode(string sessionKey, string code, string phone);

        /// <summary>
        /// 找回密码
        /// </summary>
        /// <param name="phone">手机号码</param>
        /// <param name="code">验证码</param>
        /// <param name="newPassWord">新密码</param>
        /// <param name="againPassWord">重复密码</param>
        /// <returns></returns>
        WebResponseContent FindPassword(string phone, string code, string sessionKey, string newPassWord, string againPassWord);



    }
}
