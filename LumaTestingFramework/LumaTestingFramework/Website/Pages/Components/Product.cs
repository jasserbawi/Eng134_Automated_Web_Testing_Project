using OpenQA.Selenium;

namespace LumaTestingFramework.Website.Pages.Components
{
    public class Product
    {
        private IWebElement _webElement;
        private Dictionary<string, IWebElement> colourOptions;
        private Dictionary<string, IWebElement> sizeOptions;
        IWebElement AddToCartButton { get; set; }
        IWebElement ItemPageLink { get; set; }
        IWebElement Price { get; set; }
        IWebElement AddToWishListButton { get; set; }
        IWebElement AddToCompareButton { get; set; }

        public void AddToCart()
        {
            PickAnySize();
            PickAnyColour();
            AddToCartButton = _webElement.FindElement(By.CssSelector(".action.tocart.primary"));
            AddingToCart();
            Thread.Sleep(2000);
        }
        public void PickAnyColour()
        {
            if (colourOptions.Any())
            {
                var listOfColourOptions = colourOptions.Keys.ToList();
                SelectColor(listOfColourOptions[0]);
            }
        }
        public void PickAnySize()
        {
            if (sizeOptions.Any())
            {
                var listOfSizeOptions = sizeOptions.Keys.ToList();
                SelectSize(listOfSizeOptions[0]);
            }
        }
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
            _webElement = productElement;
            AddToCartButton = productElement.FindElement(By.CssSelector(".action.tocart.primary"));
            ItemPageLink = productElement.FindElement(By.ClassName("product-item-link"));
            Price = productElement.FindElement(By.ClassName("price"));
            AddToWishListButton = productElement.FindElement(By.CssSelector(".action.towishlist"));
            AddToCompareButton = productElement.FindElement(By.CssSelector(".action.tocompare"));

            colourOptions = new();
            var colourSwatch = productElement.FindElement(By.CssSelector(".swatch-attribute.color")).FindElement(By.CssSelector(".swatch-attribute-options.clearfix"));
            var colourElements = colourSwatch.FindElements(By.CssSelector(".swatch-option.color"));
            foreach (var colourElement in colourElements)
            {
                var colour = colourElement.GetAttribute("aria-label");
                colourOptions[colour] = colourElement;
            }

            sizeOptions = new();
            var sizeSwatch = productElement.FindElement(By.CssSelector(".swatch-attribute.size")).FindElement(By.CssSelector(".swatch-attribute-options.clearfix"));
            var sizeElements = sizeSwatch.FindElements(By.CssSelector(".swatch-option.text"));
            foreach (var sizeElement in sizeElements)
            {
                var size = sizeElement.GetAttribute("aria-label");
                sizeOptions[size] = sizeElement;
            }
        }
    }
}