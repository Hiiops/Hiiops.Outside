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
    [Entity(TableCnName = "优惠券模板",TableName = "Hiiops_Shop_Store_Coupon")]
    public class Hiiops_Shop_Store_Coupon:BaseEntity
    {
        /// <summary>
       ///优惠券表Id
       /// </summary>
       [Key]
       [Display(Name ="优惠券表Id")]
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
       ///优惠券类型 0-通用 1-品类券 2-商品券
       /// </summary>
       [Display(Name ="优惠券类型 0-通用 1-品类券 2-商品券")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Type { get; set; }

       /// <summary>
       ///分类Id
       /// </summary>
       [Display(Name ="分类Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Category_Id { get; set; }

       /// <summary>
       ///所属商品Id
       /// </summary>
       [Display(Name ="所属商品Id")]
       [MaxLength(128)]
       [Column(TypeName="nvarchar(128)")]
       [Required(AllowEmptyStrings=false)]
       public string Product_Id { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Modifier")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Modifier { get; set; }

       /// <summary>
       ///是否删除
       /// </summary>
       [Display(Name ="是否删除")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Del { get; set; }

       /// <summary>
       ///状态（0：关闭，1：开启）
       /// </summary>
       [Display(Name ="状态（0：关闭，1：开启）")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Status { get; set; }

       /// <summary>
       ///排序
       /// </summary>
       [Display(Name ="排序")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Sort { get; set; }

       /// <summary>
       ///优惠券有效期限（单位：天）
       /// </summary>
       [Display(Name ="优惠券有效期限（单位：天）")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Coupon_Time { get; set; }

       /// <summary>
       ///最低消费多少金额可用优惠券
       /// </summary>
       [Display(Name ="最低消费多少金额可用优惠券")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Use_Min_Price { get; set; }

       /// <summary>
       ///兑换的优惠券面值
       /// </summary>
       [Display(Name ="兑换的优惠券面值")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Coupon_Price { get; set; }

       /// <summary>
       ///兑换消耗积分值
       /// </summary>
       [Display(Name ="兑换消耗积分值")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Integral { get; set; }

       /// <summary>
       ///优惠券名称
       /// </summary>
       [Display(Name ="优惠券名称")]
       [MaxLength(128)]
       [Column(TypeName="nvarchar(128)")]
       [Required(AllowEmptyStrings=false)]
       public string Title { get; set; }

       /// <summary>
       ///兑换项目添加时间
       /// </summary>
       [Display(Name ="兑换项目添加时间")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Add_Time { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyDate")]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       
    }
}