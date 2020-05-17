
using Hiiops.Applet.IServices;
using Hiiops.Applet.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using VOL.Core.Filters;
using VOL.Core.ObjectActionValidator;
using VOL.Entity.DomainModels;

namespace Hiiops.Cart.Controllers
{
    [Route("api/oauth2.0"), ApiController]
    public partial class AppletController : Controller
    {
        private IAppletLoginService service;
        public AppletController(AppletService service)
        {
            this.service = service;
        }
        /// <summary>
        /// 登录接口
        /// </summary>
        /// <param name="loginInfo"></param>
        /// <returns></returns>
        [HttpPost, HttpGet, Route("login"), AllowAnonymous]
        [ObjectModelValidatorFilter(ValidatorModel.Login)]
        public async Task<IActionResult> Login([FromBody]LoginInfo loginInfo)
        {
            return Json(await service.Login(loginInfo));
        }

        /// <summary>
        /// 小程序-通过OpenId快捷登录
        /// </summary>
        /// <param name="code">微信临时code</param> 
        /// <returns></returns>
        [HttpPost,Route("code"), AllowAnonymous]
        public async Task<IActionResult> Code(string code)
        { 
            return Json(await service.Login(code));
        }
        /// <summary>
        /// 手机验证码登录
        /// </summary>
        /// <param name="code">验证码</param> 
        /// <param name="phone">手机号码</param>
        /// <returns></returns>
        [HttpPost, Route("phone"), AllowAnonymous]
        public async Task<IActionResult> Phone(string code, string phone)
        {
            return Json(await service.Login(code, phone));
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="hiiops_Cart_SellerUser">hiiops_Cart_SellerUser</param>
        /// <returns></returns>
        [HttpPost, HttpGet, Route("resign"), AllowAnonymous]

        public async Task<IActionResult> Resign([FromBody]Hiiops_Cart_SellerUser hiiops_Cart_SellerUser)
        {
            return Json(await service.Resign(hiiops_Cart_SellerUser));
        }
        [HttpPost, HttpGet, Route("getUserInfo"), JWTAuthorize]
        /// <summary>
        /// 获取登录信息
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> GetCurrentLoginInfo()
        {
            return Json(await service.GetCurrentLoginInfo());
        }
        [HttpPost, HttpGet, Route("ModifyPassword"), JWTAuthorize]
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="oldPwd">旧密码</param>
        /// <param name="newPwd">新密码</param
        /// <param name="verificationCode">验证码</param>
        /// <returns></returns>
        public async Task<IActionResult> ModifyPwd(string oldPwd, string newPwd, string verificationCode)
        {
            return Json(await service.ModifyPwd(oldPwd, newPwd, verificationCode));
        }
        [HttpPost, HttpGet, Route("ValidateCode"), AllowAnonymous]
        /// <summary>
        /// 获取图片验证码
        /// </summary>
        /// <returns></returns>
        public IActionResult ValidateCode()
        {
            return Json(service.ValidateCode());
        }

        [HttpPost, HttpGet, Route("send"), AllowAnonymous]
        /// <summary>
        /// 获取短信验证码
        /// </summary>
        /// <param name="sessionKey">图形验证码KEY</param>
        /// <param name="code">验证码</param>
        /// <param name="phone">手机号</param>
        /// <returns></returns>
        public IActionResult ValidateSMSCode(string sessionKey, string code, string phone)
        {
            return Json(service.ValidateSMSCode(sessionKey, code, phone));
        }
        /// <summary>
        /// 微信小程序获取手机号码  
        /// </summary>
        /// <param name="session_key">code</param>
        /// <param name="encryptedData">encryptedData</param>
        /// <param name="iv">iv</param>
        /// <returns></returns>
        [HttpPost, HttpGet, Route("GetPhone"), AllowAnonymous]
        public async Task<IActionResult> GetPhone(string session_key, string encryptedData, string iv)
        {
            return Json(await service.GetPhone(session_key, encryptedData, iv));
        }
    }
}

