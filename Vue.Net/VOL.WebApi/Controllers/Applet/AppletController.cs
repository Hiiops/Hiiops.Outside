
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
        /// ��¼�ӿ�
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
        /// С����-ͨ��OpenId��ݵ�¼
        /// </summary>
        /// <param name="code">΢����ʱcode</param> 
        /// <returns></returns>
        [HttpPost,Route("code"), AllowAnonymous]
        public async Task<IActionResult> Code(string code)
        { 
            return Json(await service.Login(code));
        }
        /// <summary>
        /// �ֻ���֤���¼
        /// </summary>
        /// <param name="code">��֤��</param> 
        /// <param name="phone">�ֻ�����</param>
        /// <returns></returns>
        [HttpPost, Route("phone"), AllowAnonymous]
        public async Task<IActionResult> Phone(string code, string phone)
        {
            return Json(await service.Login(code, phone));
        }

        /// <summary>
        /// ע��
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
        /// ��ȡ��¼��Ϣ
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
        /// <param name="newPwd">������</param
        /// <param name="verificationCode">��֤��</param>
        /// <returns></returns>
        public async Task<IActionResult> ModifyPwd(string oldPwd, string newPwd, string verificationCode)
        {
            return Json(await service.ModifyPwd(oldPwd, newPwd, verificationCode));
        }
        [HttpPost, HttpGet, Route("ValidateCode"), AllowAnonymous]
        /// <summary>
        /// ��ȡͼƬ��֤��
        /// </summary>
        /// <returns></returns>
        public IActionResult ValidateCode()
        {
            return Json(service.ValidateCode());
        }

        [HttpPost, HttpGet, Route("send"), AllowAnonymous]
        /// <summary>
        /// ��ȡ������֤��
        /// </summary>
        /// <param name="sessionKey">ͼ����֤��KEY</param>
        /// <param name="code">��֤��</param>
        /// <param name="phone">�ֻ���</param>
        /// <returns></returns>
        public IActionResult ValidateSMSCode(string sessionKey, string code, string phone)
        {
            return Json(service.ValidateSMSCode(sessionKey, code, phone));
        }
        /// <summary>
        /// ΢��С�����ȡ�ֻ�����  
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

