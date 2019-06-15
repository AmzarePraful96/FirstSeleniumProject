using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc_ClassLibrary_10June2019;
using NUnit.Framework;
namespace UnitTestProject_10June2019.ClassLibTest
{
    [TestFixture]
    public class CalculateTest
    {

       [Test]
       public void Testaddition() {
            Calculator c = new Calculator();
            c.add(10, 20);
            int result = c.output();
            Console.WriteLine("Sum of 2 numbers " + c.output());
            Assert.AreEqual(30, result);
       }

       [Test]
       public void Testdivision() {
            Calculator c = new Calculator();
            c.divide(20, 10);
            int result = c.output();
            Console.WriteLine("Divide 2 numbers :" + c.output());
            Assert.AreEqual(2, c.output());
       }

    }
}
