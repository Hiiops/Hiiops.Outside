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
    [Entity(TableCnName = "小程序",TableName = "Hiiops_Cart_Banner")]
    public class Hiiops_Cart_Banner:BaseEntity
    {
        /// <summary>
       ///主键
       /// </summary>
       [Key]
       [Display(Name ="主键")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Banner_Id { get; set; }

       /// <summary>
       ///标题
       /// </summary>
       [Display(Name ="标题")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Name { get; set; }

       /// <summary>
       ///类型
       /// </summary>
       [Display(Name ="类型")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string BannerType { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Status { get; set; }

       /// <summary>
       ///广告语
       /// </summary>
       [Display(Name ="广告语")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Advertising { get; set; }

       /// <summary>
       ///小程序跳转
       /// </summary>
       [Display(Name ="小程序跳转")]
       [MaxLength(2048)]
       [Column(TypeName="nvarchar(2048)")]
       [Editable(true)]
       public string AppletUrls { get; set; }

       /// <summary>
       ///普通地址
       /// </summary>
       [Display(Name ="普通地址")]
       [MaxLength(2048)]
       [Column(TypeName="nvarchar(2048)")]
       [Editable(true)]
       public string WebUrls { get; set; }

       /// <summary>
       ///特权
       /// </summary>
       [Display(Name ="特权")]
       [MaxLength(2048)]
       [Column(TypeName="nvarchar(2048)")]
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
       ///
       /// </summary>
       [Display(Name ="CreateID")]
       [Column(TypeName="int")]
       public int? CreateID { get; set; }

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
       ///添加人
       /// </summary>
       [Display(Name ="添加人")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Creator { get; set; }

       /// <summary>
       ///图片
       /// </summary>
       [Display(Name ="图片")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Images { get; set; }

       
    }
}