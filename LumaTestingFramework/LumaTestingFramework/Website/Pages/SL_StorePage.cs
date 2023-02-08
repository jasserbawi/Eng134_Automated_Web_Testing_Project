using LumaTestingFramework.Website.Pages.Components;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V107.Runtime;
using SL_TestAutomationFramework;

namespace LumaTestingFramework.Website.Pages;

public abstract class SL_StorePage : SL_StandardPage
{
    protected List<Product> _products; 
    public SL_StorePage(IWebDriver driver) : base(driver)
    {
        _products = new();
    }
    protected List<Product> ProductsList(IWebDriver driver) =>
               driver.FindElements(By.CssSelector(".products.list.items.product-items")).Select(e => new Product(e)).ToList();

    public void AddProductToBasket()
    {
        _products[0].AddToCart();
    }

    public int GetNumberOfProducts()
    {
        return _products.Count();
    }
}
public class SL_MensTops : SL_StorePage, INavigate
{
    public SL_MensTops(IWebDriver driver) : base(driver) { }

    public void Navigate()
    {
        _driver.Navigate().GoToUrl(AppConfigReader.BaseUrl + AppConfigReader.MensTops);
        _products = ProductsList(_driver);
    }
}
public class SL_MensBottoms : SL_StorePage, INavigate
{
    public SL_MensBottoms(IWebDriver driver) : base(driver) { }

    public void Navigate()
    {
        _driver.Navigate().GoToUrl(AppConfigReader.BaseUrl + AppConfigReader.MensBottoms);
        _products = ProductsList(_driver);
    }
}
public class SL_WomensTops : SL_StorePage, INavigate
{
    public SL_WomensTops(IWebDriver driver) : base(driver) { }

    public void Navigate()
    {
        _driver.Navigate().GoToUrl(AppConfigReader.BaseUrl + AppConfigReader.WomensTops);
        _products = ProductsList(_driver);
    }
}
public class SL_WomensBottoms : SL_StorePage, INavigate
{
    public SL_WomensBottoms(IWebDriver driver) : base(driver) { }

    public void Navigate()
    {
        _driver.Navigate().GoToUrl(AppConfigReader.BaseUrl + AppConfigReader.WomensBottoms);
        _products = ProductsList(_driver);
    }
}
