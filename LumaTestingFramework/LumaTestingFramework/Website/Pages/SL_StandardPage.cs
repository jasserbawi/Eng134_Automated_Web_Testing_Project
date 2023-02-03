using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using LumaTestingFramework.Website.Pages.Components;
using OpenQA.Selenium.Interactions;

namespace LumaTestingFramework.Website.Pages;


public abstract class SL_StandardPage
{
    #region Elements
    public IWebElement SigninLink { get; }
    public NavBar NavBar { get; }
    #endregion

    protected IWebDriver _driver;
    public SL_StandardPage(IWebDriver driver)
    {
        _driver = driver;
    }

    /// <summary>
    /// Place the mouse over a webElement on this page
    /// </summary>
    /// <param name="webElement"></param>
    public void MouseOver(IWebElement webElement)
    {
        new Actions(_driver).MoveToElement(webElement).Perform();
    }
}
