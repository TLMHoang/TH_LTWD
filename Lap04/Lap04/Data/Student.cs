namespace Lap04.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    [Table("Student")]
    public partial class Student : ClassInterface<Student>
    {
        HandleDB db = new HandleDB();

        public Student(string studentID, string fullName, double? averageScore, int? facultyID)
        {
            StudentID = studentID;
            FullName = fullName;
            AverageScore = averageScore;
            FacultyID = facultyID;
        }

        public Student() { }

        [StringLength(20)]
        public string StudentID { get; set; }

        [StringLength(200)]
        public string FullName { get; set; }

        public double? AverageScore { get; set; }

        public int? FacultyID { get; set; }


        public Task<bool> Them(Student student)
        {
            try
            {
                if (student != null)
                {
                    db.Student.Add(student);
                    db.SaveChanges();
                    return Task.FromResult(true);
                }
                return Task.FromResult(false);

            }
            catch (Exception ex)
            {
                if (MessageBox.Show("Lỗi thêm thử lại.\n Yes Xem lỗi","Lỗi",MessageBoxButtons.YesNo) == DialogResult.OK)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            return Task.FromResult(false);
        }

        public Task<bool> CapNhap(Student student)
        {
            try
            {
                Student s = db.Student.FirstOrDefault(p => p.StudentID == student.StudentID);
                if (s != null)
                {
                    s.FullName = student.FullName;
                    s.FacultyID = student.FacultyID;
                    s.AverageScore = student.AverageScore;
                    db.SaveChanges();
                    return Task.FromResult(true);
                }
                return Task.FromResult(false);
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("Lỗi Cập nhập thử lại.\n Yes Xem lỗi", "Lỗi", MessageBoxButtons.YesNo) == DialogResult.OK)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            return Task.FromResult(false);
        }

        public Task<bool> Xoa(Student student)
        {
            try
            {
                Student s = db.Student.FirstOrDefault(p => p.StudentID == student.StudentID);
                if (s != null)
                {
                    db.Student.Remove(s);
                    db.SaveChanges();
                    return Task.FromResult(true);
                }
                return Task.FromResult(false);

            }
            catch (Exception ex)
            {
                if (MessageBox.Show("Lỗi Xóa thử lại.\n Yes Xem lỗi", "Lỗi", MessageBoxButtons.YesNo) == DialogResult.OK)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            return Task.FromResult(false);
        }
    }
}
