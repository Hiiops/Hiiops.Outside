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
    [Entity(TableCnName = "管理会员",TableName = "Hiiops_Shop_User")]
    public class Hiiops_Shop_User:BaseEntity
    {
        /// <summary>
       ///用户Id
       /// </summary>
       [Key]
       [Display(Name ="用户Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int UId { get; set; }

       /// <summary>
       ///用户账号
       /// </summary>
       [Display(Name ="用户账号")]
       [MaxLength(64)]
       [Column(TypeName="nvarchar(64)")]
       [Required(AllowEmptyStrings=false)]
       public string Account { get; set; }

       /// <summary>
       ///用户密码
       /// </summary>
       [Display(Name ="用户密码")]
       [MaxLength(64)]
       [Column(TypeName="nvarchar(64)")]
       [Required(AllowEmptyStrings=false)]
       public string Pwd { get; set; }

       /// <summary>
       ///真实姓名
       /// </summary>
       [Display(Name ="真实姓名")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Required(AllowEmptyStrings=false)]
       public string Real_Name { get; set; }

       /// <summary>
       ///生日
       /// </summary>
       [Display(Name ="生日")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Birthday { get; set; }

       /// <summary>
       ///身份证号码
       /// </summary>
       [Display(Name ="身份证号码")]
       [MaxLength(40)]
       [Column(TypeName="nvarchar(40)")]
       [Required(AllowEmptyStrings=false)]
       public string Card_Id { get; set; }

       /// <summary>
       ///用户备注
       /// </summary>
       [Display(Name ="用户备注")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Required(AllowEmptyStrings=false)]
       public string Mark { get; set; }

       /// <summary>
       ///合伙人Id
       /// </summary>
       [Display(Name ="合伙人Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Partner_Id { get; set; }

       /// <summary>
       ///用户分组Id
       /// </summary>
       [Display(Name ="用户分组Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Group_Id { get; set; }

       /// <summary>
       ///用户昵称
       /// </summary>
       [Display(Name ="用户昵称")]
       [MaxLength(120)]
       [Column(TypeName="nvarchar(120)")]
       [Required(AllowEmptyStrings=false)]
       public string Nickname { get; set; }

       /// <summary>
       ///用户头像
       /// </summary>
       [Display(Name ="用户头像")]
       [MaxLength(512)]
       [Column(TypeName="nvarchar(512)")]
       [Required(AllowEmptyStrings=false)]
       public string Avatar { get; set; }

       /// <summary>
       ///手机号码
       /// </summary>
       [Display(Name ="手机号码")]
       [MaxLength(30)]
       [Column(TypeName="nchar(30)")]
       public string Phone { get; set; }

       /// <summary>
       ///添加时间
       /// </summary>
       [Display(Name ="添加时间")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Add_Time { get; set; }

       /// <summary>
       ///添加ip
       /// </summary>
       [Display(Name ="添加ip")]
       [MaxLength(32)]
       [Column(TypeName="nvarchar(32)")]
       [Required(AllowEmptyStrings=false)]
       public string Add_Ip { get; set; }

       /// <summary>
       ///最后一次登录时间
       /// </summary>
       [Display(Name ="最后一次登录时间")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Last_Time { get; set; }

       /// <summary>
       ///最后一次登录ip
       /// </summary>
       [Display(Name ="最后一次登录ip")]
       [MaxLength(32)]
       [Column(TypeName="nvarchar(32)")]
       [Required(AllowEmptyStrings=false)]
       public string Last_Ip { get; set; }

       /// <summary>
       ///用户余额
       /// </summary>
       [Display(Name ="用户余额")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Now_Money { get; set; }

       /// <summary>
       ///佣金金额
       /// </summary>
       [Display(Name ="佣金金额")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Brokerage_Price { get; set; }

       /// <summary>
       ///用户剩余积分
       /// </summary>
       [Display(Name ="用户剩余积分")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Integral { get; set; }

       /// <summary>
       ///连续签到天数
       /// </summary>
       [Display(Name ="连续签到天数")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Sign_Num { get; set; }

       /// <summary>
       ///1为正常，0为禁止
       /// </summary>
       [Display(Name ="1为正常，0为禁止")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Status { get; set; }

       /// <summary>
       ///等级
       /// </summary>
       [Display(Name ="等级")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Level { get; set; }

       /// <summary>
       ///推广元Id
       /// </summary>
       [Display(Name ="推广元Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Spread_UId { get; set; }

       /// <summary>
       ///推广员关联时间
       /// </summary>
       [Display(Name ="推广员关联时间")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Spread_Time { get; set; }

       /// <summary>
       ///用户类型
       /// </summary>
       [Display(Name ="用户类型")]
       [MaxLength(64)]
       [Column(TypeName="nvarchar(64)")]
       [Required(AllowEmptyStrings=false)]
       public string User_Type { get; set; }

       /// <summary>
       ///是否为推广员
       /// </summary>
       [Display(Name ="是否为推广员")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Promoter { get; set; }

       /// <summary>
       ///用户购买次数
       /// </summary>
       [Display(Name ="用户购买次数")]
       [Column(TypeName="int")]
       public int? Pay_Count { get; set; }

       /// <summary>
       ///下级人数
       /// </summary>
       [Display(Name ="下级人数")]
       [Column(TypeName="int")]
       public int? Spread_Count { get; set; }

       /// <summary>
       ///清理会员时间
       /// </summary>
       [Display(Name ="清理会员时间")]
       [Column(TypeName="int")]
       public int? Clean_Time { get; set; }

       /// <summary>
       ///详细地址
       /// </summary>
       [Display(Name ="详细地址")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Required(AllowEmptyStrings=false)]
       public string Addres { get; set; }

       /// <summary>
       ///管理员编号 
       /// </summary>
       [Display(Name ="管理员编号 ")]
       [Column(TypeName="int")]
       public int? AdminId { get; set; }

       /// <summary>
       ///用户登陆类型，h5,wechat,routine
       /// </summary>
       [Display(Name ="用户登陆类型，h5,wechat,routine")]
       [MaxLength(72)]
       [Column(TypeName="nvarchar(72)")]
       [Required(AllowEmptyStrings=false)]
       public string Login_Type { get; set; }

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

       /// <summary>
       ///只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段
       /// </summary>
       [Display(Name ="只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段")]
       [MaxLength(60)]
       [Column(TypeName="nvarchar(60)")]
       public string UnionId { get; set; }

       /// <summary>
       ///用户的标识，对当前公众号唯一
       /// </summary>
       [Display(Name ="用户的标识，对当前公众号唯一")]
       [MaxLength(60)]
       [Column(TypeName="nvarchar(60)")]
       public string OpenId { get; set; }

       /// <summary>
       ///小程序唯一身份Id
       /// </summary>
       [Display(Name ="小程序唯一身份Id")]
       [MaxLength(64)]
       [Column(TypeName="nvarchar(64)")]
       public string Routine_OpenId { get; set; }

       /// <summary>
       ///分组Id
       /// </summary>
       [Display(Name ="分组Id")]
       [Column(TypeName="smallint")]
       public int? GroupId { get; set; }

       /// <summary>
       ///用户标签Id列表
       /// </summary>
       [Display(Name ="用户标签Id列表")]
       [MaxLength(512)]
       [Column(TypeName="nvarchar(512)")]
       public string TagId_List { get; set; }

       /// <summary>
       ///用户是否订阅该公众号标识
       /// </summary>
       [Display(Name ="用户是否订阅该公众号标识")]
       [Column(TypeName="tinyint")]
       public byte? Subscribe { get; set; }

       /// <summary>
       ///关注公众号时间
       /// </summary>
       [Display(Name ="关注公众号时间")]
       [Column(TypeName="int")]
       public int? Subscribe_Time { get; set; }

       /// <summary>
       ///一级推荐人
       /// </summary>
       [Display(Name ="一级推荐人")]
       [Column(TypeName="int")]
       public int? Stair { get; set; }

       /// <summary>
       ///二级推荐人
       /// </summary>
       [Display(Name ="二级推荐人")]
       [Column(TypeName="int")]
       public int? Second { get; set; }

       /// <summary>
       ///一级推荐人订单
       /// </summary>
       [Display(Name ="一级推荐人订单")]
       [Column(TypeName="int")]
       public int? Order_Stair { get; set; }

       /// <summary>
       ///二级推荐人订单
       /// </summary>
       [Display(Name ="二级推荐人订单")]
       [Column(TypeName="int")]
       public int? Order_Second { get; set; }

       /// <summary>
       ///小程序用户会话密匙
       /// </summary>
       [Display(Name ="小程序用户会话密匙")]
       [MaxLength(64)]
       [Column(TypeName="nvarchar(64)")]
       public string Session_Key { get; set; }

       /// <summary>
       ///头像
       /// </summary>
       [Display(Name ="头像")]
       [MaxLength(512)]
       [Column(TypeName="nvarchar(512)")]
       [Required(AllowEmptyStrings=false)]
       public string Headimgurl { get; set; }

       /// <summary>
       ///性别
       /// </summary>
       [Display(Name ="性别")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Sex { get; set; }

       /// <summary>
       ///城市
       /// </summary>
       [Display(Name ="城市")]
       [MaxLength(128)]
       [Column(TypeName="nvarchar(128)")]
       [Required(AllowEmptyStrings=false)]
       public string City { get; set; }

       /// <summary>
       ///语言
       /// </summary>
       [Display(Name ="语言")]
       [MaxLength(128)]
       [Column(TypeName="nvarchar(128)")]
       [Required(AllowEmptyStrings=false)]
       public string Language { get; set; }

       /// <summary>
       ///省份
       /// </summary>
       [Display(Name ="省份")]
       [MaxLength(128)]
       [Column(TypeName="nvarchar(128)")]
       [Required(AllowEmptyStrings=false)]
       public string Province { get; set; }

       /// <summary>
       ///国家
       /// </summary>
       [Display(Name ="国家")]
       [MaxLength(128)]
       [Column(TypeName="nvarchar(128)")]
       [Required(AllowEmptyStrings=false)]
       public string Country { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(512)]
       [Column(TypeName="nvarchar(512)")]
       public string Remark { get; set; }

       
    }
}