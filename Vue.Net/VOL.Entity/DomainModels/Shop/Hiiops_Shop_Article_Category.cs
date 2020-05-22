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
    [Entity(TableCnName = "分类管理",TableName = "Hiiops_Shop_Article_Category")]
    public class Hiiops_Shop_Article_Category:BaseEntity
    {
        /// <summary>
       ///文章分类Id
       /// </summary>
       [Key]
       [Display(Name ="文章分类Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///父级Id
       /// </summary>
       [Display(Name ="父级Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int PId { get; set; }

       /// <summary>
       ///文章分类标题
       /// </summary>
       [Display(Name ="文章分类标题")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Required(AllowEmptyStrings=false)]
       public string Title { get; set; }

       /// <summary>
       ///文章分类简介
       /// </summary>
       [Display(Name ="文章分类简介")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Intr { get; set; }

       /// <summary>
       ///文章分类图片
       /// </summary>
       [Display(Name ="文章分类图片")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Required(AllowEmptyStrings=false)]
       public string Image { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
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
       ///1删除0未删除
       /// </summary>
       [Display(Name ="1删除0未删除")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Del { get; set; }

       /// <summary>
       ///是否隐藏
       /// </summary>
       [Display(Name ="是否隐藏")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte HIdden { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateId")]
       [Column(TypeName="int")]
       public int? CreateId { get; set; }

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
       [Display(Name ="ModifyId")]
       [Column(TypeName="int")]
       public int? ModifyId { get; set; }

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