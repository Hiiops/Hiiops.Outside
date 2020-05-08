/*
*所有关于Hiiops_Cart类的业务代码接口应在此处编写
*/
using VOL.Core.BaseProvider;
using VOL.Entity.DomainModels;
using VOL.Core.Utilities;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Hiiops.Cart.IServices
{
    public partial interface IHiiops_CartService
    {
        /// <summary>
        /// 生成html页面
        /// </summary>
        /// <param name="news"></param>
        /// <returns></returns>
        Task<WebResponseContent> CreatePage(Hiiops_Cart cart);
    }
 }
