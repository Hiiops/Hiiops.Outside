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
    [Entity(TableCnName = "商品管理",TableName = "Hiiops_Shop_Store_Product")]
    public class Hiiops_Shop_Store_Product:BaseEntity
    {
        /// <summary>
       ///商品Id
       /// </summary>
       [Key]
       [Display(Name ="商品Id")]
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
       ///商品图片
       /// </summary>
       [Display(Name ="商品图片")]
       [MaxLength(512)]
       [Column(TypeName="nvarchar(512)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Image { get; set; }

       /// <summary>
       ///轮播图
       /// </summary>
       [Display(Name ="轮播图")]
       [MaxLength(4000)]
       [Column(TypeName="nvarchar(4000)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string SlIder_Image { get; set; }

       /// <summary>
       ///商品名称
       /// </summary>
       [Display(Name ="商品名称")]
       [MaxLength(256)]
       [Column(TypeName="nvarchar(256)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Store_Name { get; set; }

       /// <summary>
       ///商品简介
       /// </summary>
       [Display(Name ="商品简介")]
       [MaxLength(512)]
       [Column(TypeName="nvarchar(512)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Store_Info { get; set; }

       /// <summary>
       ///关键字
       /// </summary>
       [Display(Name ="关键字")]
       [MaxLength(512)]
       [Column(TypeName="nvarchar(512)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Keyword { get; set; }

       /// <summary>
       ///商品条码（一维码）
       /// </summary>
       [Display(Name ="商品条码（一维码）")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Bar_Code { get; set; }

       /// <summary>
       ///分类Id
       /// </summary>
       [Display(Name ="分类Id")]
       [MaxLength(128)]
       [Column(TypeName="nvarchar(128)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Cate_Id { get; set; }

       /// <summary>
       ///商品价格
       /// </summary>
       [Display(Name ="商品价格")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal Price { get; set; }

       /// <summary>
       ///会员价格
       /// </summary>
       [Display(Name ="会员价格")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal Vip_Price { get; set; }

       /// <summary>
       ///市场价
       /// </summary>
       [Display(Name ="市场价")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal Ot_Price { get; set; }

       /// <summary>
       ///邮费
       /// </summary>
       [Display(Name ="邮费")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal Postage { get; set; }

       /// <summary>
       ///单位名
       /// </summary>
       [Display(Name ="单位名")]
       [MaxLength(64)]
       [Column(TypeName="nvarchar(64)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Unit_Name { get; set; }

       /// <summary>
       ///排序
       /// </summary>
       [Display(Name ="排序")]
       [Column(TypeName="smallint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Sort { get; set; }

       /// <summary>
       ///销量
       /// </summary>
       [Display(Name ="销量")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Sales { get; set; }

       /// <summary>
       ///库存
       /// </summary>
       [Display(Name ="库存")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Stock { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [Column(TypeName="tinyint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Show { get; set; }

       /// <summary>
       ///是否热卖
       /// </summary>
       [Display(Name ="是否热卖")]
       [Column(TypeName="tinyint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Hot { get; set; }

       /// <summary>
       ///是否优惠
       /// </summary>
       [Display(Name ="是否优惠")]
       [Column(TypeName="tinyint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public byte Is_benefit { get; set; }

       /// <summary>
       ///是否精品
       /// </summary>
       [Display(Name ="是否精品")]
       [Column(TypeName="tinyint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public byte Is_best { get; set; }

       /// <summary>
       ///是否新品
       /// </summary>
       [Display(Name ="是否新品")]
       [Column(TypeName="tinyint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public byte Is_New { get; set; }

       /// <summary>
       ///添加时间
       /// </summary>
       [Display(Name ="添加时间")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Add_Time { get; set; }

       /// <summary>
       ///是否包邮
       /// </summary>
       [Display(Name ="是否包邮")]
       [Column(TypeName="tinyint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Postage { get; set; }

       /// <summary>
       ///是否删除
       /// </summary>
       [Display(Name ="是否删除")]
       [Column(TypeName="tinyint")]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Del { get; set; }

       /// <summary>
       ///商户是否代理
       /// </summary>
       [Display(Name ="商户是否代理")]
       [Column(TypeName="tinyint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public byte Mer_Use { get; set; }

       /// <summary>
       ///获得积分
       /// </summary>
       [Display(Name ="获得积分")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal Give_Integral { get; set; }

       /// <summary>
       ///成本价
       /// </summary>
       [Display(Name ="成本价")]
       [DisplayFormat(DataFormatString="8,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal Cost { get; set; }

       /// <summary>
       ///秒杀状态
       /// </summary>
       [Display(Name ="秒杀状态")]
       [Column(TypeName="tinyint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Seckill { get; set; }

       /// <summary>
       ///砍价状态
       /// </summary>
       [Display(Name ="砍价状态")]
       [Column(TypeName="tinyint")]
       [Editable(true)]
       public byte? Is_bargain { get; set; }

       /// <summary>
       ///是否优品推荐
       /// </summary>
       [Display(Name ="是否优品推荐")]
       [Column(TypeName="tinyint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Good { get; set; }

       /// <summary>
       ///是否单独分佣
       /// </summary>
       [Display(Name ="是否单独分佣")]
       [Column(TypeName="tinyint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public byte Is_Sub { get; set; }

       /// <summary>
       ///虚拟销量
       /// </summary>
       [Display(Name ="虚拟销量")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Ficti { get; set; }

       /// <summary>
       ///浏览量
       /// </summary>
       [Display(Name ="浏览量")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? Browse { get; set; }

       /// <summary>
       ///商品二维码地址(用户小程序海报)
       /// </summary>
       [Display(Name ="商品二维码地址(用户小程序海报)")]
       [MaxLength(128)]
       [Column(TypeName="nvarchar(128)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Code_Path { get; set; }

       /// <summary>
       ///淘宝京东1688类型
       /// </summary>
       [Display(Name ="淘宝京东1688类型")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Editable(true)]
       public string Soure_Link { get; set; }

       /// <summary>
       ///主图视频链接
       /// </summary>
       [Display(Name ="主图视频链接")]
       [MaxLength(400)]
       [Column(TypeName="nvarchar(400)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string VIdeo_Link { get; set; }

       /// <summary>
       ///运费模板Id
       /// </summary>
       [Display(Name ="运费模板Id")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Temp_Id { get; set; }

       /// <summary>
       ///规格
       /// </summary>
       [Display(Name ="规格")]
       [Column(TypeName="tinyint")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public byte Spec_Type { get; set; }

       /// <summary>
       ///活动显示排序
       /// </summary>
       [Display(Name ="活动显示排序")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string Activity { get; set; }

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