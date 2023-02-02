using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

using LumaTestingFramework.Website.Pages;
using LumaTestingFramework.Website.Driver;

namespace LumaTestingFramework.Website;

public class SL_Website 
{
    #region Pages
    public SL_Homepage Homepage { get; }
    public SL_Basket BasketPage { get; }    

    #endregion

    IWebDriver _driver;
    public SL_Website()
    {
        _driver = DriverSetup();
        Homepage = new SL_Homepage(_driver);
        BasketPage = new SL_Basket(_driver);
       
    }

    public IWebDriver DriverSetup(int pageLoadInSecs = 3, int implicitWaitInSecs = 3, bool headless = true)
    {
        DriverConfig<ChromeDriver> driverConfig = new(pageLoadInSecs, implicitWaitInSecs, headless);
        return driverConfig.Driver;
    }
}
