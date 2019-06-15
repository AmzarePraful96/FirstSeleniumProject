using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject_10June2019.Selenium
{
    [TestFixture]
    public class FrameHandling
    {
      [Test]
      public void FrameTest() {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://jqueryui.com/droppable/");
            //maximize the window
            driver.Manage().Window.Maximize(); //Maximizing your browser
            IWebElement frameElement = driver.FindElement(By.ClassName("demo-frame"));
            driver.SwitchTo().Frame(frameElement);
            System.Threading.Thread.Sleep(2000);
            IWebElement dragElement = driver.FindElement(By.Id("draggable"));
            IWebElement dropElement = driver.FindElement(By.Id("droppable"));
            //Perfrom drap and drop operation  - Mouse Operation
            //Create an instance Actions class 
            Actions actions = new Actions(driver);
            actions.DragAndDrop(dragElement, dropElement).Perform();
            if (dropElement.Text.Equals("Dropped!"))
                Console.WriteLine("Drag and Drop Operation is Successful");
            else
                Console.WriteLine("Drag and Drop Operation Failed");

        }
    }
}
