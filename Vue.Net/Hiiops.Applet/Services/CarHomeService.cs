using Hiiops.Applet.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using VOL.Core.BaseProvider;
using VOL.Core.Const;
using VOL.Core.Enums;
using VOL.Core.Extensions;
using VOL.Core.Extensions.AutofacManager;
using VOL.Core.Utilities;
using VOL.Entity.DomainModels;
using VOL.Entity.DomainModels.Cart.ViewModel;

namespace Hiiops.Applet.Services
{
    public class CarHomeService : BaseService, ICarHomeService, IDependency
    {

        public static ICarHomeService Instance
        {
            get { return AutofacContainerModule.GetService<ICarHomeService>(); }
        }
        /// <summary>
        /// 获取首页数据
        /// </summary>
        /// <returns></returns>
        public CarHomeModel GetHomeModel()
        {
            CarHomeModel carHomeModel = new CarHomeModel();
            carHomeModel.AppName = "中启汽车";
            carHomeModel.Contact = "13533506304";
            carHomeModel.IsLogin = false;
            //菜单
            carHomeModel.Menus = Instance.DbContext.Set<Hiiops_Cart_Banner>().AsQueryable().Where(x => x.BannerType == "2" && x.Status == 1).OrderBy(x => x.CreateDate).Take(10).ToList();
            //轮播
            carHomeModel.Banner = Instance.DbContext.Set<Hiiops_Cart_Banner>().AsQueryable().Where(x => x.BannerType == "1" && x.Status == 1).OrderBy(x => x.CreateDate).Take(5).ToList();
            //carHomeModel.CarList = Instance.DbContext.Set<Hiiops_Cart>().Where(x => x.Status == 1 && x.Recomend.ToBool()==true).
            //分类(最多拿8条)
            var categories = Instance.DbContext.Set<Hiiops_Cart_Category>().AsQueryable().OrderBy(x => x.Sort).Where(x => x.Status == 1 && x.Recomend == true).Take(8).ToList();
            //获取推荐分类和分类车辆
            if (categories.Count() > 0)
            {
                categories.ForEach(x =>
               {
                   var data = Instance.DbContext.Set<Hiiops_Cart>().AsQueryable().OrderBy(x => x.CreateDate).Where(x => x.Status == 1 && x.Recomend == true).Take(8).ToList();
                   if (data.Count() > 0)
                   {
                       carHomeModel.CarList.Add(new CarList()
                       {
                           Type = x.Name.Contains("二手"),
                           CategoryId = x.Id,
                           CategoryName = x.Name,
                           Total = data.Count(),
                           Hiiops_Carts = data
                       });
                   }

               });
            }
            return carHomeModel;
        }
        /// <summary>
        /// 通过车辆id获取车辆
        /// </summary>
        /// <param name="id">车辆id</param>
        /// <returns></returns>
        public async Task<WebResponseContent> Get_Cart(int id)
        {
            var data = await Instance.DbContext.Set<Hiiops_Cart>().Where(x => x.Id == id).FirstOrDefaultAsync(); 
            return new WebResponseContent().OK("获取成功", data);
        }
        /// <summary>
        /// 获取分类 信息
        /// </summary>
        /// <param name="page">页面大小</param>
        /// <param name="pageSize">行数</param>
        /// <param name="rowcount">获取到的数据行数</param>
        /// <param name="sortType">排序类型 默认通过id排序（传0，可不传） 1 创建时间 2 价格降序 3 价格升序</param>
        /// <param name="CartTypeID">分类 ID</param>
        /// <param name="BrandId">品牌ID</param>
        /// <param name="returnRowCount">是否返回行数</param>
        /// <returns></returns> 
        public WebResponseContent GetCategoryPageData(int page, int pageSize, out int rowcount, int sortType = 0, int CartTypeID = 0, int BrandId = 0, bool returnRowCount = true)
        {
            dynamic data = new System.Dynamic.ExpandoObject();
            var b = Instance.DbContext.Set<Hiiops_Cart_Brand>().AsQueryable().ToList();
            var t = Instance.DbContext.Set<Hiiops_Cart_Category>().AsQueryable().ToList();
            //排序字段
            Dictionary<string, QueryOrderBy> orderbyDic = new Dictionary<string, QueryOrderBy>();
            switch (sortType)
            {
                case 1:
                    orderbyDic.Add("CreateDate", QueryOrderBy.Desc);
                    break;
                case 2:
                    orderbyDic.Add("Price", QueryOrderBy.Desc);
                    break;
                case 3:
                    orderbyDic.Add("Price", QueryOrderBy.Asc);
                    break;
                default:
                    orderbyDic.Add("Id", QueryOrderBy.Desc);
                    break;
            }
            // Hiiops_Cart
            PageDataOptions options = new PageDataOptions();
            options.TableName = "Hiiops_Cart";
            options.Page = page;
            options.Rows = pageSize;
            //生成查询条件
            List<SearchParameters> searchParameters = new List<SearchParameters>();

            if (CartTypeID != 0)
            {
                searchParameters.Add(new SearchParameters() { DisplayType = "int", Name = "CategoryId", Value = CartTypeID + "" });
            }
            if (BrandId != 0)
            {
                searchParameters.Add(new SearchParameters() { DisplayType = "int", Name = "BrandId", Value = BrandId + "" });
            }
            options.Wheres = searchParameters.Serialize();

            page = page <= 0 ? 1 : page;
            pageSize = pageSize <= 0 ? 10 : pageSize;
            options.Page = page;
            options.Rows = pageSize;

            _ = ValidatePageOptions(options, out IQueryable<Hiiops_Cart> queryable, searchParameters);

            rowcount = returnRowCount ? queryable.Count() : 0;
            var row = queryable.GetIQueryableOrderBy<Hiiops_Cart>(orderbyDic)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
            data.brand = b;
            data.type = t;
            var cartlist = row.ToList();
            if (cartlist.Count > 0)
            {
                cartlist.ForEach(x =>
                {  
                    x.LicenseTime.ToString("yyy-MM-dd");
                });
            }
            
            data.cartlist = cartlist;
            
            decimal d = rowcount / pageSize;
            data.count = Math.Ceiling(d);
            WebResponseContent webResponseContent = new WebResponseContent();

            return webResponseContent.OK("获取成功", data);
        }
        /// <summary>
        /// 验证排序与查询字段合法性
        /// </summary>
        /// <param name="options"></param>
        /// <param name="queryable"></param>
        /// <returns></returns>
        private PageDataOptions ValidatePageOptions(PageDataOptions options, out IQueryable<Hiiops_Cart> queryable, List<SearchParameters> searchParametersList)
        {
            options = options ?? new PageDataOptions();


            queryable = Instance.DbContext.Set<Hiiops_Cart>();
            //判断列的数据类型数字，日期的需要判断值的格式是否正确
            for (int i = 0; i < searchParametersList.Count; i++)
            {
                SearchParameters x = searchParametersList[i];
                x.DisplayType = x.DisplayType.GetDBCondition();
                if (string.IsNullOrEmpty(x.Value))
                {
                    //  searchParametersList.Remove(x);
                    continue;
                }

                PropertyInfo property = TProperties.Where(c => c.Name.ToUpper() == x.Name.ToUpper()).FirstOrDefault();
                // property
                //移除查询的值与数据库类型不匹配的数据
                // x.Value = string.Join(",", dbType.ValidationVal(x.Value.Split(',')).Where(q => q != ""));
                object[] values = property.ValidationValueForDbType(x.Value.Split(',')).Where(q => q.Item1).Select(s => s.Item3).ToArray();
                // if (string.IsNullOrEmpty(x.Value))
                if (values == null || values.Length == 0)
                {
                    //   searchParametersList.Remove(x);
                    continue;
                }
                if (x.DisplayType == HtmlElementType.Contains)
                    x.Value = string.Join(",", values);
                LinqExpressionType expressionType = x.DisplayType.GetLinqCondition();
                queryable = LinqExpressionType.In == expressionType
                              ? queryable.Where(x.Name.CreateExpression<Hiiops_Cart>(values, expressionType))
                              : queryable.Where(x.Name.CreateExpression<Hiiops_Cart>(x.Value, expressionType));
            }
            //   options.Wheres = searchParametersList.GetEntitySql(); 
            return options;
        }
        private PropertyInfo[] _propertyInfo { get; set; } = null;
        private PropertyInfo[] TProperties
        {
            get
            {
                if (_propertyInfo != null)
                {
                    return _propertyInfo;
                }
                _propertyInfo = typeof(Hiiops_Cart).GetProperties();
                return _propertyInfo;
            }
        }

    }
}
