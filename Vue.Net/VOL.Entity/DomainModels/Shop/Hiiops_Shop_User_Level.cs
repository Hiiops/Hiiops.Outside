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
    [Entity(TableCnName = "会员等级",TableName = "Hiiops_Shop_User_Level")]
    public class Hiiops_Shop_User_Level:BaseEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyID")]
       [Column(TypeName="int")]
       public int? ModifyID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateDate")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

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
       [Display(Name ="CreateID")]
       [Column(TypeName="int")]
       public int? CreateID { get; set; }

       /// <summary>
       ///享受折扣
       /// </summary>
       [Display(Name ="享受折扣")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Discount { get; set; }

       /// <summary>
       ///添加时间
       /// </summary>
       [Display(Name ="添加时间")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Add_Time { get; set; }

       /// <summary>
       ///是否删除,0=未删除,1=删除
       /// </summary>
       [Display(Name ="是否删除,0=未删除,1=删除")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Del { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Modifier")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Modifier { get; set; }

       /// <summary>
       ///是否已通知
       /// </summary>
       [Display(Name ="是否已通知")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Remind { get; set; }

       /// <summary>
       ///0:禁止,1:正常
       /// </summary>
       [Display(Name ="0:禁止,1:正常")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Status { get; set; }

       /// <summary>
       ///商户Id
       /// </summary>
       [Display(Name ="商户Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Mer_Id { get; set; }

       /// <summary>
       ///是否永久
       /// </summary>
       [Display(Name ="是否永久")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Forever { get; set; }

       /// <summary>
       ///过期时间
       /// </summary>
       [Display(Name ="过期时间")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int ValId_Time { get; set; }

       /// <summary>
       ///会员等级
       /// </summary>
       [Display(Name ="会员等级")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Grade { get; set; }

       /// <summary>
       ///等级vip
       /// </summary>
       [Display(Name ="等级vip")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Level_Id { get; set; }

       /// <summary>
       ///用户uId
       /// </summary>
       [Display(Name ="用户uId")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int UId { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Required(AllowEmptyStrings=false)]
       public string Mark { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyDate")]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///等级ID
       /// </summary>
       [Key]
       [Display(Name ="等级ID")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       
    }
}