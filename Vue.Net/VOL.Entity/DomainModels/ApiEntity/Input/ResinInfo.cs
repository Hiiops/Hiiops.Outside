using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace VOL.Entity.DomainModels.ApiEntity
{
    /// <summary>
    /// 注册实体类
    /// </summary>
    public class ResinInfo
    {
        [Display(Name = "用户名")]
        [MaxLength(50)]
        [Required(ErrorMessage = "用户名不能为空")]
        public string UserName { get; set; }
        [MaxLength(50)]
        [Display(Name = "密码")]
        [Required(ErrorMessage = "密码不能为空")]
        public string PassWord { get; set; }
        [MaxLength(6)]
        [Display(Name = "验证码")]
        [Required(ErrorMessage = "验证码不能为空")]

        public string VerificationCode { get; set; }

        [MaxLength(11)]
        [Display(Name = "注册类型")]
        [Required(AllowEmptyStrings = true)]
        public int ResignType { get; set; } = 4;//默认手机号码注册

        [MaxLength(50)]
        [Display(Name = "账户")]
        [Required(AllowEmptyStrings = true)]
        public string Account { get; set; }

        [MaxLength(256)]
        [Display(Name = "邮箱")]
        [Required(AllowEmptyStrings = true)]
        public string Email { get; set; }
        [MaxLength(256)]
        [Display(Name = "微信OPENID")]
        [Required(AllowEmptyStrings = true)]
        public string OpenId { get; set; }
        [MaxLength(256)]
        [Display(Name = "微信UnionId")]
        [Required(AllowEmptyStrings = true)]
        public string UnionId { get; set; }
        [MaxLength(50)]
        [Display(Name = "手机号码")]
        [Required(AllowEmptyStrings = true)]
        public string Phone { get; set; }
        [MaxLength(256)]
        [Display(Name = "小程序")]
        [Required(AllowEmptyStrings = true)]
        public string Applet { get; set; }
    }
}
