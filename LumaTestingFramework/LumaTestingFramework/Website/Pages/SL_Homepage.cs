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
    private IWebElement _radiantTeeRedirect => Driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[3]/div/div/ol/li[1]/div/a"));
    private IWebElement _breateEasyTankRedirect => Driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[3]/div/div/ol/li[2]/div/a"));
    private IWebElement _argusAllWeatherTankRedirect => Driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[3]/div/div/ol/li[3]/div/a"));
    private IWebElement _heroHoodieRedirect => Driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[3]/div/div/ol/li[4]/div/a"));
    private IWebElement _fusionBackpackRedirect => Driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[3]/div/div/ol/li[5]/div/a"));
    private IWebElement _pushItMessengerBagRedirect => Driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[3]/div/div/ol/li[6]/div/a"));

    public void ClickYogaCollections() => _yogaCollectionRedirect.Click();
    public void ClickPantsPromotions() => _pantsPromotionsRedirect.Click();
    public void ClickTeesPromotions() => _teesPromotoinsRedirect.Click();
    public void ClickErinsPromotions() => _erinsRecommendationsRedirect.Click();
    public void ClickPerformanceCollections() => _performanceCollectionsRedirect.Click();
    public void ClickEcoFriendlyCollections() => _ecoFriendlyCollectionsRedirect.Click();
    public void ClickRadiantTee() => _radiantTeeRedirect.Click();
    public void ClickBreatheEasyTank() => _breateEasyTankRedirect.Click();
    public void ClickArgusAllWeatherTank() => _argusAllWeatherTankRedirect.Click();
    public void ClickHeroHoodie() => _heroHoodieRedirect.Click();
    public void ClickFusionBackpack() => _fusionBackpackRedirect.Click();
    public void ClickPushItMessengerBag() => _pushItMessengerBagRedirect.Click();

    public void Navigate()
    {
        _driver.Navigate().GoToUrl(_homePageUrl);
    }
}
