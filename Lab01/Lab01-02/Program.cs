using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Program
    {
        static void InPutSV(List<Student> listStudent, int i)
        {
            Student SV = new Student();

            Console.Write("Nhap MaSV {0}:", i + 1);
            SV.ID1 = Console.ReadLine();
            Console.Write("Nhap Ten SV {0}:", i + 1);
            SV.Name1 = Console.ReadLine();
            Console.Write("Nhap DTB SV {0}:", i + 1);
            SV.DTB1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap Khoa {0}:", i + 1);
            SV.Khoa1 = Console.ReadLine();

            listStudent.Add(SV);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Person> listPerson = new List<Person>();
            List<Student> listStudent = new List<Student>();
            List<Teacher> listTeacher = new List<Teacher>();

            Console.Write("Nhập số SV vs GV: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("1 De chon SV. 2 de chon GV: ");
                switch (Convert.ToInt32(Console.ReadKey().KeyChar))
                {
                    case 49:
                        Console.WriteLine();
                        Student student = new Student();
                        student.InputS();
                        listPerson.Add(new Person(student.ID1, student.Name1));
                        listStudent.Add(student);


                        break;
                    case 50:
                        Console.WriteLine();
                        Teacher teacher = new Teacher();
                        teacher.InputT();
                        listPerson.Add(new Person(teacher.ID1, teacher.Name1));
                        listTeacher.Add(teacher);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("====================================================================================");
            foreach (Student st in listStudent)
            {
                Console.WriteLine("1: {0}\t2: {1}\t3: {2}\t4: {3}", st.ID1, st.Name1, st.DTB1, st.Khoa1);
            }

            Console.WriteLine("====================================================================================");
            foreach (Teacher st in listTeacher)
            {
                Console.WriteLine("1: {0}\t2: {1}\t3: {2}", st.ID1, st.Name1, st.Address1);
            }

            Console.WriteLine("====================================================================================");
            foreach (Person st in listPerson)
            {
                Console.WriteLine("1: {0}\t2: {1}\t", st.ID1, st.Name1);
            }

            double Max = listStudent.Max(p => p.DTB1);
            Console.WriteLine(Max);

            //var listCNTT = listPerson.Where(p => (p is Student) && (p as Student).Khoa1 == "CNTT").ToList();
            var listCNTT = (from per in listPerson
                            from stu in listStudent
                            where per.ID1 == stu.ID1 && stu.Khoa1 == "CNTT"
                            select stu).ToList();

            
            var maxCNTT = listCNTT.Max(p => p.DTB1);
            var ListMax = listCNTT.Where(p => p.DTB1 == maxCNTT);


            Console.WriteLine("====================================================================================");
            foreach (var A in listCNTT)
            {
                Console.WriteLine("1: {0}\t2: {1}\t3: {2}\t4: {3}", A.ID1, A.Name1, A.DTB1, A.Khoa1);
            }

            Console.ReadKey();
        }

        
    }
}
