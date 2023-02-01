using OpenQA.Selenium;
using SL_TestAutomationFramework;

namespace LumaTestingFramework.Website.Pages;

public class SL_Homepage : SL_StandardPage, INavigate
{
    public SL_Homepage(IWebDriver driver) : base(driver)
    {
        //Setup IWebElements and custom objects
    }
    
    private string _homePageUrl = AppConfigReader.BaseUrl;   
    private IWebDriver Driver { get; }
    
    private IWebElement _yogaCollectionRedirect => Driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[1]/a"));
    private IWebElement _pantsPromotionsRedirect => Driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[1]/div/a[1]"));
    private IWebElement _teesPromotoinsRedirect => Driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[1]/div/a[2]"));
    private IWebElement _erinsRecommendationsRedirect => Driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[1]/div/a[3]"));
    private IWebElement _performanceCollectionsRedirect => Driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[1]/div/a[4]"));
    private IWebElement _ecoFriendlyCollectionsRedirect => Driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[1]/div/a[5]"));

    public void ClickYogaCollections() => _yogaCollectionRedirect.Click();
    public void ClickPantsPromotions() => _pantsPromotionsRedirect.Click();
    public void ClickTeesPromotions() => _teesPromotoinsRedirect.Click();
    public void ClickErinsPromotions() => _erinsRecommendationsRedirect.Click();
    public void ClickPerformanceCollections() => _performanceCollectionsRedirect.Click();
    public void ClickEcoFriendlyCollections() => _ecoFriendlyCollectionsRedirect.Click();

    public void Navigate()
    {
        _driver.Navigate().GoToUrl(_homePageUrl);
    }
}
