using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
//using SeleniumExtras.WaitHelpers;

namespace UnitTestProject_10June2019.Selenium
{
    [TestFixture]
    public class WebDriverWaitExample
    {
    [Test]
    public void WebDriverWaitMethod() {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            //maximize the window
            driver.Manage().Window.Maximize(); //Maximizing your browser
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Identify Component Menu
            IWebElement componentMenu = driver.FindElement(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/a"));
            componentMenu.Click();
            //first lets declare an Explicit Wait
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                //put a property check of Element Visibility on Printer Element SubmEnu item
                //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/div/div/ul/li[3]/a")));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/div/div/ul/li[3]/a")));
                //ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/div/div/ul/li[3]/a")));
                IWebElement printerElement = driver.FindElement(By.XPath("//*[@id='menu']/div[2]/ul/li[3]/div/div/ul/li[3]/a"));
                //for Mouse Operations - to move the cursor to PrinterElement
                Actions actions = new Actions(driver);
                //Build is used to consolidate all mouse operations and perform triggers them in sequence
                actions.MoveToElement(printerElement).Click().Build().Perform();
                //actions.MoveToElement(printerElement).Perform();
                //printerElement.Click();
                
            }catch(NoSuchElementException e) {
                Console.WriteLine("Printer Element not found");
            }

        }
    }
}
