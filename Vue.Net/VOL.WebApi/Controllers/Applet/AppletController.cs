
using Hiiops.Applet.IServices;
using Hiiops.Applet.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        /// ��¼�ӿ�
        /// </summary>
        /// <param name="loginInfo"></param>
        /// <returns></returns>
        [HttpPost, HttpGet, Route("getToken"), AllowAnonymous]
        [ObjectModelValidatorFilter(ValidatorModel.Login)]
        public async Task<IActionResult> Login([FromBody]LoginInfo loginInfo)
        {
            return Json(await service.Login(loginInfo));
        }
        [HttpPost, HttpGet, Route("resign"), AllowAnonymous]
        /// <summary>
        /// ע��ӿ�
        /// </summary>
        /// <param name="hiiops_Cart_SellerUser"></param>
        /// <returns></returns>
        public async Task<IActionResult> Resign([FromBody]Hiiops_Cart_SellerUser hiiops_Cart_SellerUser)
        {
            return Json(await service.Resign(hiiops_Cart_SellerUser));
        }
        [HttpPost, HttpGet, Route("getUserInfo"), JWTAuthorize]
        /// <summary>
        /// ��ȡ������Ϣ
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> GetCurrentLoginInfo()
        {
            return Json(await service.GetCurrentLoginInfo());
        }
        [HttpPost, HttpGet, Route("ModifyPassword"), JWTAuthorize]
        /// <summary>
        /// �޸�����
        /// </summary>
        /// <param name="oldPwd">������</param>
        /// <param name="newPwd">������</param>
        /// <param name="verificationCode">��֤��</param>
        /// <returns></returns>
        public async Task<IActionResult> ModifyPwd(string oldPwd, string newPwd, string verificationCode)
        {
            return Json(await service.ModifyPwd(oldPwd, newPwd, verificationCode));
        }
        [HttpPost, HttpGet, Route("ValidateCode"), AllowAnonymous]
        /// <summary>
        /// ��ȡ��֤��
        /// </summary>
        /// <returns></returns>
        public IActionResult ValidateCode()
        {
            return Json(service.ValidateCode());
        }

    }
}

