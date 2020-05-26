using Hiiops.Applet.IServices;
using Hiiops.Applet.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VOL.Core.Utilities;

namespace VOL.WebApi.Controllers.Applet
{
    [Route("api/car"), ApiController, AllowAnonymous]
    public class CarHomeController : Controller
    {
        private ICarHomeService service;
        public CarHomeController(CarHomeService homeService)
        {
            service = homeService;
        }
        [HttpGet, HttpPost, AllowAnonymous, Route("home")]
        /// <summary>
        /// 小程序获取首页数据
        /// </summary>
        /// <returns></returns>
        public async Task<WebResponseContent> Home()
        {
            WebResponseContent webResponseContent = new WebResponseContent();
            var data = service.GetHomeModel();
            await Task.CompletedTask;
            return webResponseContent.OK("获取成功", data);
        }

    }
}