using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject_10June2019.Csharp
{
    public class HDFCBank : Bank
    {
        public void credit()
        {
            Console.WriteLine("HDFC - Credit");
        }

        public void debit()
        {
            Console.WriteLine("HDFC - Debit");
        }
         
        public void transfermoney()
        {
            Console.WriteLine("HDFC - TransferMoney");
        }

        public void HDFCGetBalance() {
            Console.WriteLine("HDFC - Balance Amount");
        }

        
    }
}
