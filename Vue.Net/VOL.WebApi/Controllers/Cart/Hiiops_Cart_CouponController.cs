/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Hiiops_Cart_CouponController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using Hiiops.Cart.IServices;
namespace Hiiops.Cart.Controllers
{
    [Route("api/Hiiops_Cart_Coupon")]
    [PermissionTable(Name = "Hiiops_Cart_Coupon")]
    public partial class Hiiops_Cart_CouponController : ApiBaseController<IHiiops_Cart_CouponService>
    {
        public Hiiops_Cart_CouponController(IHiiops_Cart_CouponService service)
        : base(service)
        {
        }
    }
}

