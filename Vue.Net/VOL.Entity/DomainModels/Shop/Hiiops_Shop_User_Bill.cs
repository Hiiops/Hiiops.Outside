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
    [Entity(TableCnName = "资金记录",TableName = "Hiiops_Shop_User_Bill")]
    public class Hiiops_Shop_User_Bill:BaseEntity
    {
        /// <summary>
       ///用户账单Id
       /// </summary>
       [Key]
       [Display(Name ="用户账单Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///用户uId
       /// </summary>
       [Display(Name ="用户uId")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int UId { get; set; }

       /// <summary>
       ///关联Id
       /// </summary>
       [Display(Name ="关联Id")]
       [MaxLength(64)]
       [Column(TypeName="nvarchar(64)")]
       [Required(AllowEmptyStrings=false)]
       public string Link_Id { get; set; }

       /// <summary>
       ///0 = 支出 1 = 获得
       /// </summary>
       [Display(Name ="0 = 支出 1 = 获得")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Pm { get; set; }

       /// <summary>
       ///账单标题
       /// </summary>
       [Display(Name ="账单标题")]
       [MaxLength(128)]
       [Column(TypeName="nvarchar(128)")]
       [Required(AllowEmptyStrings=false)]
       public string Title { get; set; }

       /// <summary>
       ///明细种类
       /// </summary>
       [Display(Name ="明细种类")]
       [MaxLength(128)]
       [Column(TypeName="nvarchar(128)")]
       [Required(AllowEmptyStrings=false)]
       public string Category { get; set; }

       /// <summary>
       ///明细类型
       /// </summary>
       [Display(Name ="明细类型")]
       [MaxLength(128)]
       [Column(TypeName="nvarchar(128)")]
       [Required(AllowEmptyStrings=false)]
       public string Type { get; set; }

       /// <summary>
       ///明细数字
       /// </summary>
       [Display(Name ="明细数字")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Number { get; set; }

       /// <summary>
       ///剩余
       /// </summary>
       [Display(Name ="剩余")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Balance { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(1024)]
       [Column(TypeName="nvarchar(1024)")]
       [Required(AllowEmptyStrings=false)]
       public string Mark { get; set; }

       /// <summary>
       ///添加时间
       /// </summary>
       [Display(Name ="添加时间")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Add_Time { get; set; }

       /// <summary>
       ///0 = 带确定 1 = 有效 -1 = 无效
       /// </summary>
       [Display(Name ="0 = 带确定 1 = 有效 -1 = 无效")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Status { get; set; }

       /// <summary>
       ///0 = 未收货 1 = 已收货
       /// </summary>
       [Display(Name ="0 = 未收货 1 = 已收货")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Take { get; set; }

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