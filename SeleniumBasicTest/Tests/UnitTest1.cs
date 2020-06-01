using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Interactions;
using SeleniumBasicTest.tests;
using SeleniumBasicTest.BusinessObject;
using SeleniumBasicTest.UI.PageObjects;

namespace SeleniumBasicTest
{
    public class Tests : Base
    {           
        private MainPage mainPage;        
        private Login login = new Login("user", "user");
        private Product Ekzo = new Product("Ekzo", "50 - 1kg box", "68", "40", "30", "0");
        private ProductsPage productsPage;
        private NewProductPage newProductPage;
        [Test]
        public void Test2LoginAddNewProduct()
        {
            mainPage = new MainPage(driver);
            mainPage.LoginNW(login, login);           
            Assert.AreEqual("Home page", driver.FindElement(By.XPath("//h2")).Text);
            mainPage.ClickOnProducts();
            Thread.Sleep(2000);
            productsPage = new ProductsPage(driver);
            productsPage.ClickOnCreateNewBut();
            newProductPage = new NewProductPage(driver);
            newProductPage.CreateNewProduct(Ekzo, Ekzo, Ekzo, Ekzo, Ekzo, Ekzo);           
            Assert.AreEqual("All Products", productsPage.TitleAllProducts());
            productsPage.DeleteProduct();
        }
        [Test]
        public void Test3OpenNewProduct()
        {
            mainPage = new MainPage(driver);
            mainPage.LoginNW(login, login);           
            mainPage.ClickOnProducts();
            productsPage = new ProductsPage(driver);
            productsPage.ClickOnCreateNewBut();
            newProductPage = new NewProductPage(driver);
            newProductPage.CreateNewProduct(Ekzo, Ekzo, Ekzo, Ekzo, Ekzo, Ekzo);                        
            Thread.Sleep(2000);
            Assert.AreEqual("Ekzo", driver.FindElement(By.XPath("//a[text()='Ekzo']")).Text);
            Assert.AreEqual("Confections", driver.FindElement(By.XPath("//a[text()='Ekzo']/parent::td/following-sibling::td[text()='Confections']")).Text);
            Assert.AreEqual("Pavlova, Ltd.", driver.FindElement(By.XPath("//a[text()='Ekzo']/parent::td/following-sibling::td[text()='Pavlova, Ltd.']")).Text);
            Assert.AreEqual("68,0000", driver.FindElement(By.XPath("//a[text()='Ekzo']/parent::td/following-sibling::td[text()='68,0000']")).Text);
            Assert.AreEqual("50 - 1kg box", driver.FindElement(By.XPath("//a[text()='Ekzo']/parent::td/following-sibling::td[text()='50 - 1kg box']")).Text);
            Assert.AreEqual("40", driver.FindElement(By.XPath("//a[text()='Ekzo']/parent::td/following-sibling::td[text()='40']")).Text);
            Assert.AreEqual("30", driver.FindElement(By.XPath("//a[text()='Ekzo']/parent::td/following-sibling::td[text()='30']")).Text);
            Assert.AreEqual("0", driver.FindElement(By.XPath("//a[text()='Ekzo']/parent::td/following-sibling::td[text()='0']")).Text);
            Assert.AreEqual("True", driver.FindElement(By.XPath("//a[text()='Ekzo']/parent::td/following-sibling::td[text()='True']")).Text);
            productsPage.DeleteProduct();
        }
        [Test]
        public void Test4Logout()
        {
            mainPage = new MainPage(driver);
            mainPage.LoginNW(login, login);
            driver.FindElement(By.XPath("//a[text()='Logout']")).Click();
            Assert.AreEqual("Login", driver.FindElement(By.XPath("//h2[text()='Login']")).Text);
        }
        
    }
}