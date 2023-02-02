using OpenQA.Selenium;
using SL_TestAutomationFramework;
using LumaTestingFramework.Website.Pages.Components;

namespace LumaTestingFramework.Website.Pages;

public class SL_WomenPage : SL_StandardPage, INavigate
{
    public NavBar NavBar { get; private set; }
    public PageHeader PageHeader { get; private set; }

    protected SL_WomenPage(IWebDriver driver) : base(driver)
    {
    }

    public void Navigate()
    {
        _driver.Navigate().GoToUrl(AppConfigReader.WomensPage);
        NavBar = new NavBar(_driver.FindElement(By.TagName("nav")));
        PageHeader = new PageHeader(_driver.FindElement(By.CssSelector("header[class='page-header']")));
    }
}
