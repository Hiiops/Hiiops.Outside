/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Hiiops_Shop_Store_Coupon_Issue_UserService与IHiiops_Shop_Store_Coupon_Issue_UserService中编写
 */
using Hiiops.Shop.IRepositories;
using Hiiops.Shop.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Hiiops.Shop.Services
{
    public partial class Hiiops_Shop_Store_Coupon_Issue_UserService : ServiceBase<Hiiops_Shop_Store_Coupon_Issue_User, IHiiops_Shop_Store_Coupon_Issue_UserRepository>, IHiiops_Shop_Store_Coupon_Issue_UserService, IDependency
    {
        public Hiiops_Shop_Store_Coupon_Issue_UserService(IHiiops_Shop_Store_Coupon_Issue_UserRepository repository)
             : base(repository) 
        { 
           Init(repository);
        }
        public static IHiiops_Shop_Store_Coupon_Issue_UserService Instance
        {
           get { return AutofacContainerModule.GetService<IHiiops_Shop_Store_Coupon_Issue_UserService>(); }
        }
    }
}
