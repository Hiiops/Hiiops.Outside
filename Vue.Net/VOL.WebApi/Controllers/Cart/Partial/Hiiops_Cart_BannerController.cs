/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("Hiiops_Cart_Banner",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VOL.Core.Filters;
using VOL.Entity.DomainModels;

namespace Hiiops.Cart.Controllers
{
    public partial class Hiiops_Cart_BannerController
    {
        [HttpPost, Route("Upload")]
        [ApiActionPermission(VOL.Core.Enums.ActionPermissionOptions.Upload)]
        public override async Task<IActionResult> Upload(IEnumerable<IFormFile> fileInput)
        {
            return await base.Upload(fileInput.ToList());
        }
    }
}
