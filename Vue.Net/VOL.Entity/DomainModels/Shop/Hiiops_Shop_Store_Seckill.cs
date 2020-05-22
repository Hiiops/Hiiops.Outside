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
    [Entity(TableCnName = "秒杀商品",TableName = "Hiiops_Shop_Store_Seckill")]
    public class Hiiops_Shop_Store_Seckill:BaseEntity
    {
        /// <summary>
       ///商品秒杀商品表Id
       /// </summary>
       [Key]
       [Display(Name ="商品秒杀商品表Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///商品Id
       /// </summary>
       [Display(Name ="商品Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Product_Id { get; set; }

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
       ///成本
       /// </summary>
       [Display(Name ="成本")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Cost { get; set; }

       /// <summary>
       ///原价
       /// </summary>
       [Display(Name ="原价")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Ot_Price { get; set; }

       /// <summary>
       ///返多少积分
       /// </summary>
       [Display(Name ="返多少积分")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Give_Integral { get; set; }

       /// <summary>
       ///排序
       /// </summary>
       [Display(Name ="排序")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Sort { get; set; }

       /// <summary>
       ///库存
       /// </summary>
       [Display(Name ="库存")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Stock { get; set; }

       /// <summary>
       ///销量
       /// </summary>
       [Display(Name ="销量")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Sales { get; set; }

       /// <summary>
       ///单位名
       /// </summary>
       [Display(Name ="单位名")]
       [MaxLength(32)]
       [Column(TypeName="nvarchar(32)")]
       [Required(AllowEmptyStrings=false)]
       public string Unit_Name { get; set; }

       /// <summary>
       ///邮费
       /// </summary>
       [Display(Name ="邮费")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Postage { get; set; }

       /// <summary>
       ///内容
       /// </summary>
       [Display(Name ="内容")]
       [Column(TypeName="nvarchar(max)")]
       public string Description { get; set; }

       /// <summary>
       ///开始时间
       /// </summary>
       [Display(Name ="开始时间")]
       [MaxLength(256)]
       [Column(TypeName="nvarchar(256)")]
       [Required(AllowEmptyStrings=false)]
       public string Start_Time { get; set; }

       /// <summary>
       ///结束时间
       /// </summary>
       [Display(Name ="结束时间")]
       [MaxLength(256)]
       [Column(TypeName="nvarchar(256)")]
       [Required(AllowEmptyStrings=false)]
       public string Stop_Time { get; set; }

       /// <summary>
       ///添加时间
       /// </summary>
       [Display(Name ="添加时间")]
       [MaxLength(256)]
       [Column(TypeName="nvarchar(256)")]
       [Required(AllowEmptyStrings=false)]
       public string Add_Time { get; set; }

       /// <summary>
       ///商品状态
       /// </summary>
       [Display(Name ="商品状态")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Status { get; set; }

       /// <summary>
       ///是否包邮
       /// </summary>
       [Display(Name ="是否包邮")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Postage { get; set; }

       /// <summary>
       ///热门推荐
       /// </summary>
       [Display(Name ="热门推荐")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Hot { get; set; }

       /// <summary>
       ///删除 0未删除1已删除
       /// </summary>
       [Display(Name ="删除 0未删除1已删除")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Del { get; set; }

       /// <summary>
       ///最多秒杀几个
       /// </summary>
       [Display(Name ="最多秒杀几个")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Num { get; set; }

       /// <summary>
       ///显示
       /// </summary>
       [Display(Name ="显示")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Show { get; set; }

       /// <summary>
       ///时间段Id
       /// </summary>
       [Display(Name ="时间段Id")]
       [Column(TypeName="int")]
       public int? Time_Id { get; set; }

       /// <summary>
       ///运费模板Id
       /// </summary>
       [Display(Name ="运费模板Id")]
       [Column(TypeName="int")]
       public int? Temp_Id { get; set; }

       /// <summary>
       ///商品重量
       /// </summary>
       [Display(Name ="商品重量")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       public decimal? Weight { get; set; }

       /// <summary>
       ///商品体积
       /// </summary>
       [Display(Name ="商品体积")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       public decimal? Volume { get; set; }

       /// <summary>
       ///限购总数
       /// </summary>
       [Display(Name ="限购总数")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Quota { get; set; }

       /// <summary>
       ///限购总数显示
       /// </summary>
       [Display(Name ="限购总数显示")]
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