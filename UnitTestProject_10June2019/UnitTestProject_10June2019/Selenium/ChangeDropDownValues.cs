using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace UnitTestProject_10June2019.Selenium
{
 [TestFixture]
  public  class ChangeDropDownValues
    {
        [Test]
        public void ChangeDropDownSelection()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            //maximize the window
            driver.Manage().Window.Maximize(); //Maximizing your browser
            //Activity drodown element
            IWebElement activitydd = driver.FindElement(By.Id("cactivity"));
            SelectElement select = new SelectElement(activitydd);
            Console.WriteLine("Default Dropdown Value : " + select.SelectedOption.Text);
            //Change the dropdown selection to first dropdown value
            //This is recommended when your dropdown static nature 
            select.SelectByIndex(0);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Current Value changed by index to Basal :" + select.SelectedOption.Text);
            //Change the dropdown value by value  to Active: daily exercise or intense exercise 3-4 times/week
            select.SelectByValue("1.55");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Current Value changed by value = 1.55 [Active] Dropdown Value : " + select.SelectedOption.Text);
            //Change the dropdown value by text to Extra Active: very intense exercise daily, or physical job
            select.SelectByText("Extra Active: very intense exercise daily, or physical job");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Current Value Changed by Text- Extra Active : " + select.SelectedOption.Text);

        }

    }
}
