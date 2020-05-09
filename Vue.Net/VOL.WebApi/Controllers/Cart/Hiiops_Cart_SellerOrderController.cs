/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Hiiops_Cart_SellerOrderController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using Hiiops.Cart.IServices;
namespace Hiiops.Cart.Controllers
{
    [Route("api/Hiiops_Cart_SellerOrder")]
    [PermissionTable(Name = "Hiiops_Cart_SellerOrder")]
    public partial class Hiiops_Cart_SellerOrderController : ApiBaseController<IHiiops_Cart_SellerOrderService>
    {
        public Hiiops_Cart_SellerOrderController(IHiiops_Cart_SellerOrderService service)
        : base(service)
        {
        }
    }
}

