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
    [Entity(TableCnName = "优惠券列表",TableName = "Hiiops_Shop_Store_Coupon_Issue")]
    public class Hiiops_Shop_Store_Coupon_Issue:BaseEntity
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
       ///
       /// </summary>
       [Display(Name ="ModifyID")]
       [Column(TypeName="int")]
       public int? ModifyID { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
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
       ///是否首次关注赠送 0-否(默认) 1-是
       /// </summary>
       [Display(Name ="是否首次关注赠送 0-否(默认) 1-是")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Give_Subscribe { get; set; }

       /// <summary>
       ///消费满多少赠送优惠券
       /// </summary>
       [Display(Name ="消费满多少赠送优惠券")]
       [Column(TypeName="decimal")]
       public decimal? Full_Reduction { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Modifier { get; set; }

       /// <summary>
       ///是否满赠0-否(默认) 1-是
       /// </summary>
       [Display(Name ="是否满赠0-否(默认) 1-是")]
       [Column(TypeName="tinyint")]
       public byte? Is_Full_Give { get; set; }

       /// <summary>
       ///是否无限
       /// </summary>
       [Display(Name ="是否无限")]
       [Column(TypeName="tinyint")]
       public byte? Is_Permanent { get; set; }

       /// <summary>
       ///优惠券剩余领取数量
       /// </summary>
       [Display(Name ="优惠券剩余领取数量")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Remain_Count { get; set; }

       /// <summary>
       ///优惠券领取数量
       /// </summary>
       [Display(Name ="优惠券领取数量")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Total_Count { get; set; }

       /// <summary>
       ///优惠券领取结束时间
       /// </summary>
       [Display(Name ="优惠券领取结束时间")]
       [Column(TypeName="datetime")]
       [Required(AllowEmptyStrings=false)]
       public DateTime End_Time { get; set; }

       /// <summary>
       ///优惠券领取开始时间
       /// </summary>
       [Display(Name ="优惠券领取开始时间")]
       [Column(TypeName="datetime")]
       [Required(AllowEmptyStrings=false)]
       public DateTime Start_Time { get; set; }

       /// <summary>
       ///优惠券ID
       /// </summary>
       [Display(Name ="优惠券ID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int CId { get; set; }

       /// <summary>
       ///1 正常 0 未开启 -1 已无效
       /// </summary>
       [Display(Name ="1 正常 0 未开启 -1 已无效")]
       [Column(TypeName="tinyint")]
       public byte? Status { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       
    }
}