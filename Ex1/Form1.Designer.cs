namespace Ex1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GrayScaleProcessButton = new System.Windows.Forms.Button();
            this.ShowResultImageButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Weight1Button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Weight2Button = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Weight3Button = new System.Windows.Forms.Button();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.KMeansButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.KMeansTextBox = new System.Windows.Forms.TextBox();
            this.KMeansLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GrayScaleProcessButton
            // 
            this.GrayScaleProcessButton.Enabled = false;
            this.GrayScaleProcessButton.Location = new System.Drawing.Point(771, 35);
            this.GrayScaleProcessButton.Name = "GrayScaleProcessButton";
            this.GrayScaleProcessButton.Size = new System.Drawing.Size(75, 23);
            this.GrayScaleProcessButton.TabIndex = 1;
            this.GrayScaleProcessButton.Text = "Process";
            this.GrayScaleProcessButton.UseVisualStyleBackColor = true;
            this.GrayScaleProcessButton.Click += new System.EventHandler(this.GrayScaleProcessButton_Click);
            // 
            // ShowResultImageButton
            // 
            this.ShowResultImageButton.Enabled = false;
            this.ShowResultImageButton.Location = new System.Drawing.Point(771, 81);
            this.ShowResultImageButton.Name = "ShowResultImageButton";
            this.ShowResultImageButton.Size = new System.Drawing.Size(75, 23);
            this.ShowResultImageButton.TabIndex = 2;
            this.ShowResultImageButton.Text = "Result";
            this.ShowResultImageButton.UseVisualStyleBackColor = true;
            this.ShowResultImageButton.Click += new System.EventHandler(this.ShowResultImageButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 292);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(371, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(501, 35);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 214);
            this.trackBar1.TabIndex = 4;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(594, 35);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 214);
            this.trackBar2.TabIndex = 5;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(687, 35);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(45, 214);
            this.trackBar3.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(479, 255);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Weight1Button
            // 
            this.Weight1Button.Location = new System.Drawing.Point(479, 12);
            this.Weight1Button.Name = "Weight1Button";
            this.Weight1Button.Size = new System.Drawing.Size(67, 23);
            this.Weight1Button.TabIndex = 8;
            this.Weight1Button.Text = "Show";
            this.Weight1Button.UseVisualStyleBackColor = true;
            this.Weight1Button.Click += new System.EventHandler(this.Weight1Button_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(572, 255);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 20);
            this.textBox2.TabIndex = 9;
            // 
            // Weight2Button
            // 
            this.Weight2Button.Location = new System.Drawing.Point(572, 12);
            this.Weight2Button.Name = "Weight2Button";
            this.Weight2Button.Size = new System.Drawing.Size(67, 23);
            this.Weight2Button.TabIndex = 10;
            this.Weight2Button.Text = "Show";
            this.Weight2Button.UseVisualStyleBackColor = true;
            this.Weight2Button.Click += new System.EventHandler(this.Weight2Button_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(665, 255);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 20);
            this.textBox3.TabIndex = 11;
            // 
            // Weight3Button
            // 
            this.Weight3Button.Location = new System.Drawing.Point(665, 12);
            this.Weight3Button.Name = "Weight3Button";
            this.Weight3Button.Size = new System.Drawing.Size(67, 23);
            this.Weight3Button.TabIndex = 12;
            this.Weight3Button.Text = "Show";
            this.Weight3Button.UseVisualStyleBackColor = true;
            this.Weight3Button.Click += new System.EventHandler(this.Weight3Button_Click);
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.Location = new System.Drawing.Point(771, 161);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(75, 23);
            this.LoadImageButton.TabIndex = 13;
            this.LoadImageButton.Text = "Load";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // KMeansButton
            // 
            this.KMeansButton.Enabled = false;
            this.KMeansButton.Location = new System.Drawing.Point(79, 568);
            this.KMeansButton.Name = "KMeansButton";
            this.KMeansButton.Size = new System.Drawing.Size(220, 28);
            this.KMeansButton.TabIndex = 14;
            this.KMeansButton.Text = "K-means";
            this.KMeansButton.UseVisualStyleBackColor = true;
            this.KMeansButton.Click += new System.EventHandler(this.KMeansButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(425, 292);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(371, 260);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // KMeansTextBox
            // 
            this.KMeansTextBox.Location = new System.Drawing.Point(440, 573);
            this.KMeansTextBox.Name = "KMeansTextBox";
            this.KMeansTextBox.Size = new System.Drawing.Size(50, 20);
            this.KMeansTextBox.TabIndex = 16;
            // 
            // KMeansLabel
            // 
            this.KMeansLabel.AutoSize = true;
            this.KMeansLabel.Location = new System.Drawing.Point(337, 576);
            this.KMeansLabel.Name = "KMeansLabel";
            this.KMeansLabel.Size = new System.Drawing.Size(97, 13);
            this.KMeansLabel.TabIndex = 17;
            this.KMeansLabel.Text = "Number of classes:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 697);
            this.Controls.Add(this.KMeansLabel);
            this.Controls.Add(this.KMeansTextBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.KMeansButton);
            this.Controls.Add(this.LoadImageButton);
            this.Controls.Add(this.Weight3Button);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Weight2Button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Weight1Button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ShowResultImageButton);
            this.Controls.Add(this.GrayScaleProcessButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "K-means";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button GrayScaleProcessButton;
        private System.Windows.Forms.Button ShowResultImageButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Weight1Button;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Weight2Button;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Weight3Button;
        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button KMeansButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox KMeansTextBox;
        private System.Windows.Forms.Label KMeansLabel;
    }
}

