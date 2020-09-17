using System.Drawing;

namespace Lab2
{
    public class GrayScaleFilter : IImageFilter
    {
        private readonly double _redCoefficient;
        private readonly double _greenCoefficient;
        private readonly double _blueCoefficient;

        public GrayScaleFilter(double redCoefficient, double greenCoefficient, double blueCoefficient)
        {
            _redCoefficient = redCoefficient;
            _greenCoefficient = greenCoefficient;
            _blueCoefficient = blueCoefficient;
        }

        public Color Apply(Color color)
        {
            var grayColor = _redCoefficient * color.R + _greenCoefficient * color.G + _blueCoefficient * color.B;
            var grayColor2 = (int)grayColor;
            return Color.FromArgb(grayColor2, grayColor2, grayColor2);
        }

        public static GrayScaleFilter GetPALGrayScaleFilterInstance()
            => new GrayScaleFilter(0.299, 0.587, 0.114);
        public static GrayScaleFilter GetHDTVGrayScaleFilterInstance()
            => new GrayScaleFilter(0.2126, 0.7152, 0.0722);
    }
}