using LumaTestingFramework.Website._driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace LumaTests.FrameworkTests;

[Binding]
[Scope(Feature = "DriverConfiguration")]
public class DriverConfigurationStepDefinitions
{
    private DriverConfig<ChromeDriver> _driverConfig;
    private IWebDriver _driver;

    [Given(@"I use the driver configuration class with the following arguments:")]
    public void GivenIUseTheDriverConfigurationClass(Table table)
    {
        _driverConfig = new DriverConfig<ChromeDriver>(int.Parse(table.Rows[0][0]), int.Parse(table.Rows[0][1]), bool.Parse(table.Rows[0][2]));
    }

    [When(@"I access the driver")]
    public void WhenIAccessTheDriver()
    {
        _driver = _driverConfig.Driver;
    }

    [Then(@"The driver is configured with a page load of (.*) seconds")]
    public void ThenTheDriverIsConfiguredWithAPageLoadOfSeconds(int pageLoadInSeconds)
    {
        Assert.That(_driver.Manage().Timeouts().PageLoad, Is.EqualTo(TimeSpan.FromSeconds(pageLoadInSeconds)));
    }

    [Then(@"The driver is configured with an implicit wait of (.*) seconds")]
    public void ThenTheDriverIsConfiguredWithAnImplicitWaitOfSeconds(int implicitWaitInSeconds)
    {
        Assert.That(_driver.Manage().Timeouts().ImplicitWait, Is.EqualTo(TimeSpan.FromSeconds(implicitWaitInSeconds)));
    }

    [After]
    public void TearDown()
    {
        _driver.Quit();
        _driver.Dispose();
    }
}