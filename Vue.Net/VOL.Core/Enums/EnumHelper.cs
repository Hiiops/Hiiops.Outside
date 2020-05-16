namespace VOL.Core.Enums
{
    public static class EnumHelper
    {
        #region 上传类型
        /// <summary>
        /// 上传类型
        /// </summary>
        public enum UpLoadType
        {
            none = -1,
            /// <summary>
            /// 系统
            /// </summary>
            system = 0,
            /// <summary>
            /// 电商
            /// </summary>
            shop = 1,
            /// <summary>
            /// CMS
            /// </summary>
            cms = 2,
            /// <summary>
            /// SNS
            /// </summary>
            sns = 3,
            /// <summary>
            /// 支付渠道
            /// </summary>
            paychannel = 4
        }
        #endregion

        #region 订单业务类型
        /// <summary>
        /// 订单业务类型
        /// </summary>
        public enum OrderType
        {
            /// <summary>
            /// 团购
            /// </summary>
            group,
            /// <summary>
            /// 外卖
            /// </summary>
            takeaway,
            /// <summary>
            /// 秒杀
            /// </summary>
            seckill,
            /// <summary>
            /// 酒店订房
            /// </summary>
            hotel,
            /// <summary>
            /// 普通商品（参与物流）
            /// </summary>
            practicality,
            /// <summary>
            /// 虚拟商品
            /// </summary>
            fictitious,
            /// <summary>
            /// 电子券
            /// </summary>
            ticket,
            /// <summary>
            /// 物业
            /// </summary>
            property,
            /// <summary>
            /// 用户充值
            /// </summary>
            recharge,
            /// <summary>
            /// 数据会员
            /// </summary>
            datatype,
            /// <summary>
            /// 服务会员
            /// </summary>
            servicetype,
            /// <summary>
            /// 升级会员
            /// </summary>
            updatetype,
        }
        #endregion

        #region 支付方式
        /// <summary>
        /// 支付方式 0 货到付款 |1 在线支付
        /// </summary>
        public enum PaymentMethod
        {
            /// <summary>
            /// 线下
            /// </summary>
            OfflinePay = 0,
            /// <summary>
            /// 在线支付
            /// </summary>
            OnlinePay = 1,
        }
        #endregion

        #region 支付状态
        /// <summary>
        ///支付状态 -1支付超时| 0 未支付 | 1 客户端已支付，等待服务器端确认支付状态 | 2 已支付
        /// </summary>
        public enum PaymentStatus
        {
            /// <summary>
            /// 支付超时
            /// </summary>
            TimeOut = -1,
            /// <summary>
            /// 未支付
            /// </summary>
            Unpaid = 0,
            /// <summary>
            /// 等待确认
            /// </summary>
            PreConfirm = 1,
            /// <summary>
            /// 已支付
            /// </summary>
            Paid = 2
        }
        #endregion

        #region 订单自身状态
        /// <summary>
        /// 获取订单自身状态    
        /// </summary>
        /// <remarks> -1 死单（取消） | 0 未处理 | 1 进行中 | 2 已完成 </remarks>
        public enum OrderStatus
        {
            /// <summary>
            /// 死单
            /// </summary>
            Cancel = -1,
            /// <summary>
            /// 未处理
            /// </summary>
            UnHandle = 0,
            /// <summary>
            /// 进行中
            /// </summary>
            Handling = 1,
            /// <summary>
            /// 已完成
            /// </summary>
            Complete = 2
        }
        #endregion

        #region 配送方式
        /// <summary>
        /// 配送方式 0 到店自取 |1 物流配送
        /// </summary>
        public enum ShippingMethod
        {
            /// <summary>
            /// 到店自取
            /// </summary>
            Pickup = 0,
            /// <summary>
            /// 物流配送
            /// </summary>
            Logistics = 1,
        }
        #endregion

        #region 配送状态
        /// <summary>
        /// 配送状态 0 未发货 | 1 已发货 | 2 已确认收货 | 3 拒收退货中 | 4 拒收已确认退货(商家收到退回的货物)
        /// </summary>
        public enum ShippingStatus
        {
            /// <summary>
            /// 未发货
            /// </summary>
            UnShipped = 0,
            /// <summary>
            /// 已发货
            /// </summary>
            Shipped = 1,
            /// <summary>
            /// 已确认收货
            /// </summary>
            ConfirmShip = 2,

        }
        #endregion

        #region 退款/退货状态
        /// <summary>
        /// 退款/退货状态 0 未退款 | 1 请求退款 | 2 已退款 |3 拒绝退款|4退货单关闭
        /// </summary>
        public enum RefundStatus
        {
            /// <summary>
            /// 未退款
            /// </summary>
            None = 0,
            /// <summary>
            /// 申请退款中
            /// </summary>
            Refunding = 1,
            /// <summary> 
            /// 已退款
            /// </summary>
            Refunds = 2,
            /// <summary>
            /// 拒绝退款
            /// </summary>
            Refuse = 3,
            /// <summary>
            /// 退款关闭
            /// </summary>
            RefundsClose = 4
        }
        #endregion

        #region 收藏类型
        /// <summary>
        ///  收藏类型
        /// </summary>
        public enum Favorite
        {
            /// <summary>
            /// 商品
            /// </summary>
            Product = 1,
            /// <summary>
            /// 商家
            /// </summary>
            Supplier = 2,
            /// <summary>
            /// 文章
            /// </summary>
            Article = 3,
            /// <summary>
            /// 高校
            /// </summary>
            College = 4,
            /// <summary>
            /// 专业
            /// </summary>
            Major = 5,
            /// <summary>
            /// 留言
            /// </summary>
            Guestbook = 6
        }
        #endregion

        #region 组合状态
        /// <summary>
        /// 获取的订单组合状态的类型
        /// </summary>
        public enum OrderMainStatus
        {
            /// <summary>
            /// 全部
            /// </summary>
            All = 0,
            /// <summary>
            /// 等待付款
            /// </summary>
            Paying = 1,
            /// <summary>
            /// 待发货  【虚拟商品标识为：待发货-未使用(待生成预订套餐)】
            /// </summary>
            UnShiped = 2,
            /// <summary>
            /// 已发货,等待收货  【虚拟商品标识为：待评价-已发货(已生成预订套餐)】
            /// </summary>
            Shiped = 3,
            /// <summary>
            /// 已完成   【虚拟商品标识为：已生成预订套餐体验流程全部完成)】
            /// </summary>
            Complete = 4,
            /// <summary>
            /// 取消订单
            /// </summary>
            Cancel = 5,
            /// <summary>
            /// 退货与退款组合
            /// </summary>
            Refunds = 6,
            /// <summary>
            /// 退款中
            /// </summary>
            RefundsPaying = 7,
            /// <summary>
            /// 退货中
            /// </summary>
            RefundsShiping = 8,
            /// <summary>
            /// 已退款
            /// </summary>
            RefundsPayed = 9,
            /// <summary>
            /// 已退货
            /// </summary>
            RefundsShiped = 10,
            /// <summary>
            /// 退款/退货失败
            /// </summary>
            RefundsFail = 11
        }
        #endregion

        #region 消息类型
        /// <summary>
        /// 获取的订单组合状态的类型
        /// </summary>
        public enum MsgType
        {
            /// <summary>
            /// 系统消息
            /// </summary>
            System,
            /// <summary>
            /// 订单消息
            /// </summary>
            Order,
            /// <summary>
            /// 通知消息
            /// </summary>
            Notice
        }
        #endregion

        #region 支付渠道
        /// <summary>
        /// 支付渠道
        /// </summary>
        public enum PaymentChannel
        {
            /// <summary>
            /// 微信支付
            /// </summary>
            wxpay,
            /// <summary>
            /// 支付宝支付
            /// </summary>
            alipay,
            /// <summary>
            /// 小程序支付
            /// </summary>
            wxjspay,
            /// <summary>
            /// 支付宝pc
            /// </summary>
            alipaypc,
            /// <summary>
            /// 微信pc扫码支付
            /// </summary>
            wxnativepay,
            /// <summary>
            /// 卡充值
            /// </summary>
            card
        }
        #endregion

        #region 会员服务类型
        /// <summary>
        /// 会员服务类型
        /// </summary>
        public enum ServiceType
        {
            /// <summary>
            /// 院校数据查询
            /// </summary>
            院校数据查询 = 0,
            /// <summary>
            /// 专业数据查询 other接口
            /// </summary>
            专业录取数据查询 = 1,
            /// <summary>
            /// 招生计划查询 other接口
            /// </summary>
            招生计划查询 = 2,
            /// <summary>
            /// 学校录取查询 collage接口
            /// </summary>
            学校录取查询 = 3,
            /// <summary>
            /// 职业信息库
            /// </summary>
            职业信息库 = 4,
            /// <summary>
            /// 专业库
            /// </summary>
            专业库 = 5,
            /// <summary>
            /// 录取风险测评
            /// </summary>
            录取风险测评 = 6,
            /// <summary>
            /// 志愿表存储张数
            /// </summary>
            志愿表存储张数 = 7,
            /// <summary>
            /// 志愿填报
            /// </summary>
            院校优先填报 = 8,
            /// <summary>
            /// 智能填报
            /// </summary>
            智能填报 = 9,
            /// <summary>
            /// 分数段查询
            /// </summary>
            分数段查询 = 10,
            /// <summary>
            /// 分数段查询
            /// </summary>
            位次段查询 = 11,
            /// <summary>
            /// 专业游戏填报
            /// </summary>
            专业优先填报 = 12,
            /// <summary>
            /// 自主填报
            /// </summary>
            自主填报 = 13,
        }
        #endregion

        #region 志愿填报类型
        /// <summary>
        /// 志愿填报类型
        /// </summary>
        public enum StuReportType
        {
            /// <summary>
            /// 暂无数据
            /// </summary>
            暂无数据 = 0,
            /// <summary>
            /// 冲
            /// </summary>
            冲 = 1,
            /// <summary>
            /// 争
            /// </summary>
            争 = 2,
            /// <summary>
            /// 稳
            /// </summary>
            稳 = 3,
            /// <summary>
            /// 保
            /// </summary>
            保 = 4,
            /// <summary>
            /// 守
            /// </summary>
            守 = 5,
            /// <summary>
            /// 分数浪费
            /// </summary>
            可能浪费分数 = 6,
            /// <summary>
            /// 风险大
            /// </summary>
            风险大 = 7,
        }
        #endregion

        #region 会员类型
        /// <summary>
        ///  会员类型
        /// </summary>
        public enum VipType
        {
            /// <summary>
            /// 数据卡会员
            /// </summary>
            DataType = 1,
            /// <summary>
            /// 服务卡会员
            /// </summary>
            ServiceType = 2
        }
        #endregion
    }
}
