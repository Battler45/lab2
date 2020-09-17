using System;
using System.Drawing;
using System.Windows.Forms;
using Lab2.Constants;

namespace Lab2
{
    public partial class Form4 : Form
    {
        public Form4(Bitmap image)
        {
            InitializeComponent();
            trackBar_hue.Maximum = 360;
            trackBar_saturation.Maximum = trackBar_brightness.Maximum = 100;
            pictureBox1.Image = image;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog()
            {
                Filter = FileTypeRegexes.ImageTypesRegexes
            };
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Не удалось сохранить файл");
                return;
            }
            pictureBox1.Image.Save(saveFileDialog.FileName);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var hueCoefficient = trackBar_hue.Value * 1.0f / trackBar_hue.Maximum;
            var saturationCoefficient = trackBar_saturation.Value * 1.0f / trackBar_saturation.Maximum;
            var valueCoefficient = trackBar_brightness.Value * 1.0f / trackBar_brightness.Maximum;
            var hsvFilter = new HSVFilter(hueCoefficient, saturationCoefficient, valueCoefficient);
            var newImage = Transformer.GetInstance().Transform((Bitmap)pictureBox1.Image, hsvFilter);
            pictureBox1.Image = newImage;
            pictureBox1.Refresh();
        }
    }
}