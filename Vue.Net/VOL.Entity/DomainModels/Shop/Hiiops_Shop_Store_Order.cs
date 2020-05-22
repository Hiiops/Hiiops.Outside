/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果数据库字段发生变化，请在代码生器重新生成此Model
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOL.Entity.SystemModels;

namespace VOL.Entity.DomainModels
{
    [Entity(TableCnName = "订单管理",TableName = "Hiiops_Shop_Store_Order")]
    public class Hiiops_Shop_Store_Order:BaseEntity
    {
        /// <summary>
       ///订单Id
       /// </summary>
       [Key]
       [Display(Name ="订单Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///订单号
       /// </summary>
       [Display(Name ="订单号")]
       [MaxLength(64)]
       [Column(TypeName="nvarchar(64)")]
       [Required(AllowEmptyStrings=false)]
       public string Order_Id { get; set; }

       /// <summary>
       ///用户Id
       /// </summary>
       [Display(Name ="用户Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int UId { get; set; }

       /// <summary>
       ///用户姓名
       /// </summary>
       [Display(Name ="用户姓名")]
       [MaxLength(64)]
       [Column(TypeName="nvarchar(64)")]
       [Required(AllowEmptyStrings=false)]
       public string Real_Name { get; set; }

       /// <summary>
       ///用户电话
       /// </summary>
       [Display(Name ="用户电话")]
       [MaxLength(36)]
       [Column(TypeName="nvarchar(36)")]
       [Required(AllowEmptyStrings=false)]
       public string User_Phone { get; set; }

       /// <summary>
       ///详细地址
       /// </summary>
       [Display(Name ="详细地址")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Required(AllowEmptyStrings=false)]
       public string User_Address { get; set; }

       /// <summary>
       ///购物车Id
       /// </summary>
       [Display(Name ="购物车Id")]
       [MaxLength(1000)]
       [Column(TypeName="nvarchar(1000)")]
       [Required(AllowEmptyStrings=false)]
       public string Cart_Id { get; set; }

       /// <summary>
       ///运费金额
       /// </summary>
       [Display(Name ="运费金额")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Freight_Price { get; set; }

       /// <summary>
       ///订单商品总数
       /// </summary>
       [Display(Name ="订单商品总数")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Total_Num { get; set; }

       /// <summary>
       ///订单总价
       /// </summary>
       [Display(Name ="订单总价")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Total_Price { get; set; }

       /// <summary>
       ///邮费
       /// </summary>
       [Display(Name ="邮费")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Total_Postage { get; set; }

       /// <summary>
       ///实际支付金额
       /// </summary>
       [Display(Name ="实际支付金额")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Pay_Price { get; set; }

       /// <summary>
       ///支付邮费
       /// </summary>
       [Display(Name ="支付邮费")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Pay_Postage { get; set; }

       /// <summary>
       ///抵扣金额
       /// </summary>
       [Display(Name ="抵扣金额")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Deduction_Price { get; set; }

       /// <summary>
       ///优惠券Id
       /// </summary>
       [Display(Name ="优惠券Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Coupon_Id { get; set; }

       /// <summary>
       ///优惠券金额
       /// </summary>
       [Display(Name ="优惠券金额")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Coupon_Price { get; set; }

       /// <summary>
       ///支付状态
       /// </summary>
       [Display(Name ="支付状态")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte PaId { get; set; }

       /// <summary>
       ///支付时间
       /// </summary>
       [Display(Name ="支付时间")]
       [Column(TypeName="int")]
       public int? Pay_Time { get; set; }

       /// <summary>
       ///支付方式
       /// </summary>
       [Display(Name ="支付方式")]
       [MaxLength(64)]
       [Column(TypeName="nvarchar(64)")]
       [Required(AllowEmptyStrings=false)]
       public string Pay_Type { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Add_Time { get; set; }

       /// <summary>
       ///订单状态（-1 : 申请退款 -2 : 退货成功 0：待发货；1：待收货；2：已收货；3：待评价；-1：已退款）
       /// </summary>
       [Display(Name ="订单状态（-1 : 申请退款 -2 : 退货成功 0：待发货；1：待收货；2：已收货；3：待评价；-1：已退款）")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Status { get; set; }

       /// <summary>
       ///0 未退款 1 申请中 2 已退款
       /// </summary>
       [Display(Name ="0 未退款 1 申请中 2 已退款")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Refund_Status { get; set; }

       /// <summary>
       ///退款图片
       /// </summary>
       [Display(Name ="退款图片")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Refund_Reason_Wap_Img { get; set; }

       /// <summary>
       ///退款用户说明
       /// </summary>
       [Display(Name ="退款用户说明")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Refund_Reason_Wap_Explain { get; set; }

       /// <summary>
       ///退款时间
       /// </summary>
       [Display(Name ="退款时间")]
       [Column(TypeName="int")]
       public int? Refund_Reason_Time { get; set; }

       /// <summary>
       ///前台退款原因
       /// </summary>
       [Display(Name ="前台退款原因")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Refund_Reason_Wap { get; set; }

       /// <summary>
       ///不退款的理由
       /// </summary>
       [Display(Name ="不退款的理由")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Refund_Reason { get; set; }

       /// <summary>
       ///退款金额
       /// </summary>
       [Display(Name ="退款金额")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Refund_Price { get; set; }

       /// <summary>
       ///快递名称/送货人姓名
       /// </summary>
       [Display(Name ="快递名称/送货人姓名")]
       [MaxLength(128)]
       [Column(TypeName="nvarchar(128)")]
       public string Delivery_Name { get; set; }

       /// <summary>
       ///发货类型
       /// </summary>
       [Display(Name ="发货类型")]
       [MaxLength(64)]
       [Column(TypeName="nvarchar(64)")]
       public string Delivery_Type { get; set; }

       /// <summary>
       ///快递单号/手机号
       /// </summary>
       [Display(Name ="快递单号/手机号")]
       [MaxLength(128)]
       [Column(TypeName="nvarchar(128)")]
       public string Delivery_Id { get; set; }

       /// <summary>
       ///消费赚取积分
       /// </summary>
       [Display(Name ="消费赚取积分")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Gain_Integral { get; set; }

       /// <summary>
       ///使用积分
       /// </summary>
       [Display(Name ="使用积分")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Use_Integral { get; set; }

       /// <summary>
       ///给用户退了多少积分
       /// </summary>
       [Display(Name ="给用户退了多少积分")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       public decimal? Back_Integral { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(1024)]
       [Column(TypeName="nvarchar(1024)")]
       [Required(AllowEmptyStrings=false)]
       public string Mark { get; set; }

       /// <summary>
       ///是否删除
       /// </summary>
       [Display(Name ="是否删除")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Del { get; set; }

       /// <summary>
       ///唯一Id(md5加密)类似Id
       /// </summary>
       [Display(Name ="唯一Id(md5加密)类似Id")]
       [MaxLength(64)]
       [Column(TypeName="nchar(64)")]
       [Required(AllowEmptyStrings=false)]
       public string Unique { get; set; }

       /// <summary>
       ///管理员备注
       /// </summary>
       [Display(Name ="管理员备注")]
       [MaxLength(1024)]
       [Column(TypeName="nvarchar(1024)")]
       public string Remark { get; set; }

       /// <summary>
       ///商户Id
       /// </summary>
       [Display(Name ="商户Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Mer_Id { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Is_Mer_Check")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Mer_Check { get; set; }

       /// <summary>
       ///拼团商品Id0一般商品
       /// </summary>
       [Display(Name ="拼团商品Id0一般商品")]
       [Column(TypeName="int")]
       public int? Combination_Id { get; set; }

       /// <summary>
       ///拼团Id 0没有拼团
       /// </summary>
       [Display(Name ="拼团Id 0没有拼团")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Pink_Id { get; set; }

       /// <summary>
       ///成本价
       /// </summary>
       [Display(Name ="成本价")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Cost { get; set; }

       /// <summary>
       ///秒杀商品Id
       /// </summary>
       [Display(Name ="秒杀商品Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Seckill_Id { get; set; }

       /// <summary>
       ///砍价Id
       /// </summary>
       [Display(Name ="砍价Id")]
       [Column(TypeName="int")]
       public int? Bargain_Id { get; set; }

       /// <summary>
       ///核销码
       /// </summary>
       [Display(Name ="核销码")]
       [MaxLength(24)]
       [Column(TypeName="nvarchar(24)")]
       [Required(AllowEmptyStrings=false)]
       public string Verify_Code { get; set; }

       /// <summary>
       ///门店Id
       /// </summary>
       [Display(Name ="门店Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Store_Id { get; set; }

       /// <summary>
       ///配送方式 1=快递 ，2=门店自提
       /// </summary>
       [Display(Name ="配送方式 1=快递 ，2=门店自提")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Shipping_Type { get; set; }

       /// <summary>
       ///店员Id
       /// </summary>
       [Display(Name ="店员Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Clerk_Id { get; set; }

       /// <summary>
       ///支付渠道(0微信公众号1微信小程序)
       /// </summary>
       [Display(Name ="支付渠道(0微信公众号1微信小程序)")]
       [Column(TypeName="tinyint")]
       public byte? Is_Channel { get; set; }

       /// <summary>
       ///消息提醒
       /// </summary>
       [Display(Name ="消息提醒")]
       [Column(TypeName="tinyint")]
       public byte? Is_Remind { get; set; }

       /// <summary>
       ///后台是否删除
       /// </summary>
       [Display(Name ="后台是否删除")]
       [Column(TypeName="tinyint")]
       public byte? Is_System_Del { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateID")]
       [Column(TypeName="int")]
       public int? CreateID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Creator")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Creator { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateDate")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyID")]
       [Column(TypeName="int")]
       public int? ModifyID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Modifier")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyDate")]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       
    }
}