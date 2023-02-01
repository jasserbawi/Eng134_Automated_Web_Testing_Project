using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using LumaTestingFramework.Website.Pages.Components;

namespace LumaTestingFramework.Website.Pages;


public abstract class SL_StandardPage : INavigate
{
    #region Elements
    public IWebElement SigninLink { get; }
    public NavBar NavBar { get; }
    #endregion

    IWebDriver _driver;
    public SL_StandardPage(IWebDriver driver)
    {
        _driver = driver;
    }

    public abstract void Navigate();
}
