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

    [Table("Falculty")]
    public partial class Falculty : ClassInterface<Falculty>
    {
        private HandleDB db = new HandleDB();
        public Falculty(int facultyID, string facultyName)
        {
            FacultyID = facultyID;
            FacultyName = facultyName;
        }

        public Falculty() { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FacultyID { get; set; }

        [StringLength(200)]
        public string FacultyName { get; set; }

        public Task<bool> CapNhap(Falculty obj)
        {
            try
            {
                Falculty s = db.Falculty.FirstOrDefault(p => p.FacultyID == obj.FacultyID);
                if (s != null)
                {
                    s = obj;
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

        public Task<bool> Them(Falculty obj)
        {
            try
            {
                if (obj != null)
                {
                    db.Falculty.Add(obj);
                    db.SaveChanges();
                    return Task.FromResult(true);
                }
                return Task.FromResult(false);

            }
            catch (Exception ex)
            {
                if (MessageBox.Show("Lỗi thêm thử lại.\n Yes Xem lỗi", "Lỗi", MessageBoxButtons.YesNo) == DialogResult.OK)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            return Task.FromResult(false);
        }

        public Task<bool> Xoa(Falculty obj)
        {
            try
            {
                Falculty s = db.Falculty.FirstOrDefault(p => p.FacultyID == obj.FacultyID);
                if (s != null)
                {
                    db.Falculty.Remove(s);
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
