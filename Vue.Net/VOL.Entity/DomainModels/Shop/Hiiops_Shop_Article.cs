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
    [Entity(TableCnName = "文章管理",TableName = "Hiiops_Shop_Article")]
    public class Hiiops_Shop_Article:BaseEntity
    {
        /// <summary>
       ///文章管理Id
       /// </summary>
       [Key]
       [Display(Name ="文章管理Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///分类Id
       /// </summary>
       [Display(Name ="分类Id")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string CId { get; set; }

       /// <summary>
       ///文章标题
       /// </summary>
       [Display(Name ="文章标题")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Required(AllowEmptyStrings=false)]
       public string Title { get; set; }

       /// <summary>
       ///文章作者
       /// </summary>
       [Display(Name ="文章作者")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Author { get; set; }

       /// <summary>
       ///文章图片
       /// </summary>
       [Display(Name ="文章图片")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Required(AllowEmptyStrings=false)]
       public string Image_Input { get; set; }

       /// <summary>
       ///文章简介
       /// </summary>
       [Display(Name ="文章简介")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Synopsis { get; set; }

       /// <summary>
       ///文章分享标题
       /// </summary>
       [Display(Name ="文章分享标题")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Share_Title { get; set; }

       /// <summary>
       ///文章分享简介
       /// </summary>
       [Display(Name ="文章分享简介")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Share_Synopsis { get; set; }

       /// <summary>
       ///浏览次数
       /// </summary>
       [Display(Name ="浏览次数")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Visit { get; set; }

       /// <summary>
       ///排序
       /// </summary>
       [Display(Name ="排序")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Sort { get; set; }

       /// <summary>
       ///原文链接
       /// </summary>
       [Display(Name ="原文链接")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Url { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Status { get; set; }

       /// <summary>
       ///是否隐藏
       /// </summary>
       [Display(Name ="是否隐藏")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte HIde { get; set; }

       /// <summary>
       ///管理员Id
       /// </summary>
       [Display(Name ="管理员Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Admin_Id { get; set; }

       /// <summary>
       ///商户Id
       /// </summary>
       [Display(Name ="商户Id")]
       [Column(TypeName="int")]
       public int? Mer_Id { get; set; }

       /// <summary>
       ///商品关联Id
       /// </summary>
       [Display(Name ="商品关联Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Product_Id { get; set; }

       /// <summary>
       ///是否热门(小程序)
       /// </summary>
       [Display(Name ="是否热门(小程序)")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Hot { get; set; }

       /// <summary>
       ///是否轮播图(小程序)
       /// </summary>
       [Display(Name ="是否轮播图(小程序)")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_banner { get; set; }

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