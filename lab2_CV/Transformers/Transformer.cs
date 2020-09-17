using System.Drawing;

namespace Lab2
{
    public class Transformer
    {
        public static Transformer GetInstance()
            => new Transformer();
        public Bitmap Transform(Bitmap image, IImageFilter filter)
        {
            var newImage = image.Copy();
            Change(newImage, filter);
            return newImage;
        }
        public void Change(Bitmap image, IImageFilter filter)
        {
            foreach (var pixel in image.GetPixels())
            {
                var newColor = filter.Apply(pixel.Color);
                image.SetPixel(pixel.X, pixel.Y, newColor);
            }
        }

        public Bitmap Transform(Bitmap image, Bitmap anotherImage, IComparingImageFilter filter)
        {
            var newImage = image.Copy();
            foreach (var pixel in image.GetPixels())
            {
                var anotherImageColor = anotherImage.GetPixel(pixel.X, pixel.Y);
                var newColor = filter.Apply(pixel.Color, anotherImageColor);
                newImage.SetPixel(pixel.X, pixel.Y, newColor);
            }
            return newImage;
        }

    }
}