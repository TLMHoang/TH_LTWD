using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Person
    {
        protected string ID;
        protected string Name;

        public Person()
        {

        }

        public Person(string ID, string Name)
        {
            this.ID1 = ID;
            this.Name1 = Name;
        }

        public string ID1
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }

        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = TenChuan(value);
            }
        }

        public void Input(string Ma)
        {
            Console.Write("Nhap ID: ");
            string IDG = Ma + Console.ReadLine();
            ID1 = IDG;
            Console.Write("Nhap ho ten: ");
            Name1 = Console.ReadLine();
        }

        public void Ouput()
        {
            Console.WriteLine("ID: {0}\n, Ho ten: {1}\n", ID1, Name1);
        }

        public static string TenChuan(string value)
        {
            string stringReturn = "";

            string[] AString = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < AString.Length; i++)
            {
                AString[i] = AString[i].ToLower();
                char[] TG = AString[i].ToCharArray();
                TG[0] = char.ToUpper(TG[0]);

                stringReturn += new string(TG) + " ";
            }

            return stringReturn;
        }

    }
}
