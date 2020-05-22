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
    [Entity(TableCnName = "开团商品",TableName = "Hiiops_Shop_Store_Combination")]
    public class Hiiops_Shop_Store_Combination:BaseEntity
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
       ///拼团结束时间
       /// </summary>
       [Display(Name ="拼团结束时间")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Stop_Time { get; set; }

       /// <summary>
       ///拼团订单有效时间
       /// </summary>
       [Display(Name ="拼团订单有效时间")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Effective_Time { get; set; }

       /// <summary>
       ///拼图商品成本
       /// </summary>
       [Display(Name ="拼图商品成本")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Cost { get; set; }

       /// <summary>
       ///浏览量
       /// </summary>
       [Display(Name ="浏览量")]
       [Column(TypeName="int")]
       public int? Browse { get; set; }

       /// <summary>
       ///单位名
       /// </summary>
       [Display(Name ="单位名")]
       [MaxLength(64)]
       [Column(TypeName="nvarchar(64)")]
       [Required(AllowEmptyStrings=false)]
       public string Unit_Name { get; set; }

       /// <summary>
       ///运费模板Id
       /// </summary>
       [Display(Name ="运费模板Id")]
       [Column(TypeName="int")]
       public int? Temp_Id { get; set; }

       /// <summary>
       ///重量
       /// </summary>
       [Display(Name ="重量")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       public decimal? Weight { get; set; }

       /// <summary>
       ///体积
       /// </summary>
       [Display(Name ="体积")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       public decimal? Volume { get; set; }

       /// <summary>
       ///单次购买数量
       /// </summary>
       [Display(Name ="单次购买数量")]
       [Column(TypeName="int")]
       public int? Num { get; set; }

       /// <summary>
       ///限购总数
       /// </summary>
       [Display(Name ="限购总数")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Quota { get; set; }

       /// <summary>
       ///限量总数显示
       /// </summary>
       [Display(Name ="限量总数显示")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Quota_Show { get; set; }

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
       ///拼团开始时间
       /// </summary>
       [Display(Name ="拼团开始时间")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Start_Time { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Modifier")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Modifier { get; set; }

       /// <summary>
       ///邮费
       /// </summary>
       [Display(Name ="邮费")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Postage { get; set; }

       /// <summary>
       ///商户是否可用1可用0不可用
       /// </summary>
       [Display(Name ="商户是否可用1可用0不可用")]
       [Column(TypeName="tinyint")]
       public byte? Mer_Use { get; set; }

       /// <summary>
       ///商品Id
       /// </summary>
       [Display(Name ="商品Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Product_Id { get; set; }

       /// <summary>
       ///商户Id
       /// </summary>
       [Display(Name ="商户Id")]
       [Column(TypeName="int")]
       public int? Mer_Id { get; set; }

       /// <summary>
       ///推荐图
       /// </summary>
       [Display(Name ="推荐图")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Required(AllowEmptyStrings=false)]
       public string Image { get; set; }

       /// <summary>
       ///轮播图
       /// </summary>
       [Display(Name ="轮播图")]
       [MaxLength(4000)]
       [Column(TypeName="nvarchar(4000)")]
       [Required(AllowEmptyStrings=false)]
       public string Images { get; set; }

       /// <summary>
       ///活动标题
       /// </summary>
       [Display(Name ="活动标题")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Required(AllowEmptyStrings=false)]
       public string Title { get; set; }

       /// <summary>
       ///活动属性
       /// </summary>
       [Display(Name ="活动属性")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Attr { get; set; }

       /// <summary>
       ///参团人数
       /// </summary>
       [Display(Name ="参团人数")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int People { get; set; }

       /// <summary>
       ///简介
       /// </summary>
       [Display(Name ="简介")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Required(AllowEmptyStrings=false)]
       public string Info { get; set; }

       /// <summary>
       ///价格
       /// </summary>
       [Display(Name ="价格")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Price { get; set; }

       /// <summary>
       ///排序
       /// </summary>
       [Display(Name ="排序")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Sort { get; set; }

       /// <summary>
       ///销量
       /// </summary>
       [Display(Name ="销量")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Sales { get; set; }

       /// <summary>
       ///库存
       /// </summary>
       [Display(Name ="库存")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Stock { get; set; }

       /// <summary>
       ///添加时间
       /// </summary>
       [Display(Name ="添加时间")]
       [MaxLength(256)]
       [Column(TypeName="nvarchar(256)")]
       [Required(AllowEmptyStrings=false)]
       public string Add_Time { get; set; }

       /// <summary>
       ///推荐
       /// </summary>
       [Display(Name ="推荐")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Host { get; set; }

       /// <summary>
       ///商品状态
       /// </summary>
       [Display(Name ="商品状态")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Show { get; set; }

       /// <summary>
       ///是否包邮1是0否
       /// </summary>
       [Display(Name ="是否包邮1是0否")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Postage { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyDate")]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       
    }
}