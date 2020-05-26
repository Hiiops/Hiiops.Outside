using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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
        /// <param name="id"></param>
        /// <returns></returns>
        Hiiops_Cart Get_Cart(int id);

         
    }
}
