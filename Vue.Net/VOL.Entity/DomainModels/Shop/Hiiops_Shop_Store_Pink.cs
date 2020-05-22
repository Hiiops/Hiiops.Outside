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
    [Entity(TableCnName = "开团列表",TableName = "Hiiops_Shop_Store_Pink")]
    public class Hiiops_Shop_Store_Pink:BaseEntity
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
       ///状态1进行中2已完成3未完成
       /// </summary>
       [Display(Name ="状态1进行中2已完成3未完成")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Status { get; set; }

       /// <summary>
       ///是否退款 0未退款 1已退款
       /// </summary>
       [Display(Name ="是否退款 0未退款 1已退款")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Refund { get; set; }

       /// <summary>
       ///是否发送模板消息0未发送1已发送
       /// </summary>
       [Display(Name ="是否发送模板消息0未发送1已发送")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Tpl { get; set; }

       /// <summary>
       ///团长Id 0为团长
       /// </summary>
       [Display(Name ="团长Id 0为团长")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int K_Id { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Stop_Time")]
       [MaxLength(48)]
       [Column(TypeName="nvarchar(48)")]
       [Required(AllowEmptyStrings=false)]
       public string Stop_Time { get; set; }

       /// <summary>
       ///开始时间
       /// </summary>
       [Display(Name ="开始时间")]
       [MaxLength(48)]
       [Column(TypeName="nvarchar(48)")]
       [Required(AllowEmptyStrings=false)]
       public string Add_Time { get; set; }

       /// <summary>
       ///拼团商品单价
       /// </summary>
       [Display(Name ="拼团商品单价")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Price { get; set; }

       /// <summary>
       ///拼图总人数
       /// </summary>
       [Display(Name ="拼图总人数")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int People { get; set; }

       /// <summary>
       ///商品Id
       /// </summary>
       [Display(Name ="商品Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int PId { get; set; }

       /// <summary>
       ///拼团商品Id
       /// </summary>
       [Display(Name ="拼团商品Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int CId { get; set; }

       /// <summary>
       ///购买总金额
       /// </summary>
       [Display(Name ="购买总金额")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Total_Price { get; set; }

       /// <summary>
       ///购买商品个数
       /// </summary>
       [Display(Name ="购买商品个数")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Total_Num { get; set; }

       /// <summary>
       ///订单Id  数据库
       /// </summary>
       [Display(Name ="订单Id  数据库")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Order_Id_Key { get; set; }

       /// <summary>
       ///订单Id 生成
       /// </summary>
       [Display(Name ="订单Id 生成")]
       [MaxLength(64)]
       [Column(TypeName="nvarchar(64)")]
       [Required(AllowEmptyStrings=false)]
       public string Order_Id { get; set; }

       /// <summary>
       ///用户Id
       /// </summary>
       [Display(Name ="用户Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int UId { get; set; }

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