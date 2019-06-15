using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestProject_10June2019.Csharp
{
     [TestFixture]
     public class Calculate
    {

       //public void sum(int n1, int n2) {
       //     System.Console.WriteLine("Sum(int n1, int n2)");
       //}
       public void sum(double n1, double n2) {
            System.Console.WriteLine("Sum(double n1, double n2)");
        }

        //public void sum(int n1, long n2) {
        //    System.Console.WriteLine("Sum(int n1, long n2)");
        //}

        //public void sum(long n1, int n2)
        //{
        //    System.Console.WriteLine("Sum(long n1, int n2)");
        //}

        public void sum(int n1, int n2, int n3)
        {
            System.Console.WriteLine("Sum(int n1, int n2, int n3)");
        }

        public void sub(int n1, int n2) {
            System.Console.WriteLine("sub(int n1, int n2)");
       }

       [Test]
       public void MethodOverloadTest() {
            sum(10, 20);
            sum(10, 30, 20);
            sum(10.30, 345.66);
       }
    }
}
