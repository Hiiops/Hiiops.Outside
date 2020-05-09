/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Hiiops_Cart_BannerController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using Hiiops.Cart.IServices;
namespace Hiiops.Cart.Controllers
{
    [Route("api/Hiiops_Cart_Banner")]
    [PermissionTable(Name = "Hiiops_Cart_Banner")]
    public partial class Hiiops_Cart_BannerController : ApiBaseController<IHiiops_Cart_BannerService>
    {
        public Hiiops_Cart_BannerController(IHiiops_Cart_BannerService service)
        : base(service)
        {
        }
    }
}

