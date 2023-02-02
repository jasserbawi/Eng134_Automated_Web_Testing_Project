using LumaTestingFramework.Website;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace LumaTests.FrameworkTests;

[Binding]
[Scope(Feature = "WomensTopsPage")]
public class WomensTopsPageStepDefinitions
{
    SL_Website _website;

    [BeforeScenario]
    public void Setup() => _website = new SL_Website(pageLoadInSecs: 6);

    [Given(@"I am on the womens tops page")]
    public void GivenIAmOnTheWomensTopsPage()
    {
        _website.WomensTopsPage.Navigate();
    }

    [Given(@"My basket is empty")]
    public void GivenMyBasketIsEmpty()
    {
        _website.DeleteAllCookies();
    }

    [When(@"I add a random item to the basket")]
    public void WhenIAddARandomItemToTheBasket()
    {
        _website.WomensTopsPage.Products[0].AddRandomItemToCart();
    }

    [Then(@"The number of items in my basket is (.*)")]
    public void ThenACounterOfTheNumberOfItemsInMyBasketAppears(int expected)
    {
        int numInCart = int.Parse(_website.WomensTopsPage.MiniCart.FindElement(By.ClassName("counter-number")).Text);
        Assert.That(numInCart, Is.EqualTo(expected));
    }
}
