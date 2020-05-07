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
    [Entity(TableCnName = "分类管理",TableName = "Hiiops_Cart_Category")]
    public class Hiiops_Cart_Category:BaseEntity
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
       ///分类
       /// </summary>
       [Display(Name ="分类")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Name { get; set; }

       /// <summary>
       ///父级
       /// </summary>
       [Display(Name ="父级")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ParentId { get; set; }

       /// <summary>
       ///封面
       /// </summary>
       [Display(Name ="封面")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string CoverImage { get; set; }

       /// <summary>
       ///浏览
       /// </summary>
       [Display(Name ="浏览")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int PV { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
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
       [Editable(true)]
       public string Keywords { get; set; }

       /// <summary>
       ///排序
       /// </summary>
       [Display(Name ="排序")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Sort { get; set; }

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
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(2000)]
       [Column(TypeName="nvarchar(2000)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///添加人ID
       /// </summary>
       [Display(Name ="添加人ID")]
       [Column(TypeName="int")]
       public int? CreateID { get; set; }

       /// <summary>
       ///添加人
       /// </summary>
       [Display(Name ="添加人")]
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