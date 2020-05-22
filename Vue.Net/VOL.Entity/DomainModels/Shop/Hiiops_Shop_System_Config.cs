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
    [Entity(TableCnName = "商城参数",TableName = "Hiiops_Shop_System_Config")]
    public class Hiiops_Shop_System_Config:BaseEntity
    {
        /// <summary>
       ///配置Id
       /// </summary>
       [Key]
       [Display(Name ="配置Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///字段名称
       /// </summary>
       [Display(Name ="字段名称")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Required(AllowEmptyStrings=false)]
       public string Menu_Name { get; set; }

       /// <summary>
       ///类型(文本框,单选按钮...)
       /// </summary>
       [Display(Name ="类型(文本框,单选按钮...)")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Required(AllowEmptyStrings=false)]
       public string Type { get; set; }

       /// <summary>
       ///表单类型
       /// </summary>
       [Display(Name ="表单类型")]
       [MaxLength(40)]
       [Column(TypeName="nvarchar(40)")]
       public string Input_Type { get; set; }

       /// <summary>
       ///配置分类Id
       /// </summary>
       [Display(Name ="配置分类Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Config_Tab_Id { get; set; }

       /// <summary>
       ///规则 单选框和多选框
       /// </summary>
       [Display(Name ="规则 单选框和多选框")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Parameter { get; set; }

       /// <summary>
       ///上传文件格式1单图2多图3文件
       /// </summary>
       [Display(Name ="上传文件格式1单图2多图3文件")]
       [Column(TypeName="tinyint")]
       public byte? Upload_Type { get; set; }

       /// <summary>
       ///规则
       /// </summary>
       [Display(Name ="规则")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Required { get; set; }

       /// <summary>
       ///多行文本框的宽度
       /// </summary>
       [Display(Name ="多行文本框的宽度")]
       [Column(TypeName="int")]
       public int? WIdth { get; set; }

       /// <summary>
       ///多行文框的高度
       /// </summary>
       [Display(Name ="多行文框的高度")]
       [Column(TypeName="int")]
       public int? High { get; set; }

       /// <summary>
       ///默认值
       /// </summary>
       [Display(Name ="默认值")]
       [Column(TypeName="nvarchar(max)")]
       public string Value { get; set; }

       /// <summary>
       ///配置名称
       /// </summary>
       [Display(Name ="配置名称")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Required(AllowEmptyStrings=false)]
       public string Info { get; set; }

       /// <summary>
       ///配置简介
       /// </summary>
       [Display(Name ="配置简介")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Desc { get; set; }

       /// <summary>
       ///排序
       /// </summary>
       [Display(Name ="排序")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Sort { get; set; }

       /// <summary>
       ///是否隐藏
       /// </summary>
       [Display(Name ="是否隐藏")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Status { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateID")]
       [Column(TypeName="int")]
       public int? CreateID { get; set; }

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

       
    }
}