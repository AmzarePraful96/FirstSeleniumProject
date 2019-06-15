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
    public class LocateElementsBYIDNameClass
    {
        [Test]
        public void LocateElementsByID() {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            //maximize the window
            driver.Manage().Window.Maximize(); //Maximizing your browser
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Identify element by Id attribute + FindElement which returns a single WebEleemnt
            //If there is a match found, it will return the matching Single WebElement
            //If there is more than match found, it will return the first matching WebElement
            //if there is no match found, It will give an Exception NoElementFoundException
            IWebElement ageElement = driver.FindElement(By.Id("cage"));
            Console.WriteLine("Print the Current Value of age Textbox : " + ageElement.GetAttribute("value"));
            ageElement.Clear();
            ageElement.SendKeys("45");
            Console.WriteLine("Print the Current Value of age Textbox : " + ageElement.GetAttribute("value"));
            Console.WriteLine(ageElement.GetAttribute("id") + " " + ageElement.GetAttribute("name"));
            Console.WriteLine(ageElement.TagName);
            //put a pause of 5 sec
            System.Threading.Thread.Sleep(5000);
            driver.Close(); //Closes the current active browser
        }
        [Test]
        public void LocateElementsByName()
        {
            //Identify the element by name attribute and looping through the Collection
            //There can be more than one element with the same name , 
            //we can use FindElements method to return a list of WebElements matching the Search Criteria
            //If there is a single WebElement returned, it will be a list comprising of single WebElement
            //if there is no match, then it returns an empty list
            //< input type = "radio" name = "csex" id = "csex1" value = "m" checked= "" >
            //< input type = "radio" name = "csex" id = "csex2" value = "f" >
            //Identify elements by name attribute for sex 
            //I want to find out if female is selected or not, if it is not selected, then we will select female
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            //maximize the window
            driver.Manage().Window.Maximize(); //Maximizing your browser

            IList<IWebElement> sexList = driver.FindElements(By.Name("sex"));
            Console.WriteLine(sexList.Count);
            if (sexList.Count > 0)
            {
                foreach (IWebElement sex in sexList)
                {
                    if (sex.GetAttribute("value").Equals("f"))
                    {
                        if (!sex.Selected)
                        {
                            sex.Click();
                            break;
                        }
                    }
                }
            }
            System.Threading.Thread.Sleep(5000);
            driver.Close(); //Closes the current active browser
        }
        [Test]
        public void LocateElementsByClass()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/calorie-calculator.html");
            //maximize the window
            driver.Manage().Window.Maximize(); //Maximizing your browser

            //Identify elements by class attribute  + Extracting data from WebTable
            //Text property to retrieve the data between the opening and closing tag
            //Identify the first table element with class name = cinfoT 
            IWebElement table = driver.FindElement(By.ClassName("cinfoT"));
            //Identify all the rows in the identified table with classname = cinfoT
            IList<IWebElement> Rows = table.FindElements(By.TagName("tr")); //w.r.t table element
            foreach(IWebElement row in Rows)
            {
                IList<IWebElement> Cols = row.FindElements(By.TagName("td"));
                {
                   foreach(IWebElement col in Cols)
                   {
                        Console.Write(col.Text + "\t");
                   }
                   Console.WriteLine("\n");
                }
            }
            System.Threading.Thread.Sleep(2000);
            driver.Close();
            //driver.FindElement(By.Id("cage")).SendKeys("45");
        }
    }
}

