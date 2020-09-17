using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Lab2
{
    public static class BitmapExtensions
    {
        public static Bitmap Copy(this Bitmap image)
            => image.Clone(new Rectangle(0, 0, image.Width, image.Height), image.PixelFormat);

        public static IEnumerable<Pixel> GetPixels(this Bitmap image)
        {
            for (var x = 0; x < image.Width; x++)
            {    
                for (var y = 0; y < image.Height; y++)
                {
                    var color = image.GetPixel(x, y);
                    yield return new Pixel(x, y, color);
                }
            }
        }
        public static IEnumerable<Color> GetColors(this Bitmap image)
        {
            for (var x = 0; x < image.Width; x++)
            {
                for (var y = 0; y < image.Height; y++)
                {
                    yield return image.GetPixel(x, y);
                }
            }
        }
        public static byte GetMaxColorValue(this Bitmap image)
        {
            return image.GetColors()
                .Max(color => Math.Max(color.R, Math.Max(color.B, color.G)));
        }
    }
}