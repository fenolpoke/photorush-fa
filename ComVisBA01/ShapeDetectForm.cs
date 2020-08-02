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
    public partial class ShapeDetectForm : Form
    {
        Image<Bgr, byte> original, copy;
        Image<Gray, byte> gray;

        public ShapeDetectForm()
        {
            InitializeComponent();

        }


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


        private void circlesRadioButton_Click(object sender, EventArgs e)
        {

            CvInvoke.cvCvtColor(original, gray, COLOR_CONVERSION.CV_BGR2GRAY);

            CircleF[] circles = gray.HoughCircles(new Gray(100), new Gray(80), 2, 100, 200, 0)[0];

            copy = original.Clone();

            if (circles.Length == 0) MessageBox.Show("Lingkaran 0");

            foreach (CircleF circle in circles)
            {
                copy.Draw(circle, new Bgr(Color.Khaki), 5);
            }

            pictureBox1.Image = copy.ToBitmap();
        }

        public void linesRadioButton_Click(object sender, EventArgs e)
        {
            LineSegment2D[] lines = gray.HoughLinesBinary(1, Math.PI / 180, 60, 10, 10)[0];

                copy = original.Clone();

                foreach (LineSegment2D line in lines)
                {
                    copy.Draw(line, new Bgr(Color.Gold), 5);
                }

                pictureBox1.Image = copy.ToBitmap();
            }

        private void ShapeDetectForm_Load(object sender, EventArgs e)
        {

            original = new Image<Bgr,byte>(new Bitmap( pictureBox1.Image));
            copy = new Image<Bgr, byte>(original.Width, original.Height);
            gray = new Image<Gray, byte>(original.Width, original.Height);
            CvInvoke.cvCvtColor(original, gray, COLOR_CONVERSION.CV_BGR2GRAY);
            CvInvoke.cvCanny(gray, gray, 50, 200, 3);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            saveFileDialog1.InitialDirectory = @"D:\";
            saveFileDialog1.FileName = "Shape detection.jpeg";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
                MessageBox.Show("Image saved to " + saveFileDialog1.FileName);
            }
        }

        private void linesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(linesRadioButton.Checked)
            {
                LineSegment2D[] lines = gray.HoughLinesBinary(1, Math.PI / 180, 60, 10, 10)[0];

                    copy = original.Clone();

                    foreach (LineSegment2D line in lines)
                    {
                        copy.Draw(line, new Bgr(Color.Gold), 5);
                    }

                    pictureBox1.Image = copy.ToBitmap();
                }
            }

        private void circlesRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (circlesRadioButton.Checked)
            {

                CircleF[] circles = gray.HoughCircles(new Gray(100), new Gray(80), 2, 100, 200, 0)[0];

                copy = original.Clone();

                if (circles.Length == 0) MessageBox.Show("Lingkaran 0");

                foreach (CircleF circle in circles)
                {
                    copy.Draw(circle, new Bgr(Color.Khaki), 5);
                }

                pictureBox1.Image = copy.ToBitmap();
            }

        }

        private void rectsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rectsRadioButton.Checked)
            {
                copy = original.Clone();
                Shapedetection(gray, 4);
                foreach (MCvBox2D rect in boxList)
                {
                    copy.Draw(rect, new Bgr(Color.Azure), 10);
                }
                pictureBox1.Image = copy.ToBitmap();
            }

        }

        private void triangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (triangleRadioButton.Checked)
            {
                copy = original.Clone();
                Shapedetection(gray, 3);
                foreach (Triangle2DF triangle in triList)
                {
                    copy.Draw(triangle, new Bgr(Color.LightBlue), 10);
                }
                pictureBox1.Image = copy.ToBitmap();
            }
        }
        

    }
}
