using System.Drawing;

namespace Lab2
{
    public interface IComparingImageFilter
    {
        Color Apply(Color color, Color anotherColor);
    }
}