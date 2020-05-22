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
    [Entity(TableCnName = "客服设置",TableName = "Hiiops_Shop_Store_Service")]
    public class Hiiops_Shop_Store_Service:BaseEntity
    {
        /// <summary>
       ///客服Id
       /// </summary>
       [Key]
       [Display(Name ="客服Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///商户Id
       /// </summary>
       [Display(Name ="商户Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Mer_Id { get; set; }

       /// <summary>
       ///客服uId
       /// </summary>
       [Display(Name ="客服uId")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int UId { get; set; }

       /// <summary>
       ///客服头像
       /// </summary>
       [Display(Name ="客服头像")]
       [MaxLength(500)]
       [Column(TypeName="nvarchar(500)")]
       [Required(AllowEmptyStrings=false)]
       public string Avatar { get; set; }

       /// <summary>
       ///代理名称
       /// </summary>
       [Display(Name ="代理名称")]
       [MaxLength(100)]
       [Column(TypeName="nvarchar(100)")]
       [Required(AllowEmptyStrings=false)]
       public string Nickname { get; set; }

       /// <summary>
       ///添加时间
       /// </summary>
       [Display(Name ="添加时间")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Add_Time { get; set; }

       /// <summary>
       ///0隐藏1显示
       /// </summary>
       [Display(Name ="0隐藏1显示")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Status { get; set; }

       /// <summary>
       ///订单通知1开启0关闭
       /// </summary>
       [Display(Name ="订单通知1开启0关闭")]
       [Column(TypeName="int")]
       public int? Notify { get; set; }

       /// <summary>
       ///是否展示统计管理
       /// </summary>
       [Display(Name ="是否展示统计管理")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Customer { get; set; }

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