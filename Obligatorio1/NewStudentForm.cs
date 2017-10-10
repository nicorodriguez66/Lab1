using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obligatorio1
{
    public partial class NewStudentForm : Form
    {
        SchoolERP MainPanel;
        public NewStudentForm(SchoolERP SchoolERPForm)
        {
            InitializeComponent();
            MainPanel = SchoolERPForm;
        }

        private void studentCreateBtn_Click(object sender, EventArgs e)
        {
            student studentcreated = new student();
            studentcreated.EditStudentName(studentNameTxtBox.Text);
            studentcreated.EditStudentSurname(studentSurnameTxtBox.Text);
            studentcreated.EditStudentNumber(Int32.Parse(studentNumberTxtBox.Text));
            studentcreated.EditStudentidCard(Int32.Parse(studentIdCardTxtBox.Text));
            MainPanel.Show();
            //MainPanel.ShowDialog();
            MainPanel.mySystem.showallstudents().Add(studentcreated);
            MainPanel.refreshdata();
            this.Close();
            this.Dispose();

            //AGREGO UNA NUEVA RAMA AL REPO
        }
    }
}
