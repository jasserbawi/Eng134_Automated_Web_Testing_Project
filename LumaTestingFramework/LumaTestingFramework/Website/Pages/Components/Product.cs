using OpenQA.Selenium;
using System.Collections.Generic;

namespace LumaTestingFramework.Website.Pages.Components
{
    public class Product
    {
        IWebDriver _driver;
        public IWebElement AddToCartButton { get; set; }
        public IWebElement ItemPageLink { get; set; }
        public IWebElement Price { get; set; }
        public IWebElement ColorOption { get; set; }
        public IWebElement SizeOption { get; set; }
        public IWebElement AddToWishListButton { get; set; }
        public IWebElement AddToCompareButton { get; set; }

        public Product(IWebDriver driver, IWebElement product)
        {
            _driver = driver;
            AddToCartButton = product.FindElement(By.ClassName("action tocart primary"));
            ItemPageLink = product.FindElement(By.ClassName("product-item-link"));
            Price = product.FindElement(By.ClassName("price"));
            ColorOption = product.FindElement(By.ClassName("swatch-option color"));
            SizeOption = product.FindElement(By.ClassName("swatch-option text"));
            AddToWishListButton = product.FindElement(By.ClassName("action towishlist"));
            AddToCompareButton = product.FindElement(By.ClassName("action tocompare"));
        }

        public void AddingToCart() => AddToCartButton.Click();
        public void NavigateToItemPage() => ItemPageLink.Click();
        public void AddingToWishList() => AddToWishListButton.Click();
        public void AddingToCompare() => AddToCompareButton.Click();
        public void SelectingColour() => ColorOption.Click();
        public void SelectingSize() => SizeOption.Click();
        public void CheckingPrice() => Price.Click();
    }

    public class ProductList
    {
        IWebDriver _driver;
        public List<Product> Products { get; set; }

        public ProductList(IWebDriver driver)
        {
            _driver = driver;
            var homePageProducts = _driver.FindElements(By.ClassName("product-items widget-product-grid"));
            var products = _driver.FindElements(By.ClassName("products list items product-items"));
            Products = new List<Product>();
            foreach (var product in homePageProducts.Count > 0 ? homePageProducts : products)
            {
                Products.Add(new Product(_driver, product));
            }
        }
    }
}