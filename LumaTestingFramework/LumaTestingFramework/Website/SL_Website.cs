using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

using LumaTestingFramework.Website.Pages;
using LumaTestingFramework.Website.Driver;

namespace LumaTestingFramework.Website;

public class SL_Website 
{
    #region Pages
    public SL_Homepage Homepage { get; set; }
    public SL_CheckoutPage CheckoutPage { get; set;}
    public SL_WomenPage WomenPage { get; set;}

    #endregion

    IWebDriver _driver;
    public SL_Website(int pageLoadInSecs = 3, int implicitWaitInSecs = 3, bool headless = true)
    {
        _driver = DriverSetup(pageLoadInSecs, implicitWaitInSecs, headless);
        Homepage = new SL_Homepage(_driver);
        CheckoutPage = new SL_CheckoutPage(_driver);
        WomenPage = new SL_WomenPage(_driver);

    }

    public string GetCurrentPageUrl()
    {
        return _driver.Url;
    }

    public IWebDriver DriverSetup(int pageLoadInSecs, int implicitWaitInSecs, bool headless)
    {
        DriverConfig<ChromeDriver> driverConfig = new(pageLoadInSecs, implicitWaitInSecs, headless);
        return driverConfig.Driver;
    }
}
