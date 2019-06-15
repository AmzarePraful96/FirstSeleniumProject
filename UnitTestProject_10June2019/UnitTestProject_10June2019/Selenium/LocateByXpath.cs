using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject_10June2019.Selenium
{
   [TestFixture]
   public class LocateByXpath
    {
        [Test]
        public void LocateByXpathMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            //maximize the window
            driver.Manage().Window.Maximize(); //Maximizing your browser
            IWebElement dd = driver.FindElement(By.Id("cactivity"));
            //Directly point to an element in the dropdown
            //Locate the element 
            IWebElement ActiveElement  = driver.FindElement(By.XPath("//*[@id='cactivity']/option[text()='Active: daily exercise or intense exercise 3-4 times/week']"));
            Console.WriteLine(ActiveElement.Text);
            IList<IWebElement> ActivitElmentList = driver.FindElements(By.XPath("//*[@id='cactivity']/option[contains(text(),'Active')]"));
            foreach(IWebElement e in ActivitElmentList)
            {
                Console.WriteLine(e.Text);
            }

        }
    }
}
