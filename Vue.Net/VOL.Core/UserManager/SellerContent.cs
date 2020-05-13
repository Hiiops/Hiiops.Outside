using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using VOL.Core.CacheManager;
using VOL.Core.DBManager;
using VOL.Core.Extensions;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;
using VOL.Entity.DomainModels.Cart;

namespace VOL.Core.UserManager
{
    public class SellerContent
    {
        /// <summary>
        /// 为了尽量减少redis或Memory读取,保证执行效率,将UserContext注入到DI，
        /// 每个UserContext的属性至多读取一次redis或Memory缓存从而提高查询效率
        /// </summary>
        public static SellerContent Current
        {
            get
            {
                return Context.RequestServices.GetService(typeof(SellerContent)) as SellerContent;
            }
        }

        private static Microsoft.AspNetCore.Http.HttpContext Context
        {
            get
            {
                return Utilities.HttpContext.Current;
            }
        }
        private static ICacheService CacheService
        {
            get { return GetService<ICacheService>(); }
        }

        private static T GetService<T>() where T : class
        {
            return AutofacContainerModule.GetService<T>();
        }
        private Hiiops_Cart_LoginInfo _loginInfo { get; set; }
        public Hiiops_Cart_LoginInfo LoginInfo
        {
            get
            {
                if (_loginInfo != null)
                {
                    return _loginInfo;
                }
                return GetLoginInfo(Id);
            }
        }
        public Hiiops_Cart_LoginInfo GetLoginInfo(int Id)
        {
            if (_loginInfo != null) return _loginInfo;
            if (Id <= 0)
            {
                _loginInfo = new Hiiops_Cart_LoginInfo();
                return _loginInfo;
            }
            string key = Id.GetUserIdKey();
            _loginInfo = CacheService.Get<Hiiops_Cart_LoginInfo>(key);
            if (_loginInfo != null && _loginInfo.Id > 0) return _loginInfo;

            _loginInfo = DBServerProvider.DbContext.Set<Hiiops_Cart_SellerUser>()
                .Where(x => x.Id == Id).Select(s => new Hiiops_Cart_LoginInfo()
                {
                    Id = Id,
                    Account = s.Account,
                    UnionId = s.UnionId,
                    NickNme = s.NickName,
                    OpenId = s.OpenId,
                    Phone = s.Phone,
                    Enable = s.Status,
                    Token = s.Token,
                    UserName = s.Name
                }).FirstOrDefault();

            if (_loginInfo != null && _loginInfo.Id > 0)
            {
                CacheService.AddObject(key, _loginInfo);
            }
            return _loginInfo ?? new Hiiops_Cart_LoginInfo();
        }

        public int Id
        {
            get
            {
                return (Context.User.FindFirstValue(JwtRegisteredClaimNames.Jti)
                    ?? Context.User.FindFirstValue(ClaimTypes.NameIdentifier)).GetInt();
            }
        }

        public string UserName
        {
            get { return LoginInfo.UserName; }
        }

         

        public string Token
        {
            get { return LoginInfo.Token; }
        }
 

        public void LogOut(int Id)
        {
            CacheService.Remove(Id.GetUserIdKey());
        }

    }
}
  