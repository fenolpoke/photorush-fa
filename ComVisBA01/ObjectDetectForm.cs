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
    public partial class ObjectDetectForm : Form
    {
        Image<Bgr, Byte> original, copy;
        Image<Gray, Byte> gray;
        Boolean faceDetect, eyeDetect;

        public Capture cap, video ,webcam;

        HaarCascade face = new HaarCascade("haarcascade_frontalface_default.xml");
        HaarCascade eye = new HaarCascade("haarcascade_frontalface_default.xml");

        public ObjectDetectForm()
        {
            InitializeComponent();
        }

        private void ObjectDetectForm_Load(object sender, EventArgs e)
        {
            original = new Image<Bgr, byte>(new Bitmap(pictureBox.Image));
            gray = new Image<Gray, byte>(original.Width, original.Height);
            CvInvoke.cvCvtColor(original, gray, COLOR_CONVERSION.CV_BGR2GRAY);

            if (cap != null)
            {
                video = cap;
                videoRadioButton.Checked = true;
                timer1.Start();
            }
            else
            {
                videoRadioButton.Visible = false;
            }
            faceDetect = eyeDetect = false;
            eyesFacesRadioButton.Checked = eyesRadioButton.Checked = facesRadioButton.Checked = false;
        }

        private void detect()
        {
            if (original != null)
            {
                copy = original.Clone();
                gray = new Image<Gray, byte>(original.Width, original.Height);
                CvInvoke.cvCvtColor(original, gray, COLOR_CONVERSION.CV_BGR2GRAY);

                if (faceDetect)
                {
                    foreach (MCvAvgComp f in face.Detect(gray))
                    {
                        copy.Draw(f.rect, new Bgr(Color.LightGray), 10);
                    }
                }
                if (eyeDetect)
                {

                    foreach (MCvAvgComp e in eye.Detect(gray))
                    {
                        copy.Draw(e.rect, new Bgr(Color.LightSalmon), 10);
                    }
                }
                pictureBox.Image = copy.ToBitmap();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            original = cap.QueryFrame();
            detect();
        }

        private void cameraRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cameraRadioButton.Checked && videoRadioButton.Visible)
            {
                webcam = new Capture();
                if (webcam != null)
                {
                    cap = webcam;
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("No camera found!");
                }
            }
        }

        private void eyesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (eyesRadioButton.Checked)
            {
                eyeDetect = true;
                faceDetect = false;
                detect();
            }
        }

        private void facesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (facesRadioButton.Checked)
            {
                faceDetect = true;
                eyeDetect = false;
                detect();
            }
        }

        private void eyesFacesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (eyesFacesRadioButton.Checked)
            {
                faceDetect = eyeDetect = true;
                detect();
            }
        }

        private void videoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (videoRadioButton.Checked)
            {
                cap = video;
                timer1.Start();
            }
        }
    }
}
