using Microsoft.AspNetCore.Http;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using VOL.Core.Extensions;

namespace VOL.Core.Utilities
{
    /// <summary>
    /// 通用帮助类
    /// </summary>
    public class Utils
    {
        #region 通过身份证号计算生日
        /// <summary>
        /// 通过身份证号计算生日
        /// </summary>
        /// <param name="cardId">身份证号</param>
        /// <returns></returns>
        public static DateTime GetBirthdayByCardId(string cardId)
        {
            if (string.IsNullOrWhiteSpace(cardId))
            {
                return DateTime.Now;
            }

            string year = cardId.Substring(6, 4);
            string month = cardId.Substring(10, 2);
            string date = cardId.Substring(12, 2);
            string result = year + "-" + month + "-" + date;
            return result.GetDateTime().ToDateTime();
        }

        /// <summary>
        /// 通过生日计算年龄
        /// </summary>
        /// <param name="birthday"></param>
        /// <returns></returns>
        public static int GetAgeByBirthday(DateTime birthday)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - birthday.Year;
            if (now.Month < birthday.Month || (now.Month == birthday.Month && now.Day < birthday.Day))
            {
                age--;
            }
            return age < 0 ? 0 : age;
        }
        #endregion

        #region 截取字符长度

        /// <summary>
        /// 截取字符长度
        /// </summary>
        /// <param name="inputString">字符</param>
        /// <param name="len">长度</param>
        /// <returns></returns>
        public static string CutString(string inputString, int len)
        {
            if (string.IsNullOrEmpty(inputString))
                return "";
            ASCIIEncoding ascii = new ASCIIEncoding();
            int tempLen = 0;
            string tempString = "";
            byte[] s = ascii.GetBytes(inputString);
            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s[i] == 63)
                {
                    tempLen += 2;
                }
                else
                {
                    tempLen += 1;
                }

                try
                {
                    tempString += inputString.Substring(i, 1);
                }
                catch
                {
                    break;
                }

                if (tempLen > len)
                    break;
            }
            //如果截过则加上半个省略号 
            byte[] mybyte = System.Text.Encoding.Default.GetBytes(inputString);
            if (mybyte.Length > len)
                tempString += "…";
            return tempString;
        }

        #endregion

        #region 获得IP地址
        /// <summary>
        /// 获得IP地址
        /// </summary>
        /// <returns>字符串数组</returns>
        public static string GetIp()
        {
            HttpContextAccessor _context = new HttpContextAccessor();
            if (_context.HttpContext == null) return "127.0.0.1";
            var head = _context.HttpContext.Request.Headers["X-Forwarded-For"];
            var ip = head.ToString();
            if (string.IsNullOrEmpty(ip))
            {
                ip = _context.HttpContext.Connection.RemoteIpAddress.ToString();
            }
            return ip;
        }
        #endregion

        #region 生成随机数
        static RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

        /// <summary>
        /// 获取可靠的随机数
        /// </summary>
        /// <param name="numSeeds">大小</param>
        /// <param name="length">长度</param>
        /// <returns></returns>
        public static int NextRandom(int numSeeds, int length)
        {
            byte[] randomNumber = new byte[length];
            rng.GetBytes(randomNumber);

            uint randomResult = 0x0;
            for (int i = 0; i < length; i++)
            {
                randomResult |= ((uint)randomNumber[i] << ((length - 1 - i) * 8));
            }

            return (int)(randomResult % numSeeds) + 1;
        }
        #endregion

        #region 获取GUID
        /// <summary>
        /// 获取GUID
        /// </summary>
        /// <returns></returns>
        public static string GetGuid()
        {
            return Guid.NewGuid().ToString("N").ToUpper();
        }
        #endregion

        #region 手机号码替换* ydp
        /// <summary>
        /// 手机号码替换* ydp
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns></returns>
        public static string ReplaceChar(string str, string sep = "***")
        {
            string result = str;
            if (result.Length >= 6)
            {
                string strStart = result.Substring(0, 3);
                string strEnd = result.Substring(result.Length - 3, 3);
                result = string.Format("{0}{1}{2}", strStart, sep, strEnd);
            }
            return result;
        }
        #endregion

        #region 去掉HTML

        /// <summary>
        /// 去掉所有Html标记
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string RemoveAllTag(string input)
        {
            Regex stripTags = new Regex("<(.|\n)+?>");
            return stripTags.Replace(input, "");
        }

        /// <summary>
        /// 去掉指定的HTML标记
        /// </summary>
        /// <param name="content"></param>
        /// <param name="tags"></param>
        /// <returns></returns>
        public static string RemoveHtmlTag(string content, string[] tags)
        {
            string regexstr1, regexstr2;
            foreach (string tag in tags)
            {
                if (tag != "")
                {
                    regexstr1 = string.Format(@"<{0}([^>])*>", tag);
                    regexstr2 = string.Format(@"</{0}([^>])*>", tag);
                    content = Regex.Replace(content, regexstr1, string.Empty, RegexOptions.IgnoreCase);
                    content = Regex.Replace(content, regexstr2, string.Empty, RegexOptions.IgnoreCase);
                }
            }
            return content;
        }

        /// <summary>
        /// 去掉某一个指定的HTML标记
        /// </summary>
        /// <param name="content"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        public static string RemoveHtmlTag(string content, string tag)
        {
            string returnStr;
            string regexstr1 = string.Format(@"<{0}([^>])*>", tag);
            string regexstr2 = string.Format(@"</{0}([^>])*>", tag);
            returnStr = Regex.Replace(content, regexstr1, string.Empty, RegexOptions.IgnoreCase);
            returnStr = Regex.Replace(returnStr, regexstr2, string.Empty, RegexOptions.IgnoreCase);
            return returnStr;
        }

        #endregion

        #region  获取时间戳

        /// <summary>
        /// 获取时间戳(秒)
        /// </summary>
        /// <returns></returns>
        public static string GetTimeStamps()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }

        /// <summary>
        /// 获取时间戳(毫秒)
        /// </summary>
        /// <returns></returns>
        public static string GetTimeStampms()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalMilliseconds).ToString();
        }

        #endregion
    }
}

