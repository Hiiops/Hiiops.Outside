using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace VOL.Core.Utilities.WeChat
{
    public class WxJsTicket
    {
        WxUtils _wxUtils;
        #region 属性

        private string _noncestr;
        private string _timestamp;

        /// <summary>
        /// 随机码
        /// </summary>
        public string Noncestr
        {
            set { _noncestr = value; }
            get { return _noncestr; }
        }

        /// <summary>
        /// 时间戳
        /// </summary>
        public string Timestamp
        {
            set { _timestamp = value; }
            get { return _timestamp; }
        }

        #endregion


        public WxJsTicket()
        {

            _wxUtils = new WxUtils();
            _timestamp = GetTimeStamp();
            _noncestr = GetRandomCode(16);
        }
        /// <summary>
        /// 获得JSapi调用签名
        /// </summary>
        /// <param name="url">当前的url</param>
        /// <param name="jsapi_ticket">微信公众号 jsapi_ticket</param>
        /// <returns></returns>
        public string GetSignature(string url, string jsapi_ticket)
        {
            string str = "jsapi_ticket=" + jsapi_ticket + "&noncestr=" + _noncestr + "&timestamp=" + _timestamp + "&url=" + url;
            string r = GetSHA1String(str).ToLower();
            return r;
        }
        #region 私有方法

        /// <summary>
        ///  生成微信公众号 jsapi_ticket
        /// </summary>
        /// <param name="token">微信服务号全局access_token</param>
        /// <returns></returns>
        private JObject GetJsApiTicket(string token)
        {
            var data = new Dictionary<string, string>();
            data.Add("access_token", token);
            data.Add("type", "jsapi");
            var queryString = _wxUtils.HttpBuildQuery(data);
            var jsapiTicketUrl = "https://api.weixin.qq.com/cgi-bin/ticket/getticket?" + queryString;
            var resp = _wxUtils.SendGet(jsapiTicketUrl);
            var jObject = JObject.Parse(resp);
            return jObject;
            //double expires_in = double.Parse(jObject.GetValue("expires_in").ToString());
            //string ticket = jObject.GetValue("ticket").ToString();
            //_cacheService.SetCache(CacheKey.WXFWTICKET, ticket, DateTime.Now.AddSeconds(expires_in - 1000));
            //return ticket;
        }

        /// <summary>
        /// 获取SHA1值
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        private string GetSHA1String(string src)
        {
            //建立SHA1对象
            SHA1 shaTemp = new SHA1CryptoServiceProvider();
            byte[] dataToHash = Encoding.ASCII.GetBytes(src);
            return BitConverter.ToString(shaTemp.ComputeHash(dataToHash)).Replace("-", "");
        }

        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <returns></returns>
        private string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }

        /// <summary>
        /// 获得随机数
        /// </summary>
        /// <param name="CodeCount"></param>
        /// <returns></returns>
        private string GetRandomCode(int CodeCount)
        {
            string allChar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
            string[] allCharArray = allChar.Split(',');
            string RandomCode = "";
            int temp = -1;

            Random rand = new Random();
            for (int i = 0; i < CodeCount; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(temp * i * ((int)DateTime.Now.Ticks));
                }

                int t = rand.Next(62);

                while (temp == t)
                {
                    t = rand.Next(62);
                }

                temp = t;
                RandomCode += allCharArray[t];
            }
            return RandomCode;
        }

        #endregion
    }
}
