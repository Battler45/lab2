using System;
using System.Drawing;

namespace Lab2
{
    public class DifferenceFilter: IComparingImageFilter
    {

        public Color Apply(Color color, Color anotherColor)
        {
            var red = Math.Abs(color.R - anotherColor.R);
            var blue = Math.Abs(color.B - anotherColor.B);
            var green = Math.Abs(color.G - anotherColor.G);
            return Color.FromArgb(red, green, blue);
        }
    }
}