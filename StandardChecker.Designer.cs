namespace StandardChecker
{
    partial class StandardChecker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandardChecker));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inforMenuButton = new FontAwesome.Sharp.IconButton();
            this.editMenuButton = new FontAwesome.Sharp.IconButton();
            this.checkMenuButton = new FontAwesome.Sharp.IconButton();
            this.panelWindow = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.inforMenuButton);
            this.panel1.Controls.Add(this.editMenuButton);
            this.panel1.Controls.Add(this.checkMenuButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 834);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // inforMenuButton
            // 
            this.inforMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.inforMenuButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.inforMenuButton.FlatAppearance.BorderSize = 0;
            this.inforMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inforMenuButton.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.inforMenuButton.ForeColor = System.Drawing.Color.White;
            this.inforMenuButton.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.inforMenuButton.IconColor = System.Drawing.Color.White;
            this.inforMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.inforMenuButton.IconSize = 40;
            this.inforMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inforMenuButton.Location = new System.Drawing.Point(0, 265);
            this.inforMenuButton.Name = "inforMenuButton";
            this.inforMenuButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.inforMenuButton.Size = new System.Drawing.Size(179, 81);
            this.inforMenuButton.TabIndex = 3;
            this.inforMenuButton.Text = "Thông tin";
            this.inforMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inforMenuButton.UseVisualStyleBackColor = false;
            this.inforMenuButton.Click += new System.EventHandler(this.inforMenuButton_Click);
            // 
            // editMenuButton
            // 
            this.editMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.editMenuButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.editMenuButton.FlatAppearance.BorderSize = 0;
            this.editMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMenuButton.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.editMenuButton.ForeColor = System.Drawing.Color.White;
            this.editMenuButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.editMenuButton.IconColor = System.Drawing.Color.White;
            this.editMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editMenuButton.IconSize = 40;
            this.editMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editMenuButton.Location = new System.Drawing.Point(0, 188);
            this.editMenuButton.Name = "editMenuButton";
            this.editMenuButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.editMenuButton.Size = new System.Drawing.Size(179, 81);
            this.editMenuButton.TabIndex = 2;
            this.editMenuButton.Text = "CS Dữ Liệu";
            this.editMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editMenuButton.UseVisualStyleBackColor = false;
            this.editMenuButton.Click += new System.EventHandler(this.editMenuButton_Click);
            // 
            // checkMenuButton
            // 
            this.checkMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.checkMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkMenuButton.FlatAppearance.BorderSize = 0;
            this.checkMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkMenuButton.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.checkMenuButton.ForeColor = System.Drawing.Color.White;
            this.checkMenuButton.IconChar = FontAwesome.Sharp.IconChar.Slack;
            this.checkMenuButton.IconColor = System.Drawing.Color.White;
            this.checkMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.checkMenuButton.IconSize = 40;
            this.checkMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkMenuButton.Location = new System.Drawing.Point(0, 120);
            this.checkMenuButton.Name = "checkMenuButton";
            this.checkMenuButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.checkMenuButton.Rotation = -45D;
            this.checkMenuButton.Size = new System.Drawing.Size(179, 77);
            this.checkMenuButton.TabIndex = 1;
            this.checkMenuButton.Text = "Kiểm tra";
            this.checkMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkMenuButton.UseVisualStyleBackColor = false;
            this.checkMenuButton.Click += new System.EventHandler(this.checkMenuButton_Click);
            // 
            // panelWindow
            // 
            this.panelWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelWindow.BackgroundImage")));
            this.panelWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWindow.Location = new System.Drawing.Point(179, 0);
            this.panelWindow.Name = "panelWindow";
            this.panelWindow.Size = new System.Drawing.Size(1363, 834);
            this.panelWindow.TabIndex = 1;
            this.panelWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWindow_Paint);
            // 
            // StandardChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1542, 834);
            this.Controls.Add(this.panelWindow);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StandardChecker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm kiểm tra văn bản";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton checkMenuButton;
        private FontAwesome.Sharp.IconButton inforMenuButton;
        private FontAwesome.Sharp.IconButton editMenuButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelWindow;
    }
}

