using LumaTestingFramework.Website.Pages.Components;
using OpenQA.Selenium;
using SL_TestAutomationFramework;

namespace LumaTestingFramework.Website.Pages;

public class SL_Homepage : SL_StandardPage, INavigate
{
    #region Fields and properties
    private IWebElement _yogaCollectionRedirect => _driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[1]/a"));
    public NavBar NavBar { get; private set; }
    public PageHeader PageHeader { get; private set; }
    public List<IWebElement> PromoBlock { get; private set; }
    #endregion

    #region Constructors
    public SL_Homepage(IWebDriver driver) : base(driver) { }
    #endregion

    #region Helper Methods
    public void ClickYogaCollections() => _yogaCollectionRedirect.Click();
    public void ClickPantsPromotions() => PromoBlock[0].Click();
    public void ClickTeesPromotions() => PromoBlock[1].Click();
    public void ClickErinsPromotions() => PromoBlock[2].Click();
    public void ClickPerformanceCollections() => PromoBlock[3].Click();
    public void ClickEcoFriendlyCollections() => PromoBlock[4].Click();

    public void Navigate()
    {
        _driver.Navigate().GoToUrl(AppConfigReader.BaseUrl);
        PageHeader = new PageHeader(_driver.FindElement(By.CssSelector("header[class='page-header']")));
        NavBar = new NavBar(_driver.FindElement(By.TagName("nav")));
        PromoBlock = _driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[1]/div")).FindElements(By.TagName("a")).ToList();
    }
    #endregion
}