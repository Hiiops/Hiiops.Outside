using QRCoder;
using System.Drawing;
namespace VOL.Core.Utilities
{
    /// <summary>
    /// 生成二维码
    /// </summary>
    public class QrHelper
    {
        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="message">二维码内容</param>
        /// <param name="pixel">像素</param>
        /// <returns></returns>
        public static Bitmap CreateCode(string message, int pixel = 15)
        {
            QRCodeGenerator generator = new QRCodeGenerator();
            QRCodeData codeData = generator.CreateQrCode(message, QRCodeGenerator.ECCLevel.M, true);
            QRCode qrcode = new QRCode(codeData);
            Bitmap qrImage = qrcode.GetGraphic(pixel, Color.Black, Color.White, true);
            return qrImage;
        }
    }
}
