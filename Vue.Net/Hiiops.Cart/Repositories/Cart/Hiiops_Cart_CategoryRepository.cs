/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹Hiiops_Cart_CategoryRepository编写代码
 */
using Hiiops.Cart.IRepositories;
using VOL.Core.BaseProvider;
using VOL.Core.EFDbContext;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Hiiops.Cart.Repositories
{
    public partial class Hiiops_Cart_CategoryRepository : RepositoryBase<Hiiops_Cart_Category> , IHiiops_Cart_CategoryRepository
    {
    public Hiiops_Cart_CategoryRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IHiiops_Cart_CategoryRepository Instance
    {
      get {  return AutofacContainerModule.GetService<IHiiops_Cart_CategoryRepository>(); } }
    }
}
