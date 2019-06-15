using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace UnitTestProject_10June2019.PageObjects
{
    public class BMIPage
    {
        IWebDriver driver;
        public BMIPage(IWebDriver driver) {
            this.driver = driver;
            //for initializing the Page ELements you need to use
            //PageFacgtory.initElements
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "cage")]
        private IWebElement ageTextbox;

        [FindsBy(How = How.Name,Using = "csex")]
        private IList<IWebElement> sexList;
        
        [FindsBy(How = How.XPath, Using = "//*[@name='cheightfeet']")]
        private IWebElement heightfeetTextBox;


        public void EnterBMIDetails(String age, String sex, String heightfeet) {
            ageTextbox.Clear();
            ageTextbox.SendKeys(age);
            if (sexList.Count > 0)
            {
                foreach (IWebElement sexElement in sexList)
                {
                    if (sexElement.GetAttribute("value").Equals(sex))
                    {
                        if (!sexElement.Selected)
                        {
                            sexElement.Click();
                            break;
                        }
                    }
                }
            }

            heightfeetTextBox.Clear();
            heightfeetTextBox.SendKeys(heightfeet);


        }

    }
}
