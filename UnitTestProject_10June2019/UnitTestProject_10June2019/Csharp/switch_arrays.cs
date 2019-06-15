using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestProject_10June2019
{
    [TestFixture]
    public class switch_arrays
    {
      [Test]
      public void switchArraysMethod() {
            //Switch is used to execution to execute a block of statements
            //for a matchig case statements

         int weekday = 60;

         switch(weekday) 
         {
                case 0: Console.WriteLine("Sunday");break;
                case 1: Console.WriteLine("Monday");break;
                case 2: Console.WriteLine("Tuesday");break;
                case 3: Console.WriteLine("Wednesday");break;
                case 4: Console.WriteLine("Thursday");break;
                case 5: Console.WriteLine("Friday");break;
                case 6: Console.WriteLine("Saturday");break;
                default: Console.WriteLine("Invalid Weekday");break;
         }

            //Arrays
            //datatype[] arrvariablename = new datatype[size];
            int[] marks = new int[5];
            marks[0] = 60;
            marks[1] = 78;
            marks[2] = 45;
            marks[3] = 67;
            marks[4] = 34;
            //marks[5] //indexOutOfRangeException 
            for(int k=0;k<marks.Length;k++) {
                Console.WriteLine("print marks - " + "marks["+k+"] ="+ marks[k]);
            }

            //Two dimensional Array 
            int[,] arr = new int[2,6];
            Console.WriteLine("Number of Rows : " + arr.GetLength(0));
            Console.WriteLine("Number of Cols : " + arr.GetLength(1));
            for (int row = 0;row<arr.GetLength(0);row++) 
            {
             
              for(int col = 0;col<arr.GetLength(1);col++) 
              {
                    arr[row, col] = row + col;
                    Console.Write("arr[" + row + "][" + col + "] =" + arr[row,col]);
              }

            }

      }
    }
}
