using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2
{
    public class MMCS_CS332_Lab2_Task1
    {
        public static MMCS_CS332_Lab2_Task1 GetInstance() => new MMCS_CS332_Lab2_Task1();
        public void Solve(Bitmap image, Form mainForm)
        {
            var PALGrayScaleImage = Transformer.GetInstance().Transform(image, GrayScaleFilter.GetPALGrayScaleFilterInstance());
            var HDTVGrayScaleImage = Transformer.GetInstance().Transform(image, GrayScaleFilter.GetHDTVGrayScaleFilterInstance());
            var difference = ImageComparator.GetInstance().Differ(PALGrayScaleImage, HDTVGrayScaleImage);
            var forms = new List<Form>()
            {
                new Form2(PALGrayScaleImage)
                {
                    Text = "PAL grayscale"
                },
                new Form2(HDTVGrayScaleImage)
                {
                    Text = "HDTV grayscale"
                },
                new Form2(difference)
                {
                    Text = "Difference between PAL and HDTV"
                },
                new Bar_chart(GrayHistogramData.GetInstance(difference))
                {
                    Text = "Gray histogram"
                }
            };
            forms.ForEach(form =>
            {
                form.Owner = mainForm;
                form.Show();
            });
        }
    }
}