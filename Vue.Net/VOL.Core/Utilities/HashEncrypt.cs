using System.Security.Cryptography;
using System.Text;

namespace VOL.Core.Utilities
{
    /// <summary>
    /// 散列&哈希算法
    /// </summary>
    public class HashEncrypt
    {
        /// <summary>
        /// 获得MD5值
        /// </summary>
        /// <param name="src">输入字符串</param>
        /// <returns></returns>
        public static string GetMd5(string src)
        {
            var encoding = Encoding.UTF8;
            byte[] bytValue = encoding.GetBytes(src);
            MD5 provider = new MD5CryptoServiceProvider();
            var encryptedBytes = provider.ComputeHash(bytValue);
            StringBuilder sb = new StringBuilder();
            foreach (var item in encryptedBytes)
            {
                sb.Append(item.ToString("x2"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 获得SHA1值
        /// </summary>
        /// <param name="src">输入字符串</param>
        /// <returns></returns>
        public static string GetSHA1(string src)
        {
            var encoding = Encoding.UTF8;
            byte[] bytValue = encoding.GetBytes(src);
            SHA1 provider = new SHA1CryptoServiceProvider();
            var encryptedBytes = provider.ComputeHash(bytValue);
            StringBuilder sb = new StringBuilder();
            foreach (var item in encryptedBytes)
            {
                sb.Append(item.ToString("x2"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 获得SHA256值
        /// </summary>
        /// <param name="src">输入字符串</param>
        /// <returns></returns>
        public static string GetSHA256(string src)
        {
            var encoding = Encoding.UTF8;
            byte[] bytValue = encoding.GetBytes(src);
            SHA256 provider = new SHA256CryptoServiceProvider();
            byte[] encryptedBytes = provider.ComputeHash(bytValue);
            StringBuilder sb = new StringBuilder();
            foreach (var item in encryptedBytes)
            {
                sb.Append(item.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}

