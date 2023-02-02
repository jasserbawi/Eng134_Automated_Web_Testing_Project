using LumaTestingFramework.Website.Pages.Components;
using OpenQA.Selenium;
using SL_TestAutomationFramework;

namespace LumaTestingFramework.Website.Pages;

public class SL_Homepage : SL_StandardPage, INavigate
{
    public NavBar NavBar { get; private set; }
    public PageHeader PageHeader { get; private set; }
    public SL_Homepage(IWebDriver driver) : base(driver)
    {
        //Setup IWebElements and custom objects
    }
    
    private IWebElement _yogaCollectionRedirect => _driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[1]/a"));
    private IWebElement _pantsPromotionsRedirect => _driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[1]/div/a[1]"));
    private IWebElement _teesPromotoinsRedirect => _driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[1]/div/a[2]"));
    private IWebElement _erinsRecommendationsRedirect => _driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[1]/div/a[3]"));
    private IWebElement _performanceCollectionsRedirect => _driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[1]/div/a[4]"));
    private IWebElement _ecoFriendlyCollectionsRedirect => _driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[1]/div/a[5]"));

    public void ClickYogaCollections() => _yogaCollectionRedirect.Click();
    public void ClickPantsPromotions() => _pantsPromotionsRedirect.Click();
    public void ClickTeesPromotions() => _teesPromotoinsRedirect.Click();
    public void ClickErinsPromotions() => _erinsRecommendationsRedirect.Click();
    public void ClickPerformanceCollections() => _performanceCollectionsRedirect.Click();
    public void ClickEcoFriendlyCollections() => _ecoFriendlyCollectionsRedirect.Click();

    public void Navigate()
    {
        base._driver.Navigate().GoToUrl(AppConfigReader.BaseUrl);
        NavBar = new NavBar(base._driver.FindElement(By.TagName("nav")));
        PageHeader = new PageHeader(base._driver.FindElement(By.CssSelector("header[class='page-header']")));
    }
}
