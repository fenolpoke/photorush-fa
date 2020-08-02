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
    public partial class HomePage : Form
    {
        Image<Bgr, byte> original, copy;
        Image<Gray, byte> gray;

        Capture cap;
        bool isStart = false, isDetect = false;

        HaarCascade cascade = new HaarCascade("haarcascade_frontalface_default.xml");

        List<Triangle2DF> triList = new List<Triangle2DF>();
        List<MCvBox2D> boxList = new List<MCvBox2D>();
        MemStorage storage = new MemStorage();

        void Shapedetection(Image<Gray, byte> img, int contour)
        {
            boxList.Clear();
            triList.Clear();
            for (Contour<Point> con = img.FindContours(); con != null; con = con.HNext)
            {
                Contour<Point> con2 = con.ApproxPoly(con.Perimeter * 0.16, storage);
                if (con.Area > 250)
                {
                    //Triangle
                    if (contour == 3)
                    {
                        if (con2.Total == 3)
                        {
                            Point[] pts = con2.ToArray();
                            triList.Add(new Triangle2DF(pts[0], pts[1], pts[2]));
                        }
                    }
                    //Rectangle
                    else if (contour == 4)
                    {
                        if (con2.Total == 4)
                        {
                            bool isRect = true;
                            Point[] pts = con2.ToArray();
                            LineSegment2D[] edge = PointCollection.PolyLine(pts, true);

                            for (int i = 0; i < edge.Length; i++)
                            {
                                double angle = Math.Abs(edge[(i + 1) % edge.Length].GetExteriorAngleDegree(edge[i]));
                                if (angle < 80 || angle > 100)
                                {
                                    isRect = false;
                                    break;
                                }
                            }
                            if (isRect) boxList.Add(con2.GetMinAreaRect());
                        }
                    }
                }
            }
        }

        public HomePage()
        {
            InitializeComponent();
            cap = null;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            grayscaleButton.Enabled = false;
            thresholdButton.Enabled = false;
            smoothingButton.Enabled = false;
            shapeDetectButton.Enabled = false;
            objectDetectButton.Enabled = false;
            edgeDetectButton.Enabled = false;
        }

        public void browseImageButton_Click(object sender, EventArgs e)
        {
             if (openFileDialog1.ShowDialog() == DialogResult.OK) //open image
            {
                timer1.Stop();
                isStart = false;
                isDetect = false;

                original = new Image<Bgr, byte>(openFileDialog1.FileName);
                copy = new Image<Bgr, byte>(original.Width, original.Height);
                gray = new Image<Gray, byte>(original.Width, original.Height);

                pictureBox.Image = original.ToBitmap();

                label1.Text = openFileDialog1.SafeFileName;
                cap = null;

                grayscaleButton.Enabled = true;
                thresholdButton.Enabled = true;
                smoothingButton.Enabled = true;
                shapeDetectButton.Enabled = true;
                objectDetectButton.Enabled = true;
                edgeDetectButton.Enabled = true;
            }
    }

        Image<Bgr, byte> detect(Image<Bgr, byte> edit)
        {
            gray = new Image<Gray, byte>(edit.Width, edit.Height);
            CvInvoke.cvCvtColor(original, gray, COLOR_CONVERSION.CV_BGR2GRAY);
            var faces = cascade.Detect(gray);
            edit = edit.Clone();
            foreach (var face in faces)
            {
                edit.Draw(face.rect, new Bgr(Color.Aqua), 5);
            }

            return edit;
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
             if (isStart)
            {
                original = cap.QueryFrame();
                if (original != null)
                {
                    if (isDetect)
                    {
                        original = detect(original);
                    }
                    pictureBox.Image = original.ToBitmap();

                }
                else
                {
                    timer1.Stop();
                    isStart = false;
                }
            }
        }

        private void browseVideoButton_Click(object sender, EventArgs e)
       
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                timer1.Start();
                isStart = true;
                cap = new Capture(openFileDialog2.FileName);
                
                label1.Text = openFileDialog2.SafeFileName;

                thresholdButton.Enabled = false;
                smoothingButton.Enabled = false;
                shapeDetectButton.Enabled = false;
                edgeDetectButton.Enabled = false;

                grayscaleButton.Enabled = true;
                objectDetectButton.Enabled = true;

            }
        }

        private void grayscaleButton_Click(object sender, EventArgs e)
        {
            GrayscaledForm grayscale = new GrayscaledForm();

            if (cap == null)
            {
                CvInvoke.cvCvtColor(original, gray, COLOR_CONVERSION.CV_BGR2GRAY);
                grayscale.pictureBox.Image = gray.ToBitmap();

            }
            else
            {
                grayscale.cap = cap;
            }

//            this.Hide();
            grayscale.ShowDialog();
        }

        private void thresholdButton_Click(object sender, EventArgs e)
        {
            ThresholdForm threshold = new ThresholdForm();
            CvInvoke.cvCvtColor(original, gray, COLOR_CONVERSION.CV_BGR2GRAY);
            threshold.pictureBox.Image = gray.ToBitmap();
            //Dispose();
            threshold.ShowDialog();
        }

        public void shapeDetectButton_Click(object sender, EventArgs e)
        {
            ShapeDetectForm shap = new ShapeDetectForm();
            shap.pictureBox1.Image = copy.ToBitmap();



            if (shap.linesRadioButton.Checked == true)
            {

                LineSegment2D[] lines = gray.HoughLinesBinary(1, Math.PI / 180, 60, 10, 10)[0];

                copy = original.Clone();

                foreach (LineSegment2D line in lines)
                {
                    copy.Draw(line, new Bgr(Color.Gold), 5);
                }

                shap.pictureBox1.Image = copy.ToBitmap();
            }
            //else if (shap.circlesRadioButton_Click())
            //{
            //    CircleF[] circles = gray.HoughCircles(new Gray(100), new Gray(80), 2, 100, 200, 0)[0];

            //    copy = original.Clone();

            //    if (circles.Length == 0) MessageBox.Show("Lingkaran 0");

            //    foreach (CircleF circle in circles)
            //    {
            //        copy.Draw(circle, new Bgr(Color.Khaki), 5);
            //    }

            //    shap.pictureBox.Image = copy.ToBitmap();
            //}




            //Dispose();
            shap.ShowDialog();
        }

        public void circlesRadioButton_Click(object sender, EventArgs e)
        {

        }

        private void smoothingButton_Click(object sender, EventArgs e)
        {
            SmoothingForm smooth = new SmoothingForm();
//            CvInvoke.cvCvtColor(original, gray, COLOR_CONVERSION.CV_BGR2GRAY);
            smooth.pictureBox.Image = original.ToBitmap();
//            Dispose();
            smooth.ShowDialog();
        }

        private void edgeDetectButton_Click(object sender, EventArgs e)
        {
            EdgeDetectForm edge = new EdgeDetectForm();
            edge.pictureBox.Image = gray.ToBitmap();

            edge.ShowDialog();
        }

        private void objectDetectButton_Click(object sender, EventArgs e)
        {
            ObjectDetectForm obj = new ObjectDetectForm();
            obj.cap = cap;
            obj.pictureBox.Image = original.ToBitmap();

            obj.ShowDialog();
        }
       
    }
}
