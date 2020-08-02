namespace ComVisBA01
{
    partial class ThresholdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThresholdForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.highLabel = new System.Windows.Forms.Label();
            this.lowLabel = new System.Windows.Forms.Label();
            this.highNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lowNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.highNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(190, 317);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(152, 28);
            this.titleLabel.TabIndex = 19;
            this.titleLabel.Text = "PhotoRush";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Turquoise;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveButton.Location = new System.Drawing.Point(195, 274);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(135, 30);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save Image";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chooseLabel.Location = new System.Drawing.Point(28, 204);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(105, 18);
            this.chooseLabel.TabIndex = 20;
            this.chooseLabel.Text = "Choose One : ";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Binary",
            "Binary Inverse",
            "Zero",
            "Zero Inverse"});
            this.typeComboBox.Location = new System.Drawing.Point(168, 201);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(142, 26);
            this.typeComboBox.TabIndex = 21;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // highLabel
            // 
            this.highLabel.AutoSize = true;
            this.highLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.highLabel.Location = new System.Drawing.Point(28, 234);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(41, 17);
            this.highLabel.TabIndex = 20;
            this.highLabel.Text = "High";
            // 
            // lowLabel
            // 
            this.lowLabel.AutoSize = true;
            this.lowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lowLabel.Location = new System.Drawing.Point(28, 263);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(36, 17);
            this.lowLabel.TabIndex = 20;
            this.lowLabel.Text = "Low";
            // 
            // highNumericUpDown
            // 
            this.highNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.highNumericUpDown.Increment = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.highNumericUpDown.Location = new System.Drawing.Point(93, 234);
            this.highNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.highNumericUpDown.Name = "highNumericUpDown";
            this.highNumericUpDown.Size = new System.Drawing.Size(96, 23);
            this.highNumericUpDown.TabIndex = 22;
            this.highNumericUpDown.ValueChanged += new System.EventHandler(this.highNumericUpDown_ValueChanged);
            // 
            // lowNumericUpDown
            // 
            this.lowNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lowNumericUpDown.Increment = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.lowNumericUpDown.Location = new System.Drawing.Point(93, 261);
            this.lowNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lowNumericUpDown.Name = "lowNumericUpDown";
            this.lowNumericUpDown.Size = new System.Drawing.Size(96, 23);
            this.lowNumericUpDown.TabIndex = 22;
            this.lowNumericUpDown.ValueChanged += new System.EventHandler(this.lowNumericUpDown_ValueChanged);
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
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            // 
            // ThresholdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(342, 348);
            this.Controls.Add(this.lowNumericUpDown);
            this.Controls.Add(this.highNumericUpDown);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureBox);
            this.Name = "ThresholdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThresholdForm";
            this.Load += new System.EventHandler(this.ThresholdForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.highNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Label lowLabel;
        private System.Windows.Forms.NumericUpDown highNumericUpDown;
        private System.Windows.Forms.NumericUpDown lowNumericUpDown;
        public System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}