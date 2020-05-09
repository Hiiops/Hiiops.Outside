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
    [Entity(TableCnName = "访问统计",TableName = "Hiiops_Cart_Seller_PV_Count")]
    public class Hiiops_Cart_Seller_PV_Count:BaseEntity
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
       ///姓名
       /// </summary>
       [Display(Name ="姓名")]
       [MaxLength(2000)]
       [Column(TypeName="nchar(2000)")]
       public string SellerUserName { get; set; }

       /// <summary>
       ///电话
       /// </summary>
       [Display(Name ="电话")]
       [MaxLength(36)]
       [Column(TypeName="nchar(36)")]
       [Editable(true)]
       public string Phone { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="SellerOrderId")]
       [Column(TypeName="int")]
       public int? SellerOrderId { get; set; }

       /// <summary>
       ///车辆名称
       /// </summary>
       [Display(Name ="车辆名称")]
       [MaxLength(2000)]
       [Column(TypeName="nchar(2000)")]
       public string CartName { get; set; }

       /// <summary>
       ///车辆ID
       /// </summary>
       [Display(Name ="车辆ID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int CartId { get; set; }

       /// <summary>
       ///次数
       /// </summary>
       [Display(Name ="次数")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Count { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Remark { get; set; }

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