using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestProject_10June2019.Csharp
{
    [TestFixture]
     public class Car : Vehicle
    {
        public long speed = 200;
        public void run()
        {
            Console.WriteLine("Car - run method");
        }


        [Test]
      public void CarInheritanceTest() {
            ///Create an instance of child class Car
            Car c = new Car();
            Console.WriteLine("Speed is " + c.speed);
            c.run();
      }
    }
}
