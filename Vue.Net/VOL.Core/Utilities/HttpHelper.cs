using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
namespace VOL.Core.Utilities
{
    /// <summary>
    /// HTTP发送请求
    /// </summary>
    public class HttpHelper
    {
        #region 私有变量
        Encoding _encoding = Encoding.UTF8;
        string _contentType;
        string _url;
        #endregion

        /// <summary>
        /// 请求头
        /// </summary>
        public Dictionary<string, string> RequestHeaders { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="url">地址</param>
        /// <param name="contentType">contentType</param>
        public HttpHelper(string url, string contentType = "text/html;charset=UTF-8")
        {
            _url = url;
            _contentType = contentType;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="url">地址</param>
        /// <param name="encoding">编码</param>
        public HttpHelper(string url, Encoding encoding)
        {
            _url = url;
            _encoding = encoding;
        }

        /// <summary>
        /// 发起 get 请求
        /// </summary>
        /// <returns>response</returns>
        public string SendGet()
        {
            try
            {
                Uri uri = new Uri(_url);
                if (uri.Scheme == "https")
                    ServicePointManager.ServerCertificateValidationCallback += (x, cert, chain, sslPolicyErrors) => true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                var request = (HttpWebRequest)WebRequest.Create(_url);
                request.Method = "GET";
                request.ContentType = _contentType;
                if (RequestHeaders.Count > 0)
                {
                    foreach (var item in RequestHeaders)
                    {
                        request.Headers.Add(item.Key, item.Value);
                    }
                }
                RequestHeaders.Clear();
                WebResponse response = request.GetResponse() as HttpWebResponse;
                StreamReader reader = new StreamReader(response.GetResponseStream(), _encoding);
                string s = reader.ReadToEnd();
                response.Close();
                reader.Close();
                return s;
            }
            catch (WebException e)
            {
                throw new WebException(e.Message);
            }
        }

        /// <summary>
        /// 发起post请求且发送JSON
        /// </summary>
        /// <param name="data">发送数据</param>
        /// <returns></returns>
        public string SendPost(string data)
        {
            try
            {
                Uri uri = new Uri(_url);
                if (uri.Scheme == "https")
                    ServicePointManager.ServerCertificateValidationCallback += (x, cert, chain, sslPolicyErrors) => true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                byte[] buffer = _encoding.GetBytes(data);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_url);
                request.Method = "POST";
                request.ContentType = _contentType;
                request.ContentLength = buffer.Length;
                if (RequestHeaders.Count > 0)
                {
                    foreach (var item in RequestHeaders)
                    {
                        request.Headers.Add(item.Key, item.Value);
                    }
                }
                RequestHeaders.Clear();

                Stream reqst = request.GetRequestStream();
                reqst.Write(buffer, 0, buffer.Length);
                reqst.Flush();
                reqst.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, _encoding);
                string result = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();
                return result;
            }
            catch (WebException e)
            {
                throw new WebException(e.Message);
            }
        }

        /// <summary>
        /// 发起post请求
        /// </summary>
        /// <param name="data">发送数据</param>
        /// <returns></returns>
        public string SendPost(Dictionary<string, string> data)
        {
            var strParam = string.Join("&", data.Select(o => o.Key + "=" + o.Value));
            return SendPost(strParam);
        }

        /// <summary>
        /// 发起post请求且获取stream
        /// </summary>
        /// <param name="data">发送数据</param>
        /// <returns></returns>
        public Stream SendPostStream(string data)
        {
            try
            {
                Uri uri = new Uri(_url);
                if (uri.Scheme == "https")
                    ServicePointManager.ServerCertificateValidationCallback += (x, cert, chain, sslPolicyErrors) => true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                byte[] buffer = _encoding.GetBytes(data);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_url);
                request.Method = "POST";
                request.ContentType = _contentType;
                request.ContentLength = buffer.Length;
                if (RequestHeaders.Count > 0)
                {
                    foreach (var item in RequestHeaders)
                    {
                        request.Headers.Add(item.Key, item.Value);
                    }
                }
                RequestHeaders.Clear();

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
    }
}
