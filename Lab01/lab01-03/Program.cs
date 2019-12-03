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



            var KQFind = listKhacHang.Find(p => p.Id == Console.ReadLine());

            if (KQFind == null)
            {
                Console.WriteLine("Khong co Id do");
            }
            else
            {
                KQFind.Output();
            }
            Console.ReadKey();
        }

        static void BaiLam(List<KhacHang> list)
        {
            var listVN = list.Where(p => (p is VietNam)).ToList();
            if (listVN.Count != 0)
            {
                Console.WriteLine("Trung binh so luong VN: {0}", listVN.Average(p => p.SoLuong));
            }
            else
            {
                Console.WriteLine("Khong có Hoa don VN");
            }
            
            //list.Average(p => p.SoLuong);
            var listNG = list.Where(p => (p is NuocNgoai)).ToList();
            if (listVN.Count != 0)
            {
                Console.WriteLine("Trung binh so luong Nuoc Ngoai: {0}", listNG.Average(p => p.SoLuong));

                Console.WriteLine("Trung binh thanh tien nuoc ngoai: {0}", listVN.Average(p => p.ThanhTien));

            }
            else
            {
                Console.WriteLine("Khong có Hoa don Nuoc ngoai");
            }
           
            var listDate = list.Where(p => p.Date.Month == 9 && p.Date.Year == 2019).ToList();

            if (listDate.Count != 0)
            {
                foreach (var item in listDate)
                {
                    item.Output();
                }
            }
            else
            {
                Console.WriteLine("Khong có Hoa don Nuoc ngoai");
            }
            

        }



}
}
