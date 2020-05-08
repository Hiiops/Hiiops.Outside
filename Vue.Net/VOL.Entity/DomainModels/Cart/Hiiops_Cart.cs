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
    [Entity(TableCnName = "车辆管理",TableName = "Hiiops_Cart")]
    public class Hiiops_Cart:BaseEntity
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
       ///名称
       /// </summary>
       [Display(Name ="名称")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Name { get; set; }

       /// <summary>
       ///品牌
       /// </summary>
       [Display(Name ="品牌")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int BrandId { get; set; }

       /// <summary>
       ///分类
       /// </summary>
       [Display(Name ="分类")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int CategoryId { get; set; }

       /// <summary>
       ///封面
       /// </summary>
       [Display(Name ="封面")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string CoverImage { get; set; }

       /// <summary>
       ///主图
       /// </summary>
       [Display(Name ="主图")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string Images { get; set; }

       /// <summary>
       ///详情
       /// </summary>
       [Display(Name ="详情")]
       [MaxLength(16)]
       [Column(TypeName="ntext(16)")]
       [Editable(true)]
       public string DetailContent { get; set; }

       /// <summary>
       ///静态页面
       /// </summary>
       [Display(Name ="静态页面")]
       [MaxLength(2000)]
       [Column(TypeName="nvarchar(2000)")]
       [Editable(true)]
       public string StaticUrl { get; set; }

       /// <summary>
       ///浏览数
       /// </summary>
       [Display(Name ="浏览数")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int PV { get; set; }

       /// <summary>
       ///启用状态
       /// </summary>
       [Display(Name ="启用状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Status { get; set; }

       /// <summary>
       ///关键字
       /// </summary>
       [Display(Name ="关键字")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Keywords { get; set; }

       /// <summary>
       ///排序
       /// </summary>
       [Display(Name ="排序")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Sort { get; set; }

       /// <summary>
       ///推荐
       /// </summary>
       [Display(Name ="推荐")]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? Recomend { get; set; }

       /// <summary>
       ///热门
       /// </summary>
       [Display(Name ="热门")]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? Hot { get; set; }

       /// <summary>
       ///置顶
       /// </summary>
       [Display(Name ="置顶")]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? SetTop { get; set; }

       /// <summary>
       ///促销价格
       /// </summary>
       [Display(Name ="促销价格")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Editable(true)]
       public string SalePrice { get; set; }

       /// <summary>
       ///价格
       /// </summary>
       [Display(Name ="价格")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Editable(true)]
       public string Price { get; set; }

       /// <summary>
       ///里程
       /// </summary>
       [Display(Name ="里程")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Editable(true)]
       public string Mileage { get; set; }

       /// <summary>
       ///上牌时间
       /// </summary>
       [Display(Name ="上牌时间")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? LicenseTime { get; set; }

       /// <summary>
       ///出售
       /// </summary>
       [Display(Name ="出售")]
       [Column(TypeName="bit")]
       [Editable(true)]
       public bool? Sale { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(2000)]
       [Column(TypeName="nvarchar(2000)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///上传人ID
       /// </summary>
       [Display(Name ="上传人ID")]
       [Column(TypeName="int")]
       public int? CreateID { get; set; }

       /// <summary>
       ///上传人
       /// </summary>
       [Display(Name ="上传人")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Creator { get; set; }

       /// <summary>
       ///添加时间
       /// </summary>
       [Display(Name ="添加时间")]
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