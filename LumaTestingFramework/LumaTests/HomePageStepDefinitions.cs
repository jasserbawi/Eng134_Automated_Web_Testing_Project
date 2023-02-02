using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using LumaTestingFramework.Website.Pages;

namespace LumaTests;

public class HomePageStepDefinitions
{
    private SL_Homepage<ChromeDriver> SL_Website = new();
    private IWebDriver _driver;
    
    [Given(@"I am on the homepage")]
    public void GivenIAmOnTheHomepage()
    {
        throw new PendingStepException();
    }

    [When(@"I click on the New Luma Yoga Collection")]
    public void WhenIClickOnTheNewLumaYogaCollection()
    {
        throw new PendingStepException();
    }

    [Then(@"I am taken to the New Luma Yoga Collection page")]
    public void ThenIAmTakenToTheNewLumaYogaCollectionPage()
    {
        throw new PendingStepException();
    }

    [When(@"I click on the Luma Pants Collection Discount")]
    public void WhenIClickOnTheLumaPantsCollectionDiscount()
    {
        throw new PendingStepException();
    }

    [Then(@"I am taken to the Luma Pants Collection Discount page")]
    public void ThenIAmTakenToTheLumaPantsCollectionDiscountPage()
    {
        throw new PendingStepException();
    }

    [When(@"I click on the Tees Collection Discount")]
    public void WhenIClickOnTheTeesCollectionDiscount()
    {
        throw new PendingStepException();
    }

    [Then(@"I am taken to the Tees Collection Discount page")]
    public void ThenIAmTakenToTheTeesCollectionDiscountPage()
    {
        throw new PendingStepException();
    }

    [When(@"I click Erin Recommends")]
    public void WhenIClickErinRecommends()
    {
        throw new PendingStepException();
    }

    [Then(@"I am taken to the Erin Recommends page")]
    public void ThenIAmTakenToTheErinRecommendsPage()
    {
        throw new PendingStepException();
    }

    [When(@"I click Shop Performance")]
    public void WhenIClickShopPerformance()
    {
        throw new PendingStepException();
    }

    [Then(@"I am taken to the Science Meets Performance Collection page")]
    public void ThenIAmTakenToTheScienceMeetsPerformanceCollectionPage()
    {
        throw new PendingStepException();
    }

    [When(@"I click on the Eco-Friendly Collection")]
    public void WhenIClickOnTheEco_FriendlyCollection()
    {
        throw new PendingStepException();
    }

    [Then(@"I am taken to the Eco-Friendly Collection page")]
    public void ThenIAmTakenToTheEco_FriendlyCollectionPage()
    {
        throw new PendingStepException();
    }

}
