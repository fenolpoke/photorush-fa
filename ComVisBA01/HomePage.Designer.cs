namespace ComVisBA01
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.grayscaleButton = new System.Windows.Forms.Button();
            this.browseImageButton = new System.Windows.Forms.Button();
            this.thresholdButton = new System.Windows.Forms.Button();
            this.browseVideoButton = new System.Windows.Forms.Button();
            this.smoothingButton = new System.Windows.Forms.Button();
            this.shapeDetectButton = new System.Windows.Forms.Button();
            this.objectDetectButton = new System.Windows.Forms.Button();
            this.edgeDetectButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // grayscaleButton
            // 
            this.grayscaleButton.BackColor = System.Drawing.Color.Turquoise;
            this.grayscaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grayscaleButton.Location = new System.Drawing.Point(32, 295);
            this.grayscaleButton.Name = "grayscaleButton";
            this.grayscaleButton.Size = new System.Drawing.Size(136, 31);
            this.grayscaleButton.TabIndex = 11;
            this.grayscaleButton.Text = "Grayscale";
            this.grayscaleButton.UseVisualStyleBackColor = false;
            this.grayscaleButton.Click += new System.EventHandler(this.grayscaleButton_Click);
            // 
            // browseImageButton
            // 
            this.browseImageButton.BackColor = System.Drawing.Color.Turquoise;
            this.browseImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.browseImageButton.Location = new System.Drawing.Point(32, 197);
            this.browseImageButton.Name = "browseImageButton";
            this.browseImageButton.Size = new System.Drawing.Size(136, 31);
            this.browseImageButton.TabIndex = 11;
            this.browseImageButton.Text = "Browse Image";
            this.browseImageButton.UseVisualStyleBackColor = false;
            this.browseImageButton.Click += new System.EventHandler(this.browseImageButton_Click);
            // 
            // thresholdButton
            // 
            this.thresholdButton.BackColor = System.Drawing.Color.Turquoise;
            this.thresholdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.thresholdButton.Location = new System.Drawing.Point(174, 295);
            this.thresholdButton.Name = "thresholdButton";
            this.thresholdButton.Size = new System.Drawing.Size(136, 31);
            this.thresholdButton.TabIndex = 11;
            this.thresholdButton.Text = "Threshold";
            this.thresholdButton.UseVisualStyleBackColor = false;
            this.thresholdButton.Click += new System.EventHandler(this.thresholdButton_Click);
            // 
            // browseVideoButton
            // 
            this.browseVideoButton.BackColor = System.Drawing.Color.Turquoise;
            this.browseVideoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.browseVideoButton.Location = new System.Drawing.Point(32, 234);
            this.browseVideoButton.Name = "browseVideoButton";
            this.browseVideoButton.Size = new System.Drawing.Size(136, 31);
            this.browseVideoButton.TabIndex = 11;
            this.browseVideoButton.Text = "Browse Video";
            this.browseVideoButton.UseVisualStyleBackColor = false;
            this.browseVideoButton.Click += new System.EventHandler(this.browseVideoButton_Click);
            // 
            // smoothingButton
            // 
            this.smoothingButton.BackColor = System.Drawing.Color.Turquoise;
            this.smoothingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.smoothingButton.Location = new System.Drawing.Point(32, 332);
            this.smoothingButton.Name = "smoothingButton";
            this.smoothingButton.Size = new System.Drawing.Size(136, 31);
            this.smoothingButton.TabIndex = 11;
            this.smoothingButton.Text = "Smoothing ";
            this.smoothingButton.UseVisualStyleBackColor = false;
            this.smoothingButton.Click += new System.EventHandler(this.smoothingButton_Click);
            // 
            // shapeDetectButton
            // 
            this.shapeDetectButton.BackColor = System.Drawing.Color.Turquoise;
            this.shapeDetectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeDetectButton.Location = new System.Drawing.Point(174, 332);
            this.shapeDetectButton.Name = "shapeDetectButton";
            this.shapeDetectButton.Size = new System.Drawing.Size(136, 31);
            this.shapeDetectButton.TabIndex = 11;
            this.shapeDetectButton.Text = "Shape Detection";
            this.shapeDetectButton.UseVisualStyleBackColor = false;
            this.shapeDetectButton.Click += new System.EventHandler(this.shapeDetectButton_Click);
            // 
            // objectDetectButton
            // 
            this.objectDetectButton.BackColor = System.Drawing.Color.Turquoise;
            this.objectDetectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.objectDetectButton.Location = new System.Drawing.Point(32, 369);
            this.objectDetectButton.Name = "objectDetectButton";
            this.objectDetectButton.Size = new System.Drawing.Size(136, 31);
            this.objectDetectButton.TabIndex = 11;
            this.objectDetectButton.Text = "Object Detection";
            this.objectDetectButton.UseVisualStyleBackColor = false;
            this.objectDetectButton.Click += new System.EventHandler(this.objectDetectButton_Click);
            // 
            // edgeDetectButton
            // 
            this.edgeDetectButton.BackColor = System.Drawing.Color.Turquoise;
            this.edgeDetectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edgeDetectButton.Location = new System.Drawing.Point(174, 369);
            this.edgeDetectButton.Name = "edgeDetectButton";
            this.edgeDetectButton.Size = new System.Drawing.Size(136, 31);
            this.edgeDetectButton.TabIndex = 11;
            this.edgeDetectButton.Text = "Edge Detection";
            this.edgeDetectButton.UseVisualStyleBackColor = false;
            this.edgeDetectButton.Click += new System.EventHandler(this.edgeDetectButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(189, 435);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(152, 28);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "PhotoRush";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(174, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Browse Image or Video";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(32, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(278, 179);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image File | *.jpg;*.jpeg;*.png;";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Filter = "Video File | *.mp4;";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(342, 463);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.browseVideoButton);
            this.Controls.Add(this.browseImageButton);
            this.Controls.Add(this.edgeDetectButton);
            this.Controls.Add(this.objectDetectButton);
            this.Controls.Add(this.shapeDetectButton);
            this.Controls.Add(this.smoothingButton);
            this.Controls.Add(this.thresholdButton);
            this.Controls.Add(this.grayscaleButton);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhotoRush - Home";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button grayscaleButton;
        private System.Windows.Forms.Button browseImageButton;
        private System.Windows.Forms.Button thresholdButton;
        private System.Windows.Forms.Button browseVideoButton;
        private System.Windows.Forms.Button smoothingButton;
        private System.Windows.Forms.Button shapeDetectButton;
        private System.Windows.Forms.Button objectDetectButton;
        private System.Windows.Forms.Button edgeDetectButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        public System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}