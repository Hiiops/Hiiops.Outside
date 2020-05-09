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
    [Entity(TableCnName = "优惠券",TableName = "Hiiops_Cart_Coupon")]
    public class Hiiops_Cart_Coupon:BaseEntity
    {
        /// <summary>
       ///图片
       /// </summary>
       [Display(Name ="图片")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Images { get; set; }

       /// <summary>
       ///优惠券名 
       /// </summary>
       [Display(Name ="优惠券名 ")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string Name { get; set; }

       /// <summary>
       ///主键
       /// </summary>
       [Key]
       [Display(Name ="主键")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Coupon_Id { get; set; }

       /// <summary>
       ///过期状态
       /// </summary>
       [Display(Name ="过期状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Expire { get; set; }

       /// <summary>
       ///开始时间
       /// </summary>
       [Display(Name ="开始时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? StartTime { get; set; }

       /// <summary>
       ///结束时间
       /// </summary>
       [Display(Name ="结束时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ExpireTime { get; set; }

       /// <summary>
       ///优惠券类型
       /// </summary>
       [Display(Name ="优惠券类型")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int CouponType { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Status { get; set; }

       /// <summary>
       ///面值
       /// </summary>
       [Display(Name ="面值")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Denomination { get; set; }

       /// <summary>
       ///特权
       /// </summary>
       [Display(Name ="特权")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string Privilege { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(2000)]
       [Column(TypeName="nvarchar(2000)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///创建人ID
       /// </summary>
       [Display(Name ="创建人ID")]
       [Column(TypeName="int")]
       public int? CreateID { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Creator { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///修改人ID
       /// </summary>
       [Display(Name ="修改人ID")]
       [Column(TypeName="int")]
       public int? ModifyID { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Modifier { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       
    }
}