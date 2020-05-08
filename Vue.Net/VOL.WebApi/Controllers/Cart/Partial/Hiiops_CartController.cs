/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("Hiiops_Cart",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VOL.Core.Enums;
using VOL.Core.Filters;
using VOL.Entity.AttributeManager;
using VOL.Entity.DomainModels;

namespace Hiiops.Cart.Controllers
{
     
    public partial class Hiiops_CartController
    {
        /// <summary>
        /// 生成静态页面
        /// </summary>
        /// <param name="news"></param>
        /// <returns></returns>
        [HttpPost, Route("createPage")]
        [ApiActionPermission("Hiiops_Cart", ActionPermissionOptions.Add)]
        public async Task<IActionResult> CreatePage([FromBody]Hiiops_Cart cart)
        {
            return Json(await Service.CreatePage(cart));
        } 
    }
}
