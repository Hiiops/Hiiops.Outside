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
    [Entity(TableCnName = "商品规格",TableName = "Hiiops_Shop_Store_Product_Attr")]
    public class Hiiops_Shop_Store_Product_Attr:BaseEntity
    {
        /// <summary>
       ///商品Id
       /// </summary>
       [Key]
       [Display(Name ="商品Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Product_Id { get; set; }

       /// <summary>
       ///属性名
       /// </summary>
       [Display(Name ="属性名")]
       [MaxLength(64)]
       [Column(TypeName="nvarchar(64)")]
       [Required(AllowEmptyStrings=false)]
       public string Attr_Name { get; set; }

       /// <summary>
       ///属性值
       /// </summary>
       [Display(Name ="属性值")]
       [MaxLength(512)]
       [Column(TypeName="nvarchar(512)")]
       [Required(AllowEmptyStrings=false)]
       public string Attr_Values { get; set; }

       /// <summary>
       ///活动类型 0=商品，1=秒杀，2=砍价，3=拼团
       /// </summary>
       [Display(Name ="活动类型 0=商品，1=秒杀，2=砍价，3=拼团")]
       [Column(TypeName="tinyint")]
       public byte? Type { get; set; }

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