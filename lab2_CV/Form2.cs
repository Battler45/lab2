using System.Drawing;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {
        public Form2(Image bitmap)
        {
            InitializeComponent();
            pictureBox1.Image = bitmap;
        }
    }
}
