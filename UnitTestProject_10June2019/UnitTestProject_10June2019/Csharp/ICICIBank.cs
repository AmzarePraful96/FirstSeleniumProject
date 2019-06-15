using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject_10June2019.Csharp
{
    public class ICICIBank : Bank
    {
        public void credit()
        {
            Console.WriteLine("ICICI Bank - Credit");
        }

        public void debit()
        {
            Console.WriteLine("ICICI Bank - Debit");
        }

        public void transfermoney()
        {
            Console.WriteLine("ICICI Bank - TransferMoney");
        }


        //Specific implementation method of the class
        public void ICICIgetROI() {
            Console.WriteLine("ICICIBank - getROI");
        }
    }
}
