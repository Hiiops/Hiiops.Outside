/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Sys_UserService与ISys_UserService中编写
 */
using VOL.System.IRepositories;
using VOL.System.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.System.Services
{
    public partial class Sys_UserService : ServiceBase<Sys_User, ISys_UserRepository>, ISys_UserService, IDependency
    {
        public Sys_UserService(ISys_UserRepository repository)
             : base(repository) 
        { 
           Init(repository);
        }
        public static ISys_UserService Instance
        {
           get { return AutofacContainerModule.GetService<ISys_UserService>(); }
        }
    }
}
