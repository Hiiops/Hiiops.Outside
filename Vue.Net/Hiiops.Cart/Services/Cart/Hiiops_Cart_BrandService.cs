/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Hiiops_Cart_BrandService与IHiiops_Cart_BrandService中编写
 */
using Hiiops.Cart.IRepositories;
using Hiiops.Cart.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Hiiops.Cart.Services
{
    public partial class Hiiops_Cart_BrandService : ServiceBase<Hiiops_Cart_Brand, IHiiops_Cart_BrandRepository>, IHiiops_Cart_BrandService, IDependency
    {
        public Hiiops_Cart_BrandService(IHiiops_Cart_BrandRepository repository)
             : base(repository) 
        { 
           Init(repository);
        }
        public static IHiiops_Cart_BrandService Instance
        {
           get { return AutofacContainerModule.GetService<IHiiops_Cart_BrandService>(); }
        }
    }
}
