using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1b
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Nhap tong so sinh vien N =");
            int N = Convert.ToInt32(Console.ReadLine());
            Student[] arrStudents = new Student[N];
            Student.InputInfoSV(arrStudents, N);
           // Student.OutputInfoSV(arrStudents);

            List<Student> listStudent = new List<Student>();
            listStudent = arrStudents.ToList();
            listStudent.Sort(new Student.SortList2Val());

            Student.OutputInfoSVByList(listStudent);

            Console.Write("Nhap Khoa can tim");
            string Khoa = Console.ReadLine();

            if (Student.XuatTheoKhoa("CNTT", listStudent))
            {
                Console.WriteLine("Khong co sinh vien thuoc khoa " + Khoa);
            }
  

            Console.ReadKey();
        }
    }
}
