using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject_10June2019.Csharp
{
    public class AMClass1
    {
        protected String var1;
        protected void Method1()
        {
            Console.WriteLine("Private - Method1");
        }

        public static void main(String[] args)
        {
            AMClass1 c1 = new AMClass1();
            Console.WriteLine(c1.var1);
            c1.Method1();
        }
    }

    public class AMClass2
    {
       public static void main(String[] args) {
            AMClass1 c1 = new AMClass1();
           // Console.WriteLine(c1.var1);
           // c1.Method1();

        }

    }

    } 

