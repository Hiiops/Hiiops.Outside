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
    [Entity(TableCnName = "商品评价",TableName = "Hiiops_Shop_Store_Product_Reply")]
    public class Hiiops_Shop_Store_Product_Reply:BaseEntity
    {
        /// <summary>
       ///评论Id
       /// </summary>
       [Key]
       [Display(Name ="评论Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///用户Id
       /// </summary>
       [Display(Name ="用户Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int UId { get; set; }

       /// <summary>
       ///订单Id
       /// </summary>
       [Display(Name ="订单Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int OId { get; set; }

       /// <summary>
       ///唯一Id
       /// </summary>
       [Display(Name ="唯一Id")]
       [MaxLength(64)]
       [Column(TypeName="nchar(64)")]
       [Required(AllowEmptyStrings=false)]
       public string Unique { get; set; }

       /// <summary>
       ///商品Id
       /// </summary>
       [Display(Name ="商品Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Product_Id { get; set; }

       /// <summary>
       ///某种商品类型(普通商品、秒杀商品）
       /// </summary>
       [Display(Name ="某种商品类型(普通商品、秒杀商品）")]
       [MaxLength(64)]
       [Column(TypeName="nvarchar(64)")]
       [Required(AllowEmptyStrings=false)]
       public string Reply_Type { get; set; }

       /// <summary>
       ///商品分数
       /// </summary>
       [Display(Name ="商品分数")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Product_Score { get; set; }

       /// <summary>
       ///服务分数
       /// </summary>
       [Display(Name ="服务分数")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Service_Score { get; set; }

       /// <summary>
       ///评论内容
       /// </summary>
       [Display(Name ="评论内容")]
       [MaxLength(1024)]
       [Column(TypeName="nvarchar(1024)")]
       [Required(AllowEmptyStrings=false)]
       public string Comment { get; set; }

       /// <summary>
       ///评论图片
       /// </summary>
       [Display(Name ="评论图片")]
       [Column(TypeName="nvarchar(max)")]
       [Required(AllowEmptyStrings=false)]
       public string Pics { get; set; }

       /// <summary>
       ///管理员回复内容
       /// </summary>
       [Display(Name ="管理员回复内容")]
       [MaxLength(600)]
       [Column(TypeName="nvarchar(600)")]
       public string Merchant_Reply_Content { get; set; }

       /// <summary>
       ///管理员回复时间
       /// </summary>
       [Display(Name ="管理员回复时间")]
       [Column(TypeName="int")]
       public int? Merchant_Reply_Time { get; set; }

       /// <summary>
       ///0未删除1已删除
       /// </summary>
       [Display(Name ="0未删除1已删除")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Del { get; set; }

       /// <summary>
       ///0未回复1已回复
       /// </summary>
       [Display(Name ="0未回复1已回复")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Reply { get; set; }

       /// <summary>
       ///用户名称
       /// </summary>
       [Display(Name ="用户名称")]
       [MaxLength(128)]
       [Column(TypeName="nvarchar(128)")]
       [Required(AllowEmptyStrings=false)]
       public string Nickname { get; set; }

       /// <summary>
       ///用户头像
       /// </summary>
       [Display(Name ="用户头像")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Required(AllowEmptyStrings=false)]
       public string Avatar { get; set; }

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