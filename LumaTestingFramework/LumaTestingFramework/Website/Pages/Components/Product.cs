using OpenQA.Selenium;

namespace LumaTestingFramework.Website.Pages.Components;

public class Product
{
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
    public void SelectingColour() => ColorOption.Click();
    public void SelectingSize() => SizeOption.Click();
    public void CheckingPrice() => Price.Click();

    public Product(IWebDriver driver, string addToCartButtonXPath, string itemPageLinkXPath, string priceXPath, 
    string colorOptionXPath, string sizeOptionXPath, string addToWishListButtonXPath, string addToCompareButtonXPath)
    {
        AddToCartButton = driver.FindElement(By.XPath(addToCartButtonXPath));
        ItemPageLink = driver.FindElement(By.XPath(itemPageLinkXPath));
        Price = driver.FindElement(By.XPath(priceXPath));
        ColorOption = driver.FindElement(By.XPath(colorOptionXPath));
        SizeOption = driver.FindElement(By.XPath(sizeOptionXPath));
        AddToWishListButton = driver.FindElement(By.XPath(addToWishListButtonXPath));
        AddToCompareButton = driver.FindElement(By.XPath(addToCompareButtonXPath));
    }
}
