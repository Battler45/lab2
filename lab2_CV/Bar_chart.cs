using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab2
{
    public partial class Bar_chart : Form
    {
		public Bar_chart(IHistogramData data)	//0 - red, 1 - green, 2 - blue
        {
            InitializeComponent();
            switch (data)
            {
                case GrayHistogramData grayscale:
                    DrawGrayscaleData(grayscale, chart4);
                    break;
                case RGBHistogramData rgb:
                    DrawRGBData(rgb, chart1, chart2, chart3);
                    break;
            }

            //Text = "Bar chart";

        }
        private void DrawGrayscaleData(GrayHistogramData grayscale, Chart chart)
        {
            chart.Visible = true;
            chart.Series["Gray"].Color = Color.Gray;
            for (var i = 0; i < grayscale.Data.Count; i++)
                chart.Series["Gray"].Points.AddXY(i, grayscale.Data[i]);
        }
        private void DrawRGBData(RGBHistogramData rgb, Chart redChart, Chart greenChart, Chart blueChart)
        {
            redChart.Visible = greenChart.Visible = blueChart.Visible = true;
            redChart.Series["Red"].Color = Color.Red;
            greenChart.Series["Green"].Color = Color.Green;
            blueChart.Series["Blue"].Color = Color.Blue;
            var maxLength = Math.Max(rgb.RedData.Count, Math.Max(rgb.BlueData.Count, rgb.GreenData.Count));
            for (var i = 0; i < maxLength; i++)
            {
                redChart.Series["Red"].Points.AddXY(i, rgb.RedData[i]);
                greenChart.Series["Green"].Points.AddXY(i,rgb.GreenData[i]);
                blueChart.Series["Blue"].Points.AddXY(i, rgb.BlueData[i]);
            }
        }
    }
}
