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
    [Entity(TableCnName = "参数配置",TableName = "Hiiops_Cart_System_Config")]
    public class Hiiops_Cart_System_Config:BaseEntity
    {
        /// <summary>
       ///名称
       /// </summary>
       [Display(Name ="名称")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string KEYNAME { get; set; }

       /// <summary>
       ///主键
       /// </summary>
       [Key]
       [Display(Name ="主键")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Config_Id { get; set; }

       /// <summary>
       ///值
       /// </summary>
       [Display(Name ="值")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string VAL { get; set; }

       /// <summary>
       ///配置类型
       /// </summary>
       [Display(Name ="配置类型")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int ConfigType { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Sta { get; set; }

       /// <summary>
       ///加密类型
       /// </summary>
       [Display(Name ="加密类型")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? SecretType { get; set; }

       /// <summary>
       ///秘钥
       /// </summary>
       [Display(Name ="秘钥")]
       [MaxLength(512)]
       [Column(TypeName="nvarchar(512)")]
       [Editable(true)]
       public string Secret { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(2000)]
       [Column(TypeName="nvarchar(2000)")]
       [Editable(true)]
       public string Remark { get; set; }

       /// <summary>
       ///创建ID
       /// </summary>
       [Display(Name ="创建ID")]
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
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///修改ID
       /// </summary>
       [Display(Name ="修改ID")]
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
       ///修改日期
       /// </summary>
       [Display(Name ="修改日期")]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       
    }
}