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
    public partial class SmoothingForm : Form
    {
        Image<Bgr, Byte> original, smooth;
     
        public SmoothingForm()
        {
            InitializeComponent();
            typeComboBox.SelectedIndex = 0;
        }

        private void SmoothingForm_Load(object sender, EventArgs e)
        {
            original = new Image<Bgr,byte>(new Bitmap(pictureBox.Image));
            smooth = new Image<Bgr, byte>(original.Width, original.Height);

            typeComboBox.SelectedIndex = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            saveFileDialog1.InitialDirectory = @"D:\";
            saveFileDialog1.FileName = typeComboBox.SelectedIndex == 0 ? "Gaussian.jpeg" : typeComboBox.SelectedIndex == 1 ? "Median.jpeg" : "Bilateral.jpeg";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                pictureBox.Image.Save(saveFileDialog1.FileName);
                MessageBox.Show("Image saved into "+saveFileDialog1.FileName);
            }
        }

        private void smoothes()
        {
            if (original != null)
            {
                int value = (int)levelNumericUpDown.Value;
                if (value <= 0 || value % 2 == 0) value = 127;

                switch (typeComboBox.SelectedIndex)
                {
                    case 0:
                        CvInvoke.cvSmooth(original, smooth, SMOOTH_TYPE.CV_GAUSSIAN, value, value, 0, 0);
                        break;
                    case 1:
                        CvInvoke.cvSmooth(original, smooth, SMOOTH_TYPE.CV_MEDIAN, value, value, 0, 0);
                        break;
                    case 2:
                        CvInvoke.cvSmooth(original, smooth, SMOOTH_TYPE.CV_MEDIAN, value, value, 0, 0);
                        break;
                }
                pictureBox.Image = smooth.ToBitmap();
            }

        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            smoothes();
        }

        private void levelNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            smoothes();
        }
    }
}
