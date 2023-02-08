using LumaTestingFramework.Website._driver;
using LumaTestingFramework.Website.Pages.Components;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SL_TestAutomationFramework;
using System;
using TechTalk.SpecFlow;

namespace LumaTests.FrameworkTests;

[Binding]
[Scope(Feature = "NavBar")]
public class NavBarStepDefinitions
{
    private DriverConfig<ChromeDriver> _driverConfig;
    private IWebDriver _driver;
    private NavBar _navBar;

    [BeforeScenario]
    public void Setup()
    {
        _driverConfig = new DriverConfig<ChromeDriver>(3, 3, true);
        _driver = _driverConfig.Driver;
    }

    [Given(@"I am on a page with a nav bar")]
    public void GivenIAmOnAPageWithANavBar()
    {
        _driver.Navigate().GoToUrl(AppConfigReader.BaseUrl);
        _navBar = new(_driver.FindElement(By.Id("store.menu")));
    }

    [When(@"I click on the What's New link")]
    public void WhenIClickOnTheWhatsNewLink()
    {
        _navBar.ClickOnWhatsNew();
    }

    [Then(@"I land on the What's New page")]
    public void ThenILandOnTheWhatsNewPage()
    {
        Assert.That(_driver.Url, Is.EqualTo(AppConfigReader.BaseUrl + "what-is-new.html"));
    }

    [When(@"I click on the Women link")]
    public void WhenIClickOnTheWomenLink()
    {
        _navBar.ClickOnWomen();
    }

    [Then(@"I land on the Women page")]
    public void ThenILandOnTheWomenPage()
    {
        Assert.That(_driver.Url, Is.EqualTo(AppConfigReader.BaseUrl + "women.html"));
    }

    [When(@"I click on the Men link")]
    public void WhenIClickOnTheMenLink()
    {
        _navBar.ClickOnMen();
    }

    [Then(@"I land on the Men page")]
    public void ThenILandOnTheMenPage()
    {
        Assert.That(_driver.Url, Is.EqualTo(AppConfigReader.BaseUrl + "men.html"));
    }

    [When(@"I click on the Gear link")]
    public void WhenIClickOnTheGearLink()
    {
        _navBar.ClickOnGear();
    }

    [Then(@"I land on the Gear page")]
    public void ThenILandOnTheGearPage()
    {
        Assert.That(_driver.Url, Is.EqualTo(AppConfigReader.BaseUrl + "gear.html"));
    }

    [When(@"I click on the Training link")]
    public void WhenIClickOnTheTrainingLink()
    {
        _navBar.ClickOnTraining();
    }

    [Then(@"I land on the Training page")]
    public void ThenILandOnTheTrainingPage()
    {
        Assert.That(_driver.Url, Is.EqualTo(AppConfigReader.BaseUrl + "training.html"));
    }

    [When(@"I click on the Sale link")]
    public void WhenIClickOnTheSaleLink()
    {
        _navBar.ClickOnSale();
    }

    [Then(@"I land on the Sale page")]
    public void ThenILandOnTheSalePage()
    {
        Assert.That(_driver.Url, Is.EqualTo(AppConfigReader.BaseUrl + "sale.html"));
    }

    [AfterScenario]
    public void TearDown()
    {
        _driver.Quit();
        _driver.Dispose();
    }
}
