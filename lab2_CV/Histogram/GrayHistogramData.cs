using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Lab2
{
    public class GrayHistogramData : IHistogramData
    {
        public List<int> Data { get; }
        private GrayHistogramData(List<int> grayHistogramData) => Data = grayHistogramData;
        public static GrayHistogramData GetInstance(Bitmap image)
        {
            var grayHistogramData = new int[256];
            foreach (var color in image.GetColors())
            {
                ///?? or ++ ones
                ++grayHistogramData[color.R];
                ++grayHistogramData[color.G];
                ++grayHistogramData[color.B];
            }
            return new GrayHistogramData(grayHistogramData.ToList());
        }

        public string DataType => "Grayscale";
    }
}