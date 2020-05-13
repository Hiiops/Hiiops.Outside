using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Newtonsoft.Json;
using System;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VOL.Core.BaseInterface;
using VOL.Core.CacheManager;
using VOL.Core.Dapper;
using VOL.Core.DBManager;
using VOL.Core.EFDbContext;
using VOL.Core.Enums;
using VOL.Core.Extensions;
using VOL.Core.Extensions.AutofacManager;
using VOL.Core.Services;
using VOL.Core.Utilities;

namespace VOL.Core.BaseProvider
{
    public abstract class BaseService: IServices
    {

        public BaseService()
        {
            Response = new WebResponseContent(true);
            this.DefaultDbContext = DBServerProvider.DbContext;
        }
        public BaseService(VOLContext dbContext)
        {
            Response = new WebResponseContent(true);
            this.DefaultDbContext = dbContext ?? throw new Exception("dbContext未实例化。");
        }
        private WebResponseContent Response { get; set; }
        private VOLContext DefaultDbContext { get; set; }
        private VOLContext EFContext
        {
            get
            { 
                return DefaultDbContext;
            }
        }

        public virtual VOLContext DbContext
        {
            get { return DefaultDbContext; }
        } 
        public ISqlDapper DapperContext
        {
            get { return DBServerProvider.SqlDapper; }
        }
        public ICacheService CacheContext
        {
            get
            {
                return AutofacContainerModule.GetService<ICacheService>();
            }
        }

        public Microsoft.AspNetCore.Http.HttpContext Context
        {
            get
            {
                return HttpContext.Current;
            }
        }
        /// <summary>
        /// 执行事务
        /// </summary>
        /// <param name="action">如果返回false则回滚事务(可自行定义规则)</param>
        /// <returns></returns>
        public virtual WebResponseContent DbContextBeginTransaction(Func<WebResponseContent> action)
        {
            WebResponseContent webResponse = new WebResponseContent();
            using (IDbContextTransaction transaction = DefaultDbContext.Database.BeginTransaction())
            {
                try
                {
                    webResponse = action();
                    if (webResponse.Status)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        transaction.Rollback();
                    }

                    return webResponse;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return new WebResponseContent().Error(ex.Message);
                }
            }
        }
        /// <summary>
        /// 对指定类与api的参数进行验证
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="bizContent"></param>
        /// <param name="input"></param>
        /// <param name="expression">对指属性验证</param>
        /// <returns>(string,TInput, bool) string:返回验证消息,TInput：bizContent序列化后的对象,bool:验证是否通过</returns>
        public virtual (string, TInput, bool) ApiValidateInput<TInput>(string bizContent, Expression<Func<TInput, object>> expression)
        {
            return ApiValidateInput(bizContent, expression, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="bizContent"></param>
        /// <param name="expression">对指属性验证格式如：x=>new { x.UserName,x.Value }</param>
        /// <param name="validateExpression">对指定的字段只做合法性判断比如长度是是否超长</param>
        /// <returns>(string,TInput, bool) string:返回验证消息,TInput：bizContent序列化后的对象,bool:验证是否通过</returns>
        public virtual (string, TInput, bool) ApiValidateInput<TInput>(string bizContent, Expression<Func<TInput, object>> expression, Expression<Func<TInput, object>> validateExpression)
        {
            try
            {
                TInput input = JsonConvert.DeserializeObject<TInput>(bizContent);
                if (!(input is System.Collections.IList))
                {
                    Response = input.ValidationEntity(expression, validateExpression);
                    return (Response.Message, input, Response.Status);
                }
                System.Collections.IList list = input as System.Collections.IList;
                for (int i = 0; i < list.Count; i++)
                {
                    Response = list[i].ValidationEntity(expression?.GetExpressionProperty(),
                        validateExpression?.GetExpressionProperty());
                    if (!Response.Status)
                        return (Response.Message, default(TInput), false);
                }
                return ("", input, true);
            }
            catch (Exception ex)
            {
                Response.Status = false;
                Response.Message = ApiMessage.ParameterError;
                Logger.Error(LoggerType.HandleError, bizContent, null, ex.Message);
            }
            return (Response.Message, default(TInput), Response.Status);
        }

        /// <summary>
        /// 将数据源映射到新的数据中,目前只支持List<TSource>映射到List<TResult>或TSource映射到TResult
        /// 目前只支持Dictionary或实体类型
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="source"></param>
        /// <param name="resultExpression">只映射返回对象的指定字段</param>
        /// <param name="sourceExpression">只映射数据源对象的指定字段</param>
        /// 过滤条件表达式调用方式：List表达式x => new { x[0].MenuName, x[0].Menu_Id}，表示指定映射MenuName,Menu_Id字段
        ///  List<Sys_Menu> list = new List<Sys_Menu>();
        ///  list.MapToObject<List<Sys_Menu>, List<Sys_Menu>>(x => new { x[0].MenuName, x[0].Menu_Id}, null);
        ///  
        ///过滤条件表达式调用方式：实体表达式x => new { x.MenuName, x.Menu_Id}，表示指定映射MenuName,Menu_Id字段
        ///  Sys_Menu sysMenu = new Sys_Menu();
        ///  sysMenu.MapToObject<Sys_Menu, Sys_Menu>(x => new { x.MenuName, x.Menu_Id}, null);
        /// <returns></returns>
        public virtual TResult MapToEntity<TSource, TResult>(TSource source, Expression<Func<TResult, object>> resultExpression,
            Expression<Func<TSource, object>> sourceExpression = null) where TResult : class
        {
            return source.MapToObject<TSource, TResult>(resultExpression, sourceExpression);
        }

        /// <summary>
        /// 将一个实体的赋到另一个实体上,应用场景：
        /// 两个实体，a a1= new a();b b1= new b();  a1.P=b1.P; a1.Name=b1.Name;
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="source"></param>
        /// <param name="result"></param>
        /// <param name="expression">指定对需要的字段赋值,格式x=>new {x.Name,x.P},返回的结果只会对Name与P赋值</param>
        public virtual void MapValueToEntity<TSource, TResult>(TSource source, TResult result, Expression<Func<TResult, object>> expression = null) where TResult : class
        {
            source.MapValueToEntity<TSource, TResult>(result, expression);
        }
        public virtual int ExecuteSqlCommand(string sql, params SqlParameter[] sqlParameters)
        {
            return DbContext.Database.ExecuteSqlRaw(sql, sqlParameters);
        }

        public virtual int SaveChanges()
        {
            return EFContext.SaveChanges();
        }

        public virtual Task<int> SaveChangesAsync()
        {
            return EFContext.SaveChangesAsync();
        }
    }
}
