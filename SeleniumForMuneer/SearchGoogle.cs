using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumForMuneer
{
    [TestClass]
    public class SearchGoogle
    {
        [TestMethod]
        public void SearchForMuneer()
        {
            var chromeoptions = new ChromeOptions();
            chromeoptions.AddArguments("headless");

            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeoptions)) 
            {
                driver.Navigate().GoToUrl("https://google.com");
                IWebElement query = driver.FindElement(By.Name("q"));
                query.SendKeys("Cheese");
                query.Submit();
                // Conflict the code change made by user Muneer
            }
        }
    }
}
