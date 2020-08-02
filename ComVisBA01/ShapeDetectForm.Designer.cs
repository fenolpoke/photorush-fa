namespace ComVisBA01
{
    partial class ShapeDetectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShapeDetectForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linesRadioButton = new System.Windows.Forms.RadioButton();
            this.circlesRadioButton = new System.Windows.Forms.RadioButton();
            this.rectsRadioButton = new System.Windows.Forms.RadioButton();
            this.triangleRadioButton = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(190, 319);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(152, 28);
            this.titleLabel.TabIndex = 25;
            this.titleLabel.Text = "PhotoRush";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Turquoise;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveButton.Location = new System.Drawing.Point(195, 276);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(135, 30);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "Save Image";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // linesRadioButton
            // 
            this.linesRadioButton.AutoSize = true;
            this.linesRadioButton.Checked = true;
            this.linesRadioButton.Location = new System.Drawing.Point(83, 216);
            this.linesRadioButton.Name = "linesRadioButton";
            this.linesRadioButton.Size = new System.Drawing.Size(50, 17);
            this.linesRadioButton.TabIndex = 26;
            this.linesRadioButton.TabStop = true;
            this.linesRadioButton.Text = "Lines";
            this.linesRadioButton.UseVisualStyleBackColor = true;
            this.linesRadioButton.CheckedChanged += new System.EventHandler(this.linesRadioButton_CheckedChanged);
            this.linesRadioButton.Click += new System.EventHandler(this.linesRadioButton_Click);
            // 
            // circlesRadioButton
            // 
            this.circlesRadioButton.AutoSize = true;
            this.circlesRadioButton.Location = new System.Drawing.Point(203, 216);
            this.circlesRadioButton.Name = "circlesRadioButton";
            this.circlesRadioButton.Size = new System.Drawing.Size(56, 17);
            this.circlesRadioButton.TabIndex = 26;
            this.circlesRadioButton.Text = "Circles";
            this.circlesRadioButton.UseVisualStyleBackColor = true;
            this.circlesRadioButton.CheckedChanged += new System.EventHandler(this.circlesRadioButton_CheckedChanged);
            this.circlesRadioButton.Click += new System.EventHandler(this.circlesRadioButton_Click);
            // 
            // rectsRadioButton
            // 
            this.rectsRadioButton.AutoSize = true;
            this.rectsRadioButton.Location = new System.Drawing.Point(83, 239);
            this.rectsRadioButton.Name = "rectsRadioButton";
            this.rectsRadioButton.Size = new System.Drawing.Size(53, 17);
            this.rectsRadioButton.TabIndex = 26;
            this.rectsRadioButton.Text = "Rects";
            this.rectsRadioButton.UseVisualStyleBackColor = true;
            this.rectsRadioButton.CheckedChanged += new System.EventHandler(this.rectsRadioButton_CheckedChanged);
            // 
            // triangleRadioButton
            // 
            this.triangleRadioButton.AutoSize = true;
            this.triangleRadioButton.Location = new System.Drawing.Point(203, 239);
            this.triangleRadioButton.Name = "triangleRadioButton";
            this.triangleRadioButton.Size = new System.Drawing.Size(63, 17);
            this.triangleRadioButton.TabIndex = 26;
            this.triangleRadioButton.Text = "Triangle";
            this.triangleRadioButton.UseVisualStyleBackColor = true;
            this.triangleRadioButton.CheckedChanged += new System.EventHandler(this.triangleRadioButton_CheckedChanged);
            // 
            // ShapeDetectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(342, 350);
            this.Controls.Add(this.triangleRadioButton);
            this.Controls.Add(this.rectsRadioButton);
            this.Controls.Add(this.circlesRadioButton);
            this.Controls.Add(this.linesRadioButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ShapeDetectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhotoRush - Shape Detection";
            this.Load += new System.EventHandler(this.ShapeDetectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RadioButton rectsRadioButton;
        private System.Windows.Forms.RadioButton triangleRadioButton;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.RadioButton circlesRadioButton;
        public System.Windows.Forms.RadioButton linesRadioButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}