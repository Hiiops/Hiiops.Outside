using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using VOL.Core.Const;
using VOL.Core.Enums;
using VOL.Core.Extensions;
using VOL.Core.Services;
using VOL.Core.Utilities;
using static VOL.Core.Enums.EnumHelper;

namespace VOL.Core.Push
{
    /// <summary>
    /// 个推实现
    /// </summary>
    public class GeTuiPushService : PushService
    {
        #region 属性
        /// <summary>
        /// 个推appid
        /// </summary>
        string _appId = "";
        /// <summary>
        /// 个推appkey
        /// </summary>
        string _appKey = "";
        /// <summary>
        /// 个推mastersecret
        /// </summary>
        string _masterSecret = "";

        #endregion

        /// <summary>
        /// 推送消息
        /// </summary>
        public override void SendPush()
        {
            string taskId = SaveListBody(Title, Description, MsgType, TargetId);
            var url = $"https://restapi.getui.com/v1/{_appId}/push_list";
            var authToken = GetAuthToken();
            var data = new JObject();
            data.Add("alias", JArray.FromObject(ReceiverIdList));
            data.Add("taskid", taskId);
            data.Add("need_detail", true);

            HttpHelper httpHelper = new HttpHelper(url, "application/json");
            httpHelper.RequestHeaders.Add("authtoken", authToken);
            string result = httpHelper.SendPost(data.ToString());
            var json = JObject.Parse(result);
            //添加推送记录
            if (json["result"].ToString() == "ok")
            {
                //var listMsg = new List<ZhongQi.Entity.SiteMessage>();
                //foreach (var item in ReceiverIdList)
                //{
                //    var model = new ZhongQi.Entity.SiteMessage();
                //    model.SenderID = SenderID;
                //    model.ReceiverID = item.ToInt();
                //    model.Title = Title;
                //    model.Content = Description;
                //    model.MsgType = MsgType.ToString();
                //    model.SendTime = DateTime.Now;
                //    model.Ext1 = TargetId.ToString();
                //    listMsg.Add(model);
                //}
                //_siteMessage.AddRange(listMsg);
            }
        }

        /// <summary>
        /// 绑定别名
        /// </summary>
        /// <param name="cId">设备id</param>
        /// <param name="userId">userId</param>
        public override void BindAlias(string cId, string userId)
        {
            var url = $"https://restapi.getui.com/v1/{_appId}/bind_alias";
            var authToken = GetAuthToken();
            var data = new JObject();
            JArray aliasList = new JArray();

            var alias = new JObject();
            alias.Add("cid", cId);
            alias.Add("alias", userId);
            aliasList.Add(alias);

            data.Add("alias_list", aliasList);
            HttpHelper httpHelper = new HttpHelper(url, "application/json");
            httpHelper.RequestHeaders.Add("authtoken", authToken);
            string result = httpHelper.SendPost(data.ToString()); 
            Logger.Info(LoggerType.Login, $"绑定用户,结果[{result}],cid[{cId}],userId[{userId}]");
           
        }

        #region 私有方法
        /// <summary>
        /// 获取token
        /// </summary>
        /// <returns></returns>
        private string GetAuthToken()
        {
            string objCache = _cacheService.Get<string>(CacheKey.GETUIAUTHTOKEN);
            if (objCache == null)
            {
                string authToken = string.Empty;
                string timestamp = DateTime.Now.GetTimeSpan().ToString();
                var url = string.Format("https://restapi.getui.com/v1/{0}/auth_sign", _appId);
                var data = new JObject();
                string sign = HashEncrypt.GetSHA256(_appKey + timestamp + _masterSecret);
                data.Add("sign", sign);
                data.Add("timestamp", timestamp);
                data.Add("appkey", _appKey);
                HttpHelper httpHelper = new HttpHelper(url, "application/json");
                string result = httpHelper.SendPost(data.ToString());
                JObject json = JObject.Parse(result);
                if (json["result"].ToString() == "ok")
                {
                    authToken = json["auth_token"].ToString();
                    _cacheService.Add(CacheKey.GETUIAUTHTOKEN, authToken, DateTime.Now.AddHours(23).GetTimeSpan());
                }
                return authToken;
            }
            else
            {
                return objCache;
            }
        }

        /// <summary>
        /// 保存消息体
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="text">内容</param>
        /// <param name="msgType">消息类型</param>
        /// <param name="targetId">参数值</param>
        /// <returns></returns>
        private string SaveListBody(string title, string text, MsgType msgType, int targetId)
        {
            var url = $"https://restapi.getui.com/v1/{_appId}/save_list_body";
            var authToken = GetAuthToken();
            var data = new JObject();

            var msgObj = new JObject();
            msgObj.Add("appkey", _appKey);
            msgObj.Add("is_offline", true);//是否离线推送
            msgObj.Add("msgtype", "transmission");//消息应用类型，可选项：notification(点击通知打开应用模板)、link(点击通知打开网页模
            var transmissionObj = new JObject();

            var pushInfoObj = new JObject();
            var apsObj = new JObject();

            var alertObj = new JObject();
            alertObj.Add("title", title);
            alertObj.Add("body", text);

            apsObj.Add("alert", alertObj);

            var payLoad = new JObject();
            payLoad.Add("id", 1);
            payLoad.Add("msgType", msgType.ToString());
            payLoad.Add("targetId", targetId);

            var contentObj = new JObject();
            contentObj.Add("title", title);
            contentObj.Add("content", text);
            contentObj.Add("payload", payLoad);
            transmissionObj.Add("transmission_content", contentObj.ToString());//透传内容

            pushInfoObj.Add("aps", apsObj);
            pushInfoObj.Add("payload", payLoad.ToString());

            data.Add("message", msgObj);
            data.Add("transmission", transmissionObj);
            data.Add("push_info", pushInfoObj);

            HttpHelper httpHelper = new HttpHelper(url, "application/json");
            httpHelper.RequestHeaders.Add("authtoken", authToken);
            string result = httpHelper.SendPost(data.ToString());
            JObject json = JObject.Parse(result);

            string taskId = string.Empty;
            if (json["result"].ToString() == "ok")
            {
                taskId = json["taskid"].ToString();
            }
            return taskId;
        }
        #endregion
    }
}
