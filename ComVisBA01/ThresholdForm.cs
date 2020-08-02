using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace ComVisBA01
{
    public partial class ThresholdForm : Form
    {
        Image<Gray,Byte> gray, thresh;

        public ThresholdForm()
        {
            InitializeComponent();
        }

        private void threshold()
        {
            if (gray != null)
            {

                Double low = (Double)lowNumericUpDown.Value, high = (Double)highNumericUpDown.Value;

                if (low <= 0 || low % 2 == 0) low = 127;
                if (high <= 0 || high % 2 == 0) high = 255;

                switch (typeComboBox.SelectedIndex)
                {
                    case 0:
                        CvInvoke.cvThreshold(gray, thresh, low, high, THRESH.CV_THRESH_BINARY);
                        break;
                    case 1:
                        CvInvoke.cvThreshold(gray, thresh, low, high, THRESH.CV_THRESH_BINARY_INV);
                        break;
                    case 2:
                        CvInvoke.cvThreshold(gray, thresh, low, high, THRESH.CV_THRESH_TOZERO);
                        break;
                    case 3:
                        CvInvoke.cvThreshold(gray, thresh, low, high, THRESH.CV_THRESH_TOZERO_INV);
                        break;
                }
                pictureBox.Image = thresh.ToBitmap();
            }
            else
            {
                MessageBox.Show("Gray image missing!");
            }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            threshold();
        }

        private void ThresholdForm_Load(object sender, EventArgs e)
        {
            gray = new Image<Gray,byte>(new Bitmap(pictureBox.Image));
            thresh = new Image<Gray, byte>(gray.Width, gray.Height);
            typeComboBox.SelectedIndex = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"D:\";
            saveFileDialog1.FileName = typeComboBox.SelectedIndex == 0 ? "Binary.jpeg" : typeComboBox.SelectedIndex == 1 ? "Binary Inverse.jpeg" : typeComboBox.SelectedIndex == 2 ? "Zero.jpeg" : "Zero Inverse.jpeg";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                pictureBox.Image.Save(saveFileDialog1.FileName);
                MessageBox.Show("Image saved into "+saveFileDialog1.FileName);
            }
        }

        private void highNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            threshold();
        }

        private void lowNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            threshold();
        }
    }
}
