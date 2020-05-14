namespace VOL.Core.Enums
{
    /// <summary>
    /// 账户注册类型
    /// </summary>
    public enum ResignType
    {
        /// <summary>
        /// 微信公众号注册
        /// </summary>
        OpenId = 1,
        /// <summary>
        /// 微信公众号注册
        /// </summary>
        UnionId = 2,
        /// <summary>
        /// 账户密码注册
        /// </summary>
        Account = 3,
        /// <summary>
        /// 手机号码注册
        /// </summary>
        Phone = 4,
        /// <summary>
        /// 小程序注册
        /// </summary>
        Applet = 5,
        /// <summary>
        /// 邮件注册
        /// </summary>
        Email = 6,
    }
}
