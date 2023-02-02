using LumaTestingFramework.Website;
using SL_TestAutomationFramework;
using TechTalk.SpecFlow;

namespace LumaTests.SiteTests;

[Binding]
public class FilterTopsBottomsStepDefinitions
{
    SL_Website _website;

    [BeforeScenario]
    public void Setup() => _website = new SL_Website();

    [Given(@"I am on the women page")]
    public void GivenIAmOnTheWomenPage()
    {
        _website.WomenPage.Navigate();
    }

    [When(@"I click the tops filter option")]
    public void WhenIClickTheTopsFilterOption() => _website.WomenPage.ClickTopsLink();

    [Then(@"I should be redirected to the women's tops page")]
    public void ThenIShouldBeRedirectedToTheWomensTopsPage()
    {
        Assert.That(_website.GetCurrentUrl(), Is.EqualTo(AppConfigReader.BaseUrl + "women/tops-women.html"));
    }

    [When(@"I click the bottoms filter option")]
    public void WhenIClickTheBottomsFilterOption() => _website.WomenPage.ClickBottomsLink();

    [Then(@"I should be redirected to the women's bottoms page")]
    public void ThenIShouldBeRedirectedToTheWomensBottomsPage()
    {
        Assert.That(_website.GetCurrentUrl(), Is.EqualTo(AppConfigReader.BaseUrl + "women/bottoms-women.html"));
    }

    [Given(@"I am on the men page")]
    public void GivenIAmOnTheMenPage()
    {
        throw new PendingStepException();
    }

    [Then(@"I should be redirected to the men's tops page")]
    public void ThenIShouldBeRedirectedToTheMensTopsPage()
    {
        throw new PendingStepException();
    }

    [Then(@"I should be redirected to the men's bottoms page")]
    public void ThenIShouldBeRedirectedToTheMensBottomsPage()
    {
        throw new PendingStepException();
    }

    [AfterScenario]
    public void TearDown() => _website.DisposeOfDriver();
}
