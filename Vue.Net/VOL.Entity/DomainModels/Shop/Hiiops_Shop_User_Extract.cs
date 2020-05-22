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
    [Entity(TableCnName = "提现申请",TableName = "Hiiops_Shop_User_Extract")]
    public class Hiiops_Shop_User_Extract:BaseEntity
    {
        /// <summary>
       ///Id
       /// </summary>
       [Key]
       [Display(Name ="Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///审核ID
       /// </summary>
       [Display(Name ="审核ID")]
       [Column(TypeName="int")]
       public int? ModifyID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateDate")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

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
       [Display(Name ="CreateID")]
       [Column(TypeName="int")]
       public int? CreateID { get; set; }

       /// <summary>
       ///微信号
       /// </summary>
       [Display(Name ="微信号")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       public string Wechat { get; set; }

       /// <summary>
       ///-1 未通过 0 审核中 1 已提现
       /// </summary>
       [Display(Name ="-1 未通过 0 审核中 1 已提现")]
       [Column(TypeName="tinyint")]
       public byte? Status { get; set; }

       /// <summary>
       ///失败时间
       /// </summary>
       [Display(Name ="失败时间")]
       [Column(TypeName="int")]
       public int? Fail_Time { get; set; }

       /// <summary>
       ///无效原因
       /// </summary>
       [Display(Name ="无效原因")]
       [MaxLength(256)]
       [Column(TypeName="nvarchar(256)")]
       public string Fail_Msg { get; set; }

       /// <summary>
       ///金额
       /// </summary>
       [Display(Name ="金额")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       public decimal? Balance { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(1024)]
       [Column(TypeName="nvarchar(1024)")]
       public string Mark { get; set; }

       /// <summary>
       ///提现金额
       /// </summary>
       [Display(Name ="提现金额")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       public decimal? Extract_Price { get; set; }

       /// <summary>
       ///支付宝账号
       /// </summary>
       [Display(Name ="支付宝账号")]
       [MaxLength(128)]
       [Column(TypeName="nvarchar(128)")]
       public string Alipay_Code { get; set; }

       /// <summary>
       ///开户地址
       /// </summary>
       [Display(Name ="开户地址")]
       [MaxLength(512)]
       [Column(TypeName="nvarchar(512)")]
       public string Bank_Address { get; set; }

       /// <summary>
       ///银行卡
       /// </summary>
       [Display(Name ="银行卡")]
       [MaxLength(64)]
       [Column(TypeName="nvarchar(64)")]
       public string Bank_Code { get; set; }

       /// <summary>
       ///bank = 银行卡 alipay = 支付宝wx=微信
       /// </summary>
       [Display(Name ="bank = 银行卡 alipay = 支付宝wx=微信")]
       [MaxLength(64)]
       [Column(TypeName="nvarchar(64)")]
       public string Extract_Type { get; set; }

       /// <summary>
       ///名称
       /// </summary>
       [Display(Name ="名称")]
       [MaxLength(128)]
       [Column(TypeName="nvarchar(128)")]
       public string Real_Name { get; set; }

       /// <summary>
       ///用户ID
       /// </summary>
       [Display(Name ="用户ID")]
       [Column(TypeName="int")]
       public int? UId { get; set; }

       /// <summary>
       ///审核人
       /// </summary>
       [Display(Name ="审核人")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Modifier { get; set; }

       /// <summary>
       ///审核时间
       /// </summary>
       [Display(Name ="审核时间")]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       
    }
}