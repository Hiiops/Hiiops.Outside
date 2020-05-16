using System;
using System.Security.Cryptography;
using System.Text;


namespace VOL.Core.Extensions
{
    /// <summary>
    ///  AES加密/解密
    /// </summary>
    public class AESEncrypt
    {
        #region ========加密========

        /// <summary>  
        /// AES加密算法  
        /// </summary>  
        /// <param name="text">明文字符串</param>  
        /// <param name="key">密钥（32位）</param>  
        /// <param name="iv">密钥（16位）</param> 
        /// <returns>Base64字符串</returns>  
        public static string Encrypt(string text, string key, string iv)
        {
            try
            {
                byte[] encryptedData = Encoding.UTF8.GetBytes(text);
                RijndaelManaged rijndaelCipher = new RijndaelManaged();
                rijndaelCipher.Key = Encoding.UTF8.GetBytes(key);
                rijndaelCipher.IV = Encoding.UTF8.GetBytes(iv);
                rijndaelCipher.Mode = CipherMode.CBC;
                rijndaelCipher.Padding = PaddingMode.PKCS7;
                ICryptoTransform encryptor = rijndaelCipher.CreateEncryptor();
                byte[] plainText = encryptor.TransformFinalBlock(encryptedData, 0, encryptedData.Length);
                string result = Convert.ToBase64String(plainText);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region ========解密========

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="text">密文字符串Base64</param>
        /// <param name="key">密钥（32位）</param>
        /// <param name="iv">iv（16位）</param>
        /// <returns></returns>
        public static string Decrypt(string text, string key, string iv)
        {
            try
            {
                //判断是否是16位 如果不够补0
                //text = tests(text);
                //16进制数据转换成byte
                byte[] encryptedData = Convert.FromBase64String(text);  // strToToHexByte(text);
                RijndaelManaged rijndaelCipher = new RijndaelManaged();
                rijndaelCipher.Key = Convert.FromBase64String(key); // Encoding.UTF8.GetBytes(AesKey);
                rijndaelCipher.IV = Convert.FromBase64String(iv);// Encoding.UTF8.GetBytes(AesIV);
                rijndaelCipher.Mode = CipherMode.CBC;
                rijndaelCipher.Padding = PaddingMode.PKCS7;
                ICryptoTransform transform = rijndaelCipher.CreateDecryptor();
                byte[] plainText = transform.TransformFinalBlock(encryptedData, 0, encryptedData.Length);
                string result = Encoding.Default.GetString(plainText);
                return result;
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="text">密文字符串Base64</param>
        /// <param name="key">密钥（32位）</param>
        /// <param name="iv">iv（16位）</param>
        /// <returns></returns>
        public static string Decrypt2(string text, string key, string iv)
        {
            try
            {
                //判断是否是16位 如果不够补0
                //text = tests(text);
                //16进制数据转换成byte
                byte[] encryptedData = Convert.FromBase64String(text);  // strToToHexByte(text);
                RijndaelManaged rijndaelCipher = new RijndaelManaged();
                rijndaelCipher.Key = Encoding.UTF8.GetBytes(key); // Encoding.UTF8.GetBytes(AesKey);
                rijndaelCipher.IV = Encoding.UTF8.GetBytes(iv);// Encoding.UTF8.GetBytes(AesIV);
                rijndaelCipher.Mode = CipherMode.CBC;
                rijndaelCipher.Padding = PaddingMode.PKCS7;
                ICryptoTransform transform = rijndaelCipher.CreateDecryptor();
                byte[] plainText = transform.TransformFinalBlock(encryptedData, 0, encryptedData.Length);
                string result = Encoding.UTF8.GetString(plainText);
                return result;
            }
            catch
            {
                return string.Empty;
            }
        }

        #endregion
    }
}

