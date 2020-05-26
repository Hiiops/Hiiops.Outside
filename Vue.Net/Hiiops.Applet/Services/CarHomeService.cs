using Hiiops.Applet.IServices;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;
using VOL.Entity.DomainModels.Cart.ViewModel;

namespace Hiiops.Applet.Services
{
    public class CarHomeService : BaseService, ICarHomeService, IDependency
    {

        public static ICarHomeService Instance
        {
            get { return AutofacContainerModule.GetService<ICarHomeService>(); }
        }
        public CarHomeModel GetHomeModel()
        {
            CarHomeModel carHomeModel = new CarHomeModel();
            carHomeModel.AppName = "中启汽车";
            carHomeModel.Contact = "13533506304";
            carHomeModel.IsLogin = false;
            //菜单
            carHomeModel.Menus = Instance.DbContext.Set<Hiiops_Cart_Banner>().AsQueryable().Where(x => x.BannerType == "2" && x.Status == 1).OrderBy(x => x.CreateDate).Take(10).ToList();
            //轮播
            carHomeModel.Banner = Instance.DbContext.Set<Hiiops_Cart_Banner>().AsQueryable().Where(x => x.BannerType == "1" && x.Status == 1).OrderBy(x => x.CreateDate).Take(5).ToList();
            //carHomeModel.CarList = Instance.DbContext.Set<Hiiops_Cart>().Where(x => x.Status == 1 && x.Recomend.ToBool()==true).
            //分类(最多拿8条)
            var categories = Instance.DbContext.Set<Hiiops_Cart_Category>().AsQueryable().OrderBy(x => x.Sort).Where(x => x.Status == 1 && x.Recomend == true).Take(8).ToList();
            //获取推荐分类和分类车辆
            if (categories.Count() > 0)
            {
                categories.ForEach(x =>
               {
                   var data = Instance.DbContext.Set<Hiiops_Cart>().AsQueryable().OrderBy(x => x.CreateDate).Where(x => x.Status == 1 && x.Recomend == true).Take(8).ToList();
                   if (data.Count() > 0)
                   {
                       carHomeModel.CarList.Add(new CarList()
                       {
                           Type = x.Name.Contains("二手"),
                           CategoryId = x.Id,
                           CategoryName = x.Name,
                           Total = data.Count(),
                           Hiiops_Carts = data
                       });
                   }

               });
            }
            return carHomeModel;
        }

        public Hiiops_Cart Get_Cart(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
