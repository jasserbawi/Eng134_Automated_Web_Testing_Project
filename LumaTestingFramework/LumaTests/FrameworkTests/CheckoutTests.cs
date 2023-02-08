using LumaTestingFramework.Website;
using LumaTestingFramework.Website._driver;
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
    private SL_Website _website;

    [Ignore("Descoped")]
    [Category("Checkout Framework Tests")]
    [Test]
    public void WithItemsInBasket_CanNavigateToCheckoutPage()
    {
        _website = new(10, 10, true);
        _website.WomensTops.Navigate();
        _website.WomensTops.AddProductToBasket();
        _website.CheckoutPage.Navigate();

        string checkoutUrl = AppConfigReader.BaseUrl + AppConfigReader.Checkout;

        Assert.That(_website.GetCurrentPageUrl(), Is.EqualTo(checkoutUrl));

    }

    [TearDown]
    public void TearDown()
    {
        _website.DisposeOfDriver();
    }
}
