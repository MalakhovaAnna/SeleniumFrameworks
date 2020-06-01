using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumBasicTest.UI.PageObjects;

namespace SeleniumBasicTest.UI.PageObjects
{
    public class NewProductPage
    {        
            protected IWebDriver driver;

        public NewProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NewProductsPage(IWebDriver driver)
            {
                this.driver = driver;
            }
            private IWebElement ProductNameInput => driver.FindElement(By.XPath("//input[@id='ProductName']"));           
            private IWebElement UnitPriceInput => driver.FindElement(By.XPath("//input[@id='UnitPrice']"));
            private IWebElement QuantityPerUnitInput => driver.FindElement(By.XPath("//input[@id='QuantityPerUnit']"));
            private IWebElement UnitInStockInput => driver.FindElement(By.XPath("//input[@id='UnitsInStock']"));
            private IWebElement UnitInOrderInput => driver.FindElement(By.XPath("//input[@id='UnitsOnOrder']"));
            private IWebElement ReorderLevelInput => driver.FindElement(By.XPath("//input[@id='ReorderLevel']"));
            private IWebElement Checkbox => driver.FindElement(By.XPath("//input[@type='checkbox']"));
            private IWebElement Create => driver.FindElement(By.XPath("//input[@type='submit']"));
            public void CreateNewProduct (Product ProductName, Product UnitPrice, Product QuantityPerUnit, Product UnitStock, Product UnitsOnOrder, Product ReorderLevel)
            {
                ProductNameInput.SendKeys(ProductName.ProductName);
                new SelectElement(driver.FindElement(By.Id("CategoryId"))).SelectByText("Confections");
                new SelectElement(driver.FindElement(By.Id("SupplierId"))).SelectByText("Pavlova, Ltd.");
                UnitPriceInput.SendKeys(UnitPrice.UnitPrice);
                QuantityPerUnitInput.SendKeys(QuantityPerUnit.QuantityPerUnit);
                UnitInStockInput.SendKeys(UnitStock.UnitStock);
                UnitInOrderInput.SendKeys(UnitsOnOrder.UnitsOnOrder);
                ReorderLevelInput.SendKeys(ReorderLevel.ReorderLevel);
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//input[@type='checkbox']"))).Click();
                Create.Click();
        }
        }
}
