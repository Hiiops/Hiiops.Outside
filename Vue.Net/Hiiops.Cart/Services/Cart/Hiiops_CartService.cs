/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Hiiops_CartService与IHiiops_CartService中编写
 */
using Hiiops.Cart.IRepositories;
using Hiiops.Cart.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Hiiops.Cart.Services
{
    public partial class Hiiops_CartService : ServiceBase<Hiiops_Cart, IHiiops_CartRepository>, IHiiops_CartService, IDependency
    {
        public Hiiops_CartService(IHiiops_CartRepository repository)
             : base(repository) 
        { 
           Init(repository);
        }
        public static IHiiops_CartService Instance
        {
           get { return AutofacContainerModule.GetService<IHiiops_CartService>(); }
        }
    }
}
