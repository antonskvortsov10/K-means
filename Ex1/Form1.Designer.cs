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
            this.RTrackBar = new System.Windows.Forms.TrackBar();
            this.GTrackBar = new System.Windows.Forms.TrackBar();
            this.BTrackBar = new System.Windows.Forms.TrackBar();
            this.RTextBox = new System.Windows.Forms.TextBox();
            this.RButton = new System.Windows.Forms.Button();
            this.GTextBox = new System.Windows.Forms.TextBox();
            this.GButton = new System.Windows.Forms.Button();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.BButton = new System.Windows.Forms.Button();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.KMeansButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.KMeansTextBox = new System.Windows.Forms.TextBox();
            this.KMeansLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTrackBar)).BeginInit();
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
            // RTrackBar
            // 
            this.RTrackBar.Location = new System.Drawing.Point(501, 35);
            this.RTrackBar.Maximum = 255;
            this.RTrackBar.Name = "RTrackBar";
            this.RTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RTrackBar.Size = new System.Drawing.Size(45, 214);
            this.RTrackBar.TabIndex = 4;
            // 
            // GTrackBar
            // 
            this.GTrackBar.Location = new System.Drawing.Point(594, 35);
            this.GTrackBar.Maximum = 255;
            this.GTrackBar.Name = "GTrackBar";
            this.GTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.GTrackBar.Size = new System.Drawing.Size(45, 214);
            this.GTrackBar.TabIndex = 5;
            // 
            // BTrackBar
            // 
            this.BTrackBar.Location = new System.Drawing.Point(687, 35);
            this.BTrackBar.Maximum = 255;
            this.BTrackBar.Name = "BTrackBar";
            this.BTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BTrackBar.Size = new System.Drawing.Size(45, 214);
            this.BTrackBar.TabIndex = 6;
            // 
            // RTextBox
            // 
            this.RTextBox.Location = new System.Drawing.Point(479, 255);
            this.RTextBox.Name = "RTextBox";
            this.RTextBox.ReadOnly = true;
            this.RTextBox.Size = new System.Drawing.Size(67, 20);
            this.RTextBox.TabIndex = 7;
            // 
            // RButton
            // 
            this.RButton.Location = new System.Drawing.Point(479, 12);
            this.RButton.Name = "RButton";
            this.RButton.Size = new System.Drawing.Size(67, 23);
            this.RButton.TabIndex = 8;
            this.RButton.Text = "Show";
            this.RButton.UseVisualStyleBackColor = true;
            this.RButton.Click += new System.EventHandler(this.RButton_Click);
            // 
            // GTextBox
            // 
            this.GTextBox.Location = new System.Drawing.Point(572, 255);
            this.GTextBox.Name = "GTextBox";
            this.GTextBox.ReadOnly = true;
            this.GTextBox.Size = new System.Drawing.Size(67, 20);
            this.GTextBox.TabIndex = 9;
            // 
            // GButton
            // 
            this.GButton.Location = new System.Drawing.Point(572, 12);
            this.GButton.Name = "GButton";
            this.GButton.Size = new System.Drawing.Size(67, 23);
            this.GButton.TabIndex = 10;
            this.GButton.Text = "Show";
            this.GButton.UseVisualStyleBackColor = true;
            this.GButton.Click += new System.EventHandler(this.GButton_Click);
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(665, 255);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.ReadOnly = true;
            this.BTextBox.Size = new System.Drawing.Size(67, 20);
            this.BTextBox.TabIndex = 11;
            // 
            // BButton
            // 
            this.BButton.Location = new System.Drawing.Point(665, 12);
            this.BButton.Name = "BButton";
            this.BButton.Size = new System.Drawing.Size(67, 23);
            this.BButton.TabIndex = 12;
            this.BButton.Text = "Show";
            this.BButton.UseVisualStyleBackColor = true;
            this.BButton.Click += new System.EventHandler(this.BButton_Click);
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
            this.KMeansTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KMeansTextBox_KeyPress);
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
            this.Controls.Add(this.BButton);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.GButton);
            this.Controls.Add(this.GTextBox);
            this.Controls.Add(this.RButton);
            this.Controls.Add(this.RTextBox);
            this.Controls.Add(this.BTrackBar);
            this.Controls.Add(this.GTrackBar);
            this.Controls.Add(this.RTrackBar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ShowResultImageButton);
            this.Controls.Add(this.GrayScaleProcessButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "K-means";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button GrayScaleProcessButton;
        private System.Windows.Forms.Button ShowResultImageButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar RTrackBar;
        private System.Windows.Forms.TrackBar GTrackBar;
        private System.Windows.Forms.TrackBar BTrackBar;
        private System.Windows.Forms.TextBox RTextBox;
        private System.Windows.Forms.Button RButton;
        private System.Windows.Forms.TextBox GTextBox;
        private System.Windows.Forms.Button GButton;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.Button BButton;
        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button KMeansButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox KMeansTextBox;
        private System.Windows.Forms.Label KMeansLabel;
    }
}

