using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardChecker
{
    public partial class ManageForm : Form
    {
        DocManagement currentDoc = new DocManagement();
        List<DocManagement> ComboboxDatalist = new List<DocManagement>();

        public ManageForm()
        {
            InitializeComponent();
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            DocFilterCB.Items.Insert(0, "Vui lòng chọn bộ lọc");
            DocFilterCB.Items.Insert(1, "Còn hiệu lực");
            DocFilterCB.Items.Insert(2, "Hết hiệu lực");
            DocFilterCB.Items.Insert(3, "Văn bản thay thế");
            DocFilterCB.Items.Insert(4, "Tất cả");
            DocFilterCB.SelectedIndex = 0;

            InvalidCheckbox.Checked = false;

            documentDTGV.Columns[4].DefaultCellStyle.Format = "dd-MM-yyyy";
            documentDTGV.Columns[5].DefaultCellStyle.Format = "dd-MM-yyyy";
            documentDTGV.Columns[6].DefaultCellStyle.Format = "dd-MM-yyyy";
            EditBtn.Enabled = false;
            documentDTGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.documentDTGV.RowsDefaultCellStyle.BackColor = Color.White;
            this.documentDTGV.AlternatingRowsDefaultCellStyle.BackColor = Color.Linen;
            documentDTGV.RowHeadersVisible = false;

            DataGridViewColumn NameCol = documentDTGV.Columns[2];
            DataGridViewColumn CodeCol = documentDTGV.Columns[3];
            DataGridViewColumn IssueCol = documentDTGV.Columns[4];
            DataGridViewColumn ValidCol = documentDTGV.Columns[5];
            DataGridViewColumn ExpiryDateCol = documentDTGV.Columns[6];
            DataGridViewColumn CheckExpiryCol = documentDTGV.Columns[7];
            DataGridViewColumn NoteCol = documentDTGV.Columns[8];
            DataGridViewColumn AlternativeCol = documentDTGV.Columns[9];
            DataGridViewColumn SourceDocCol = documentDTGV.Columns[11];

            NameCol.Width = 500;
            CodeCol.Width = 200;
            IssueCol.Width = 100;
            ValidCol.Width = 100;
            ExpiryDateCol.Width = 100;
            CheckExpiryCol.Width = 100;
            NoteCol.Width = 380;
            AlternativeCol.Width = 80;

            try
            {
                var context = new DocCheckEntities();
                var DocList = context.DocManagements.ToList<DocManagement>();
                var docListView = new List<DocManagementListView>();

                docListView = LoadDocListView(DocList);
           
            #region get data for combobox
            //foreach(var item in DocList)
            //{
            //    if(item.SourceDoc == 0)
            //    {
            //        docListView.Add(new DocManagementListView() {
            //            ID = item.ID,
            //            DocumentTitle = item.DocumentTitle,
            //            DocumentCode = item.DocumentCode,
            //            IssueDate = item.IssueDate,
            //            ValidDate = item.ValidDate,
            //            ExpireDate = item.ExpireDate,
            //            Note = item.Note,
            //            IsAlternativeDoc = item.IsAlternativeDoc,
            //            IsInvalid = item.IsInvalid,
            //            SourceDoc = item.SourceDoc,
            //            SourceDocString = " "
            //        });
            //    }
            //    else
            //    {
            //        docListView.Add(new DocManagementListView()
            //        {
            //            ID = item.ID,
            //            DocumentTitle = item.DocumentTitle,
            //            DocumentCode = item.DocumentCode,
            //            IssueDate = item.IssueDate,
            //            ValidDate = item.ValidDate,
            //            ExpireDate = item.ExpireDate,
            //            Note = item.Note,
            //            IsAlternativeDoc = item.IsAlternativeDoc,
            //            IsInvalid = item.IsInvalid,
            //            SourceDoc = item.SourceDoc,
            //            SourceDocString = context.DocManagements.ToList<DocManagement>().Where(x => x.ID == item.SourceDoc).First().DocumentCode
            //        });
            //    }    
            //}    
            #endregion


            documentDTGV.DataSource = docListView;


            ValidDatePicker.Enabled = false;
            IssueDatePicker.Enabled = false;
            ExpireDatePicker.Enabled = false;
            //ValidDatePicker.Format = DateTimePickerFormat.Custom;
            //IssueDatePicker.Format = DateTimePickerFormat.Custom;
            //IssueDatePicker.CustomFormat = " ";
            //ExpireDatePicker.Format = DateTimePickerFormat.Custom;
            ValidDatePicker.CustomFormat = " ";
            ExpireDatePicker.CustomFormat = " ";
            ValidDatePicker.Enabled = true;
            IssueDatePicker.Enabled = true;
            ExpireDatePicker.Enabled = true;


            //alternative doc load
            var AltDocCode = context.DocManagements.ToList<DocManagement>().Where(x => x.SourceDoc == 0).ToList();
            
            AltDocComboBox.Items.Clear();
            ComboboxDatalist.Add(new DocManagement() { ID = 0, DocumentCode = "Vui lòng chọn văn bản gốc" });
            if (AltDocCode.Count > 0)
            {

                foreach (var item in AltDocCode)
                {
                    ComboboxDatalist.Add(new DocManagement() { ID = item.ID, DocumentCode = item.DocumentCode });
                    //AltDocComboBox.Items.Add(item.DocumentCode);
                }

                AltDocComboBox.DataSource = null;
                AltDocComboBox.DataSource = ComboboxDatalist;
                AltDocComboBox.DisplayMember = "DocumentCode";
                AltDocComboBox.ValueMember = "ID";

               
            }
            }
            catch (Exception ex)
            {
                DialogResult messDialog = MessageBox.Show("Vui lòng kiểm tra kết nối VPN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (messDialog == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void documentDTGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow >= 0)
            {
                EditBtn.Enabled = true;
                AddBtn.Enabled = false;
                // Get selected document Id
                currentDoc.ID = Convert.ToInt32(documentDTGV.Rows[e.RowIndex].Cells["DocumentID"].FormattedValue.ToString());

                ValidDatePicker.Enabled = true;
                IssueDatePicker.Enabled = true;
                ExpireDatePicker.Enabled = true;

                if (documentDTGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    NameTB.Text = documentDTGV.Rows[e.RowIndex].Cells["DocumentTitle"].FormattedValue.ToString();
                    CodeTB.Text = documentDTGV.Rows[e.RowIndex].Cells["DocumentCode"].FormattedValue.ToString();
                    NoteTb.Text = documentDTGV.Rows[e.RowIndex].Cells["Note"].FormattedValue.ToString();

                    var AltCheck = documentDTGV.Rows[e.RowIndex].Cells["IsAlternativeDoc"].FormattedValue.ToString().Trim();
                    if (AltCheck == "True")
                    {
                        IsAlternativeCB.Checked = true;
                    }
                    else
                        IsAlternativeCB.Checked = false;

                    var InvalidCheck = documentDTGV.Rows[e.RowIndex].Cells["IsInvalid"].FormattedValue.ToString().Trim();
                    if (InvalidCheck == "True")
                    {
                        InvalidCheckbox.Checked = true;
                    }
                    else
                        InvalidCheckbox.Checked = false;

                    if (!string.IsNullOrEmpty(documentDTGV.Rows[e.RowIndex].Cells["IssueDate"].FormattedValue.ToString()))
                    {
                        //DateTime converter
                        CultureInfo culture = new CultureInfo("es-ES");
                        IssueDatePicker.CustomFormat = "dd-MM-yyyy";
                        var DateTemp = DateTime.Parse(documentDTGV.Rows[e.RowIndex].Cells["IssueDate"].FormattedValue.ToString(), culture);
                        IssueDatePicker.Value = DateTemp;

                    }
                    else
                        IssueDatePicker.CustomFormat = " ";


                    if (!string.IsNullOrEmpty(documentDTGV.Rows[e.RowIndex].Cells["ValidDate"].FormattedValue.ToString()))
                    {
                        //DateTime converter
                        CultureInfo culture = new CultureInfo("es-ES");

                        ValidDatePicker.CustomFormat = "dd-MM-yyyy";
                        var DateTemp = Convert.ToDateTime(documentDTGV.Rows[e.RowIndex].Cells["ValidDate"].FormattedValue.ToString(), culture);
                        ValidDatePicker.Value = DateTemp;

                        currentDoc.ValidDate = DateTemp;
                    }

                    else
                    {
                        ValidDatePicker.CustomFormat = " ";
                        currentDoc.ValidDate = null;
                    }

                    if (!string.IsNullOrEmpty(documentDTGV.Rows[e.RowIndex].Cells["ExpireDate"].FormattedValue.ToString()))
                    {
                        //DateTime converter
                        CultureInfo culture = new CultureInfo("es-ES");
                        ExpireDatePicker.CustomFormat = "dd-MM-yyyy";
                        var DateTemp = Convert.ToDateTime(documentDTGV.Rows[e.RowIndex].Cells["ExpireDate"].FormattedValue.ToString(), culture);
                        ExpireDatePicker.Value = DateTemp;

                        currentDoc.ExpireDate = DateTemp;
                    }
                    else
                    {
                        ExpireDatePicker.CustomFormat = " ";
                        currentDoc.ExpireDate = null;
                    }

                    AltDocComboBox.SelectedIndex = ComboboxDatalist.FindIndex(x => x.ID == Convert.ToInt32(documentDTGV.Rows[e.RowIndex].Cells["SourceDoc"].FormattedValue));
                }
            }
        }

        private void IssueDatePicker_MouseDown(object sender, MouseEventArgs e)
        {
            IssueDatePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void ValidDatePicker_KeyDown(object sender, KeyEventArgs e)
        {
            ValidDatePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void ValidDatePicker_MouseDown(object sender, MouseEventArgs e)
        {
            ValidDatePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void IssueDatePicker_KeyDown(object sender, KeyEventArgs e)
        {
            IssueDatePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void ExpireDatePicker_MouseEnter(object sender, EventArgs e)
        {
            ExpireDatePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void ExpireDatePicker_KeyDown(object sender, KeyEventArgs e)
        {
            ExpireDatePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DialogResult messDialog = MessageBox.Show("Bạn muốn thêm văn bản này vào CSDL?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (messDialog == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(NameTB.Text) && !string.IsNullOrEmpty(CodeTB.Text))
                {

                    var context = new DocCheckEntities();
                    var newDoc = new DocManagement();
                    newDoc.DocumentTitle = NameTB.Text;
                    newDoc.DocumentCode = CodeTB.Text;
                    newDoc.Note = NoteTb.Text;
                    newDoc.IssueDate = IssueDatePicker.Value;
                    newDoc.SourceDoc = Convert.ToInt32(AltDocComboBox.SelectedValue);

                    if (!string.IsNullOrEmpty(ValidDatePicker.Text.Trim()))
                        newDoc.ValidDate = ValidDatePicker.Value;

                    if (!string.IsNullOrEmpty(ExpireDatePicker.Text.Trim()))
                        newDoc.ExpireDate = ExpireDatePicker.Value;


                    if (newDoc.SourceDoc > 0)
                    {
                        newDoc.IsAlternativeDoc = true;
                    }
                    else
                        newDoc.IsAlternativeDoc = false;

                    if (!string.IsNullOrEmpty(ExpireDatePicker.Text.Trim()))
                    {
                        if (DateTime.Now >= ExpireDatePicker.Value)
                        {
                            newDoc.IsInvalid = true;
                        }
                        else
                            newDoc.IsInvalid = false;
                    }
                    else
                    {
                        if (InvalidCheckbox.Checked)
                        {
                            newDoc.IsInvalid = true;
                        }
                        else newDoc.IsInvalid = false;
                    }

                    /*
                    if (!string.IsNullOrEmpty(AltDocComboBox.SelectedItem.ToString()))
                    {
                        var sourceDoc = context.DocManagements.ToList<DocManagement>()
                            .Where(x => x.DocumentCode == AltDocComboBox.SelectedItem.ToString().Trim()).First().ID;
                        newDoc.SourceDoc = sourceDoc;
                    }
                    else
                        newDoc.SourceDoc = 0;
                    */

                    context.DocManagements.Add(newDoc);
                    context.SaveChanges();


                    MessageBox.Show("Thao tác thành công", "Thêm văn bản", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ReloadAlternativeCombobox();
                    NameTB.Text = "";
                    CodeTB.Text = "";
                    NoteTb.Text = "";
                    IsAlternativeCB.Checked = false;
                    ValidDatePicker.CustomFormat = " ";
                    ExpireDatePicker.CustomFormat = " ";

                    var DocList = context.DocManagements.ToList<DocManagement>();

                    var docListView = new List<DocManagementListView>();
                    docListView = LoadDocListView(DocList);
                    documentDTGV.DataSource = docListView;
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ tên và mã văn bản", "Thao tác không thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void ExpireDatePicker_MouseDown(object sender, MouseEventArgs e)
        {
            ExpireDatePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void SortAZBtn_Click(object sender, EventArgs e)
        {
            var context = new DocCheckEntities();
            if (DocFilterCB.SelectedIndex == 0)
            {
                if (SortAZBtn.IconChar.ToString().Trim() == "SortAlphaDown")
                {
                    SortAZBtn.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDownAlt;

                    var DocList = context.DocManagements.ToList<DocManagement>().OrderBy(x => x.DocumentTitle).ToList();
                    var docListView = new List<DocManagementListView>();
                    docListView = LoadDocListView(DocList);
                    documentDTGV.DataSource = docListView;
                }
                else
                {
                    SortAZBtn.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;

                    var DocList = context.DocManagements.ToList<DocManagement>().OrderByDescending(x => x.DocumentTitle).ToList();
                    var docListView = new List<DocManagementListView>();
                    docListView = LoadDocListView(DocList);
                    documentDTGV.DataSource = docListView;
                }
            }

            if (DocFilterCB.SelectedIndex == 1)
            {
                var DocList = context.DocManagements.Where(x => x.IsInvalid == false).ToList();

                if (DocList.Count > 0)
                {

                    if (SortAZBtn.IconChar.ToString().Trim() == "SortAlphaDown")
                    {
                        SortAZBtn.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDownAlt;
                        DocList = DocList.OrderBy(x => x.DocumentTitle).ToList();
                        var docListView = new List<DocManagementListView>();
                        docListView = LoadDocListView(DocList);
                        documentDTGV.DataSource = docListView;
                    }
                    else
                    {
                        SortAZBtn.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;

                        DocList = DocList.OrderByDescending(x => x.DocumentTitle).ToList();
                        var docListView = new List<DocManagementListView>();
                        docListView = LoadDocListView(DocList);
                        documentDTGV.DataSource = docListView;
                    }
                }
                else
                {
                    DocList = new List<DocManagement>();
                    var docListView = new List<DocManagementListView>();
                    documentDTGV.DataSource = docListView;
                }
            }

            if (DocFilterCB.SelectedIndex == 2)
            {
                var DocList = context.DocManagements.Where(x => x.IsInvalid == true).ToList();

                if (DocList.Count > 0)
                {
                    if (SortAZBtn.IconChar.ToString().Trim() == "SortAlphaDown")
                    {
                        SortAZBtn.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDownAlt;
                        DocList = DocList.OrderBy(x => x.DocumentTitle).ToList();
                        var docListView = new List<DocManagementListView>();
                        docListView = LoadDocListView(DocList);
                        documentDTGV.DataSource = docListView;
                    }
                    else
                    {
                        SortAZBtn.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;

                        DocList = DocList.OrderByDescending(x => x.DocumentTitle).ToList();
                        var docListView = new List<DocManagementListView>();
                        docListView = LoadDocListView(DocList);
                        documentDTGV.DataSource = docListView;
                    }
                }
                else
                {
                    DocList = new List<DocManagement>();
                    var docListView = new List<DocManagementListView>();
                    docListView = LoadDocListView(DocList);
                    documentDTGV.DataSource = docListView;
                }
            }

            if (DocFilterCB.SelectedIndex == 3)
            {
                var DocList = context.DocManagements.Where(x => x.IsAlternativeDoc == true).ToList();

                if (DocList.Count > 0)
                {
                    if (SortAZBtn.IconChar.ToString().Trim() == "SortAlphaDown")
                    {
                        SortAZBtn.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDownAlt;
                        DocList = DocList.OrderBy(x => x.DocumentTitle).ToList();
                        var docListView = new List<DocManagementListView>();
                        docListView = LoadDocListView(DocList);
                        documentDTGV.DataSource = docListView;
                    }
                    else
                    {
                        SortAZBtn.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;

                        DocList = DocList.OrderByDescending(x => x.DocumentTitle).ToList();
                        var docListView = new List<DocManagementListView>();
                        docListView = LoadDocListView(DocList);
                        documentDTGV.DataSource = docListView;
                    }
                }
                else
                {
                    DocList = new List<DocManagement>();
                    var docListView = new List<DocManagementListView>();
                    docListView = LoadDocListView(DocList);
                    documentDTGV.DataSource = docListView;
                }
            }

            if (DocFilterCB.SelectedIndex == 4)
            {
                var DocList = context.DocManagements.ToList();

                if (DocList.Count > 0)
                {
                    if (SortAZBtn.IconChar.ToString().Trim() == "SortAlphaDown")
                    {
                        SortAZBtn.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDownAlt;
                        DocList = DocList.OrderBy(x => x.DocumentTitle).ToList();
                        var docListView = new List<DocManagementListView>();
                        docListView = LoadDocListView(DocList);
                        documentDTGV.DataSource = docListView;
                    }
                    else
                    {
                        SortAZBtn.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;

                        DocList = DocList.OrderByDescending(x => x.DocumentTitle).ToList();
                        var docListView = new List<DocManagementListView>();
                        docListView = LoadDocListView(DocList);
                        documentDTGV.DataSource = docListView;
                    }
                }
                else
                {
                    DocList = new List<DocManagement>();
                    var docListView = new List<DocManagementListView>();
                    documentDTGV.DataSource = docListView;
                }
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            DialogResult messDialog = MessageBox.Show("Bạn muốn chỉnh sửa văn bản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (messDialog == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(NameTB.Text) && !string.IsNullOrEmpty(CodeTB.Text))
                {
                    var context = new DocCheckEntities();
                    var selectedDoc = context.DocManagements.Where(x => x.ID == currentDoc.ID).FirstOrDefault();

                    selectedDoc.DocumentTitle = NameTB.Text;
                    selectedDoc.DocumentCode = CodeTB.Text;
                    selectedDoc.Note = NoteTb.Text;

                    selectedDoc.IssueDate = IssueDatePicker.Value;
                    selectedDoc.SourceDoc = Convert.ToInt32(AltDocComboBox.SelectedValue);

                    if (!string.IsNullOrEmpty(ValidDatePicker.Text.Trim()))
                    {
                        selectedDoc.ValidDate = ValidDatePicker.Value;
                    }
                    else
                        selectedDoc.ValidDate = null;

                    if (!string.IsNullOrEmpty(ExpireDatePicker.Text.Trim()))
                    {
                        selectedDoc.ExpireDate = ExpireDatePicker.Value;
                    }
                    else
                        selectedDoc.ExpireDate = null;

                    if (selectedDoc.SourceDoc > 0)
                    {
                        selectedDoc.IsAlternativeDoc = true;
                    }
                    else
                        selectedDoc.IsAlternativeDoc = false;

                    if (!string.IsNullOrEmpty(ExpireDatePicker.Text.Trim()))
                    {
                        if (DateTime.Now >= ExpireDatePicker.Value)
                        {
                            selectedDoc.IsInvalid = true;
                        }
                        else
                            selectedDoc.IsInvalid = false;
                    }
                    else
                    {
                        if (InvalidCheckbox.Checked)
                        {
                            selectedDoc.IsInvalid = true;
                        }
                        else selectedDoc.IsInvalid = false;

                    }

                    AddBtn.Enabled = true;
                    EditBtn.Enabled = false;
                    NameTB.Text = "";
                    CodeTB.Text = "";
                    NoteTb.Text = "";
                    IsAlternativeCB.Checked = false;
                    ValidDatePicker.CustomFormat = " ";
                    ExpireDatePicker.CustomFormat = " ";

                    context.SaveChanges();

                    ReloadAlternativeCombobox();

                    MessageBox.Show("Thao tác thành công", "Cập nhật văn bản", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    var DocList = context.DocManagements.ToList<DocManagement>();
                    var docListView = new List<DocManagementListView>();
                    docListView = LoadDocListView(DocList);
                    documentDTGV.DataSource = docListView;
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ tên và mã văn bản", "Cập nhật văn bản", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void ValidDateDel_Click(object sender, EventArgs e)
        {
            ValidDatePicker.CustomFormat = " ";
        }

        private void ExpiryDateDel_Click(object sender, EventArgs e)
        {
            ExpireDatePicker.CustomFormat = " ";
        }

        private void documentDTGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            documentDTGV.ClearSelection();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(searchContent.Text))
            {
                var context = new DocCheckEntities();
                var filteredDocs = context.DocManagements.Where(x => x.DocumentCode.Contains(searchContent.Text.ToLower().ToString())).ToList();

                if (filteredDocs.Count > 0)
                {
                    documentDTGV.DataSource = filteredDocs;

                }
            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            AddBtn.Enabled = true;
            EditBtn.Enabled = false;
            NameTB.Text = "";
            CodeTB.Text = "";
            NoteTb.Text = "";
            IsAlternativeCB.Checked = false;
            ValidDatePicker.CustomFormat = " ";
            ExpireDatePicker.CustomFormat = " ";
            DocFilterCB.SelectedIndex = 0;
            InvalidCheckbox.Checked = false;

            ReloadAlternativeCombobox();

            var context = new DocCheckEntities();
            var DocList = context.DocManagements.ToList<DocManagement>();
            var docListView = new List<DocManagementListView>();
            docListView = LoadDocListView(DocList);
            documentDTGV.DataSource = docListView;
        }

        private void DocFilterCB_SelectedValueChanged(object sender, EventArgs e)
        {
            var context = new DocCheckEntities();

            if (DocFilterCB.SelectedIndex == 1)
            {
                var DocList = context.DocManagements.Where(x => x.IsInvalid == false).ToList();

                if (DocList.Count > 0)
                {
                    var docListView = new List<DocManagementListView>();
                    docListView = LoadDocListView(DocList);
                    documentDTGV.DataSource = docListView;
                }
                else
                {
                    DocList = new List<DocManagement>();
                    var docListView = new List<DocManagementListView>();
                    documentDTGV.DataSource = docListView;
                }
            }


            if (DocFilterCB.SelectedIndex == 2)
            {
                var DocList = context.DocManagements.Where(x => x.IsInvalid == true).ToList();

                if (DocList.Count > 0)
                {
                    var docListView = new List<DocManagementListView>();
                    docListView = LoadDocListView(DocList);
                    documentDTGV.DataSource = docListView;
                }
                else
                {
                    DocList = new List<DocManagement>();
                    var docListView = new List<DocManagementListView>();
                    documentDTGV.DataSource = docListView;
                }
            }


            if (DocFilterCB.SelectedIndex == 3)
            {
                var DocList = context.DocManagements.Where(x => x.IsAlternativeDoc == true).ToList();

                if (DocList.Count > 0)
                {
                    var docListView = new List<DocManagementListView>();
                    docListView = LoadDocListView(DocList);
                    documentDTGV.DataSource = docListView;
                }
                else
                {
                    DocList = new List<DocManagement>();
                    var docListView = new List<DocManagementListView>();
                    documentDTGV.DataSource = docListView;
                }
            }

            if (DocFilterCB.SelectedIndex == 4)
            {
                var DocList = context.DocManagements.ToList();

                if (DocList.Count > 0)
                {
                    var docListView = new List<DocManagementListView>();
                    docListView = LoadDocListView(DocList);
                    documentDTGV.DataSource = docListView;
                }
                else
                {
                    DocList = new List<DocManagement>();
                    var docListView = new List<DocManagementListView>();
                    docListView = LoadDocListView(DocList);
                    documentDTGV.DataSource = docListView;
                }
            }
        }
        private void ReloadAlternativeCombobox ()
        {
            var context = new DocCheckEntities();
            //alternative doc load
            var AltDocCode = context.DocManagements.ToList<DocManagement>().Where(x => x.SourceDoc == 0).ToList();

            AltDocComboBox.DataSource = null;
            ComboboxDatalist.Clear();
            
            ComboboxDatalist.Add(new DocManagement() { ID = 0, DocumentCode = "Vui lòng chọn văn bản gốc" });
            if (AltDocCode.Count > 0)
            {

                foreach (var item in AltDocCode)
                {
                    ComboboxDatalist.Add(new DocManagement() { ID = item.ID, DocumentCode = item.DocumentCode });
                    //AltDocComboBox.Items.Add(item.DocumentCode);
                }

                
                AltDocComboBox.DataSource = ComboboxDatalist;
                AltDocComboBox.DisplayMember = "DocumentCode";
                AltDocComboBox.ValueMember = "ID";
                AltDocComboBox.SelectedIndex = 0;
            }
        }

        private List<DocManagementListView> LoadDocListView (List<DocManagement> DocList)
        {
            var context = new DocCheckEntities();
            var docListView = new List<DocManagementListView>();
           
            foreach (var item in DocList)
            {
                if (item.SourceDoc == 0)
                {
                    docListView.Add(new DocManagementListView()
                    {
                        ID = item.ID,
                        DocumentTitle = item.DocumentTitle,
                        DocumentCode = item.DocumentCode,
                        IssueDate = item.IssueDate,
                        ValidDate = item.ValidDate,
                        ExpireDate = item.ExpireDate,
                        Note = item.Note,
                        IsAlternativeDoc = item.IsAlternativeDoc,
                        IsInvalid = item.IsInvalid,
                        SourceDoc = item.SourceDoc,
                        SourceDocString = " "
                    });
                }
                else
                {
                    docListView.Add(new DocManagementListView()
                    {
                        ID = item.ID,
                        DocumentTitle = item.DocumentTitle,
                        DocumentCode = item.DocumentCode,
                        IssueDate = item.IssueDate,
                        ValidDate = item.ValidDate,
                        ExpireDate = item.ExpireDate,
                        Note = item.Note,
                        IsAlternativeDoc = item.IsAlternativeDoc,
                        IsInvalid = item.IsInvalid,
                        SourceDoc = item.SourceDoc,
                        SourceDocString = context.DocManagements.ToList<DocManagement>().Where(x => x.ID == item.SourceDoc).First().DocumentCode
                    });
                }
            }

            return docListView;
        }
    }
}
