using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Teacher : Person
    {
        private string Address;

        public Teacher()
            :base()
        {

        }

        public Teacher(string ID, string Name, string Address)
            :base(ID,Name)
        {
            this.Address1 = Address;
        }

        public string Address1
        {
            get
            {
                return Address;
            }

            set
            {
                Address = value;
            }
        }

        public void InputT()
        {
            base.Input("GV");
            Console.Write("Nhap Dia Chi: ");
            Address1 = Console.ReadLine();
        }

        public void OuputT()
        {
            base.Ouput();
            Console.WriteLine("Dia chi: {0}\n", Address1);
        }

    }
}
