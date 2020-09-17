using System;
using System.Drawing;

namespace Lab2
{
    public class HSVColor
    {
        public HSVColor(float hue, float saturation, float value)
        {
            Hue = hue;
            Saturation = saturation;
            Value = value;
        }

        public float Hue { get; set; }
        public float Saturation { get; set; }
        public float Value { get; set; }

        /// <summary>
        ///
        /// https://en.wikipedia.org/wiki/HSL_and_HSV#HSL_to_HSV
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static explicit operator HSVColor(Color color)
        {
            var hue = color.GetHue();
            var HSLBrightness = color.GetBrightness();
            var value = HSLBrightness + color.GetSaturation() * Math.Min(HSLBrightness, 1 - HSLBrightness);
            var saturation = Math.Abs(value) < 1e-5
                ? 0
                : 2 * (1 - HSLBrightness / value);
            return new HSVColor(hue, saturation, value);
        }
        /// <summary>
        ///
        /// https://en.wikipedia.org/wiki/HSL_and_HSV#HSV_to_HSL
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        /// TODO: это говно нужно исправить: на 42 строчки выглядит крайне убого, не смотря на то, что в нем есть вложенный метод
        public static explicit operator Color(HSVColor color)
        {
            if (float.IsNaN(color.Hue) || color.Hue < 0)
                return Color.FromArgb(0, 0, 0);

            var dashHue = color.Hue / 60.0f;
            var _c = color.Value * color.Saturation;
            var _x = _c * (1 - Math.Abs(dashHue % 2 - 1));
            var c = Convert.ToByte(_c * 255.0f);
            var x = Convert.ToByte(_x * 255.0f);
            var dashColor = GetDashColor(dashHue, c, x);
            var m = Convert.ToByte(Math.Abs(color.Value - _c) * 255.0f);
            return Color.FromArgb(dashColor.R + m, dashColor.G + m, dashColor.B + m);

            static Color GetDashColor(float dashHue, byte c, byte x)
            {
                if (dashHue <= 1)
                {
                    return Color.FromArgb(c, x, 0);
                }
                if (dashHue <= 2)
                {
                    return Color.FromArgb(x, c, 0);
                }
                if (dashHue <= 3)
                {
                    return Color.FromArgb(0, c, x);
                }
                if (dashHue <= 4)
                {
                    return Color.FromArgb(0, x, c);
                }
                if (dashHue <= 5)
                {
                    return Color.FromArgb(x, 0, c);
                }
                if (dashHue <= 6)
                {
                    return Color.FromArgb(c, 0, x);
                }
                return Color.FromArgb(0, 0, 0);
            }
        }
    }
}