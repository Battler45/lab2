using System.Drawing;

namespace Lab2
{
    public class ImageComparator
    {
        public static ImageComparator GetInstance()
            => new ImageComparator();
        public Bitmap Differ(Bitmap image, Bitmap anotherImage)
        {
            var transformer = new Transformer();
            var differenceFilter = new DifferenceFilter();
            var newImage = transformer.Transform(image, anotherImage, differenceFilter);
            var maxImageColorValue = newImage.GetMaxColorValue();
            var normalizationFilter = new NormalizationFilter(maxImageColorValue);
            transformer.Change(newImage, normalizationFilter);
            return newImage;
        }
    }
}