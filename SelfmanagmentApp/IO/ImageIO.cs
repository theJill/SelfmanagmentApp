using System.IO;
using System.Windows.Media.Imaging;

namespace SelfmanagmentApp.IO
{
    public static class ImageIO
    {
        public static byte[] BitmapImageToByte(BitmapImage imageSource)
        {
            byte[] data;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            if (imageSource == null)
            {
                return null;
            }
            encoder.Frames.Add(BitmapFrame.Create(imageSource));

            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
            }
            return data;
        }

        public static BitmapImage ByteToBitmapImage(byte[] array)
        {
            using (var ms = new MemoryStream(array))
            {
                var image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = ms;
                image.EndInit();
                return image;
            }
        }
    }
}
