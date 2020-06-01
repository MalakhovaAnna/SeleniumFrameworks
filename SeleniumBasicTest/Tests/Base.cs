using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasicTest.tests
{
     public class Base
    {
        protected IWebDriver driver;        
        private string baseURL;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            baseURL = "http://localhost:5000";
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
