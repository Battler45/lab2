using System.Drawing;

namespace Lab2
{
    public interface IImageFilter
    {
        Color Apply(Color color);
    }
}