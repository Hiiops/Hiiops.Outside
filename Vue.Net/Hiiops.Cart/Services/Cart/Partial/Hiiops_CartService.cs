/*
 *所有关于Hiiops_Cart类的业务代码应在此处编写
*可使用repository.调用常用方法，获取EF/Dapper等信息
*如果需要事务请使用repository.DbContextBeginTransaction
*也可使用DBServerProvider.手动获取数据库相关信息
*用户信息、权限、角色等使用UserContext.Current操作
*Hiiops_CartService对增、删、改查、导入、导出、审核业务代码扩展参照ServiceFunFilter
*/
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;
using System.Linq;
using VOL.Core.Utilities;
using System.Linq.Expressions;
using VOL.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;

namespace Hiiops.Cart.Services
{
    public partial class Hiiops_CartService
    {
        public async Task<WebResponseContent> CreatePage(Hiiops_Cart cart)
        {
            WebResponseContent webResponseContent = WebResponseContent.Instance;
            if (cart == null)
            {
                return webResponseContent.Error("未获取到数据");
            }
            if (!await repository.ExistsAsync(x => x.Id == cart.Id))
            {
                return webResponseContent.Error("请求的数据已发生变化,请刷新页面重新提交");
            }
            string template = FileHelper.ReadFile(@"Template\\AppHtml\\cart.html");
            if (string.IsNullOrEmpty(template))
            {
                return webResponseContent.Error("未获取到页面的模板,请确认模板是否存在");
            }
            string filePath;
            string fileName;
            string urlPath;
            if (!string.IsNullOrEmpty(cart.StaticUrl) && cart.StaticUrl.IndexOf("/") != -1 && cart.StaticUrl.Split(".").Length == 2)
            {
                var file = cart.StaticUrl.Split("/");
                fileName = file[^1];
                filePath = cart.StaticUrl.Replace(fileName, "");
                urlPath = filePath;
            }
            else
            {
                string day = DateTime.Now.ToString("yyyyMMdd");
                fileName = DateTime.Now.ToString("HHmmsss") + new Random().Next(1000, 9999) + ".html";
                urlPath = $"static/cart/{day}/";
                filePath = urlPath.MapPath(true);
            }
            string content = template.Replace("{title}", cart.Name).Replace("{date}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")).Replace("{content}", cart.DetailContent);
            FileHelper.WriteFile((filePath.IndexOf("wwwroot") == -1 ? "wwwroot/" : "") + filePath, fileName, content);
            //更新数据库的url
            cart.StaticUrl = $"{urlPath}{fileName}";
            repository.Update(cart, x => new { cart.StaticUrl, cart.DetailContent }, true);
            return webResponseContent.OK("面发布成功,可预览看效果", new { url = cart.StaticUrl });
        }
    }
}
