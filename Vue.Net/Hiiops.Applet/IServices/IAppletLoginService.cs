using System.Threading.Tasks;
using VOL.Core.Utilities;
using VOL.Entity.DomainModels;

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

        Task<WebResponseContent> Resign(LoginInfo loginInfo, string verificationCode );

        /// <summary>
        /// 小程序-登录接口
        /// </summary>
        /// <param name="loginInfo"></param>
        /// <param name="verificationCode"></param>
        /// <returns></returns>
        Task<WebResponseContent> Login(LoginInfo loginInfo);
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
        Task<WebResponseContent> ModifyPwd(string oldPwd, string newPwd,string verificationCode);
        /// <summary>
        /// 获取登录信息
        /// </summary>
        /// <returns></returns>
        Task<WebResponseContent> GetCurrentLoginInfo();

    }
}
