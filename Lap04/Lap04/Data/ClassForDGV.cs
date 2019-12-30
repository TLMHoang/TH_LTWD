using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap04.Data
{
    class ClassForDGV
    {
        public ClassForDGV() { }
        public ClassForDGV(string iD, string name, string khoa, float diem)
        {
            ID = iD;
            Name = name;
            Khoa = khoa;
            Diem = diem;
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public string Khoa { get; set; }
        public float Diem { get; set; }
        
    }
}
