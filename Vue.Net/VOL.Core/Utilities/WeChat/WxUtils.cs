using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace VOL.Core.Utilities.WeChat
{
    /// <summary>
    /// 微信辅助类
    /// </summary>
    public class WxUtils
    {
        public WxUtils()
        {

        }

        #region 辅助方法

        /// <summary>
        /// Dictionary类转化为queryString
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public string HttpBuildQuery(Dictionary<string, string> queryString)
        {
            var sb = new StringBuilder();

            foreach (var kvp in queryString)
            {
                if (sb.Length > 0)
                {
                    sb.Append('&');
                }
                sb.Append(UrlEncodePair(kvp.Key, kvp.Value));
            }

            return sb.ToString();
        }

        /// <summary>
        /// 组合key与value
        /// </summary>
        /// <param name="k"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        private string UrlEncodePair(string k, string v)
        {
            return string.Format("{0}={1}", k, UrlEncode(v));
        }

        /// <summary>
        /// 对key value 进行URL编码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string UrlEncode(string str)
        {
            return string.IsNullOrEmpty(str) ? null : WebUtility.UrlEncode(str);
        }

        /// <summary>
        /// 发起 get 请求
        /// </summary>
        /// <param name="url">请求的 url</param>
        /// <returns>response</returns>
        public string SendGet(string url)
        {
            try
            {
                Uri uri = new Uri(url);
                if (uri.Scheme == "https")
                    ServicePointManager.ServerCertificateValidationCallback += (x, cert, chain, sslPolicyErrors) => true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                WebResponse response = request.GetResponse() as HttpWebResponse;
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                string s = reader.ReadToEnd();
                response.Close();
                reader.Close();
                return s;
            }
            catch (WebException e)
            {
                throw new WebException(e.ToString());
            }
        }

        /// <summary>
        /// 发起post请求且发送JSON
        /// </summary>
        /// <param name="url">请求地址URL</param>
        /// <param name="data">发送JSON数据</param>
        /// <returns></returns>
        public string SendPost(string url, string data)
        {
            try
            {
                Uri uri = new Uri(url);
                if (uri.Scheme == "https")
                    ServicePointManager.ServerCertificateValidationCallback += (x, cert, chain, sslPolicyErrors) => true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                byte[] buffer = Encoding.UTF8.GetBytes(data);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "text/html;charset=UTF-8";
                request.ContentLength = buffer.Length;

                Stream reqst = request.GetRequestStream();
                reqst.Write(buffer, 0, buffer.Length);
                reqst.Flush();
                reqst.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                string result = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();
                return result;
            }
            catch (WebException e)
            {
                throw new WebException(e.ToString());
            }
        }

        /// <summary>
        /// 发起post请求且发送JSON获取stream
        /// </summary>
        /// <param name="url">请求地址URL</param>
        /// <param name="data">发送JSON数据</param>
        /// <returns></returns>
        public Stream SendPostStream(string url, string data)
        {
            try
            {
                Uri uri = new Uri(url);
                if (uri.Scheme == "https")
                    ServicePointManager.ServerCertificateValidationCallback += (x, cert, chain, sslPolicyErrors) => true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                byte[] buffer = Encoding.UTF8.GetBytes(data);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "text/html;charset=UTF-8";
                request.ContentLength = buffer.Length;

                Stream reqst = request.GetRequestStream();
                reqst.Write(buffer, 0, buffer.Length);
                reqst.Flush();
                reqst.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                return myResponseStream;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        #endregion

        #region 小程序

        /// <summary>
        /// 获取小程序全局(access_token)
        /// </summary>
        /// <param name="appid">微信小程序appid</param>
        /// <param name="secret">微信小程序AppSecret</param>
        /// <param name="grant_type">授权类型,默认client_credential</param>
        /// <returns>JObject</returns>
        /// string access_token = jObject.GetValue("access_token").ToString();
        ///double expires_in = double.Parse(jObject.GetValue("expires_in").ToString());
        public JObject GetXcxAccessToken(string appid, string secret, string grant_type = "client_credential")
        {
            var data = new Dictionary<string, string>
                {
                    {"appid", appid},
                    {"secret",secret},
                    {"grant_type", grant_type}
                };
            var queryString = HttpBuildQuery(data);
            var accessTokenUrl = "https://api.weixin.qq.com/cgi-bin/token?" + queryString;
            var resp = SendGet(accessTokenUrl);
            return JObject.Parse(resp);
            //var jObject = JObject.Parse(resp);
            //string access_token = jObject.GetValue("access_token").ToString();
            //double expires_in = double.Parse(jObject.GetValue("expires_in").ToString());
            //return access_token;
        }


        /// <summary>
        /// 组装微信小程序授权url
        /// </summary>
        /// <param name="code">获取到的 code</param>
        /// <param name="appid">微信小程序appid</param>
        /// <param name="secret">微信小程序AppSecret</param>
        /// <returns>获取 openid 的 URL 地址</returns>
        private string CreateXcxOauthUrlForOpenid(string code, string appid, string secret)
        {
            var data = new Dictionary<string, string>
            {
                {"appid",appid},
                {"secret", secret},
                {"js_code", code},
                {"grant_type", "authorization_code"}
            };
            return string.Format("https://api.weixin.qq.com/sns/jscode2session?{0}", HttpBuildQuery(data));
        }

        /// <summary>
        /// 获取小程序登录授权key
        /// </summary>
        /// <param name="code">获取到的 code</param>
        /// <param name="appid">微信小程序appid</param>
        /// <param name="secret">微信小程序AppSecret</param>
        /// <returns>openid</returns>
        public string GetXcxKey(string code, string appid, string secret)
        {
            var url = CreateXcxOauthUrlForOpenid(code, appid, secret);
            var resp = SendGet(url);
            return resp;
        }

        /// <summary>
        /// 获取小程序二维码
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="token">微信服务号全局access_token</param>
        /// <returns></returns>
        public Stream CreateWxaQrcode(string path, string token)
        {
            string url = "https://api.weixin.qq.com/cgi-bin/wxaapp/createwxaqrcode?access_token=" + token;
            string data = "{\"path\": \"" + path + "\", \"width\": 430}";
            Stream stream = SendPostStream(url, data);
            return stream;
        }

        /// <summary>
        /// 微信模板消息通知
        /// </summary>
        /// <param name="openid">通知用户openID</param>
        /// <param name="tempId">模板ID</param>
        /// <param name="formId">本次支付的 prepay_id</param>
        /// <param name="kv">模板参数</param>
        /// <param name="token">微信服务号全局access_token</param>
        /// <param name="pageUrl">跳转路径</param>
        public string SendTemplateNotice(string openid, string tempId, string formId, string kv, string token, string pageUrl = "")
        {
            string result = "";
            string url = "https://api.weixin.qq.com/cgi-bin/message/wxopen/template/send?access_token=" + token;

            var jsonData = new JObject();
            jsonData.Add("touser", openid);
            jsonData.Add("template_id", tempId);
            jsonData.Add("form_id", formId);
            jsonData.Add("data", kv);
            if (!string.IsNullOrWhiteSpace(pageUrl))
            {
                jsonData.Add("page", pageUrl);
            }
            result = SendPost(url, jsonData.ToString());
            return result;
        }

        #endregion

        #region 微信服务号

        /// <summary>
        /// 用于生成获取授权 code 的 URL 地址，此地址用于用户身份鉴权，获取用户身份信息，同时重定向到 redirect_url
        /// </summary>
        /// <param name="redirectUrl">
        /// 授权后重定向的回调链接地址，重定向后此地址将带有授权code参数，该地址的域名需在微信公众号平台上进行设置，
        /// 步骤为：登陆微信公众号平台  开发者中心  网页授权获取用户基本信息 修改
        /// </param>
        /// <param name="moreInfo">
        /// FALSE 不弹出授权页面,直接跳转,这个只能拿到用户openid
        /// TRUE 弹出授权页面,这个可以通过 openid 拿到昵称、性别、所在地
        /// </param>
        /// <param name="url">客户端跳转url</param>
        /// <param name="appid">微信服务号appid</param>
        /// <returns>用于获取授权 code 的 URL 地址</returns>
        public string CreateOauthUrlForCode(string redirectUrl, bool moreInfo, string url, string appid)
        {
            var data = new Dictionary<string, string>
            {
                {"appid", appid},
                {"redirect_uri", redirectUrl},
                {"response_type", "code"},
                {"scope", moreInfo ? "snsapi_userinfo" : "snsapi_base"},
                {"state", url==string.Empty?"STATE#wechat_redirect":url}
            };

            return "https://open.weixin.qq.com/connect/oauth2/authorize?" + HttpBuildQuery(data);
        }

        /// <summary>
        /// 获取 openid
        /// </summary>
        /// <param name="code">获取到的 code</param>
        /// <param name="appid">微信服务号appid</param>
        /// <param name="secret">微信服务号AppSecret</param>
        /// <returns>openid</returns>
        public string GetOpenId(string code, string appid, string secret)
        {
            var url = CreateOauthUrlForOpenid(code, appid, secret);
            var resp = SendGet(url);
            var jObject = JObject.Parse(resp);
            if (jObject == null) return "";
            JProperty jp = jObject.Property("openid");
            if (jp == null) return "";
            return jObject.GetValue("openid").ToString();
        }

        /// <summary>
        /// 生成获取 openid 的 URL 地址
        /// </summary>
        /// <param name="code">获取到的 code</param>
        /// <param name="appid">微信服务号appid</param>
        /// <param name="secret">微信服务号AppSecret</param>
        /// <returns>获取 openid 的 URL 地址</returns>
        private string CreateOauthUrlForOpenid(string code, string appid, string secret)
        {
            var data = new Dictionary<string, string>
            {
                {"appid",appid},
                {"secret", secret},
                {"code", code},
                {"grant_type", "authorization_code"}
            };

            return string.Format("https://api.weixin.qq.com/sns/oauth2/access_token?{0}", HttpBuildQuery(data));
        }

        /// <summary>
        /// 获取微信服务号全局access_token
        /// </summary>
        /// <param name="appid">微信服务号appid</param>
        /// <param name="secret">微信服务号AppSecret</param>
        /// <param name="grant_type">授权类型,默认client_credential</param>
        /// <returns>access_token</returns>
        /// string access_token = jObject.GetValue("access_token").ToString();
        /// double expires_in = double.Parse(jObject.GetValue("expires_in").ToString());
        public JObject GetAccessToken(string appid, string secret, string grant_type = "client_credential")
        {
            var data = new Dictionary<string, string>
                {
                    {"appid", appid},
                    {"secret", secret},
                    {"grant_type", grant_type}
                };
            var queryString = HttpBuildQuery(data);
            var accessTokenUrl = "https://api.weixin.qq.com/cgi-bin/token?" + queryString;
            var resp = SendGet(accessTokenUrl);
            return JObject.Parse(resp);
            //var jObject = JObject.Parse(resp);
            //string access_token = jObject.GetValue("access_token").ToString();
            //double expires_in = double.Parse(jObject.GetValue("expires_in").ToString());
            //_cacheService.SetCache(CacheKey.WXFWACCESSTOKEN, access_token, DateTime.Now.AddSeconds(expires_in - 1000));
            //return access_token;
        }

        #endregion

        #region PC

        /// <summary>
        /// 用于生成获取授权 code 的 URL 地址，此地址用于用户身份鉴权，获取用户身份信息，同时重定向到 redirect_url
        /// </summary>
        /// <param name="appid">微信PC appid</param>
        /// <param name="redirectUrl">
        /// 授权后重定向的回调链接地址，重定向后此地址将带有授权code参数，该地址的域名需在微信公众号平台上进行设置，
        /// 步骤为：登陆微信公众号平台  开发者中心  网页授权获取用户基本信息 修改
        /// </param>
        /// <param name="url">客户端跳转url</param>
        /// <returns>用于获取授权 code 的 URL 地址</returns>
        public string CreatePcOauthUrlForCode(string appid, string redirectUrl, string url)
        {
            var data = new Dictionary<string, string>
            {
                {"appid", appid},
                {"redirect_uri", redirectUrl},
                {"response_type", "code"},
                {"scope", "snsapi_login"},
                {"state", url==string.Empty?"STATE#wechat_redirect":url}
            };

            return "https://open.weixin.qq.com/connect/qrconnect?" + HttpBuildQuery(data);
        }

        /// <summary>
        /// 获取 openid
        /// </summary>
        /// <param name="code">获取到的 code</param>
        /// <param name="appid">微信PC appid</param>
        /// <param name="secret">微信PC AppSecret</param>
        /// <returns>openid</returns>
        public string GetPcOpenId(string code, string appid, string secret)
        {
            var url = CreatePcOauthUrlForOpenid(code, appid, secret);
            var resp = SendGet(url);
            var jObject = JObject.Parse(resp);
            if (jObject == null) return "";
            JProperty jp = jObject.Property("openid");
            if (jp == null) return "";
            return jObject.GetValue("openid").ToString();
        }

        /// <summary>
        /// 获取 unionid
        /// </summary>
        /// <param name="code">获取到的 code</param>
        /// <param name="appid">微信PC appid</param>
        /// <param name="secret">微信PC AppSecret</param>
        /// <returns>openid</returns>
        public string GetPcUnionid(string code, string appid, string secret)
        {
            var url = CreatePcOauthUrlForOpenid(code, appid, secret);
            var resp = SendGet(url);
            var jObject = JObject.Parse(resp);
            if (jObject == null) return "";
            JProperty jp = jObject.Property("unionid");
            if (jp == null) return "";
            return jObject.GetValue("unionid").ToString();
        }

        /// <summary>
        ///  生成获取 openid 的 URL 地址
        /// </summary>
        /// <param name="code">获取到的 code</param>
        /// <param name="appid">微信PC appid</param>
        /// <param name="secret">微信PC AppSecret</param>
        /// <returns>获取 openid 的 URL 地址</returns>
        private string CreatePcOauthUrlForOpenid(string code, string appid, string secret)
        {
            var data = new Dictionary<string, string>
            {
                {"appid", appid},
                {"secret", secret },
                {"code", code},
                {"grant_type", "authorization_code"}
            };
            return string.Format("https://api.weixin.qq.com/sns/oauth2/access_token?{0}", HttpBuildQuery(data));
        }

        #endregion

    }

}
