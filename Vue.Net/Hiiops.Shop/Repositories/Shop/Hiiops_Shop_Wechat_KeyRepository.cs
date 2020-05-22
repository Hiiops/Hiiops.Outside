/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹Hiiops_Shop_Wechat_KeyRepository编写代码
 */
using Hiiops.Shop.IRepositories;
using VOL.Core.BaseProvider;
using VOL.Core.EFDbContext;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Hiiops.Shop.Repositories
{
    public partial class Hiiops_Shop_Wechat_KeyRepository : RepositoryBase<Hiiops_Shop_Wechat_Key> , IHiiops_Shop_Wechat_KeyRepository
    {
    public Hiiops_Shop_Wechat_KeyRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IHiiops_Shop_Wechat_KeyRepository Instance
    {
      get {  return AutofacContainerModule.GetService<IHiiops_Shop_Wechat_KeyRepository>(); } }
    }
}
