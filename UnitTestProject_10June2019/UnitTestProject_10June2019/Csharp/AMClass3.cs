using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject_10June2019.Csharp

{
    public class AMClass3  : AMClass1
    {
        public static void main(String[] args)
        {
            AMClass3 c3 = new AMClass3();
            Console.WriteLine(c3.var1);
            c3.Method1();
        }

    }
}