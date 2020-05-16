
using System;
using System.Collections.Generic;
using VOL.Core.BaseInterface;
using VOL.Core.BaseProvider;
using VOL.Core.CacheManager;
using VOL.Core.Extensions.AutofacManager;
using static VOL.Core.Enums.EnumHelper;

namespace VOL.Core.Push
{
    /// <summary>
    /// 推送抽象类
    /// </summary>
    public abstract class PushService : BaseService, IDependency
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 接收者
        /// </summary>
        public List<string> ReceiverIdList { get; set; }
        /// <summary>
        /// 发送者
        /// </summary>
        public int SenderID { get; set; }
        /// <summary>
        /// 参数值
        /// </summary>
        public int TargetId { get; set; }

        public MsgType MsgType { get; set; }

        protected IServices _services;
        protected ICacheService _cacheService;
        protected IServiceProvider _serviceProvider;

        public PushService()
        {

        }
        public static IServices Instance
        {
            get { return AutofacContainerModule.GetService<IServices>(); }
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="receiverIdList">接收者</param>
        /// <param name="senderId">发送者</param>
        /// <param name="title">标题</param>
        /// <param name="description">内容</param>
        /// <param name="msgType">消息类型</param>
        /// <param name="targetId">参数值</param>
        public void Init(List<string> receiverIdList, int senderId, string title, string description, MsgType msgType, int targetId)
        {
            this.SenderID = senderId;
            this.Title = title;
            this.ReceiverIdList = receiverIdList;
            this.Description = description;
            this.MsgType = msgType;
            this.TargetId = targetId;
        }

        /// <summary>
        /// 推送消息
        /// </summary>
        public abstract void SendPush();

        /// <summary>
        /// 绑定别名
        /// </summary>
        /// <param name="cId">设备id</param>
        /// <param name="userId">userId</param>
        public abstract void BindAlias(string cId, string userId);
    }
}

