using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardChecker
{
    public partial class StandardChecker : Form
    {
        private Form currentChildForm;
        public StandardChecker()
        {
            InitializeComponent();
            this.DoubleBuffered = true ;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).Bounds;
            this.WindowState = FormWindowState.Maximized;
            OpenChildForm(new InspectionForm());
            editMenuButton.BackColor = Color.Transparent;
            checkMenuButton.BackColor = Color.DodgerBlue;
            inforMenuButton.BackColor = Color.Transparent;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkMenuButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InspectionForm());
            editMenuButton.BackColor = Color.Transparent;
            checkMenuButton.BackColor = Color.DodgerBlue;
            inforMenuButton.BackColor = Color.Transparent;
        }

        private void editMenuButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageForm());
            editMenuButton.BackColor = Color.DodgerBlue;
            checkMenuButton.BackColor = Color.Transparent;
            inforMenuButton.BackColor = Color.Transparent;

        }

        private void inforMenuButton_Click(object sender, EventArgs e)
        {
        }

        private void panelWindow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelWindow.Controls.Add(childForm);
            panelWindow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
