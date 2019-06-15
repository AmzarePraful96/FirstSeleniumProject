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
   public class WindowNav
    {
      [Test]
      public void WindowNavigation() 
      {
            try
            {
                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.online.citibank.co.in/products-services/online-services/internet-banking.htm");
                //maximize the window
                driver.Manage().Window.Maximize(); //Maximizing your browser
                                                   //Find the Parent Window Handle
                String ParentWindowId = driver.CurrentWindowHandle;
                Console.WriteLine("Parent Window ID : " + ParentWindowId);
                //Click on Login Now
                IWebElement Login = driver.FindElement(By.XPath("//*[@title='LOGIN NOW']"));
                //Opens a new sub window
                Login.Click();
                //get the list of current window handles
                IList<String> winids = driver.WindowHandles;
                //gets the number of open windows
                Console.WriteLine("Current Number of Open Windows :" + winids.Count);
                String mainWindowId = null;
                String subWindowId = null;
                for (int i = 0; i < winids.Count; i++)
                {
                    //capture the window id of main and sub window
                    mainWindowId = winids[0];
                    subWindowId = winids[1];
                }
                Console.WriteLine("mainWindowId = " + mainWindowId);
                Console.WriteLine("subWindowId = " + subWindowId);
                //switch control to the subwindow
                driver.SwitchTo().Window(subWindowId);
                //identify an element in the subwindow and enter data
                driver.FindElement(By.Id("User_Id")).SendKeys("Selenium");
                //put a wait of 2 secs to check the operation is performed
                //before closing the sub window
                System.Threading.Thread.Sleep(2000);
                driver.Close(); //closing the subwindow
                                //switch control to main window
                driver.SwitchTo().Window(mainWindowId);
                //identify and click on an element in the main window 
                driver.FindElement(By.Id("topMnuinsurance")).Click();
            }catch(NoSuchWindowException e) {
                Console.WriteLine("Window is Closed");
            }catch(Exception e) {
                Console.WriteLine("Generic Exception");
            }




        }
    }
}
