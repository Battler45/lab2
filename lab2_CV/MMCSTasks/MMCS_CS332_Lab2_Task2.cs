using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab2
{
    public class MMCS_CS332_Lab2_Task2
    {
        public static MMCS_CS332_Lab2_Task2 GetInstance() => new MMCS_CS332_Lab2_Task2();
        public  void Solve(Bitmap image, Form mainForm)
        {
            var forms = new List<Color>
                {
                    Color.Red,
                    Color.Blue,
                    Color.Green
                }
                .Select(color => (filer: new RGBColorMask(color), color))
                .Select(tuple => (imageMask: Transformer.GetInstance().Transform(image, tuple.filer), tuple.color))
                .Select(tuple => (Form) new Form2(tuple.imageMask)
                {
                    Text = $@"{tuple.color.Name} mask"
                })
                .ToList();
            forms.Add(new Bar_chart(RGBHistogramData.GetInstance(image))
            {
                Text = "RGB histogram"
            });
            forms.ForEach(form =>
            {
                form.Owner = mainForm;
                form.Show();
            });
        }
    }
}