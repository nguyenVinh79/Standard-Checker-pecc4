using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Pdf;
using Spire.Pdf.General.Find;
using Spire.Pdf.Graphics;
using Spire.Pdf.Graphics.Fonts;
using Spire.Pdf.Tables;
using static StandardChecker.DiceCoefficientExtensions;

namespace StandardChecker
{
    public partial class InspectionForm : Form
    {

        public InspectionForm()
        {
            InitializeComponent();
        }

        private async void fileLoadingButton_Click(object sender, EventArgs e)
        {
            Progress<ProgressReportModel> progress = new Progress<ProgressReportModel>();
            progress.ProgressChanged += ReportProgress;

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Mở tập tin cần kiểm tra";
            openFile.Filter = "PDF format(.pdf)|*.pdf|Word format(.docx, .doc)|*.doc;*.docx";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var filePath = openFile.FileName;
                var docDirectory = openFile.FileName;
                var indexPdfTag = docDirectory.IndexOf(".pdf");
                var truncatedFilename = docDirectory.Substring(0, docDirectory.Length - 4);

                await Task.Run(() => DocChecking(progress,docDirectory, filePath, truncatedFilename));
             
            }
        }

        

        private void InspectionForm_Load(object sender, EventArgs e)
        {
            AutoModeCheckBox.Checked = true;
        }

        private void AutoModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoModeCheckBox.Checked)
            {
                demoTextBox.Enabled = false;
            }
            else
                demoTextBox.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async Task DocChecking(IProgress<ProgressReportModel> progress,string docDirectory, string filePath, string truncatedFilename)
        {
            try
            {
                ProgressReportModel report = new ProgressReportModel();


                textBox.Invoke((MethodInvoker)(() => textBox.Text = ""));
                var loadingPdfFilename = docDirectory.Remove(0, docDirectory.LastIndexOf('\\') + 1);

                textBox.Invoke((MethodInvoker)(() => textBox.Text = "Đang xử lý file: " + loadingPdfFilename + " \r\n"));


                var pageText = new StringBuilder();
                Boolean HasDetected = false;

                PdfDocument document = new PdfDocument();
                document.LoadFromFile(filePath);

                var progressBarTotalCount = document.Pages.Count;
                progressBarTotalCount += 2;
                report.PercentageComplete = 1 * 100 / progressBarTotalCount;
                progress.Report(report);

                List<string> pageContent = new List<string>();

                foreach (PdfPageBase page in document.Pages)
                {
                    pageContent.Add(page.ExtractText());
                }

                List<String>[] pageContentList = new List<String>[document.Pages.Count];

                for (int i = 0; i < document.Pages.Count; i++)
                {
                    string[] strArray = pageContent[i].ToString().Split();

                    List<string> strList = new List<string>();
                    strList = strArray.Where(x => !string.IsNullOrEmpty(x)).ToList();
                    pageContentList[i] = strList;
                }
                //PdfUsedFont[] usedfont = document.UsedFonts;
                var acceptedMatchLevel = 0.62;
                var matchResult = DiceCoefficientExtensions.DiceCoefficient(Cleanser.Cleanse("2737-1995"), Cleanser.Cleanse("2737-1995"));

                if (!AutoModeCheckBox.Checked)
                {
                    if (!string.IsNullOrEmpty(demoTextBox.Text))
                    {
                        AutoModeCheckBox.Enabled = false;
                        textBox.Invoke((MethodInvoker)(() => textBox.Text = ""));
                        List<string> filterString = new List<string> { "IEC", "TCVN", "QCVN", "TCXD", "ACI", "ASTM", "14TCN", "22TCN" };
                        string cleanDocumentString = demoTextBox.Text;

                        foreach (var item in filterString)
                        {
                            if (cleanDocumentString.Contains(item))
                            {
                                cleanDocumentString = cleanDocumentString.Replace(item, " ").Trim();
                            }
                        }

                        if (cleanDocumentString[cleanDocumentString.Length - 1].ToString() == ".")
                        {
                            cleanDocumentString = cleanDocumentString.Substring(0, cleanDocumentString.Length - 1);
                        }

                        List<string> notifyContent = new List<string>();


                        //foreach (var item in pageContentList)
                        for (var i = 0; i < pageContentList.Count(); i++)
                        {

                            foreach (var item in pageContentList[i])
                            {
                                var matchCheckBool = DiceCoefficientExtensions.DiceCoefficient(Cleanser.Cleanse(cleanDocumentString), Cleanser.Cleanse(item));

                                if (matchCheckBool > acceptedMatchLevel)
                                {
                                    var docCodePosition = pageContent[i].ToString().IndexOf(item, StringComparison.OrdinalIgnoreCase);


                                    if (docCodePosition > 0)
                                    {
                                        HasDetected = true;
                                        //textBox.Text += "Đã phát hiện VB hết hiệu lực - " + item + " trang " + $"{i + 1}" + " \r\n";
                                        var notifyTextTemp = "(Trang " + $"{ i + 1}) " + "Đã phát hiện văn bản - " + item + " - hết hiệu lực";
                                        notifyContent.Add(notifyTextTemp);

                                        //find all matching strings from the first page, even if some of them span multiple lines
                                        PdfTextFind[] findResults = document.Pages[i].FindText(item, TextFindParameter.CrossLine).Finds;

                                        //highlight the search result
                                        foreach (var result in findResults)
                                        {

                                            result.ApplyHighLight(Color.Yellow);
                                        }

                                        //save to file
                                    }

                                }
                            }
                        }
                        if (HasDetected)
                        {
                            //document.Pages.Add();
                            PdfPageBase docResultPage = document.Pages.Add();
                            PdfTrueTypeFont font = new PdfTrueTypeFont(new Font("Arial", 12f, FontStyle.Regular), true);
                            PdfSolidBrush brush = new PdfSolidBrush(Color.Blue);
                            PdfStringFormat leftAlignment = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);

                            var lineOffset = 35;

                            var pagebreakcount = 43;
                            var objectCount = 0;

                            foreach (var item in notifyContent)
                            {
                                if (objectCount < pagebreakcount)
                                {
                                    docResultPage.Canvas.DrawString(item, font, brush, 0, lineOffset, leftAlignment);
                                    //docResultPage.Canvas.DrawString("test file", font, brush, 0, 30, leftAlignment);
                                    lineOffset += 15;
                                    objectCount++;
                                }
                                else
                                {
                                    objectCount = 0;
                                    lineOffset = 35;
                                    docResultPage = document.Pages.Add();
                                    font = new PdfTrueTypeFont(new Font("Arial", 12f, FontStyle.Regular), true);
                                    brush = new PdfSolidBrush(Color.Blue);
                                    leftAlignment = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);
                                }

                            }

                            document.SaveToFile(truncatedFilename + $" Checked on {DateTime.Now.Day}-{DateTime.Now.Month}@{DateTime.Now.Hour}-{DateTime.Now.Minute}" + ".pdf", FileFormat.PDF);

                            MessageBox.Show("Hoàn tất", "Kiểm tra văn bản lỗi thời", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy văn bản hết hiệu lực trong tài liệu", "Kiểm tra văn bản lỗi thời", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {

                        //document.Pages.Add();
                        PdfPageBase docResultPage = document.Pages.Add();
                        PdfTrueTypeFont font = new PdfTrueTypeFont(new Font("Arial", 12f, FontStyle.Regular), true);
                        PdfSolidBrush brush = new PdfSolidBrush(Color.Blue);
                        PdfStringFormat leftAlignment = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);

                        MessageBox.Show("Vui lòng nhập mã văn bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else
                {


                    List<string> filterString = new List<string> { "IEC", "TCVN", "QCVN", "TCXD", "ACI", "ASTM", "14TCN", "22TCN" };

                    var cleanDocumentList = new List<DocManagement>();

                    var context = new DocCheckEntities();
                    var InvalidDocList = context.DocManagements.Where(x => x.IsInvalid == true).ToList();

                    List<string> notifyContent = new List<string>();
                    List<string> notifyAltContent = new List<string>();
                    List<string> notifyAbsoluteCheckContent = new List<string>();
                    List<string> relativeResultList = new List<string>();

                    String[] relativeResultData = { };
                    relativeResultList.Add("Trang$Ky hieu VB$VB tham chieu$VB thay the");

                    var AlternativeList = context.DocManagements.Where(x => x.SourceDoc != 0).ToList();
                    var SourceOfAltDocList = new List<DocManagement>();
                    var AlternativeNoteList = new List<string>();
                    //get source list from alternative Doc
                    if (AlternativeList.Count > 0)
                    {
                        foreach (var item in AlternativeList)
                        {
                            var SourceItem = context.DocManagements.Find(item.SourceDoc);

                            if (SourceItem != null)
                            {
                                SourceOfAltDocList.Add(SourceItem);
                            }
                        }
                    }

                    #region check alt
                    /*
                    //check alternative doc in object
                    foreach (var itemAltDoc in SourceOfAltDocList)
                    {
                        foreach (var filterItem in filterString)
                        {
                            if (itemAltDoc.DocumentCode.Contains(filterItem))
                            {
                                var cleanDocumentString = itemAltDoc.DocumentCode;
                                cleanDocumentString = cleanDocumentString.Replace(filterItem, " ").Trim();

                                for (var i = 0; i < pageContentList.Count(); i++)
                                {
                                    foreach (var item in pageContentList[i])
                                    {
                                        var matchCheckBool = DiceCoefficientExtensions.DiceCoefficient(Cleanser.Cleanse(cleanDocumentString), Cleanser.Cleanse(item));

                                        if (matchCheckBool >= acceptedMatchLevel)
                                        {
                                            var docCodePosition = pageText.ToString().IndexOf(item, StringComparison.OrdinalIgnoreCase);

                                            if (docCodePosition > 0)
                                            {
                                                var altDoc = context.DocManagements.Where(x => x.SourceDoc == itemAltDoc.ID).First();
                                                var notifyTextTemp = "Đã phát hiện văn bản " + item + " đã được thay thế bởi văn bản :" + altDoc.DocumentCode;
                                                notifyContent.Add(notifyTextTemp);

                                                //find all matching strings from the first page, even if some of them span multiple lines

                                                PdfTextFind[] findResults = document.Pages[i].FindText(item, TextFindParameter.CrossLine).Finds;

                                                //highlight the search result
                                                foreach (var result in findResults)
                                                {
                                                    result.ApplyHighLight(Color.Yellow);
                                                }

                                                //save to file
                                            }

                                        }
                                    }

                                }
                            }
                        }
                    }
                    */
                    #endregion

                    if (InvalidDocList.Count > 0)
                    {
                        foreach (var invalidDoc in InvalidDocList)
                        {
                            var cleanDocumentString = "";
                            cleanDocumentString = invalidDoc.DocumentCode;

                            foreach (var filterItem in filterString)
                            {
                                if (invalidDoc.DocumentCode.Contains(filterItem))
                                {
                                    cleanDocumentString = cleanDocumentString.Replace(filterItem, " ").Trim();
                                }
                            }


                            for (var i = 0; i < pageContentList.Count(); i++)
                            {
                                Dictionary<string, int> docDic = new Dictionary<string, int>();
                                if (pageContentList[i].Count > 0)
                                {
                                    foreach (var item in pageContentList[i])
                                    {
                                        var docItem = item;

                                        if (item[item.Length - 1].ToString() == ".")
                                        {
                                            docItem = item.Substring(0, docItem.Length - 1);
                                        }

                                        if (item[item.Length - 1].ToString() == ",")
                                        {
                                            docItem = item.Substring(0, docItem.Length - 1);
                                        }

                                        if (item[item.Length - 1].ToString() == ")")
                                        {
                                            docItem = item.Substring(0, docItem.Length - 1);
                                        }

                                        if (item[item.Length - 1].ToString() == ";")
                                        {
                                            docItem = item.Substring(0, docItem.Length - 1);
                                        }

                                        var matchCheckBool = DiceCoefficientExtensions.DiceCoefficient(Cleanser.Cleanse(cleanDocumentString), Cleanser.Cleanse(docItem));

                                        if (matchCheckBool >= acceptedMatchLevel)
                                        {

                                            if (!docDic.ContainsKey(docItem))
                                            {
                                                docDic.Add(docItem, 0);
                                            }
                                            else
                                            {
                                                docDic[docItem] += 1;
                                            }

                                            var docCodePosition = pageContent[i].ToString().IndexOf(docItem, StringComparison.OrdinalIgnoreCase);

                                            if (matchCheckBool < 1)
                                            {
                                                //textBox.Text += "Đã phát hiện văn bản " + docItem + " hết hiệu lực " + "(trang " + $"{i + 1})" + " \r\n";
                                                var notifyTextTemp = "(Trang " + $"{i + 1}) " + "Phát hiện văn bản " + docItem + $" (từ {invalidDoc.DocumentCode})" + " hết hiệu lực";

                                                string relativeResultItem = $"{i + 1}${docItem}${invalidDoc.DocumentCode}$";

                                                if (docCodePosition > 0)
                                                {
                                                    HasDetected = true;

                                                    notifyContent.Add(notifyTextTemp);

                                                    var findAltDoc = context.DocManagements.Where(x => x.SourceDoc == invalidDoc.ID).ToList();

                                                    //find all matching strings from the first page, even if some of them span multiple lines
                                                    PdfTextFind[] findResults = document.Pages[i].FindText(docItem, TextFindParameter.CrossLine).Finds;

                                                    //highlight the search result
                                                    findResults[docDic[docItem]].ApplyHighLight(Color.Red);


                                                    if (findAltDoc.Count > 0)
                                                    {

                                                        foreach (var AltItem in findAltDoc)
                                                        {
                                                            notifyTextTemp = "Văn bản " + invalidDoc.DocumentCode + " đã được thay thế bởi văn bản " + AltItem.DocumentCode;
                                                            notifyContent.Add(notifyTextTemp);
                                                            if (findAltDoc.Count < 2)
                                                            {
                                                                relativeResultItem += $"{AltItem.DocumentCode}";
                                                            }
                                                            else
                                                                relativeResultItem += $"{AltItem.DocumentCode} - ";
                                                        }
                                                    }
                                                    else
                                                    {
                                                        relativeResultItem += " ";
                                                    }

                                                    relativeResultList.Add(relativeResultItem);

                                                    relativeResultData = relativeResultList.ToArray();
                                                }
                                            }
                                            else
                                            {
                                                //textBox.Text += "Đã phát hiện văn bản " + docItem + " hết hiệu lực " + "(trang " + $"{i + 1})" + " \r\n";
                                                var notifyTextTemp = "(Trang " + $"{ i + 1}) " + "Đã phát hiện văn bản " + docItem + $" (tham chiếu từ {invalidDoc.DocumentCode})" + " hết hiệu lực";


                                                if (docCodePosition > 0)
                                                {
                                                    HasDetected = true;

                                                    notifyAbsoluteCheckContent.Add(notifyTextTemp);
                                                    var findAltDoc = context.DocManagements.Where(x => x.SourceDoc == invalidDoc.ID).ToList();

                                                    //find all matching strings from the first page, even if some of them span multiple lines
                                                    PdfTextFind[] findResults = document.Pages[i].FindText(docItem, TextFindParameter.CrossLine).Finds;

                                                    //highlight the search result

                                                    findResults[docDic[docItem]].ApplyHighLight(Color.Red);

                                                    if (findAltDoc.Count > 0)
                                                    {

                                                        foreach (var AltItem in findAltDoc)
                                                        {
                                                            notifyTextTemp = "Văn bản " + invalidDoc.DocumentCode + " đã được thay thế bởi văn bản " + AltItem.DocumentCode;
                                                            notifyAbsoluteCheckContent.Add(notifyTextTemp);
                                                        }

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                report.PercentageComplete = (1 + i) * 100 / progressBarTotalCount;

                                progress.Report(report);
                                //Task.Delay(2000);
                            }

                        }

                        //save to file
                        if (HasDetected)
                        {
                            PdfPageBase docResultPage = document.Pages.Add();
                            PdfTrueTypeFont font = new PdfTrueTypeFont(new Font("Arial", 11f, FontStyle.Regular), true);
                            PdfSolidBrush brush = new PdfSolidBrush(Color.Blue);
                            PdfStringFormat leftAlignment = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);

                            var lineOffset = 35;

                            var pagebreakcount = 43;
                            var objectCount = 0;

                            #region relative result in line by line
                            /*
                            docResultPage.Canvas.DrawString("Các kết quả tương đối: ", font, brush, 0, lineOffset, leftAlignment);
                            lineOffset += 15;

                            foreach (var item in notifyContent)
                            {
                                if (objectCount < pagebreakcount)
                                {
                                    docResultPage.Canvas.DrawString(item, font, brush, 0, lineOffset, leftAlignment);

                                    lineOffset += 16;
                                    objectCount++;
                                }
                                else
                                {
                                    objectCount = 0;
                                    lineOffset = 35;
                                    docResultPage = document.Pages.Add();
                                    font = new PdfTrueTypeFont(new Font("Arial", 11f, FontStyle.Regular), true);
                                    brush = new PdfSolidBrush(Color.Blue);
                                    leftAlignment = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);
                                }
                            }
                            */
                            #endregion

                            //docResultPage = document.Pages.Add();
                            font = new PdfTrueTypeFont(new Font("Arial", 11f, FontStyle.Regular), true);
                            brush = new PdfSolidBrush(Color.Green);
                            leftAlignment = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);

                            lineOffset = 35;
                            objectCount = 0;
                            docResultPage.Canvas.DrawString("Các kết quả chính xác tìm được: ", font, brush, 0, lineOffset, leftAlignment);
                            lineOffset += 15;

                            foreach (var item in notifyAbsoluteCheckContent)
                            {
                                if (objectCount < pagebreakcount)
                                {
                                    docResultPage.Canvas.DrawString(item, font, brush, 0, lineOffset, leftAlignment);

                                    lineOffset += 15;
                                    objectCount++;
                                }
                                else
                                {
                                    objectCount = 0;
                                    lineOffset = 35;
                                    docResultPage = document.Pages.Add();
                                    font = new PdfTrueTypeFont(new Font("Arial", 11f, FontStyle.Regular), true);
                                    brush = new PdfSolidBrush(Color.Blue);
                                    leftAlignment = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);
                                }
                            }

                            #region result table
                            //PdfDocument doc = new PdfDocument();
                            PdfSection sec = document.Sections.Add();
                            sec.PageSettings.Width = PdfPageSize.A4.Width;
                            PdfPageBase page = sec.Pages.Add();
                            float y = 25;
                            //title
                            PdfSolidBrush brush1 = new PdfSolidBrush(Color.Black);
                            PdfTrueTypeFont font1 = new PdfTrueTypeFont(new Font("Arial", 12f, FontStyle.Bold));
                            PdfStringFormat format1 = new PdfStringFormat(PdfTextAlignment.Center);

                            page.Canvas.DrawString("Cac ket qua tuong doi tim duoc", font1, brush1, page.Canvas.ClientSize.Width / 2, y, format1);
                            y = y + font1.MeasureString("Trang", format1).Height;
                            y = y + 5;

                            String[][] resultTabledataSource = new String[relativeResultData.Length][];

                            for (int i = 0; i < relativeResultData.Length; i++)  //relativeResultData.Length
                            {
                                resultTabledataSource[i] = relativeResultData[i].Split('$');
                            }

                            PdfTable table = new PdfTable();
                            table.Style.CellPadding = 2;
                            table.Style.BorderPen = new PdfPen(brush1, 0.75f);
                            table.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);
                            table.Style.HeaderSource = PdfHeaderSource.Rows;
                            table.Style.HeaderRowCount = 1;
                            table.Style.ShowHeader = true;
                            table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.LightBlue;
                            table.DataSource = resultTabledataSource;
                            foreach (PdfColumn column in table.Columns)
                            {
                                column.StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
                            }
                            table.Draw(page, new PointF(0, y));

                            #endregion

                            var newFileName = truncatedFilename + $" Checked on {DateTime.Now.Day}-{DateTime.Now.Month}@{DateTime.Now.Hour}-{DateTime.Now.Minute}" + ".pdf";

                            var resultStatus = await Task.Run(() => saveResultPDF(document, newFileName));
                            report.PercentageComplete = (progressBarTotalCount) * 100 / progressBarTotalCount;
                            progress.Report(report);
                            AutoModeCheckBox.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy văn bản hết hiệu lực trong tài liệu", "Kiểm tra văn bản lỗi thời", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                 DialogResult messDialog = MessageBox.Show("Vui lòng kiểm tra kết nối VPN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                if(messDialog == DialogResult.OK)
                {
                    Application.Exit();
                }    
            }
        }
        private async Task<Boolean> saveResultPDF (PdfDocument document,string newFileName)
        {
            await Task.Delay(2500);
            document.SaveToFile(newFileName, FileFormat.PDF);
            textBox.Invoke((MethodInvoker)(() => textBox.Text += "Đã hoàn thành")); 
            return true;
        }

        private void ReportProgress(object sender, ProgressReportModel e)
        {
            progressBar.Value = e.PercentageComplete;
        }
    }
}
