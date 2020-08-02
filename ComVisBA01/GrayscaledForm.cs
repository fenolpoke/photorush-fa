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
    public partial class GrayscaledForm : Form
    {
        public Capture cap;
        public GrayscaledForm()
        {
            InitializeComponent();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"D:\";
            saveFileDialog1.FileName = "Grayscaled.jpeg";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                pictureBox.Image.Save(saveFileDialog1.FileName);
                MessageBox.Show("Iamge saved into "+saveFileDialog1.FileName);
            }
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cap.QueryGrayFrame() != null)
            {
                pictureBox.Image = cap.QueryGrayFrame().ToBitmap();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void GrayscaledForm_Load(object sender, EventArgs e)
        {

            if (cap != null)
            {
                timer1.Start();
                saveButton.Visible = false;
            }
        }
    }
}
