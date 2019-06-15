using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestProject_10June2019.Csharp
{
   [TestFixture]
   public class employee
    {
        public int empid;
        public String empname;
        public String company;

        public employee() {

            Console.WriteLine("Default employee constructor");
        }
        public employee(int empid, String empname,String company) {
            this.empid = empid;
            this.empname = empname;
            this.company = company;

        }


        public void displayEmpInfo() {
            Console.WriteLine("empid = " + empid + " empname = " + empname + " company =" + company);
        }

        [Test]
        public void employeeTest() {
            employee e1 = new employee(); //Object instance
            e1.empid = 100; //first data member initialization
            e1.empname = "Rajesh"; 
            e1.company = "Larsen & Toubro";
            e1.displayEmpInfo();


            employee e3 = new employee(300, "Shreyas", "L&T Infotech");
            e3.displayEmpInfo();

            employee e2 = new employee();
            e2.empid = 200;
            e2.empname = "Kavita";
            e2.company = "Reliance";
            e2.displayEmpInfo();
        }


    }
}
