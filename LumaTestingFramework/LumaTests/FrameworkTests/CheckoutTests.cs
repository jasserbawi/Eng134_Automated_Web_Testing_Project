using LumaTestingFramework.Website.Driver;
using LumaTestingFramework.Website.Pages.Components;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SL_TestAutomationFramework;
using TechTalk.SpecFlow.Configuration.AppConfig;

namespace LumaTests.FrameworkTests;

public class CheckoutTests
{
    private IWebDriver _driver;
    private DriverConfig<ChromeDriver> _driverConfig;

    [Category("Checkout Framework Tests")]
    [Test]
    public void WithItemsInBasket_CanNavigateToCheckoutPage()
    {
        _driverConfig = new(10, 10, true);
        _driver = _driverConfig.Driver;
        _driver.Navigate().GoToUrl(AppConfigReader.BaseUrl + AppConfigReader.MensBottoms);
        //var productList = Product.ProductsList(_driver);
        //productList[0].AddRandomItemToCart();

        //sleep to allow the website to process an item being added to the basket
        Thread.Sleep(1000);

        string checkoutUrl = AppConfigReader.BaseUrl + AppConfigReader.Checkout;
        _driver.Navigate().GoToUrl(checkoutUrl);

        Assert.That(_driver.Url, Is.EqualTo(checkoutUrl));

    }
}
