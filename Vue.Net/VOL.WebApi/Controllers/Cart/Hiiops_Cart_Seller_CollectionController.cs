/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Hiiops_Cart_Seller_CollectionController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using Hiiops.Cart.IServices;
namespace Hiiops.Cart.Controllers
{
    [Route("api/Hiiops_Cart_Seller_Collection")]
    [PermissionTable(Name = "Hiiops_Cart_Seller_Collection")]
    public partial class Hiiops_Cart_Seller_CollectionController : ApiBaseController<IHiiops_Cart_Seller_CollectionService>
    {
        public Hiiops_Cart_Seller_CollectionController(IHiiops_Cart_Seller_CollectionService service)
        : base(service)
        {
        }
    }
}

