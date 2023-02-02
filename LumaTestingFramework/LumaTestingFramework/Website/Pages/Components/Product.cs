using OpenQA.Selenium;

namespace LumaTestingFramework.Website.Pages.Components
{
    public class Product
    {
        private Dictionary<string, IWebElement> colourOptions;
        private Dictionary<string, IWebElement> sizeOptions;
        IWebElement AddToCartButton { get; set; }
        IWebElement ItemPageLink { get; set; }
        IWebElement Price { get; set; }
        IWebElement AddToWishListButton { get; set; }
        IWebElement AddToCompareButton { get; set; }

        public void AddingToCart() => AddToCartButton.Click();
        public void NavigateToItemPage() => ItemPageLink.Click();
        public void AddingToWishList() => AddToWishListButton.Click();
        public void AddingToCompare() => AddToCompareButton.Click();
        public string CheckingPrice() => Price.Text;
        public void SelectColor(string colour)
        {
            if (colourOptions.TryGetValue(colour, out IWebElement colourOption))
            {
                colourOption.Click();
            }
            else
            {
                throw new Exception("Colour not found: " + colour);
            }
        }

        public void SelectSize(string size)
        {
            if (sizeOptions.TryGetValue(size, out IWebElement sizeOption))
            {
                sizeOption.Click();
            }
            else
            {
                throw new Exception("Size not found: " + size);
            }
        }

        public Product(IWebElement productElement)
        {
            AddToCartButton = productElement.FindElement(By.ClassName("action tocart primary"));
            ItemPageLink = productElement.FindElement(By.ClassName("product-item-link"));
            Price = productElement.FindElement(By.ClassName("price"));
            AddToWishListButton = productElement.FindElement(By.ClassName("action towishlist"));
            AddToCompareButton = productElement.FindElement(By.ClassName("action tocompare"));
            
            var colourElements = productElement.FindElements(By.ClassName("color-option"));
            foreach (var colourElement in colourElements)
            {
                var colour = colourElement.GetAttribute("value");
                colourOptions[colour] = colourElement;
            }
            var sizeElements = productElement.FindElements(By.ClassName("size-option"));
            foreach (var sizeElement in sizeElements)
            {
                var size = sizeElement.GetAttribute("value");
                sizeOptions[size] = sizeElement;
            }
        }

        public static List<Product> ProductsList(IWebDriver driver) =>
            driver.FindElements(By.ClassName("product-items widget-product-grid")).Select(e => new Product(e)).ToList();
    }
}