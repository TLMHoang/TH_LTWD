using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01_03
{
    class NuocNgoai : KhacHang
    {
        public override void Input()
        {
            base.Input();
            Console.Write("Nhập Ngày/Tháng/Năm (yyyyMMdd): ");
            //Date = DateTime.ParseExact(Console.ReadLine(), "ddMMyyyy", null);
            Date = DateTime.Today;
            Console.Write("Nhâp Quoc tich: ");
            QuocTich = Console.ReadLine();
            Console.Write("Nhâp số lượng: ");
            SoLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhâp đơn giá: ");
            DonGia = double.Parse(Console.ReadLine());
            ThanhTien = DonGia * SoLuong;
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine(" Thanh tiền {0}", ThanhTien);
            Console.WriteLine("========================================================================");
        }
    }
}
