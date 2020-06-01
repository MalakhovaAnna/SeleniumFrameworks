using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Threading;
using SeleniumBasicTest.BusinessObject;
using OpenQA.Selenium.Support.UI;
using SeleniumBasicTest.UI.PageObjects;

namespace SeleniumBasicTest.UI.PageObjects
{
    public class ProductsPage
    {
        private IWebDriver driver;

        public ProductsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement AllProductLogo => driver.FindElement(By.XPath("//a[contains(text(),'Create new')]"));
        private IWebElement LogoAllProducts => driver.FindElement(By.XPath("//h2[text()='All Products']"));
        private IWebElement Delete => driver.FindElement(By.XPath("//a[text()='Ekzo']/parent::td/following-sibling::td/a[text()='Remove']"));        
        public NewProductPage ClickOnCreateNewBut()
        {
            AllProductLogo.Click();
            return new NewProductPage(driver);

        }
        public string TitleAllProducts()
        {
            return LogoAllProducts.Text;
        }
        public void DeleteProduct()
        {
            Thread.Sleep(2000);
            Delete.Click();
            IAlert alert = driver.SwitchTo().Alert();
            Thread.Sleep(2000);
            alert.Accept();
        }
        
    }
}
