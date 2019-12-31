using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace LAb005
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            List<Student> listStudent = GetTempListStudent();
            ReportDataSource rds = new ReportDataSource("dataSetStudent", listStudent);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();

        }
        public List<Student> GetTempListStudent()
        {
            List<Student> listStudent = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                Student temp = new Student();
                temp.StudentID = "CNTT0120" + i;
                temp.FullName = "Nguyen Van" + i;
                temp.BirthDay = new DateTime(2000, 1, 1);
                temp.Address = "Dia chi" + i;
                listStudent.Add(temp);
            }
            return listStudent;
        }
    }
}
