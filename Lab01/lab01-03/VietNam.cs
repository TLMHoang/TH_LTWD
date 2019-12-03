using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01_03
{
    class VietNam : KhacHang
    {
        public override void Input()
        {
            base.Input();
            Console.Write("Nhập Ngày/Tháng/Năm (yyyyMMdd): ");
            //Date = DateTime.ParseExact(Console.ReadLine(), "ddMMyyyy", null);
            Date = DateTime.Today;
            Console.Write("Nhâp Dối tượng khách hàng: ");
            DoiTuong = Console.ReadLine();
            Console.Write("Nhâp số lượng: ");
            SoLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhâp đơn giá: ");
            DonGia = double.Parse(Console.ReadLine());
            Console.Write("Nhâp Dinh muc: ");
            DinhMuc = double.Parse(Console.ReadLine());
            ThanhTien = TinhThanhTienVN(DonGia, DinhMuc, SoLuong);
            QuocTich = "Việt Nam";
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Đối Tượng khác hàng: {0}\n Định mức: {1}\n Thanh tiền {2}", DoiTuong, DinhMuc, ThanhTien);
            Console.WriteLine("========================================================================");
        }
    }
}
