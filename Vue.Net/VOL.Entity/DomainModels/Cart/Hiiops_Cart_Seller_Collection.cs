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
    [Entity(TableCnName = "用户收藏",TableName = "Hiiops_Cart_Seller_Collection")]
    public class Hiiops_Cart_Seller_Collection:BaseEntity
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
       ///用户ID
       /// </summary>
       [Display(Name ="用户ID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int SellerUserId { get; set; }

       /// <summary>
       ///用户名
       /// </summary>
       [Display(Name ="用户名")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       public string SellerName { get; set; }

       /// <summary>
       ///车辆ID
       /// </summary>
       [Display(Name ="车辆ID")]
       [Column(TypeName="int")]
       public int? CartId { get; set; }

       /// <summary>
       ///车辆名
       /// </summary>
       [Display(Name ="车辆名")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       public string CartName { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///创建者ID
       /// </summary>
       [Display(Name ="创建者ID")]
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

       /// <summary>
       ///昵称
       /// </summary>
       [Display(Name ="昵称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string NickName { get; set; }

       /// <summary>
       ///OpenId
       /// </summary>
       [Display(Name ="OpenId")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string OpenId { get; set; }

       /// <summary>
       ///查看次数
       /// </summary>
       [Display(Name ="查看次数")]
       [Column(TypeName="int")]
       public int? Count { get; set; }

       /// <summary>
       ///手机号码
       /// </summary>
       [Display(Name ="手机号码")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string Phone { get; set; }

       
    }
}