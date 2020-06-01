using NUnit.Framework.Internal.Execution;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumBasicTest.UI.PageObjects
{
    public class Product
        {
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public string UnitPrice { get; set; }
        public string UnitStock { get; set; }
        public string UnitsOnOrder { get; set; }
        public string ReorderLevel { get; set; }
        public string Discounted { get; set; }

        public Product(string ProductName, string QuantityPerUnit, string UnitPrice, string UnitStock, string UnitsOnOrder, string ReorderLevel)
        {
            this.ProductName = ProductName;
            this.QuantityPerUnit = QuantityPerUnit;
            this.UnitPrice = UnitPrice;
            this.UnitStock = UnitStock;
            this.UnitsOnOrder = UnitsOnOrder;
            this.ReorderLevel = ReorderLevel;            
        }
    }
}
