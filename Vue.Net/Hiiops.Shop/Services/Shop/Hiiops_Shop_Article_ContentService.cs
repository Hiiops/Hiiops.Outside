/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Hiiops_Shop_Article_ContentService与IHiiops_Shop_Article_ContentService中编写
 */
using Hiiops.Shop.IRepositories;
using Hiiops.Shop.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Hiiops.Shop.Services
{
    public partial class Hiiops_Shop_Article_ContentService : ServiceBase<Hiiops_Shop_Article_Content, IHiiops_Shop_Article_ContentRepository>, IHiiops_Shop_Article_ContentService, IDependency
    {
        public Hiiops_Shop_Article_ContentService(IHiiops_Shop_Article_ContentRepository repository)
             : base(repository) 
        { 
           Init(repository);
        }
        public static IHiiops_Shop_Article_ContentService Instance
        {
           get { return AutofacContainerModule.GetService<IHiiops_Shop_Article_ContentService>(); }
        }
    }
}
