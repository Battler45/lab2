using System;
using System.Drawing;
namespace Lab2
{
    public class RGBColorMask : IImageFilter
    {
        private Color MaskColor { get; }
        public RGBColorMask(Color color)
        {
            MaskColor = color;
        }
        public Color Apply(Color color)
        {
            byte red = 0,
                green = 0,
                blue = 0;
            if (MaskColor == Color.Red)
            {
                red = color.R;
            } else if (MaskColor == Color.Green)
            {
                green = color.G;
            } else if (MaskColor == Color.Blue)
            {
                blue = color.B;
            }
            else
            {
                throw new ArgumentException();
            }
            return Color.FromArgb(red, green, blue);
        }
    }
}
