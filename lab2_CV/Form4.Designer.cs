namespace Lab2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_settings = new System.Windows.Forms.GroupBox();
            this.groupBox_brightness = new System.Windows.Forms.GroupBox();
            this.trackBar_brightness = new System.Windows.Forms.TrackBar();
            this.groupBox_saturation = new System.Windows.Forms.GroupBox();
            this.trackBar_saturation = new System.Windows.Forms.TrackBar();
            this.trackBar_hue = new System.Windows.Forms.TrackBar();
            this.button_save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_hue = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_settings.SuspendLayout();
            this.groupBox_brightness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_brightness)).BeginInit();
            this.groupBox_saturation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_saturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_hue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_hue.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_settings
            // 
            this.groupBox_settings.Controls.Add(this.groupBox_brightness);
            this.groupBox_settings.Controls.Add(this.groupBox_saturation);
            this.groupBox_settings.Location = new System.Drawing.Point(724, 15);
            this.groupBox_settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_settings.Name = "groupBox_settings";
            this.groupBox_settings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_settings.Size = new System.Drawing.Size(267, 287);
            this.groupBox_settings.TabIndex = 0;
            this.groupBox_settings.TabStop = false;
            this.groupBox_settings.Text = "change image";
            // 
            // groupBox_brightness
            // 
            this.groupBox_brightness.Controls.Add(this.trackBar_brightness);
            this.groupBox_brightness.Location = new System.Drawing.Point(0, 196);
            this.groupBox_brightness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_brightness.Name = "groupBox_brightness";
            this.groupBox_brightness.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_brightness.Size = new System.Drawing.Size(267, 79);
            this.groupBox_brightness.TabIndex = 5;
            this.groupBox_brightness.TabStop = false;
            this.groupBox_brightness.Text = "Brightness(Яркость)";
            // 
            // trackBar_brightness
            // 
            this.trackBar_brightness.Location = new System.Drawing.Point(0, 23);
            this.trackBar_brightness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar_brightness.Maximum = 100;
            this.trackBar_brightness.Name = "trackBar_brightness";
            this.trackBar_brightness.Size = new System.Drawing.Size(267, 56);
            this.trackBar_brightness.TabIndex = 2;
            this.trackBar_brightness.Value = 100;
            // 
            // groupBox_saturation
            // 
            this.groupBox_saturation.Controls.Add(this.trackBar_saturation);
            this.groupBox_saturation.Location = new System.Drawing.Point(0, 110);
            this.groupBox_saturation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_saturation.Name = "groupBox_saturation";
            this.groupBox_saturation.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_saturation.Size = new System.Drawing.Size(267, 79);
            this.groupBox_saturation.TabIndex = 4;
            this.groupBox_saturation.TabStop = false;
            this.groupBox_saturation.Text = "Saturation(Насыщенность)";
            // 
            // trackBar_saturation
            // 
            this.trackBar_saturation.Location = new System.Drawing.Point(0, 23);
            this.trackBar_saturation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar_saturation.Maximum = 100;
            this.trackBar_saturation.Name = "trackBar_saturation";
            this.trackBar_saturation.Size = new System.Drawing.Size(267, 56);
            this.trackBar_saturation.TabIndex = 1;
            this.trackBar_saturation.Value = 100;
            // 
            // trackBar_hue
            // 
            this.trackBar_hue.Location = new System.Drawing.Point(0, 23);
            this.trackBar_hue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar_hue.Maximum = 360;
            this.trackBar_hue.Name = "trackBar_hue";
            this.trackBar_hue.Size = new System.Drawing.Size(267, 56);
            this.trackBar_hue.TabIndex = 0;
            this.trackBar_hue.Value = 360;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(828, 421);
            this.button_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 28);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 524);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox_hue
            // 
            this.groupBox_hue.Controls.Add(this.trackBar_hue);
            this.groupBox_hue.Location = new System.Drawing.Point(724, 38);
            this.groupBox_hue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_hue.Name = "groupBox_hue";
            this.groupBox_hue.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_hue.Size = new System.Drawing.Size(267, 79);
            this.groupBox_hue.TabIndex = 3;
            this.groupBox_hue.TabStop = false;
            this.groupBox_hue.Text = "Hue(Тон)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(828, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox_hue);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.groupBox_settings);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form4";
            this.Text = "HSV";
            this.groupBox_settings.ResumeLayout(false);
            this.groupBox_brightness.ResumeLayout(false);
            this.groupBox_brightness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_brightness)).EndInit();
            this.groupBox_saturation.ResumeLayout(false);
            this.groupBox_saturation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_saturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_hue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_hue.ResumeLayout(false);
            this.groupBox_hue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_settings;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TrackBar trackBar_brightness;
        private System.Windows.Forms.TrackBar trackBar_saturation;
        private System.Windows.Forms.TrackBar trackBar_hue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox_hue;
        private System.Windows.Forms.GroupBox groupBox_brightness;
        private System.Windows.Forms.GroupBox groupBox_saturation;
        private System.Windows.Forms.Button button1;
    }
}