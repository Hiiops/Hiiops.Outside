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
        [HttpGet, HttpPost, AllowAnonymous, Route("Get")]
        /// <summary>
        /// 获取单个车辆信息
        /// </summary>
        /// <returns></returns>
        public async Task<WebResponseContent> GetCarDetail(int id)
        {
            var data = await service.Get_Cart(id);
            return data;

        }
        [HttpGet, HttpPost, AllowAnonymous, Route("Search")]
        /// <summary>
        /// 获取分类 信息
        /// </summary>
        /// <param name="page">页面大小</param>
        /// <param name="pageSize">行数</param>
        /// <param name="rowcount">获取到的数据行数</param>
        /// <param name="sortType">排序类型 默认通过id排序（传0，可不传） 1 创建时间 2 价格降序 3 价格升序</param>
        /// <param name="CartTypeID">分类 ID</param>
        /// <param name="BrandId">品牌ID</param>
        /// <param name="returnRowCount">是否返回行数</param>
        /// <returns></returns>  
        public async Task<WebResponseContent> Search(int page, int pageSize, int sortType = 0, int CartTypeID = 0, int BrandId = 0)
        {
            var data = service.GetCategoryPageData(page, pageSize, out _, sortType, CartTypeID, BrandId, true);
            await Task.CompletedTask;
            return data;
        }

    }
}