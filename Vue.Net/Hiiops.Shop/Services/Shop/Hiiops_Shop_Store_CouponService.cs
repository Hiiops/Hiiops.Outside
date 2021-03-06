/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Hiiops_Shop_Store_CouponService与IHiiops_Shop_Store_CouponService中编写
 */
using Hiiops.Shop.IRepositories;
using Hiiops.Shop.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Hiiops.Shop.Services
{
    public partial class Hiiops_Shop_Store_CouponService : ServiceBase<Hiiops_Shop_Store_Coupon, IHiiops_Shop_Store_CouponRepository>, IHiiops_Shop_Store_CouponService, IDependency
    {
        public Hiiops_Shop_Store_CouponService(IHiiops_Shop_Store_CouponRepository repository)
             : base(repository) 
        { 
           Init(repository);
        }
        public static IHiiops_Shop_Store_CouponService Instance
        {
           get { return AutofacContainerModule.GetService<IHiiops_Shop_Store_CouponService>(); }
        }
    }
}
