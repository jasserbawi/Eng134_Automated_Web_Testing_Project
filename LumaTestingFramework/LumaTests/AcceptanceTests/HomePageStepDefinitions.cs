using LumaTestingFramework.Website;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SL_TestAutomationFramework;
using TechTalk.SpecFlow;

namespace LumaTests.AcceptanceTests;

[Binding]
[Scope(Feature = "HomePage")]
public class HomePageStepDefinitions
{
    private SL_Website _website;

    [Before]
    public void Setup() => _website = new SL_Website(25, 25);

    [Given(@"I am on the homepage")]
    public void GivenIAmOnTheHomepage()
    {
        _website.Homepage.Navigate();
    }

    [When(@"I click on the New Luma Yoga Collection")]
    public void WhenIClickOnTheNewLumaYogaCollection()
    {
        _website.Homepage.ClickYogaCollections();
    }

    [Then(@"I am taken to the New Luma Yoga Collection page")]
    public void ThenIAmTakenToTheNewLumaYogaCollectionPage()
    {
        Assert.That(_website.GetCurrentPageUrl(), Is.EqualTo(AppConfigReader.BaseUrl + "collections/yoga-new.html"));
    }

    [When(@"I click on the Luma Pants Collection Discount")]
    public void WhenIClickOnTheLumaPantsCollectionDiscount()
    {
        _website.Homepage.ClickPantsPromotions();
    }

    [Then(@"I am taken to the Luma Pants Collection Discount page")]
    public void ThenIAmTakenToTheLumaPantsCollectionDiscountPage()
    {
        Assert.That(_website.GetCurrentPageUrl(), Is.EqualTo(AppConfigReader.BaseUrl + "promotions/pants-all.html"));
    }


    [When(@"I click on the Tees Collection Discount")]
    public void WhenIClickOnTheTeesCollectionDiscount()
    {
        _website.Homepage.ClickTeesPromotions();
    }

    [Then(@"I am taken to the Tees Collection Discount page")]
    public void ThenIAmTakenToTheTeesCollectionDiscountPage()
    {
        Assert.That(_website.GetCurrentPageUrl(), Is.EqualTo(AppConfigReader.BaseUrl + "promotions/tees-all.html"));
    }

    [When(@"I click Erin Recommends")]
    public void WhenIClickErinRecommends()
    {
        _website.Homepage.ClickErinsPromotions();
    }

    [Then(@"I am taken to the Erin Recommends page")]
    public void ThenIAmTakenToTheErinRecommendsPage()
    {
        Assert.That(_website.GetCurrentPageUrl(), Is.EqualTo(AppConfigReader.BaseUrl + "collections/erin-recommends.html"));
    }

    [When(@"I click Shop Performance")]
    public void WhenIClickShopPerformance()
    {
        _website.Homepage.ClickPerformanceCollections();
    }

    [Then(@"I am taken to the Science Meets Performance Collection page")]
    public void ThenIAmTakenToTheScienceMeetsPerformanceCollectionPage()
    {
        Assert.That(_website.GetCurrentPageUrl(), Is.EqualTo(AppConfigReader.BaseUrl + "collections/performance-fabrics.html"));
    }

    [When(@"I click on the Eco-Friendly Collection")]
    public void WhenIClickOnTheEco_FriendlyCollection()
    {
        _website.Homepage.ClickEcoFriendlyCollections();
    }

    [Then(@"I am taken to the Eco-Friendly Collection page")]
    public void ThenIAmTakenToTheEco_FriendlyCollectionPage()
    {
        Assert.That(_website.GetCurrentPageUrl(), Is.EqualTo(AppConfigReader.BaseUrl + "collections/eco-friendly.html"));
    }

    [AfterScenario]
    public void TearDown() => _website.DisposeOfDriver();
}
