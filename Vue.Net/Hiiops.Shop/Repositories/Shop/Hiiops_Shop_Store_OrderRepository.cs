/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹Hiiops_Shop_Store_OrderRepository编写代码
 */
using Hiiops.Shop.IRepositories;
using VOL.Core.BaseProvider;
using VOL.Core.EFDbContext;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Hiiops.Shop.Repositories
{
    public partial class Hiiops_Shop_Store_OrderRepository : RepositoryBase<Hiiops_Shop_Store_Order> , IHiiops_Shop_Store_OrderRepository
    {
    public Hiiops_Shop_Store_OrderRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IHiiops_Shop_Store_OrderRepository Instance
    {
      get {  return AutofacContainerModule.GetService<IHiiops_Shop_Store_OrderRepository>(); } }
    }
}
