using LumaTestingFramework.Website._driver;
using LumaTestingFramework.Website.Pages.Components;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using SL_TestAutomationFramework;
using OpenQA.Selenium.DevTools;

namespace LumaTests.FrameworkTests;

[Binding]
[Scope(Feature = "PageHeader")]
public class PageHeaderStepDefinitions
{
    private DriverConfig<ChromeDriver> _driverConfig;
    private IWebDriver _driver;
    private PageHeader _pageHeader;

    [BeforeScenario]
    public void Setup()
    {
        _driverConfig = new DriverConfig<ChromeDriver>(3, 3, true);
        _driver = _driverConfig.Driver;
    }

    [Given(@"I am on a page with a page header")]
    public void GivenIAmOnAPageWithAPageHeader()
    {
        _driver.Navigate().GoToUrl(AppConfigReader.BaseUrl);
        _pageHeader = new PageHeader(_driver.FindElement(By.CssSelector("header[class='page-header']")));
    }

    [When(@"I click the sign in link")]
    public void WhenIClickTheSignInLink()
    {
        _pageHeader.ClickSignInLink();
    }

    [Then(@"I land on the sign in page")]
    public void ThenILandOnTheSignInPage()
    {
        Assert.That(_driver.Url, Does.Contain("customer/account/login"));
    }

    [When(@"I click the create an account link")]
    public void WhenIClickTheCreateAnAccountLink()
    {
        _pageHeader.ClickCreateAccount();
    }

    [Then(@"I land on the create account page")]
    public void ThenILandOnTheCreateAccountPage()
    {
        Assert.That(_driver.Url, Is.EqualTo(AppConfigReader.BaseUrl + "customer/account/create/"));
    }

    [When(@"I click the luma logo")]
    public void WhenIClickTheLumaLogo()
    {
        _pageHeader.ClickLumaLogo();
    }

    [Then(@"I land on the homepage")]
    public void ThenILandOnTheHomepage()
    {
        Assert.That(_driver.Url, Is.EqualTo(AppConfigReader.BaseUrl));
    }

    [AfterScenario]
    public void TearDown()
    {
        _driver.Quit();
        _driver.Dispose();
    }
}
