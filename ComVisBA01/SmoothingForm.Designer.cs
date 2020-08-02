namespace ComVisBA01
{
    partial class SmoothingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmoothingForm));
            this.levelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.levelLabel = new System.Windows.Forms.Label();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.levelNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // levelNumericUpDown
            // 
            this.levelNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.levelNumericUpDown.Increment = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.levelNumericUpDown.Location = new System.Drawing.Point(170, 234);
            this.levelNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.levelNumericUpDown.Name = "levelNumericUpDown";
            this.levelNumericUpDown.Size = new System.Drawing.Size(96, 23);
            this.levelNumericUpDown.TabIndex = 31;
            this.levelNumericUpDown.ValueChanged += new System.EventHandler(this.levelNumericUpDown_ValueChanged);
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Gaussian",
            "Median",
            "Bilateral"});
            this.typeComboBox.Location = new System.Drawing.Point(170, 201);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(142, 26);
            this.typeComboBox.TabIndex = 29;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.levelLabel.Location = new System.Drawing.Point(76, 236);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(47, 17);
            this.levelLabel.TabIndex = 27;
            this.levelLabel.Text = "Level";
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chooseLabel.Location = new System.Drawing.Point(30, 204);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(105, 18);
            this.chooseLabel.TabIndex = 26;
            this.chooseLabel.Text = "Choose One : ";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(191, 311);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(152, 28);
            this.titleLabel.TabIndex = 25;
            this.titleLabel.Text = "PhotoRush";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Turquoise;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveButton.Location = new System.Drawing.Point(181, 274);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(135, 30);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "Save Image";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
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
            // SmoothingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(342, 348);
            this.Controls.Add(this.levelNumericUpDown);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureBox);
            this.Name = "SmoothingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhotoRush - Smoothing";
            this.Load += new System.EventHandler(this.SmoothingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.levelNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown levelNumericUpDown;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.PictureBox pictureBox;
    }
}