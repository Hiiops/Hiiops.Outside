using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VOL.Core.Enums;
using VOL.Core.Utilities;

namespace Hiiops.Applet.IServices
{
    public interface ISMSService
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
        WebResponseContent SendTemplateSms(string regionId, string accessKeyId, string secret, string phone, string signName, string templateCode, string templateParam, IsvType isvType = IsvType.Aliyun);

        /// <summary>
        /// 发送模板信息
        /// </summary>
        /// <param name="phone">手机号码</param>
        /// <param name="templateCode">模板编号</param>
        /// <param name="json">参数</param>
        /// <returns></returns>
        WebResponseContent SendBatchSms(string phone, string templateCode, string json);
      
    }
}
