/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹Hiiops_Cart_Seller_PV_CountRepository编写代码
 */
using Hiiops.Cart.IRepositories;
using VOL.Core.BaseProvider;
using VOL.Core.EFDbContext;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Hiiops.Cart.Repositories
{
    public partial class Hiiops_Cart_Seller_PV_CountRepository : RepositoryBase<Hiiops_Cart_Seller_PV_Count> , IHiiops_Cart_Seller_PV_CountRepository
    {
    public Hiiops_Cart_Seller_PV_CountRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IHiiops_Cart_Seller_PV_CountRepository Instance
    {
      get {  return AutofacContainerModule.GetService<IHiiops_Cart_Seller_PV_CountRepository>(); } }
    }
}