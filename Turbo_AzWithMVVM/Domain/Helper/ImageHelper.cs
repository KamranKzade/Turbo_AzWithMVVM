using System;
using System.IO;
using System.Drawing;

namespace Turbo_AzWithMVVM.Domain.Helper
{
    public class ImageHelper
    {
        public string GetImagePath(byte[] buffer, int counter)
        {
            ImageConverter ic = new ImageConverter();
            var data = ic.ConvertFrom(buffer);

            Image img = data as Image;
            if (img != null)
            {
                Bitmap bitmap1 = new Bitmap(img);

                var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Images");
                Directory.CreateDirectory(path);
                bitmap1.Save($@"{path}\image{counter}.png");
                var imagepath = $@"{path}\image{counter}.png";
                return imagepath;
            }
            else
            {
                return String.Empty;
            }

        }
        public byte[] GetBytesOfImage(string path)
        {
            var image = new Bitmap(path);
            ImageConverter imageconverter = new ImageConverter();
            var imagebytes = ((byte[])imageconverter.ConvertTo(image, typeof(byte[])));
            return imagebytes;
        }
    }
}
