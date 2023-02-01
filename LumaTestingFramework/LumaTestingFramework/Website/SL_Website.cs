using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

using LumaTestingFramework.Website.Pages;
using LumaTestingFramework.Website.Driver;

namespace LumaTestingFramework.Website;

public class SL_Website 
{
    #region Pages
    public SL_Homepage P { get; }

    #endregion

    IWebDriver _driver;
    public SL_Website()
    {
        _driver = DriverSetup();
        P = new SL_Homepage(_driver);
    }

    public IWebDriver DriverSetup()
    {
        return new ChromeDriver();
    }
}
