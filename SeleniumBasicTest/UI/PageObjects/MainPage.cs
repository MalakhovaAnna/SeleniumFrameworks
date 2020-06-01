using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Interactions;
using SeleniumBasicTest.BusinessObject;
using SeleniumBasicTest.UI.PageObjects;

namespace SeleniumBasicTest
{
    public class MainPage
    {
        protected IWebDriver driver;
        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement NameInput => driver.FindElement(By.XPath("//input[@id='Name']"));
        private IWebElement PasswordInput => driver.FindElement(By.XPath("//input[@id='Password']"));
        private IWebElement LoginButton => driver.FindElement(By.XPath("//input[@type='submit']"));        

        public void LoginNW(Login login, Login Password)
        {
            NameInput.SendKeys(login.Name);
            PasswordInput.SendKeys(Password.Password);            
            LoginButton.Click();                       
        }
        public ProductsPage ClickOnProducts()
        {
            driver.FindElement(By.XPath("//a[text()='All Products']")).Click();
            return new ProductsPage(driver);            
        }

    }
}

