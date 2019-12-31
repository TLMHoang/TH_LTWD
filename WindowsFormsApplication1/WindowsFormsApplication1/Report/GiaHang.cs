using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Report
{
    public class GiaHang
    {
   
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string DVT { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
  
        public GiaHang()
        {

        }
        public GiaHang( string ma, string ten, string dvt, int sl, decimal DG)
        {
     
            MaSP = ma;
            TenSP = ten;
            DVT = dvt;
            SoLuong = sl;
            DonGia = DG;
           
        }
    }
}
