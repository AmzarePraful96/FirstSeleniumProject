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
    public class PopUpHandling
    {
     [Test]
     public void AlertPopupMethod() {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.opencart.com/");
            //maximize the window
            driver.Manage().Window.Maximize(); //Maximizing your browser
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                //https://www.w3schools.com/js/js_popup.asp
                //  js.ExecuteScript("alert('This is an information Box');");
                System.Threading.Thread.Sleep(2000);
                IAlert alert = driver.SwitchTo().Alert();
                String alertMsg = alert.Text;
                alert.Accept(); //Click on Ok button
                                //Verify the alert Message
                if (alertMsg.Equals("This is an information Box"))
                    Console.WriteLine("Alert Message Match Found");
                else
                    Console.WriteLine("Alert Message Match Not Found");
            }
            catch (NoAlertPresentException e)
            {
                Console.WriteLine("Alert is not Present");
            }

            //confirm alert popup
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript("confirm('DO you want to continue(y/n)?');");
            System.Threading.Thread.Sleep(2000);
            IAlert alert1 = driver.SwitchTo().Alert();
            String alertMsg1 = alert1.Text;
            alert1.Dismiss(); //Click on Cancel button
            //Verify the alert Message
            if (alertMsg1.Equals("DO you want to continue(y/n)?"))
                Console.WriteLine("Alert Message Match Found");
            else
                Console.WriteLine("Alert Message Match Not Found");
            }
    
        }
    }

