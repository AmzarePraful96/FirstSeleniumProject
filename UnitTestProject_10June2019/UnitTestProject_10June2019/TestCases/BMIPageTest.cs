using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace UnitTestProject_10June2019.TestCases
{
   [TestFixture]
   public class BMIPageTest
    {

      [Test]
       public void BMIPageTestCase() {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/bmi-calculator.html");
            PageObjects.BMIPage bmipage = new PageObjects.BMIPage(driver);
            bmipage.EnterBMIDetails("44", "f", "5");
       }
    }
}
