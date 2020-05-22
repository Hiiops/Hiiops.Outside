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
    [Entity(TableCnName = "砍价商品",TableName = "Hiiops_Shop_Store_Bargain")]
    public class Hiiops_Shop_Store_Bargain:BaseEntity
    {
        /// <summary>
       ///砍价商品Id
       /// </summary>
       [Key]
       [Display(Name ="砍价商品Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///是否推荐0不推荐1推荐
       /// </summary>
       [Display(Name ="是否推荐0不推荐1推荐")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Hot { get; set; }

       /// <summary>
       ///是否删除 0未删除 1删除
       /// </summary>
       [Display(Name ="是否删除 0未删除 1删除")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Del { get; set; }

       /// <summary>
       ///是否包邮 0不包邮 1包邮
       /// </summary>
       [Display(Name ="是否包邮 0不包邮 1包邮")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Postage { get; set; }

       /// <summary>
       ///邮费
       /// </summary>
       [Display(Name ="邮费")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       public decimal? Postage { get; set; }

       /// <summary>
       ///砍价规则
       /// </summary>
       [Display(Name ="砍价规则")]
       [Column(TypeName="nvarchar(max)")]
       public string Rule { get; set; }

       /// <summary>
       ///砍价商品浏览量
       /// </summary>
       [Display(Name ="砍价商品浏览量")]
       [Column(TypeName="int")]
       public int? Look { get; set; }

       /// <summary>
       ///砍价商品分享量
       /// </summary>
       [Display(Name ="砍价商品分享量")]
       [Column(TypeName="int")]
       public int? Share { get; set; }

       /// <summary>
       ///排序
       /// </summary>
       [Display(Name ="排序")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Sort { get; set; }

       /// <summary>
       ///运费模板Id
       /// </summary>
       [Display(Name ="运费模板Id")]
       [Column(TypeName="int")]
       public int? Temp_Id { get; set; }

       /// <summary>
       ///体积
       /// </summary>
       [Display(Name ="体积")]
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
       ///重量
       /// </summary>
       [Display(Name ="重量")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       public decimal? Weight { get; set; }

       /// <summary>
       ///成本价
       /// </summary>
       [Display(Name ="成本价")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       public decimal? Cost { get; set; }

       /// <summary>
       ///砍价活动简介
       /// </summary>
       [Display(Name ="砍价活动简介")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Info { get; set; }

       /// <summary>
       ///反多少积分
       /// </summary>
       [Display(Name ="反多少积分")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Required(AllowEmptyStrings=false)]
       public decimal Give_Integral { get; set; }

       /// <summary>
       ///关联商品Id
       /// </summary>
       [Display(Name ="关联商品Id")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Product_Id { get; set; }

       /// <summary>
       ///砍价活动名称
       /// </summary>
       [Display(Name ="砍价活动名称")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Required(AllowEmptyStrings=false)]
       public string Title { get; set; }

       /// <summary>
       ///砍价活动图片
       /// </summary>
       [Display(Name ="砍价活动图片")]
       [MaxLength(300)]
       [Column(TypeName="nvarchar(300)")]
       [Required(AllowEmptyStrings=false)]
       public string Image { get; set; }

       /// <summary>
       ///单位名称
       /// </summary>
       [Display(Name ="单位名称")]
       [MaxLength(32)]
       [Column(TypeName="nvarchar(32)")]
       public string Unit_Name { get; set; }

       /// <summary>
       ///库存
       /// </summary>
       [Display(Name ="库存")]
       [Column(TypeName="int")]
       public int? Stock { get; set; }

       /// <summary>
       ///销量
       /// </summary>
       [Display(Name ="销量")]
       [Column(TypeName="int")]
       public int? Sales { get; set; }

       /// <summary>
       ///砍价商品轮播图
       /// </summary>
       [Display(Name ="砍价商品轮播图")]
       [MaxLength(4000)]
       [Column(TypeName="nvarchar(4000)")]
       [Required(AllowEmptyStrings=false)]
       public string Images { get; set; }

       /// <summary>
       ///砍价开启时间
       /// </summary>
       [Display(Name ="砍价开启时间")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Start_Time { get; set; }

       /// <summary>
       ///砍价结束时间
       /// </summary>
       [Display(Name ="砍价结束时间")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Stop_Time { get; set; }

       /// <summary>
       ///砍价商品名称
       /// </summary>
       [Display(Name ="砍价商品名称")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Store_Name { get; set; }

       /// <summary>
       ///砍价金额
       /// </summary>
       [Display(Name ="砍价金额")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       public decimal? Price { get; set; }

       /// <summary>
       ///每次购买的砍价商品数量
       /// </summary>
       [Display(Name ="每次购买的砍价商品数量")]
       [Column(TypeName="int")]
       public int? Num { get; set; }

       /// <summary>
       ///用户每次砍价的最大金额
       /// </summary>
       [Display(Name ="用户每次砍价的最大金额")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       public decimal? Bargain_Max_Price { get; set; }

       /// <summary>
       ///用户每次砍价的最小金额
       /// </summary>
       [Display(Name ="用户每次砍价的最小金额")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       public decimal? Bargain_Min_Price { get; set; }

       /// <summary>
       ///用户每次砍价的次数
       /// </summary>
       [Display(Name ="用户每次砍价的次数")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Bargain_Num { get; set; }

       /// <summary>
       ///砍价状态 0(到砍价时间不自动开启)  1(到砍价时间自动开启时间)
       /// </summary>
       [Display(Name ="砍价状态 0(到砍价时间不自动开启)  1(到砍价时间自动开启时间)")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Status { get; set; }

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

       /// <summary>
       ///砍价商品最低价
       /// </summary>
       [Display(Name ="砍价商品最低价")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       public decimal? Min_Price { get; set; }

       
    }
}