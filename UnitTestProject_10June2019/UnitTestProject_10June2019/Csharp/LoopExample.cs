using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UnitTestProject_10June2019.Csharp
{
    [TestFixture]
    public class LoopExample
    {
       [Test]
       public void LoopExampleMethod() {
            //if 
            //check if the score is <40 => fail >=40 pass
            int score = 39;
            if (score < 40)
                Console.WriteLine("Student Failed - The Score is " + score);
            else if (score >= 40)
                Console.WriteLine("Student Passed and the score is " + score);

            //for loop 
            // Executing a block of statements for a specified number of times
            //summation
            //Print sum of 10 numbers from 1 to 10
            int sum = 0;
            for(int i =1; i<=10;i++) {
                //first initialize, check cond satisfied, execute block of statements
                //increment // then again check cond satisfied, execute block                
                if (i == 5)
                    continue;
                Console.WriteLine("Print i and sum = " + i + " " + sum);
                sum = sum + i;
                
            }
            Console.WriteLine("Sum of 10 numbers  =" + sum);

            //while loop 
            //executing a block of statements as long as the cond is satisfied in the while loop
            sum = 0;
            int j = 1;
            while(j<=10) {
                if (j == 5)
                    break;
                Console.WriteLine("Print i and sum = " + j + " " + sum);
                sum = sum + j;
                j = j + 1;

            }
            Console.WriteLine("Sum of 10 numbers  =" + sum);

        }
    }
}
