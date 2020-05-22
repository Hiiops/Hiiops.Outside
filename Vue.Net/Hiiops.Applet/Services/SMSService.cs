using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;
using Hiiops.Applet.IServices;
using Newtonsoft.Json;
using System;
using VOL.Core.BaseProvider;
using VOL.Core.Enums;
using VOL.Core.Extensions.AutofacManager;
using VOL.Core.Utilities;
namespace Hiiops.Applet.Services
{

    public class SMSService :BaseService, ISMSService, IDependency
    {
        /// <summary>
        ///  发送验证码
        /// </summary>
        /// <param name="regionId">短信节点</param>
        /// <param name="accessKeyId">APPID</param>
        /// <param name="secret">secret</param>
        /// <param name="phone">手机号码</param>
        /// <param name="signName">短信签名</param>
        /// <param name="templateCode">短信模板ID</param>
        /// <param name="templateParam">短信模板变量对应的实际值，JSON格式</param>
        /// <param name="isvType">短信供应商(默认阿里云)</param>
        /// <returns></returns>
        public WebResponseContent SendTemplateSms(string regionId, string accessKeyId, string secret, string phone, string signName, string templateCode, string templateParam, IsvType isvType = IsvType.Aliyun)
        {
            switch (isvType)
            {
                case IsvType.Aliyun:
                    IClientProfile profile = DefaultProfile.GetProfile(regionId, accessKeyId, secret);
                    DefaultAcsClient client = new DefaultAcsClient(profile);
                    CommonRequest request = new CommonRequest();
                    request.Method = MethodType.POST;
                    request.Domain = "dysmsapi.aliyuncs.com";
                    request.Version = "2017-05-25";
                    request.Action = "SendSms";
                    //短信
                    // request.Protocol = ProtocolType.HTTP;
                    request.AddQueryParameters("PhoneNumbers", phone);
                    request.AddQueryParameters("SignName", signName);//"广州悦发"
                    request.AddQueryParameters("TemplateCode", templateCode);//
                    //request.AddQueryParameters("TemplateParam", "{ \"code \": \"" + content + "\" }");
                    request.AddQueryParameters("TemplateParam", templateParam);//"TemplateParam", "{'code':'" + content + "'}"
                    // request.Protocol = ProtocolType.HTTP; 
                    CommonResponse response = client.GetCommonResponse(request);
                    //string code = System.Text.Encoding.Default.GetString(response.HttpResponse.Content).Split(',')[1]; 
                    string _code = JsonConvert.DeserializeObject<AliSMSResult>(System.Text.Encoding.Default.GetString(response.HttpResponse.Content)).Code;

                    if (_code == "OK")
                    {
                        
                        return new WebResponseContent().OK("发送成功");
                    }
                    else
                    {
                        return new WebResponseContent().Error(ExceptionMsg(_code));
                    }
                case IsvType.getui:
                    string url = "http://www.ztsms.cn/sendNSms.do";
                    string userName = "userName";
                    string tkey = System.DateTime.Now.ToString("yyyyMMddHHmmss");
                    string other = HashEncrypt.GetMd5("SMSKey");
                    string password = HashEncrypt.GetMd5(other + tkey);

                    string data = string.Format("?username={0}&password={1}&mobile={2}&content={3}&tkey={4}&productid=676767&xh=",
                        userName, password, phone, templateParam, tkey);

                    HttpHelper httpHelper = new HttpHelper(url + data);
                    string s = httpHelper.SendGet();
                    string code = s.Split(',')[0];
                    if (code == "1")
                    {
                        return new WebResponseContent().OK("发送成功");
                    }
                    else
                    {
                        return new WebResponseContent().Error(ExceptionMsg(code));

                    }
                default:
                    return new WebResponseContent().Error("发送失败");

            }


        }
        /// <summary>
        /// 暂时不支持
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="templateCode"></param>
        /// <param name="json"></param>
        /// <returns></returns>
        public WebResponseContent SendBatchSms(string phone, string templateCode, string json)
        {
            throw new NotImplementedException();
        }

        #region 发送短信异常信息
        /// <summary>
        /// 发送短信异常信息
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        private static string ExceptionMsg(string code)
        {
            string msg = "";
            switch (code)
            {
                case "-1":
                    msg = "用户名或者密码不正确或用户禁用或者是管理账户！";
                    break;
                case "0":
                    msg = "当前用户ID错误,发送短信失败！";
                    break;
                case "2":
                    msg = "余额不够或扣费错误";
                    break;
                case "3":
                    msg = "扣费失败异常（请联系客服）！";
                    break;
                case "6":
                    msg = "有效号码为空！";
                    break;
                case "7":
                    msg = "短信内容为空！";
                    break;
                case "8":
                    msg = "无签名，必须，格式：【签名】";
                    break;
                case "9":
                    msg = "没有Url提交权限";
                    break;
                case "10":
                    msg = "发送号码过多,最多支持2000个号码";
                    break;

                case "11":
                    msg = "产品ID异常或产品禁用";
                    break;
                case "12":
                    msg = "参数异常！";
                    break;
                case "13":
                    msg = "tkey参数错误！";
                    break;
                case "15":
                    msg = "Ip验证失败！";
                    break;
                case "16":
                    msg = "xh参数错误！";
                    break;
                case "19":
                    msg = "短信内容过长，最多支持500个,或提交编码异常导致！";
                    break;
                case "20":
                    msg = "其它错误！";
                    break;
            }
            return msg;
        }
        #endregion


        #region 阿里短信返回结果
        public class AliSMSResult
        {
            /// <summary>
            /// 发送回执ID，可根据该ID在接口QuerySendDetails中查询具体的发送状态。
            /// </summary>
            public string BizId { get; set; }
            /// <summary>
            /// 请求状态码。 
            /// </summary>
            public string Code { get; set; }
            /// <summary>
            /// 状态码的描述。
            /// </summary>
            public string Message { get; set; }
            /// <summary>
            /// 请求ID。
            /// </summary>
            public string RequestId { get; set; }
        }
        #endregion

    }
}
