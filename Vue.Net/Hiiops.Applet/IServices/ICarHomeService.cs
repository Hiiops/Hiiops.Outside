using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VOL.Core.Utilities;
using VOL.Entity.DomainModels;
using VOL.Entity.DomainModels.Cart.ViewModel;

namespace Hiiops.Applet.IServices
{
    public interface ICarHomeService : VOL.Core.BaseInterface.IServices
    {
        /// <summary>
        /// 获取小程序首页展示数据
        /// </summary>
        /// <returns></returns>
        CarHomeModel GetHomeModel();
        /// <summary>
        /// 通过车辆id获取车辆
        /// </summary>
        /// <param name="id">车辆id</param>
        /// <returns></returns>
        Task<WebResponseContent> Get_Cart(int id);
        /// <summary>
        /// 获取分类 信息
        /// </summary>
        /// <param name="page">页面大小</param>
        /// <param name="pageSize">行数</param>
        /// <param name="rowcount">获取到的数据行数</param>
        /// <param name="sortType">排序类型 默认通过id排序（传0，可不传） 1 创建时间 2 价格降序 3 价格升序</param>
        /// <param name="CartTypeID">分类 ID</param>
        /// <param name="BrandId">品牌ID</param>
        /// <param name="returnRowCount">是否返回行数</param>
        /// <returns></returns> 
        WebResponseContent  GetCategoryPageData(int page, int pageSize, out int rowcount, int sortType = 0, int CartTypeID = 0, int BrandId = 0, bool returnRowCount = true);

    }
}
