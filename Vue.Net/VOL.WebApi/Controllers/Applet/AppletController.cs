 
using Hiiops.Applet.IServices;
using Hiiops.Applet.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VOL.Core.ObjectActionValidator;
using VOL.Entity.DomainModels;

namespace Hiiops.Cart.Controllers
{
    [Route("api/Applet"),ApiController]
    public partial class AppletController : Controller
    {
        private IAppletLoginService service;
        public AppletController(AppletService service)
        {
            this.service = service;
        }
        [HttpPost, HttpGet, Route("login"), AllowAnonymous]
        [ObjectModelValidatorFilter(ValidatorModel.Login)]
        public async Task<IActionResult> Login([FromBody]LoginInfo loginInfo)
        {
            return Json(await service.Login(loginInfo));
        }

    }
}

