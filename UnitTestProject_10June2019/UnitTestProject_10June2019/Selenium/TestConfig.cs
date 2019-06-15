using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Configuration;
namespace UnitTestProject_10June2019.Selenium
{
    [TestFixture]
    public class TestConfig
    {
        [Test]
        public void TestConfigurationSettings()
        {
            //Reference your project with System.Configuration
            //Right Click References > Add References >Select Assemblies [on left panel]
            //Search on System Configuration
            //and select to add the reference to the project
            //add using namespace for System.Configuration
            var ConnectionStringVal = ConfigurationManager.ConnectionStrings["DbConnectionString"];
            Console.WriteLine("Connection String :" + ConnectionStringVal);
            var AppUrl = ConfigurationManager.AppSettings["URL"];
            Console.WriteLine("Application URL :" + AppUrl);
            
        }
    }
}
