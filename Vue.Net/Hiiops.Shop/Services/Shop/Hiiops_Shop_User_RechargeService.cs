/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Hiiops_Shop_User_RechargeService与IHiiops_Shop_User_RechargeService中编写
 */
using Hiiops.Shop.IRepositories;
using Hiiops.Shop.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Hiiops.Shop.Services
{
    public partial class Hiiops_Shop_User_RechargeService : ServiceBase<Hiiops_Shop_User_Recharge, IHiiops_Shop_User_RechargeRepository>, IHiiops_Shop_User_RechargeService, IDependency
    {
        public Hiiops_Shop_User_RechargeService(IHiiops_Shop_User_RechargeRepository repository)
             : base(repository) 
        { 
           Init(repository);
        }
        public static IHiiops_Shop_User_RechargeService Instance
        {
           get { return AutofacContainerModule.GetService<IHiiops_Shop_User_RechargeService>(); }
        }
    }
}
