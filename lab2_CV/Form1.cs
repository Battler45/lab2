using System;
using System.Drawing;
using System.Windows.Forms;
using Lab2.Constants;

namespace Lab2
{
    public partial class Form1 : Form      
    {
        public Form1()  
        {
            InitializeComponent();
            toolTip_path.SetToolTip(button_path, "укажите путь к изображению");
            comboBox_function.SelectedIndex = 0;
            comboBox_function.DropDownStyle = ComboBoxStyle.DropDownList; 
        }
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                var res = MessageBox.Show("Указать путь?", "Изображение не выбрано", MessageBoxButtons.OKCancel);
                if (res != DialogResult.OK) return;
                button_path_Click(null, null);
                return;
            }
            var image = (pictureBox1.Image as Bitmap).Copy();
            switch (comboBox_function.SelectedIndex)
            {
                case 0: 
                    MMCS_CS332_Lab2_Task1.GetInstance().Solve(image, this);
                    break;
                case 2:
                    MMCS_CS332_Lab2_Task3.GetInstance().Solve(image, this);
                    break;
                case 1:
                    MMCS_CS332_Lab2_Task2.GetInstance().Solve(image, this);
                    break;
            }
        }

        private void button_path_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog()
            {
                Filter = FileTypeRegexes.ImageTypesRegexes
            };
            if (fileDialog.ShowDialog() != DialogResult.OK) return;

            pictureBox1.Image = Image.FromFile(fileDialog.FileName);
            button_path.Text = fileDialog.FileName;
            toolTip_path.SetToolTip(button_path, fileDialog.FileName);
        }
    }
}
