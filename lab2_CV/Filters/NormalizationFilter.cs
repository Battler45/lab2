using System;
using System.Drawing;

namespace Lab2
{
    public class NormalizationFilter: IImageFilter
    {
        private double NormalizationColorCoefficient { get; }

        public NormalizationFilter(byte maxColorValue)
        {
            NormalizationColorCoefficient = Convert.ToByte(255.0 / maxColorValue);
        }

        public Color Apply(Color color)
        {
            var red = Convert.ToByte(NormalizationColorCoefficient * color.R);
            var green = Convert.ToByte(NormalizationColorCoefficient * color.G);
            var blue = Convert.ToByte(NormalizationColorCoefficient * color.B);
            return Color.FromArgb(red, green, blue);
        }
    }
}