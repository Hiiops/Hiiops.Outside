/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Hiiops_Shop_Article_CategoryController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using Hiiops.Shop.IServices;
namespace Hiiops.Shop.Controllers
{
    [Route("api/Hiiops_Shop_Article_Category")]
    [PermissionTable(Name = "Hiiops_Shop_Article_Category")]
    public partial class Hiiops_Shop_Article_CategoryController : ApiBaseController<IHiiops_Shop_Article_CategoryService>
    {
        public Hiiops_Shop_Article_CategoryController(IHiiops_Shop_Article_CategoryService service)
        : base(service)
        {
        }
    }
}

