using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestProject_10June2019.Csharp
{

     [TestFixture]
    public class FirstTest
    {

       [Test]
       public void FirstTestMethod() {
            int i = 100;
            float f = 45.67f;
            double d = 56.455;
            char c = 'f';
            bool flag = true;
            Console.WriteLine("Value of i = " + i);
            Console.WriteLine("Value of f = " + f);
            Console.WriteLine("Value of d = " + d);
            Console.WriteLine("Value of c = " + c);
            Console.WriteLine("Value of flag = " + flag);
        }
    }
}
