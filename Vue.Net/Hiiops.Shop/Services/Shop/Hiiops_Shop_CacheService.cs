/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Hiiops_Shop_CacheService与IHiiops_Shop_CacheService中编写
 */
using Hiiops.Shop.IRepositories;
using Hiiops.Shop.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Hiiops.Shop.Services
{
    public partial class Hiiops_Shop_CacheService : ServiceBase<Hiiops_Shop_Cache, IHiiops_Shop_CacheRepository>, IHiiops_Shop_CacheService, IDependency
    {
        public Hiiops_Shop_CacheService(IHiiops_Shop_CacheRepository repository)
             : base(repository) 
        { 
           Init(repository);
        }
        public static IHiiops_Shop_CacheService Instance
        {
           get { return AutofacContainerModule.GetService<IHiiops_Shop_CacheService>(); }
        }
    }
}
