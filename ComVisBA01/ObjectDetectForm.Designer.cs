namespace ComVisBA01
{
    partial class ObjectDetectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectDetectForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.videoRadioButton = new System.Windows.Forms.RadioButton();
            this.cameraRadioButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eyesFacesRadioButton = new System.Windows.Forms.RadioButton();
            this.facesRadioButton = new System.Windows.Forms.RadioButton();
            this.eyesRadioButton = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(180, 272);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(152, 28);
            this.titleLabel.TabIndex = 25;
            this.titleLabel.Text = "PhotoRush";
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
            this.pictureBox.TabIndex = 23;
            this.pictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.videoRadioButton);
            this.panel1.Controls.Add(this.cameraRadioButton);
            this.panel1.Location = new System.Drawing.Point(32, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 33);
            this.panel1.TabIndex = 26;
            // 
            // videoRadioButton
            // 
            this.videoRadioButton.AutoSize = true;
            this.videoRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.videoRadioButton.Location = new System.Drawing.Point(153, 6);
            this.videoRadioButton.Name = "videoRadioButton";
            this.videoRadioButton.Size = new System.Drawing.Size(67, 21);
            this.videoRadioButton.TabIndex = 0;
            this.videoRadioButton.TabStop = true;
            this.videoRadioButton.Text = "Video";
            this.videoRadioButton.UseVisualStyleBackColor = true;
            this.videoRadioButton.CheckedChanged += new System.EventHandler(this.videoRadioButton_CheckedChanged);
            // 
            // cameraRadioButton
            // 
            this.cameraRadioButton.AutoSize = true;
            this.cameraRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cameraRadioButton.Location = new System.Drawing.Point(58, 6);
            this.cameraRadioButton.Name = "cameraRadioButton";
            this.cameraRadioButton.Size = new System.Drawing.Size(81, 21);
            this.cameraRadioButton.TabIndex = 0;
            this.cameraRadioButton.TabStop = true;
            this.cameraRadioButton.Text = "Camera";
            this.cameraRadioButton.UseVisualStyleBackColor = true;
            this.cameraRadioButton.CheckedChanged += new System.EventHandler(this.cameraRadioButton_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.eyesFacesRadioButton);
            this.panel2.Controls.Add(this.facesRadioButton);
            this.panel2.Controls.Add(this.eyesRadioButton);
            this.panel2.Location = new System.Drawing.Point(32, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 33);
            this.panel2.TabIndex = 26;
            // 
            // eyesFacesRadioButton
            // 
            this.eyesFacesRadioButton.AutoSize = true;
            this.eyesFacesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.eyesFacesRadioButton.Location = new System.Drawing.Point(143, 6);
            this.eyesFacesRadioButton.Name = "eyesFacesRadioButton";
            this.eyesFacesRadioButton.Size = new System.Drawing.Size(141, 21);
            this.eyesFacesRadioButton.TabIndex = 0;
            this.eyesFacesRadioButton.TabStop = true;
            this.eyesFacesRadioButton.Text = "Eyes and Faces";
            this.eyesFacesRadioButton.UseVisualStyleBackColor = true;
            this.eyesFacesRadioButton.CheckedChanged += new System.EventHandler(this.eyesFacesRadioButton_CheckedChanged);
            // 
            // facesRadioButton
            // 
            this.facesRadioButton.AutoSize = true;
            this.facesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.facesRadioButton.Location = new System.Drawing.Point(70, 6);
            this.facesRadioButton.Name = "facesRadioButton";
            this.facesRadioButton.Size = new System.Drawing.Size(69, 21);
            this.facesRadioButton.TabIndex = 0;
            this.facesRadioButton.TabStop = true;
            this.facesRadioButton.Text = "Faces";
            this.facesRadioButton.UseVisualStyleBackColor = true;
            this.facesRadioButton.CheckedChanged += new System.EventHandler(this.facesRadioButton_CheckedChanged);
            // 
            // eyesRadioButton
            // 
            this.eyesRadioButton.AutoSize = true;
            this.eyesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.eyesRadioButton.Location = new System.Drawing.Point(3, 6);
            this.eyesRadioButton.Name = "eyesRadioButton";
            this.eyesRadioButton.Size = new System.Drawing.Size(61, 21);
            this.eyesRadioButton.TabIndex = 0;
            this.eyesRadioButton.TabStop = true;
            this.eyesRadioButton.Text = "Eyes";
            this.eyesRadioButton.UseVisualStyleBackColor = true;
            this.eyesRadioButton.CheckedChanged += new System.EventHandler(this.eyesRadioButton_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ObjectDetectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(342, 303);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox);
            this.Name = "ObjectDetectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhotoRush - Face Detection";
            this.Load += new System.EventHandler(this.ObjectDetectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton videoRadioButton;
        private System.Windows.Forms.RadioButton cameraRadioButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton eyesFacesRadioButton;
        private System.Windows.Forms.RadioButton facesRadioButton;
        private System.Windows.Forms.RadioButton eyesRadioButton;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox pictureBox;
    }
}