using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1b
{
    //class Student : IComparable
    class Student
    {
        //xep theo 1 bien
        //public int CompareTo(object obj)
        //{
        //    int iCompare = Convert.ToInt32(this.DTB1 - (obj as Student).DTB1);
        //    return iCompare;
        //}
        public class SortList2Val : Comparer<Student>
        {
            public override int Compare(Student x, Student y)
            {
                if (x.DTB1.CompareTo(y.DTB1) != 0)
                {
                    return x.DTB1.CompareTo(y.DTB1);
                }
                else
                {
                    return x.NameStudent1.CompareTo(y.NameStudent1);
                }
            }
        }

        private string StudentID;
        private string NameStudent;
        private double DTB;
        private string Khoa;

        public string StudentID1
        {
            get
            {
                return StudentID;
            }

            set
            {
                StudentID = value;
            }
        }

        public string NameStudent1
        {
            get
            {
                return NameStudent;
            }

            set
            {
                NameStudent = value;
            }
        }


        public string Khoa1
        {
            get
            {
                return Khoa;
            }

            set
            {
                Khoa = value;
            }
        }

        public double DTB1
        {
            get
            {
                return DTB;
            }

            set
            {
                DTB = value;
            }
        }

        
        public static void InputInfoSV(Student[] arrStudents, int N)
        {
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

            Console.WriteLine("\n\n\n\n");
        }

        public static void OutputInfoSV(Student[] arrStudents)
        {
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            foreach (Student sv in arrStudents)
            {
                Console.WriteLine("MSSV: {0}\nTen : {1} \nDTB: {2} \nKhoa: {3}\n\n", sv.StudentID1, sv.NameStudent1, sv.DTB1, sv.Khoa1);
            }
        }


        public static void OutputInfoSVByList(List<Student> listSV)
        {
            Console.Clear();
            foreach (Student sv in listSV)
            {
                Console.WriteLine("MSSV: {0}\nTen : {1} \nDTB: {2} \nKhoa: {3}\n\n", sv.StudentID1, sv.NameStudent1, sv.DTB1, sv.Khoa1);
            }
        }

        public static bool XuatTheoKhoa(string Query, List<Student> listSV)
        {
            int i = 0;
            foreach (Student sv in listSV)
            {
                if (sv.Khoa.ToUpper() == "CNTT")
                {
                    Console.WriteLine("MSSV: {0}\nTen : {1} \nDTB: {2} \nKhoa: {3}\n\n", sv.StudentID1, sv.NameStudent1, sv.DTB1, sv.Khoa1);
                    i++;
                }
            }
            return (i == 0) ? false : true;
        }

        
    }

}
