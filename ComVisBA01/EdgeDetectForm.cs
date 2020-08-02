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
    public partial class EdgeDetectForm : Form
    {
        Image<Gray, Byte> gray, edge;

        public EdgeDetectForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "@D:/";
            saveFileDialog1.FileName = (typeComboBox.SelectedIndex == 0) ? "sobel.jpeg" : (typeComboBox.SelectedIndex == 1) ? "canny.jpeg" : "laplace.jpeg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                pictureBox.Image.Save(saveFileDialog1.FileName);
                MessageBox.Show("Image saved into " + saveFileDialog1.FileName);
            }
        }

        private void edgeDetect()
        {
            if (gray != null)
            {
                Double low = (Double)lowNumericUpDown.Value, high = (Double)highNumericUpDown.Value;
                if (low <= 0 || low % 2 == 0) low = 127;
                if (high <= 0 || high % 2 == 0) high = 255;

                switch (typeComboBox.SelectedIndex)
                {
                    case 0:
                        CvInvoke.cvSobel(gray, edge,0,1,3);
                        break;
                    case 1:
                        CvInvoke.cvCanny(gray, edge, low, high, 3);
                        break;
                    case 2:
                        CvInvoke.cvLaplace(gray, edge, 3);
                        break;
                }
                pictureBox.Image = edge.ToBitmap();
            }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            edgeDetect();
        }

        private void EdgeDetectForm_Load(object sender, EventArgs e)
        {
            gray = new Image<Gray, byte>(new Bitmap(pictureBox.Image));
            edge = new Image<Gray, byte>(gray.Width, gray.Height);
            CvInvoke.cvThreshold(gray, edge, 127, 255, THRESH.CV_THRESH_BINARY);
            typeComboBox.SelectedIndex = 0;
        }

        private void highNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            edgeDetect();
        }

        private void lowNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            edgeDetect();
        }
    }
}
