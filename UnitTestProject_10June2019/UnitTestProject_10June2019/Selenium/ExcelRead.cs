using System;
using NUnit.Framework;
using Excel = Microsoft.Office.Interop.Excel;
namespace UnitTestProject_10June2019.Selenium
{
    [TestFixture]
    public class ExcelRead
    {
        Excel.Application xlApp;
        Excel.Workbook xlWorkbook;
        Excel.Worksheet xlWorksheet;
        Excel.Range xlRange;
      [Test]
      public void ExcelReadMethod() {

            xlApp = new Excel.Application();
            xlWorkbook = xlApp.Workbooks.Open("C:/LT_Project_Materials/UnitTestProject_10June2019/UnitTestProject_10June2019/TestData/CalorieCalcData.xlsx");
            xlWorksheet = xlWorkbook.Worksheets[1];
            xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            for(int row=1;row<=rowCount;row++) 
            {
               for(int col=1;col<=colCount;col++) 
               {
                    Console.Write(xlRange.Cells[row, col].Value2.ToString());
               }
                Console.WriteLine("\n");
            }
      }
    }
}
