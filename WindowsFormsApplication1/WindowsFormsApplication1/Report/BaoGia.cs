using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Report
{
    public class BaoGia
    {

        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int Unit { get; set; }
        public decimal SellPrice { get; set; }
        
        public BaoGia()
        {

        }
        public BaoGia( string id, string name, int unit, decimal Sell)
   
        {
          
            ProductID = id;
            ProductName = name;
            Unit = unit;
            SellPrice = Sell;
        }


    }
}
