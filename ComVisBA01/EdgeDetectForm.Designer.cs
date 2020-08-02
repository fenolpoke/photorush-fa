namespace ComVisBA01
{
    partial class EdgeDetectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdgeDetectForm));
            this.lowNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.highNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.lowLabel = new System.Windows.Forms.Label();
            this.highLabel = new System.Windows.Forms.Label();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.valuesLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.lowNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lowNumericUpDown
            // 
            this.lowNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lowNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.lowNumericUpDown.Location = new System.Drawing.Point(96, 282);
            this.lowNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.lowNumericUpDown.Name = "lowNumericUpDown";
            this.lowNumericUpDown.Size = new System.Drawing.Size(45, 23);
            this.lowNumericUpDown.TabIndex = 30;
            this.lowNumericUpDown.ValueChanged += new System.EventHandler(this.lowNumericUpDown_ValueChanged);
            // 
            // highNumericUpDown
            // 
            this.highNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.highNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.highNumericUpDown.Location = new System.Drawing.Point(96, 255);
            this.highNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.highNumericUpDown.Name = "highNumericUpDown";
            this.highNumericUpDown.Size = new System.Drawing.Size(45, 23);
            this.highNumericUpDown.TabIndex = 31;
            this.highNumericUpDown.ValueChanged += new System.EventHandler(this.highNumericUpDown_ValueChanged);
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
            this.typeComboBox.Location = new System.Drawing.Point(170, 197);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(142, 26);
            this.typeComboBox.TabIndex = 29;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // lowLabel
            // 
            this.lowLabel.AutoSize = true;
            this.lowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lowLabel.Location = new System.Drawing.Point(49, 284);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(36, 17);
            this.lowLabel.TabIndex = 28;
            this.lowLabel.Text = "Low";
            // 
            // highLabel
            // 
            this.highLabel.AutoSize = true;
            this.highLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.highLabel.Location = new System.Drawing.Point(49, 255);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(41, 17);
            this.highLabel.TabIndex = 27;
            this.highLabel.Text = "High";
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chooseLabel.Location = new System.Drawing.Point(30, 200);
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
            this.titleLabel.Location = new System.Drawing.Point(192, 321);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(152, 28);
            this.titleLabel.TabIndex = 25;
            this.titleLabel.Text = "PhotoRush";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Turquoise;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveButton.Location = new System.Drawing.Point(177, 284);
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
            // valuesLabel
            // 
            this.valuesLabel.AutoSize = true;
            this.valuesLabel.Location = new System.Drawing.Point(49, 228);
            this.valuesLabel.Name = "valuesLabel";
            this.valuesLabel.Size = new System.Drawing.Size(39, 13);
            this.valuesLabel.TabIndex = 32;
            this.valuesLabel.Text = "Values";
            // 
            // EdgeDetectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(342, 358);
            this.Controls.Add(this.valuesLabel);
            this.Controls.Add(this.lowNumericUpDown);
            this.Controls.Add(this.highNumericUpDown);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureBox);
            this.Name = "EdgeDetectForm";
            this.Text = "PhotoRush - Edge Detection";
            this.Load += new System.EventHandler(this.EdgeDetectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lowNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown lowNumericUpDown;
        private System.Windows.Forms.NumericUpDown highNumericUpDown;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label lowLabel;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label valuesLabel;
        public System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}