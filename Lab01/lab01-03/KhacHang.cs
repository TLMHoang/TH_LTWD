using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01_03
{
    class KhacHang
    {
        private string id;
        private string name;
        private DateTime date;
        private double soLuong;
        private double donGia;
        private double dinhMuc;
        private double thanhTien;
        private string doiTuong;
        private string quocTich;

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public double SoLuong { get => soLuong; set => soLuong = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public double DinhMuc { get => dinhMuc; set => dinhMuc = value; }
        public string DoiTuong { get => doiTuong; set => doiTuong = value; }
        public string QuocTich { get => quocTich; set => quocTich = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }

        public KhacHang()
        {

        }

        public KhacHang(string ID, string Name, DateTime date, string DoiTuong, double SoLuong, double DonGia, double DinhMuc)
        {

        }

        public KhacHang(string ID, string Name, DateTime date, string QuocTich, double SoLuong, double DonGia)
        {

        }

        public virtual void Input()
        {
            Console.Write("Nhâp Mã: ");
            Id = Console.ReadLine();
            Console.Write("Nhâp tên: ");
            Name = Console.ReadLine();


        }

        public virtual void Output()
        {
            Console.WriteLine(" Mã: {0}\n Tên: {1}\n Quốc tịch: {2}\n Ngày: {3}\n Số lượng: {4}\n Đơn giá: {5}", Id, Name, QuocTich, Date, SoLuong, DonGia);
        }

        public static double TinhThanhTienVN(double DonGia, double DinhMuc, double SoLuong)
        {
            return (DonGia > DinhMuc) ? (DonGia * SoLuong) : (DonGia * DinhMuc * SoLuong + ((SoLuong - DinhMuc) * DonGia * 2.5));
        }
    }
}
