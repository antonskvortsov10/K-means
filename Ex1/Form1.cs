﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Bitmap bmp = new Bitmap("C:\\Users\\Anton\\source\\repos\\K-means\\Izmaylovo_2014.bmp");
        Bitmap bmp = null;
        byte i1, i2, i3;
        Image MemForImage;

        

        private void LoadImage(bool Bmp)
        {
            // openFileDialog1.InitialDirectory = "C:\\Users\\Anton\\source\\repos\\K-means";
            openFileDialog1.InitialDirectory = "";

            if (Bmp)
                openFileDialog1.Filter = "image (BMP) files (*.bmp)|*.bmp|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MemForImage = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = MemForImage;
                    bmp = (Bitmap)pictureBox1.Image;
                    GrayScaleProcessButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось загрузить файл: " + ex.Message);
                }
            }
        }

        private void GrayScaleProcessButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            double N1, N2, N3;
            N1 = RTrackBar.Value;
            N2 = GTrackBar.Value;
            N3 = BTrackBar.Value;
            bool ok = true;
            if (N1 == 0 && N2 == 0 && N3 == 0)
                ok = false;
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color col = bmp.GetPixel(x, y);
                    byte r, g, b;
                    r = col.R;
                    g = col.G;
                    b = col.B;
                    byte gray;

                    if (ok)
                        // Formula using input coefficients:
                        gray = (byte)((N1 / (N1 + N2 + N3)) * r + (N2 / (N1 + N2 + N3)) * g + (N3 / (N1 + N2 + N3)) * b);
                    else
                        // Standart formula for conversion:
                        // byte gray = (byte)(0.3 * r + 0.59 * g + 0.11 * b);
                        gray = (byte)(0.3 * r + 0.59 * g + 0.11 * b);
                    bmp.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            ShowResultImageButton.Enabled = true;
        }

        private void ShowResultImageButton_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = bmp;
            KMeansButton.Enabled = true;
        }

        private void RButton_Click(object sender, EventArgs e)
        {
            i1 = (byte)RTrackBar.Value;
            RTextBox.Text = Convert.ToString(i1);
        }

        private void GButton_Click(object sender, EventArgs e)
        {
            i2 = (byte)GTrackBar.Value;
            GTextBox.Text = Convert.ToString(i2);
        }

        private void BButton_Click(object sender, EventArgs e)
        {
            i3 = (byte)BTrackBar.Value;
            BTextBox.Text = Convert.ToString(i3);
        }

        private void KMeansTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 || number == '0' && KMeansTextBox.Text == "")
            {
                e.Handled = true;
            }
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            LoadImage(true);
        }

        private void KMeansButton_Click(object sender, EventArgs e)
        {
            Bitmap I = (Bitmap)pictureBox2.Image;
            Bitmap newI = new Bitmap(bmp);
            int k = Convert.ToInt32(KMeansTextBox.Text), n = 20; // int k = 2, n = 20;
            List<List<int>> dist = new List<List<int>>();
            Random rnd = new Random();
            int[] Ck = new int[k];
            for (int i = 0; i < k; i++)
                Ck[i] = rnd.Next(0, 255);
            for (int x = 0; x < I.Width; x++)
            {
                dist.Add(new List<int>());
                for (int y = 0; y < I.Height; y++)
                {
                    dist[x].Add(0);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int x = 0; x < I.Width; x++)
                {
                    for (int y = 0; y < I.Height; y++)
                    {
                        int[] distk = new int[k];
                        for (int j = 0; j < k; j++)
                            distk[j] = Math.Abs(newI.GetPixel(x, y).R - Ck[j]);
                        int numC = 0;
                        for (int j = 1; j < k; j++)
                            if (distk[j] < distk[numC])
                                numC = j;
                        dist[x][y] = numC;
                    }
                }
                if (i == n - 1)
                    break;
                for (int j = 0; j < k; j++)
                    Ck[j] = 0;
                int[] countk = new int[k];
                for (int j = 0; j < k; j++)
                    countk[j] = 0;
                for (int x = 0; x < I.Width; x++)
                {
                    for (int y = 0; y < I.Height; y++)
                    {
                        Ck[dist[x][y]] += newI.GetPixel(x, y).R;
                        countk[dist[x][y]] += 1;
                    }
                }
                for (int j = 0; j < k; j++)
                    Ck[j] = (int)(Ck[j] / countk[j]);
            }
            for (int x = 0; x < I.Width; x++)
            {
                for (int y = 0; y < I.Height; y++)
                {
                    newI.SetPixel(x, y, Color.FromArgb(Ck[dist[x][y]], Ck[dist[x][y]], Ck[dist[x][y]]));
                }
            }
            pictureBox3.Image = newI;
        }
    }
}
