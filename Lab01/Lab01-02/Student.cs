using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Student : Person
    {

        private double DTB;
        private string Khoa;

        public Student()
            : base()
        {

        }

        public Student(string ID, string Name, double DTB, string Khoa)
            : base(ID, Name)
        {
            this.DTB1 = DTB;
            this.Khoa1 = Khoa;
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

        public void InputS()
        {
            base.Input("SV");
            Console.Write("Nhap DTB: ");
            DTB1 = double.Parse(Console.ReadLine());
            Console.Write("Nhap Khoa: ");
            Khoa1 = Console.ReadLine();
        }

        public void OuputS()
        {
            base.Ouput();
            Console.WriteLine("DTB: {0}\n, Khoa: {1}\n", DTB1, Khoa1);
        }

    }
    #region CMT
    //public string Khoa1
    //{
    //    get
    //    {
    //        return Khoa;
    //    }

    //    set
    //    {
    //        Khoa = value;
    //    }
    //}

    //public double DTB1
    //{
    //    get
    //    {
    //        return DTB;
    //    }

    //    set
    //    {
    //        DTB = value;
    //    }
    //}


    //public static void InputInfoSV(Student[] arrStudents, int N)
    //{
    //    Console.WriteLine("\n ====NHAP DS SINH VIEN====");
    //    for (int i = 0; i < N; i++)
    //    {
    //        arrStudents[i] = new Student();
    //        Console.Write("Nhap MaSV {0}:", i + 1);
    //        arrStudents[i].StudentID1 = Console.ReadLine();
    //        Console.Write("Nhap Ten SV {0}:", i + 1);
    //        arrStudents[i].NameStudent1 = Console.ReadLine();
    //        Console.Write("Nhap DTB SV {0}:", i + 1);
    //        arrStudents[i].DTB1 = Convert.ToDouble(Console.ReadLine());
    //        Console.Write("Nhap Khoa {0}:", i + 1);
    //        arrStudents[i].Khoa1 = Console.ReadLine();
    //    }

    //    Console.WriteLine("\n\n\n\n");
    //}

    //public static void OutputInfoSV(Student[] arrStudents)
    //{
    //    Console.WriteLine("\n ====XUAT DS SINH VIEN====");
    //    foreach (Student sv in arrStudents)
    //    {
    //        Console.WriteLine("MSSV: {0}\nTen : {1} \nDTB: {2} \nKhoa: {3}\n\n", sv.StudentID1, sv.NameStudent1, sv.DTB1, sv.Khoa1);
    //    }
    //}


    //public static void OutputInfoSVByList(List<Student> listSV)
    //{
    //    Console.Clear();
    //    foreach (Student sv in listSV)
    //    {
    //        Console.WriteLine("MSSV: {0}\nTen : {1} \nDTB: {2} \nKhoa: {3}\n\n", sv.StudentID1, sv.NameStudent1, sv.DTB1, sv.Khoa1);
    //    }
    //}

    //public static bool XuatTheoKhoa(string Query, List<Student> listSV)
    //{
    //    int i = 0;
    //    foreach (Student sv in listSV)
    //    {
    //        if (sv.Khoa.ToUpper() == "CNTT")
    //        {
    //            Console.WriteLine("MSSV: {0}\nTen : {1} \nDTB: {2} \nKhoa: {3}\n\n", sv.StudentID1, sv.NameStudent1, sv.DTB1, sv.Khoa1);
    //            i++;
    //        }
    //    }
    //    return (i == 0) ? false : true;
    //}
    #endregion
}
