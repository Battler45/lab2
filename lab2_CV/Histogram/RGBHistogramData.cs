using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Lab2
{
    public class RGBHistogramData : IHistogramData
    {
        private RGBHistogramData(List<int> redData, List<int> blueData, List<int> greenData)
        {
            RedData = redData;
            BlueData = blueData;
            GreenData = greenData;
        }

        public List<int> RedData { get; }
        public List<int> BlueData { get; }
        public List<int> GreenData { get; }

        public static RGBHistogramData GetInstance(Bitmap image)
        {
            int[] red = new int[256],
                green = new int[256],
                blue = new int[256];
            foreach (var color in image.GetColors())
            {
                ++red[color.R];
                ++green[color.G];
                ++blue[color.B];
            }
            return new RGBHistogramData(red.ToList(), blue.ToList(), green.ToList());
        }

        public string DataType => "RGB";
    }
}