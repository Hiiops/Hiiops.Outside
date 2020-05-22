/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Hiiops_Shop_Store_CategoryService与IHiiops_Shop_Store_CategoryService中编写
 */
using Hiiops.Shop.IRepositories;
using Hiiops.Shop.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Hiiops.Shop.Services
{
    public partial class Hiiops_Shop_Store_CategoryService : ServiceBase<Hiiops_Shop_Store_Category, IHiiops_Shop_Store_CategoryRepository>, IHiiops_Shop_Store_CategoryService, IDependency
    {
        public Hiiops_Shop_Store_CategoryService(IHiiops_Shop_Store_CategoryRepository repository)
             : base(repository) 
        { 
           Init(repository);
        }
        public static IHiiops_Shop_Store_CategoryService Instance
        {
           get { return AutofacContainerModule.GetService<IHiiops_Shop_Store_CategoryService>(); }
        }
    }
}
