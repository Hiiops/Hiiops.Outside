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
    [Entity(TableCnName = "销售咨询",TableName = "Hiiops_Cart_SellerOrder")]
    public class Hiiops_Cart_SellerOrder:BaseEntity
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
       ///名称
       /// </summary>
       [Display(Name ="名称")]
       [MaxLength(200)]
       [Column(TypeName="nchar(200)")]
       public string SellerName { get; set; }

       /// <summary>
       ///车辆ID
       /// </summary>
       [Display(Name ="车辆ID")]
       [Column(TypeName="int")]
       public int? CartId { get; set; }

       /// <summary>
       ///车名
       /// </summary>
       [Display(Name ="车名")]
       [MaxLength(2000)]
       [Column(TypeName="nchar(2000)")]
       public string CartName { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Status { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [Column(TypeName="nvarchar(max)")]
       public string Remark { get; set; }

       /// <summary>
       ///回复
       /// </summary>
       [Display(Name ="回复")]
       [Column(TypeName="nvarchar(max)")]
       public string Reply { get; set; }

       /// <summary>
       ///创建者ID
       /// </summary>
       [Display(Name ="创建者ID")]
       [Column(TypeName="int")]
       public int? CreateID { get; set; }

       /// <summary>
       ///创建者
       /// </summary>
       [Display(Name ="创建者")]
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
       ///修改者ID
       /// </summary>
       [Display(Name ="修改者ID")]
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
       ///OpenId
       /// </summary>
       [Display(Name ="OpenId")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string OpenId { get; set; }

       /// <summary>
       ///昵称
       /// </summary>
       [Display(Name ="昵称")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       public string NickName { get; set; }

       /// <summary>
       ///联系电话
       /// </summary>
       [Display(Name ="联系电话")]
       [MaxLength(56)]
       [Column(TypeName="nvarchar(56)")]
       public string Phone { get; set; }

       
    }
}