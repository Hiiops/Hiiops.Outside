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
    [Entity(TableCnName = "缓存",TableName = "Hiiops_Shop_Cache")]
    public class Hiiops_Shop_Cache:BaseEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Key")]
       [MaxLength(64)]
       [Column(TypeName="nvarchar(64)")]
       [Required(AllowEmptyStrings=false)]
       public string Key { get; set; }

       /// <summary>
       ///缓存数据
       /// </summary>
       [Display(Name ="缓存数据")]
       [Column(TypeName="nvarchar(max)")]
       public string Result { get; set; }

       /// <summary>
       ///失效时间0=永久
       /// </summary>
       [Display(Name ="失效时间0=永久")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Expire_Time { get; set; }

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