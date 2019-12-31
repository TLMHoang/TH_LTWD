using Lap04.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap04
{
    public partial class Form1 : Form
    {
        private HandleDB db = new HandleDB();
        private Student s = new Student();
        private List<Falculty> lstFalculty = new List<Falculty>();
        private List<Student> lstStudent = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            lstStudent = db.Student.ToList();
            lstFalculty = db.Falculty.ToList();
            LoadDGV();
            LoadCBX();
        }

        private void LoadCBX()
        {
            foreach (Falculty i in lstFalculty)
            {
                cbxKhoa.Items.Add(i.FacultyName);
            }
        }

        private void LoadDGV()
        {
            List<ClassForDGV> lstdgv = new List<ClassForDGV>();
            foreach (Student i in lstStudent)
            {
                
                lstdgv.Add(new ClassForDGV(i.StudentID, i.FullName, Khoa((int)i.FacultyID), (float)i.AverageScore));
            }

            dgvData.DataSource = lstdgv;
        }

        private string Khoa(int id)
        {
            return lstFalculty.FirstOrDefault(p => p.FacultyID == id).FacultyName;
        }

        private async void btnCapNhap_Click(object sender, EventArgs e)
        {
            s.StudentID = txtMa.Text;
            s.FullName = txtTen.Text;
            s.FacultyID = lstFalculty.FirstOrDefault(p => p.FacultyName == cbxKhoa.SelectedItem.ToString()).FacultyID;
            s.AverageScore = double.Parse(txtDiem.Text);

            if (chbCheck.Checked)
            {
                if ((await s.CapNhap(s)))
                {
                    MessageBox.Show("Cập Nhập thành công");
                }
                else
                {
                    MessageBox.Show("Không có tài khoản này không thể sửa.\n Nhận mặc định là Thêm mới");
                    if ((await s.Them(s)))
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
            }
            else
            {
                if (!(await s.CapNhap(s)))
                {
                    if (await s.Them(s))
                    {
                        lstStudent = db.Student.ToList();
                    }
                }
            }
            lstStudent = db.Student.ToList();
            LoadDGV();

            s = new Student() ;
            
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            s.StudentID = txtMa.Text;
            s.FullName = txtTen.Text;
            s.FacultyID = lstFalculty.FirstOrDefault(p => p.FacultyName == cbxKhoa.SelectedItem.ToString()).FacultyID;
            s.AverageScore = double.Parse(txtDiem.Text);

            if (chbCheck.Checked)
            {
                if (await s.Xoa(s))
                {
                    MessageBox.Show("Xóa Thành công");
                }
                else
                {
                    MessageBox.Show("Không xóa được.\n Thử lại");
                }
            }
            else
            {
                await s.Xoa(s);
            }
            lstStudent = db.Student.ToList();
            LoadDGV();
        }

        private void chbCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCheck.Checked)
            {
                MessageBox.Show("Chế độ sẽ thông báo cho bạn biết đang làm gì.");
            }
            else
            {
                MessageBox.Show("Chế độ sẽ không thông báo. Chỉ thông báo lỗi");
            }
        }

        private void dgvData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMa.Text = dgvData.Rows[dgvData.CurrentRow.Index].Cells[0].Value.ToString();
            txtTen.Text = dgvData.Rows[dgvData.CurrentRow.Index].Cells[1].Value.ToString();
            cbxKhoa.Text = dgvData.Rows[dgvData.CurrentRow.Index].Cells[2].Value.ToString();
            txtDiem.Text = dgvData.Rows[dgvData.CurrentRow.Index].Cells[3].Value.ToString();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            frmFalculty f = new frmFalculty(lstFalculty);
            f.ShowDialog();
        }
    }
}
