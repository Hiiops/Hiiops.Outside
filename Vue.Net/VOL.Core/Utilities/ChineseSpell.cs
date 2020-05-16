using System.Text;
namespace VOL.Core.Utilities
{
    /// <summary>
    /// 取得汉字拼音的首字母
    /// </summary>
    public class ChineseSpell
    {
        /// <summary>
        /// 取得汉字拼音的首字母
        /// </summary>
        /// <param name="strText">汉字串</param>
        /// <returns>汉字串的首字母串</returns>
        public static string GetChineseSpell(string strText)
        {
            int len = strText.Length;
            StringBuilder myStr = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                myStr.Append(GetSpell(strText.Substring(i, 1)));
            }
            return myStr.ToString();
        }

        /// <summary>
        /// 取得一个汉字的拼音首字母
        /// </summary>
        /// <param name="cnChar">一个汉字</param>
        /// <returns>首字母</returns>
        private static string GetSpell(string cnChar)
        {
            byte[] arrCN = Encoding.Default.GetBytes(cnChar);
            if (arrCN.Length > 1)
            {
                int area = (short)arrCN[0];
                int pos = (short)arrCN[1];
                int code = (area << 8) + pos;
                int[] areacode = { 45217, 45253, 45761, 46318, 46826, 47010, 47297, 47614, 48119, 48119, 49062, 49324, 49896, 50371, 50614, 50622, 50906, 51387, 51446, 52218, 52698, 52698, 52698, 52980, 53689, 54481 };
                for (int i = 0; i < 26; i++)
                {
                    int max = 55290;
                    if (i != 25) max = areacode[i + 1];
                    if (areacode[i] <= code && code < max)
                    {
                        return Encoding.Default.GetString(new byte[] { (byte)(65 + i) });
                    }
                }
                return "*";
            }
            else return cnChar;
        }
    }
}

