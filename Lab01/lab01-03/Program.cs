using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<KhacHang> listKhacHang = new List<KhacHang>();
            Console.WriteLine("Nhap tổng số khách: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("1: Viet Nam. 2: Nuoc Ngoai");
                switch (Convert.ToInt32(Console.ReadKey().KeyChar))
                {
                    case 49:
                        KhacHang VN = new VietNam();
                        VN.Input();
                        listKhacHang.Add(VN);
                        break;
                    case 50:
                        KhacHang NC = new NuocNgoai();
                        NC.Input();
                        listKhacHang.Add(NC);
                        break;
                    default:
                        break;
                }
            }

            foreach (var Value in listKhacHang)
            {
                Value.Output();
            }
            
            Console.ReadKey();
        }

        static double TongSoLuong(List<KhacHang> list, bool VBool)
        {
            if (VBool)
            {
                var listLoaiKhacHang = list.Where(p => (p is VietNam)).ToList();
                return list.Average(p => p.SoLuong);
            }
            else
            {
                var listLoaiKhacHang = list.Where(p => (p is NuocNgoai)).ToList();
                return list.Average(p => p.SoLuong);
            }
        }



    }
}
