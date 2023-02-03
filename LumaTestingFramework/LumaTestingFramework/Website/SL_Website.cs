using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

using LumaTestingFramework.Website.Pages;
using LumaTestingFramework.Website._driver;

namespace LumaTestingFramework.Website;

public class SL_Website 
{
    #region Pages
    public SL_Homepage Homepage { get; }
    public SL_WomenPage WomenPage { get; }
    public SL_CheckoutPage CheckoutPage { get; }
    public SL_MenPage MenPage { get; }
    public SL_MensBottoms MensBottoms { get; }
    public SL_MensTops MensTops { get; }
    public SL_WomensBottoms WomensBottoms { get; }
    public SL_WomensTops WomensTops { get; }
    public SL_BasketPage BasketPage { get; }
    


    #endregion

    IWebDriver _driver;
    public SL_Website(int pageLoadInSecs = 3, int implicitWaitInSecs = 3, bool headless = true)
    {
        DriverConfig<ChromeDriver> driverConfig = new(pageLoadInSecs, implicitWaitInSecs, headless);
        _driver = driverConfig.Driver; ;

        Homepage = new SL_Homepage(_driver);
        CheckoutPage = new SL_CheckoutPage(_driver);
        WomenPage = new SL_WomenPage(_driver);
        MenPage = new SL_MenPage(_driver);
        MensBottoms = new SL_MensBottoms(_driver);
        MensTops = new SL_MensTops(_driver);
        WomensBottoms = new SL_WomensBottoms(_driver);
        WomensTops = new SL_WomensTops(_driver);
        BasketPage = new SL_BasketPage(_driver);

    }

    public string GetCurrentPageUrl() => _driver.Url;
    public void DisposeOfDriver()
    {
        _driver.Quit();
        _driver.Dispose();
    }
}
