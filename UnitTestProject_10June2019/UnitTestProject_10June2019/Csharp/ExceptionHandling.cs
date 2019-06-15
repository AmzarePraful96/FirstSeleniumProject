using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestProject_10June2019.Csharp
{
    [TestFixture]
    public class ExceptionHandling
    {
        [Test]
        public void exceptionmethod()
        {
            try
            {
                int n2 = 10;
                int n3 = 100;
                int n1 = n3 / n2; //failed
                Console.WriteLine("print n1 " + n1);
            }

            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("IndexOutOfRange Exception Occurred");
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Divide by Zero Exception Occurred");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("General Exception Occurred");
            }

            try
            {
                int[] arr = new int[5];
                arr[4] = 600;

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("IndexOutOfRange Exception Occurred");
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Divide by Zero Exception Occurred");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("General Exception Occurred");
            }
            finally {
                Console.WriteLine("Execute the finally block");
            }


        }


    }
}
