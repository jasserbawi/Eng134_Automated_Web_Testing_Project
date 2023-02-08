using LumaTestingFramework.Website;
using SL_TestAutomationFramework;
using TechTalk.SpecFlow;

namespace LumaTests.SiteTests;

[Binding]
[Scope(Feature = "FilterTopsBottoms")]
public class FilterTopsBottomsStepDefinitions
{
    SL_Website _website;

    [BeforeScenario]
    public void Setup() => _website = new SL_Website(pageLoadInSecs: 6);

    [Given(@"I am on the women page")]
    public void GivenIAmOnTheWomenPage()
    {
        _website.WomenPage.Navigate();
    }

    [When(@"I click the womens tops filter option")]
    public void WhenIClickTheTopsFilterOption()
    {
        _website.WomenPage.ClickTopsLink();
    }

    [Then(@"I should be redirected to the women's tops page")]
    public void ThenIShouldBeRedirectedToTheWomensTopsPage()
    {
        Assert.That(_website.GetCurrentPageUrl(), Is.EqualTo(AppConfigReader.BaseUrl + "women/tops-women.html"));
    }

    [When(@"I click the womens bottoms filter option")]
    public void WhenIClickTheBottomsFilterOption()
    {
        _website.WomenPage.ClickBottomsLink();
    }

    [Then(@"I should be redirected to the women's bottoms page")]
    public void ThenIShouldBeRedirectedToTheWomensBottomsPage()
    {
        Assert.That(_website.GetCurrentPageUrl(), Is.EqualTo(AppConfigReader.BaseUrl + "women/bottoms-women.html"));
    }

    [Given(@"I am on the men page")]
    public void GivenIAmOnTheMenPage()
    {
        _website.MenPage.Navigate();
    }

    [When(@"I click the mens tops filter option")]
    public void WhenIClickTheMensTopsFilterOption()
    {
        _website.MenPage.ClickTopsLink();
    }


    [Then(@"I should be redirected to the men's tops page")]
    public void ThenIShouldBeRedirectedToTheMensTopsPage()
    {
        Assert.That(_website.GetCurrentPageUrl(), Is.EqualTo(AppConfigReader.BaseUrl + "men/tops-men.html"));
    }

    [When(@"I click the mens bottoms filter option")]
    public void WhenIClickTheMensBottomsFilterOption()
    {
        _website.MenPage.ClickBottomsLink();
    }

    [Then(@"I should be redirected to the men's bottoms page")]
    public void ThenIShouldBeRedirectedToTheMensBottomsPage()
    {
        Assert.That(_website.GetCurrentPageUrl(), Is.EqualTo(AppConfigReader.BaseUrl + "men/bottoms-men.html"));

    }

    [AfterScenario]
    public void TearDown() => _website.DisposeOfDriver();
}
