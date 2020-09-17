using System.Drawing;

namespace Lab2
{
    public class HSVFilter : IImageFilter
    {
        public HSVFilter(float hueCoefficient, float saturationCoefficient, float valueCoefficient)
        {
            HueCoefficient = hueCoefficient;
            SaturationCoefficient = saturationCoefficient;
            ValueCoefficient = valueCoefficient;
        }

        private float HueCoefficient { get; }
        private float SaturationCoefficient { get; }
        private float ValueCoefficient { get; }
        private void Apply(HSVColor color)
        {
            color.Hue *= HueCoefficient;
            color.Saturation *= SaturationCoefficient;
            color.Value *= ValueCoefficient;
        }

        public Color Apply(Color color)
        {
            var hsvColor = (HSVColor)color;
            Apply(hsvColor);
            return (Color)hsvColor;
        }
    }
}