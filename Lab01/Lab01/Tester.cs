using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Tester
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap tong so sinh vien N =");
            int N = Convert.ToInt32(Console.ReadLine());
            Student[] arrStudents = new Student[N];
            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            for (int i = 0; i < N; i++) 
            {
                arrStudents[i] = new Student();
                Console.Write("Nhap MaSV {0}:", i + 1);
                arrStudents[i].StudentID1 = Console.ReadLine();
                Console.Write("Nhap Ten SV {0}:", i + 1);
                arrStudents[i].NameStudent1 = Console.ReadLine();
                Console.Write("Nhap DTB SV {0}:", i + 1);
                arrStudents[i].DTB1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhap Khoa {0}:", i + 1);
                arrStudents[i].Khoa1 = Console.ReadLine();
            }
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            foreach (Student sv in arrStudents)
            {
                Console.WriteLine("MSSV: {0}\nTen : {1} \nDTB: {2} \nKhoa: {3}\n =============================================", sv.StudentID1, sv.NameStudent1, sv.DTB1, sv.Khoa1);
            }
            Console.ReadLine();
        }
    }
}
