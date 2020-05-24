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
    [Entity(TableCnName = "会员",TableName = "Hiiops_Cart_SellerUser")]
    public class Hiiops_Cart_SellerUser:BaseEntity
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
       ///姓名
       /// </summary>
       [Display(Name ="姓名")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       [Required(AllowEmptyStrings=false)]
       public string Name { get; set; }

       /// <summary>
       ///头像
       /// </summary>
       [Display(Name ="头像")]
       [Column(TypeName="nvarchar")]
       public DateTime? HeadImgUrl { get; set; }

       /// <summary>
       ///搜索记录
       /// </summary>
       [Display(Name ="搜索记录")]
       [Column(TypeName="nvarchar(max)")]
       public string SearchKey { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Status { get; set; }

       /// <summary>
       ///电话
       /// </summary>
       [Display(Name ="电话")]
       [MaxLength(76)]
       [Column(TypeName="nvarchar(76)")]
       public string Phone { get; set; }

       /// <summary>
       ///微信OPENID
       /// </summary>
       [Display(Name ="微信OPENID")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string OpenId { get; set; }

       /// <summary>
       ///昵称
       /// </summary>
       [Display(Name ="昵称")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string NickName { get; set; }

       /// <summary>
       ///性别
       /// </summary>
       [Display(Name ="性别")]
       [Column(TypeName="int")]
       public int? Sex { get; set; }

       /// <summary>
       ///省份
       /// </summary>
       [Display(Name ="省份")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Province { get; set; }

       /// <summary>
       ///国家
       /// </summary>
       [Display(Name ="国家")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Country { get; set; }

       /// <summary>
       ///特权
       /// </summary>
       [Display(Name ="特权")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Privilege { get; set; }

       /// <summary>
       ///UNIONID
       /// </summary>
       [Display(Name ="UNIONID")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string UnionId { get; set; }

       /// <summary>
       ///最后登录时间
       /// </summary>
       [Display(Name ="最后登录时间")]
       [Column(TypeName="datetime")]
       public DateTime? LastLoginTime { get; set; }

       /// <summary>
       ///登录IP
       /// </summary>
       [Display(Name ="登录IP")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string LoginIp { get; set; }

       /// <summary>
       ///TOKEN
       /// </summary>
       [Display(Name ="TOKEN")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Token { get; set; }

       /// <summary>
       ///密码
       /// </summary>
       [Display(Name ="密码")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Password { get; set; }

       /// <summary>
       ///备注
       /// </summary>
       [Display(Name ="备注")]
       [MaxLength(2000)]
       [Column(TypeName="nvarchar(2000)")]
       public string Remark { get; set; }

       /// <summary>
       ///创建人ID
       /// </summary>
       [Display(Name ="创建人ID")]
       [Column(TypeName="int")]
       public int? CreateID { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Creator { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///修改人ID
       /// </summary>
       [Display(Name ="修改人ID")]
       [Column(TypeName="int")]
       public int? ModifyID { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Modifier { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///账户
       /// </summary>
       [Display(Name ="账户")]
       [MaxLength(510)]
       [Column(TypeName="nvarchar(510)")]
       public string Account { get; set; }

       
    }
}