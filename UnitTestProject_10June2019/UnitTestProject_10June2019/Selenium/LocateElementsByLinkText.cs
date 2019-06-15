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
    public class LocateElementsByLinkText
    {
    [Test]
    public void LocateLinks() 
    {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            //maximize the window
            driver.Manage().Window.Maximize(); //Maximizing your browser
            //Get the Page Title 
            String title = driver.Title;
            Console.WriteLine("Title of the page : " + title);
            Console.WriteLine("CUrrent URL of the Page :" + driver.Url);
            //Identify the BMI link by linktext and click on BMI link
            driver.FindElement(By.LinkText("BMI")).Click();
            Console.WriteLine("Title of the Current Page :" + driver.Title);
            driver.Navigate().Back();
            System.Threading.Thread.Sleep(1000);
            driver.Navigate().Forward();
            driver.FindElement(By.PartialLinkText("Watcher")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.Navigate().Refresh();
            IWebElement SynergyElement = driver.FindElement(By.Id("w5energy"));
            SynergyElement.SendKeys("444");

        }
    }
}
