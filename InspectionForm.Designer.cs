namespace StandardChecker
{
    partial class InspectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InspectionForm));
            this.fileLoadingButton = new FontAwesome.Sharp.IconButton();
            this.textBox = new System.Windows.Forms.TextBox();
            this.demoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AutoModeCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileLoadingButton
            // 
            this.fileLoadingButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileLoadingButton.AutoSize = true;
            this.fileLoadingButton.FlatAppearance.BorderSize = 0;
            this.fileLoadingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.fileLoadingButton.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.fileLoadingButton.IconColor = System.Drawing.Color.Black;
            this.fileLoadingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.fileLoadingButton.IconSize = 40;
            this.fileLoadingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileLoadingButton.Location = new System.Drawing.Point(564, 82);
            this.fileLoadingButton.Name = "fileLoadingButton";
            this.fileLoadingButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.fileLoadingButton.Size = new System.Drawing.Size(179, 81);
            this.fileLoadingButton.TabIndex = 0;
            this.fileLoadingButton.Text = "Chọn file";
            this.fileLoadingButton.UseVisualStyleBackColor = true;
            this.fileLoadingButton.Click += new System.EventHandler(this.fileLoadingButton_Click);
            // 
            // textBox
            // 
            this.textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox.Location = new System.Drawing.Point(283, 329);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(776, 360);
            this.textBox.TabIndex = 2;
            // 
            // demoTextBox
            // 
            this.demoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.demoTextBox.Location = new System.Drawing.Point(224, 69);
            this.demoTextBox.Name = "demoTextBox";
            this.demoTextBox.Size = new System.Drawing.Size(184, 30);
            this.demoTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(93, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tìm thủ công";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Controls.Add(this.fileLoadingButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 768);
            this.panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.AutoModeCheckBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.demoTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(397, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 125);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chế độ";
            // 
            // AutoModeCheckBox
            // 
            this.AutoModeCheckBox.AutoSize = true;
            this.AutoModeCheckBox.Location = new System.Drawing.Point(240, 29);
            this.AutoModeCheckBox.Name = "AutoModeCheckBox";
            this.AutoModeCheckBox.Size = new System.Drawing.Size(107, 29);
            this.AutoModeCheckBox.TabIndex = 9;
            this.AutoModeCheckBox.Text = "Tự động";
            this.AutoModeCheckBox.UseVisualStyleBackColor = true;
            this.AutoModeCheckBox.CheckedChanged += new System.EventHandler(this.AutoModeCheckBox_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1295, 768);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 768);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InspectionForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "InspectionForm";
            this.Load += new System.EventHandler(this.InspectionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton fileLoadingButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox demoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox AutoModeCheckBox;
    }
}