/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Hiiops_Cart_Seller_CollectionService与IHiiops_Cart_Seller_CollectionService中编写
 */
using Hiiops.Cart.IRepositories;
using Hiiops.Cart.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Hiiops.Cart.Services
{
    public partial class Hiiops_Cart_Seller_CollectionService : ServiceBase<Hiiops_Cart_Seller_Collection, IHiiops_Cart_Seller_CollectionRepository>, IHiiops_Cart_Seller_CollectionService, IDependency
    {
        public Hiiops_Cart_Seller_CollectionService(IHiiops_Cart_Seller_CollectionRepository repository)
             : base(repository) 
        { 
           Init(repository);
        }
        public static IHiiops_Cart_Seller_CollectionService Instance
        {
           get { return AutofacContainerModule.GetService<IHiiops_Cart_Seller_CollectionService>(); }
        }
    }
}
