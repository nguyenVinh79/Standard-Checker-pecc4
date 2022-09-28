namespace StandardChecker
{
    partial class DBManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBManagement));
            this.documentDTGV = new System.Windows.Forms.DataGridView();
            this.DocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsInvalid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAlternativeDoc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SourceDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceDocString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocFilterCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchContent = new System.Windows.Forms.TextBox();
            this.searchBtn = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IssueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ValidDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ExpireDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AddBtn = new FontAwesome.Sharp.IconButton();
            this.EditBtn = new FontAwesome.Sharp.IconButton();
            this.SortAZBtn = new FontAwesome.Sharp.IconButton();
            this.ValidDateDel = new FontAwesome.Sharp.IconButton();
            this.ExpiryDateDel = new FontAwesome.Sharp.IconButton();
            this.CancelBtn = new FontAwesome.Sharp.IconButton();
            this.InvalidCheckbox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CodeTB = new System.Windows.Forms.TextBox();
            this.AltDocComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NoteTb = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.documentDTGV)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // documentDTGV
            // 
            this.documentDTGV.AllowUserToDeleteRows = false;
            this.documentDTGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.documentDTGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.documentDTGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.documentDTGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.documentDTGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.documentDTGV.ColumnHeadersHeight = 60;
            this.documentDTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.documentDTGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocID,
            this.DocumentID,
            this.DocumentTitle,
            this.DocumentCode,
            this.IssueDate,
            this.ValidDate,
            this.ExpireDate,
            this.IsInvalid,
            this.Note,
            this.IsAlternativeDoc,
            this.SourceDoc,
            this.SourceDocString});
            this.documentDTGV.Location = new System.Drawing.Point(11, 338);
            this.documentDTGV.Margin = new System.Windows.Forms.Padding(4);
            this.documentDTGV.Name = "documentDTGV";
            this.documentDTGV.RowHeadersVisible = false;
            this.documentDTGV.RowHeadersWidth = 51;
            this.documentDTGV.RowTemplate.Height = 24;
            this.documentDTGV.Size = new System.Drawing.Size(917, 128);
            this.documentDTGV.TabIndex = 0;
            this.documentDTGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.documentDTGV_CellClick);
            this.documentDTGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.documentDTGV_DataBindingComplete);
            // 
            // DocID
            // 
            this.DocID.Frozen = true;
            this.DocID.HeaderText = "";
            this.DocID.MinimumWidth = 6;
            this.DocID.Name = "DocID";
            this.DocID.Visible = false;
            this.DocID.Width = 125;
            // 
            // DocumentID
            // 
            this.DocumentID.DataPropertyName = "ID";
            this.DocumentID.HeaderText = "ID";
            this.DocumentID.MinimumWidth = 6;
            this.DocumentID.Name = "DocumentID";
            this.DocumentID.Visible = false;
            this.DocumentID.Width = 125;
            // 
            // DocumentTitle
            // 
            this.DocumentTitle.DataPropertyName = "DocumentTitle";
            this.DocumentTitle.HeaderText = "Tên văn bản";
            this.DocumentTitle.MinimumWidth = 6;
            this.DocumentTitle.Name = "DocumentTitle";
            this.DocumentTitle.Width = 125;
            // 
            // DocumentCode
            // 
            this.DocumentCode.DataPropertyName = "DocumentCode";
            this.DocumentCode.HeaderText = "Mã Số";
            this.DocumentCode.MinimumWidth = 6;
            this.DocumentCode.Name = "DocumentCode";
            this.DocumentCode.Width = 125;
            // 
            // IssueDate
            // 
            this.IssueDate.DataPropertyName = "IssueDate";
            this.IssueDate.HeaderText = "Tg ban hành";
            this.IssueDate.MinimumWidth = 6;
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.Width = 125;
            // 
            // ValidDate
            // 
            this.ValidDate.DataPropertyName = "ValidDate";
            this.ValidDate.HeaderText = "Ngày hiệu lực";
            this.ValidDate.MinimumWidth = 6;
            this.ValidDate.Name = "ValidDate";
            this.ValidDate.Width = 125;
            // 
            // ExpireDate
            // 
            this.ExpireDate.DataPropertyName = "ExpireDate";
            this.ExpireDate.HeaderText = "Hạn Hiệu Lực";
            this.ExpireDate.MinimumWidth = 6;
            this.ExpireDate.Name = "ExpireDate";
            this.ExpireDate.Width = 125;
            // 
            // IsInvalid
            // 
            this.IsInvalid.DataPropertyName = "IsInvalid";
            this.IsInvalid.HeaderText = "Hết Hiệu Lực";
            this.IsInvalid.MinimumWidth = 6;
            this.IsInvalid.Name = "IsInvalid";
            this.IsInvalid.ReadOnly = true;
            this.IsInvalid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsInvalid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsInvalid.Width = 125;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Ghi chú";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.Width = 125;
            // 
            // IsAlternativeDoc
            // 
            this.IsAlternativeDoc.DataPropertyName = "IsAlternativeDoc";
            this.IsAlternativeDoc.HeaderText = "VB thay thế";
            this.IsAlternativeDoc.MinimumWidth = 6;
            this.IsAlternativeDoc.Name = "IsAlternativeDoc";
            this.IsAlternativeDoc.ReadOnly = true;
            this.IsAlternativeDoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsAlternativeDoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsAlternativeDoc.Width = 125;
            // 
            // SourceDoc
            // 
            this.SourceDoc.DataPropertyName = "SourceDoc";
            this.SourceDoc.HeaderText = "SourceDoc";
            this.SourceDoc.MinimumWidth = 6;
            this.SourceDoc.Name = "SourceDoc";
            this.SourceDoc.Visible = false;
            this.SourceDoc.Width = 125;
            // 
            // SourceDocString
            // 
            this.SourceDocString.DataPropertyName = "SourceDocString";
            this.SourceDocString.HeaderText = "Văn bản gốc";
            this.SourceDocString.MinimumWidth = 6;
            this.SourceDocString.Name = "SourceDocString";
            this.SourceDocString.Width = 125;
            // 
            // DocFilterCB
            // 
            this.DocFilterCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocFilterCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DocFilterCB.FormattingEnabled = true;
            this.DocFilterCB.Location = new System.Drawing.Point(610, 24);
            this.DocFilterCB.Margin = new System.Windows.Forms.Padding(4);
            this.DocFilterCB.Name = "DocFilterCB";
            this.DocFilterCB.Size = new System.Drawing.Size(253, 33);
            this.DocFilterCB.TabIndex = 1;
            this.DocFilterCB.SelectedValueChanged += new System.EventHandler(this.DocFilterCB_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(120, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm Kiếm";
            // 
            // searchContent
            // 
            this.searchContent.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.searchContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchContent.Location = new System.Drawing.Point(107, 24);
            this.searchContent.Margin = new System.Windows.Forms.Padding(4);
            this.searchContent.Multiline = true;
            this.searchContent.Name = "searchContent";
            this.searchContent.Size = new System.Drawing.Size(388, 33);
            this.searchContent.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.AutoSize = true;
            this.searchBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchBtn.IconColor = System.Drawing.Color.MidnightBlue;
            this.searchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchBtn.IconSize = 30;
            this.searchBtn.Location = new System.Drawing.Point(501, 20);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(48, 41);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(-109, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.MaximumSize = new System.Drawing.Size(140, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ngày ban hành";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(208, 224);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.MaximumSize = new System.Drawing.Size(100, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 48);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ngày hiệu lực";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(626, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hạn hiệu lực";
            // 
            // IssueDatePicker
            // 
            this.IssueDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IssueDatePicker.CustomFormat = "dd/MM/yyyy";
            this.IssueDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IssueDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.IssueDatePicker.Location = new System.Drawing.Point(164, 228);
            this.IssueDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.IssueDatePicker.Name = "IssueDatePicker";
            this.IssueDatePicker.Size = new System.Drawing.Size(0, 30);
            this.IssueDatePicker.TabIndex = 19;
            this.IssueDatePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IssueDatePicker_KeyDown);
            this.IssueDatePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IssueDatePicker_MouseDown);
            // 
            // ValidDatePicker
            // 
            this.ValidDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValidDatePicker.CustomFormat = "dd/MM/yyyy";
            this.ValidDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ValidDatePicker.Location = new System.Drawing.Point(474, 228);
            this.ValidDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.ValidDatePicker.Name = "ValidDatePicker";
            this.ValidDatePicker.Size = new System.Drawing.Size(0, 30);
            this.ValidDatePicker.TabIndex = 20;
            this.ValidDatePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValidDatePicker_KeyDown);
            this.ValidDatePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ValidDatePicker_MouseDown);
            // 
            // ExpireDatePicker
            // 
            this.ExpireDatePicker.CustomFormat = "dd/MM/yyyy";
            this.ExpireDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ExpireDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpireDatePicker.Location = new System.Drawing.Point(896, 234);
            this.ExpireDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.ExpireDatePicker.Name = "ExpireDatePicker";
            this.ExpireDatePicker.Size = new System.Drawing.Size(191, 30);
            this.ExpireDatePicker.TabIndex = 21;
            this.ExpireDatePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExpireDatePicker_KeyDown);
            this.ExpireDatePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExpireDatePicker_MouseDown);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AddBtn.IconColor = System.Drawing.Color.Black;
            this.AddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddBtn.IconSize = 40;
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddBtn.Location = new System.Drawing.Point(3, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.AddBtn.Size = new System.Drawing.Size(69, 65);
            this.AddBtn.TabIndex = 23;
            this.AddBtn.Text = "Thêm";
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.EditBtn.IconColor = System.Drawing.Color.Black;
            this.EditBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditBtn.IconSize = 40;
            this.EditBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EditBtn.Location = new System.Drawing.Point(78, 3);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.EditBtn.Size = new System.Drawing.Size(72, 65);
            this.EditBtn.TabIndex = 24;
            this.EditBtn.Text = "Sửa";
            this.EditBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SortAZBtn
            // 
            this.SortAZBtn.AutoSize = true;
            this.SortAZBtn.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;
            this.SortAZBtn.IconColor = System.Drawing.Color.Black;
            this.SortAZBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SortAZBtn.IconSize = 35;
            this.SortAZBtn.Location = new System.Drawing.Point(556, 18);
            this.SortAZBtn.Name = "SortAZBtn";
            this.SortAZBtn.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.SortAZBtn.Size = new System.Drawing.Size(44, 46);
            this.SortAZBtn.TabIndex = 24;
            this.SortAZBtn.UseVisualStyleBackColor = true;
            this.SortAZBtn.Click += new System.EventHandler(this.SortAZBtn_Click);
            // 
            // ValidDateDel
            // 
            this.ValidDateDel.BackColor = System.Drawing.Color.Red;
            this.ValidDateDel.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ValidDateDel.IconColor = System.Drawing.Color.Black;
            this.ValidDateDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ValidDateDel.IconSize = 30;
            this.ValidDateDel.Location = new System.Drawing.Point(671, 227);
            this.ValidDateDel.Name = "ValidDateDel";
            this.ValidDateDel.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.ValidDateDel.Size = new System.Drawing.Size(38, 37);
            this.ValidDateDel.TabIndex = 25;
            this.ValidDateDel.UseVisualStyleBackColor = false;
            this.ValidDateDel.Click += new System.EventHandler(this.ValidDateDel_Click);
            // 
            // ExpiryDateDel
            // 
            this.ExpiryDateDel.BackColor = System.Drawing.Color.Red;
            this.ExpiryDateDel.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ExpiryDateDel.IconColor = System.Drawing.Color.Black;
            this.ExpiryDateDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExpiryDateDel.IconSize = 30;
            this.ExpiryDateDel.Location = new System.Drawing.Point(1094, 228);
            this.ExpiryDateDel.Name = "ExpiryDateDel";
            this.ExpiryDateDel.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.ExpiryDateDel.Size = new System.Drawing.Size(38, 37);
            this.ExpiryDateDel.TabIndex = 26;
            this.ExpiryDateDel.UseVisualStyleBackColor = false;
            this.ExpiryDateDel.Click += new System.EventHandler(this.ExpiryDateDel_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.CancelBtn.IconColor = System.Drawing.Color.Black;
            this.CancelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelBtn.IconSize = 40;
            this.CancelBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CancelBtn.Location = new System.Drawing.Point(156, 3);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Padding = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.CancelBtn.Size = new System.Drawing.Size(86, 65);
            this.CancelBtn.TabIndex = 27;
            this.CancelBtn.Text = "Refresh";
            this.CancelBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // InvalidCheckbox
            // 
            this.InvalidCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.InvalidCheckbox.AutoSize = true;
            this.InvalidCheckbox.BackColor = System.Drawing.Color.Yellow;
            this.InvalidCheckbox.Location = new System.Drawing.Point(164, 223);
            this.InvalidCheckbox.Name = "InvalidCheckbox";
            this.InvalidCheckbox.Size = new System.Drawing.Size(18, 17);
            this.InvalidCheckbox.TabIndex = 29;
            this.InvalidCheckbox.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-225, 223);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Hết hiệu lực";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel2.Controls.Add(this.AddBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CancelBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.EditBtn, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(686, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(245, 71);
            this.tableLayoutPanel2.TabIndex = 36;
            // 
            // CodeTB
            // 
            this.CodeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CodeTB.Location = new System.Drawing.Point(850, 103);
            this.CodeTB.Margin = new System.Windows.Forms.Padding(4);
            this.CodeTB.Multiline = true;
            this.CodeTB.Name = "CodeTB";
            this.CodeTB.Size = new System.Drawing.Size(72, 0);
            this.CodeTB.TabIndex = 6;
            // 
            // AltDocComboBox
            // 
            this.AltDocComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AltDocComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AltDocComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AltDocComboBox.FormattingEnabled = true;
            this.AltDocComboBox.Location = new System.Drawing.Point(850, 102);
            this.AltDocComboBox.Name = "AltDocComboBox";
            this.AltDocComboBox.Size = new System.Drawing.Size(74, 30);
            this.AltDocComboBox.TabIndex = 30;
            this.AltDocComboBox.SelectedIndexChanged += new System.EventHandler(this.AltDocComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(459, 103);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "VB thay thế cho";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(483, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mã Số";
            // 
            // NoteTb
            // 
            this.NoteTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NoteTb.Location = new System.Drawing.Point(93, 86);
            this.NoteTb.Margin = new System.Windows.Forms.Padding(4);
            this.NoteTb.Multiline = true;
            this.NoteTb.Name = "NoteTb";
            this.NoteTb.Size = new System.Drawing.Size(358, 59);
            this.NoteTb.TabIndex = 9;
            // 
            // NameTB
            // 
            this.NameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NameTB.Location = new System.Drawing.Point(93, 36);
            this.NameTB.Margin = new System.Windows.Forms.Padding(4);
            this.NameTB.Multiline = true;
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(358, 42);
            this.NameTB.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-228, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-225, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên";
            // 
            // DBManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(936, 472);
            this.Controls.Add(this.documentDTGV);
            this.Controls.Add(this.InvalidCheckbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IssueDatePicker);
            this.Controls.Add(this.ExpiryDateDel);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.ExpireDatePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NoteTb);
            this.Controls.Add(this.ValidDateDel);
            this.Controls.Add(this.SortAZBtn);
            this.Controls.Add(this.ValidDatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.AltDocComboBox);
            this.Controls.Add(this.searchContent);
            this.Controls.Add(this.CodeTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DocFilterCB);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DBManagement";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DBManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentDTGV)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView documentDTGV;
        private System.Windows.Forms.ComboBox DocFilterCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchContent;
        private FontAwesome.Sharp.IconButton searchBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker IssueDatePicker;
        private System.Windows.Forms.DateTimePicker ValidDatePicker;
        private System.Windows.Forms.DateTimePicker ExpireDatePicker;
        private FontAwesome.Sharp.IconButton AddBtn;
        private FontAwesome.Sharp.IconButton EditBtn;
        private FontAwesome.Sharp.IconButton SortAZBtn;
        private FontAwesome.Sharp.IconButton ValidDateDel;
        private FontAwesome.Sharp.IconButton ExpiryDateDel;
        private FontAwesome.Sharp.IconButton CancelBtn;
        private System.Windows.Forms.CheckBox InvalidCheckbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsInvalid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAlternativeDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceDocString;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox CodeTB;
        private System.Windows.Forms.ComboBox AltDocComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NoteTb;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}