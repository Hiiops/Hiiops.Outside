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
    [Entity(TableCnName = "充值记录",TableName = "Hiiops_Shop_User_Recharge")]
    public class Hiiops_Shop_User_Recharge:BaseEntity
    {
        /// <summary>
       ///主键
       /// </summary>
       [Key]
       [Display(Name ="主键")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///充值用户UId
       /// </summary>
       [Display(Name ="充值用户UId")]
       [Column(TypeName="int")]
       public int? UId { get; set; }

       /// <summary>
       ///订单号
       /// </summary>
       [Display(Name ="订单号")]
       [MaxLength(64)]
       [Column(TypeName="nvarchar(64)")]
       public string Order_Id { get; set; }

       /// <summary>
       ///充值金额
       /// </summary>
       [Display(Name ="充值金额")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       public decimal? Price { get; set; }

       /// <summary>
       ///购买赠送金额
       /// </summary>
       [Display(Name ="购买赠送金额")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Give_Price { get; set; }

       /// <summary>
       ///充值类型
       /// </summary>
       [Display(Name ="充值类型")]
       [MaxLength(64)]
       [Column(TypeName="nvarchar(64)")]
       public string Recharge_Type { get; set; }

       /// <summary>
       ///是否充值
       /// </summary>
       [Display(Name ="是否充值")]
       [Column(TypeName="tinyint")]
       public byte? PaId { get; set; }

       /// <summary>
       ///充值支付时间
       /// </summary>
       [Display(Name ="充值支付时间")]
       [Column(TypeName="int")]
       public int? Pay_Time { get; set; }

       /// <summary>
       ///充值时间
       /// </summary>
       [Display(Name ="充值时间")]
       [Column(TypeName="int")]
       public int? Add_Time { get; set; }

       /// <summary>
       ///退款金额
       /// </summary>
       [Display(Name ="退款金额")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       public decimal? Refund_Price { get; set; }

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