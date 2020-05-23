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
    [Entity(TableCnName = "物流公司",TableName = "Hiiops_Shop_Express")]
    public class Hiiops_Shop_Express:BaseEntity
    {
        /// <summary>
       ///快递公司Id
       /// </summary>
       [Key]
       [Display(Name ="快递公司Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///快递公司简称
       /// </summary>
       [Display(Name ="快递公司简称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Required(AllowEmptyStrings=false)]
       public string Code { get; set; }

       /// <summary>
       ///快递公司全称
       /// </summary>
       [Display(Name ="快递公司全称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Required(AllowEmptyStrings=false)]
       public string Name { get; set; }

       /// <summary>
       ///排序
       /// </summary>
       [Display(Name ="排序")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Sort { get; set; }

       /// <summary>
       ///是否显示
       /// </summary>
       [Display(Name ="是否显示")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Show { get; set; }

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