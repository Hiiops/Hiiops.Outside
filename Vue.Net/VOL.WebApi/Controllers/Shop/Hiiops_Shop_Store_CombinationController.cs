/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Hiiops_Shop_Store_CombinationController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using Hiiops.Shop.IServices;
namespace Hiiops.Shop.Controllers
{
    [Route("api/Hiiops_Shop_Store_Combination")]
    [PermissionTable(Name = "Hiiops_Shop_Store_Combination")]
    public partial class Hiiops_Shop_Store_CombinationController : ApiBaseController<IHiiops_Shop_Store_CombinationService>
    {
        public Hiiops_Shop_Store_CombinationController(IHiiops_Shop_Store_CombinationService service)
        : base(service)
        {
        }
    }
}

