using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestProject_10June2019.Csharp
{
[TestFixture]
   public class BankInterfaceTest
    {
    [Test]
      public void BankTestMethod() {
            ICICIBank icici = new ICICIBank();
            icici.credit();
            icici.debit();
            icici.transfermoney();
            icici.ICICIgetROI();

            HDFCBank hdfc = new HDFCBank();
            hdfc.credit();
            hdfc.debit();
            hdfc.transfermoney();
            hdfc.HDFCGetBalance();

            Bank b = new ICICIBank();
            b.debit();
            b.credit();
            b.transfermoney();
       
      }
    }
}
