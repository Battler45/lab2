namespace Lab2
{

    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_graphics = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_path = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.comboBox_function = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip_path = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_graphics
            // 
            this.panel_graphics.BackColor = System.Drawing.SystemColors.Control;
            this.panel_graphics.ForeColor = System.Drawing.SystemColors.Control;
            this.panel_graphics.Location = new System.Drawing.Point(10, 10);
            this.panel_graphics.Name = "panel_graphics";
            this.panel_graphics.Size = new System.Drawing.Size(450, 440);
            this.panel_graphics.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_path);
            this.groupBox1.Controls.Add(this.button_OK);
            this.groupBox1.Controls.Add(this.comboBox_function);
            this.groupBox1.Location = new System.Drawing.Point(472, 10);
            this.groupBox1.MaximumSize = new System.Drawing.Size(150, 220);
            this.groupBox1.MinimumSize = new System.Drawing.Size(150, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button_path
            // 
            this.button_path.Location = new System.Drawing.Point(6, 75);
            this.button_path.Name = "button_path";
            this.button_path.Size = new System.Drawing.Size(138, 23);
            this.button_path.TabIndex = 5;
            this.button_path.Text = "выбрать изображение";
            this.button_path.UseVisualStyleBackColor = true;
            this.button_path.Click += new System.EventHandler(this.button_path_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(40, 132);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "ok";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // comboBox_function
            // 
            this.comboBox_function.FormattingEnabled = true;
            this.comboBox_function.Items.AddRange(new object[] {
            "task1",
            "task2",
            "task3"});
            this.comboBox_function.Location = new System.Drawing.Point(6, 19);
            this.comboBox_function.Name = "comboBox_function";
            this.comboBox_function.Size = new System.Drawing.Size(121, 21);
            this.comboBox_function.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_graphics);
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №2";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_graphics;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_function;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_path;
        private System.Windows.Forms.ToolTip toolTip_path;
    }
}

