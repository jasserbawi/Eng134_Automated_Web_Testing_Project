using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace LumaTestingFramework.Website.Pages.Components
{
    public class Product
    {
        IWebDriver _driver;
        IWebElement AddToCartButton { get; set; }
        IWebElement ItemPageLink { get; set; }
        IWebElement Price { get; set; }
        IWebElement ColorOption { get; set; }
        IWebElement SizeOption { get; set; }
        IWebElement AddToWishListButton { get; set; }
        IWebElement AddToCompareButton { get; set; }

        public void AddingToCart() => AddToCartButton.Click();
        public void NavigateToItemPage() => ItemPageLink.Click();
        public void AddingToWishList() => AddToWishListButton.Click();
        public void AddingToCompare() => AddToCompareButton.Click();
        public void SelectingColor() => ColorOption.Click();
        public void SelectingSize() => SizeOption.Click();
        public string CheckingPrice() => Price.Text;

        public Product(IWebDriver driver, IWebElement productElement)
        {
            _driver = driver;
            AddToCartButton = productElement.FindElement(By.ClassName("action tocart primary"));
            ItemPageLink = productElement.FindElement(By.ClassName("product-item-link"));
            Price = productElement.FindElement(By.ClassName("price"));
            ColorOption = productElement.FindElement(By.ClassName(""));
            SizeOption = productElement.FindElement(By.ClassName(""));
            AddToWishListButton = productElement.FindElement(By.ClassName("action towishlist"));
            AddToCompareButton = productElement.FindElement(By.ClassName("action tocompare"));
        }

        public static List<Product> ProductsList(IWebDriver driver) =>
            driver.FindElements(By.ClassName("product-items widget-product-grid")).Select(e => new Product(driver, e)).ToList();
    }
}