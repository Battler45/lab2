using System.Drawing;
using System.Windows.Forms;

namespace Lab2
{
    public class MMCS_CS332_Lab2_Task3
    {
        public static MMCS_CS332_Lab2_Task3 GetInstance() => new MMCS_CS332_Lab2_Task3();
        public void Solve(Bitmap image, Form mainForm)
        {
            var form = new Form4(image)
            {
                Owner = mainForm,
                Text = "HSV palette"
            };
            form.Show();
        }
    }
}