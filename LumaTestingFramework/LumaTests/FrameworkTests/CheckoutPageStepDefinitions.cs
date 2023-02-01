using LumaTestingFramework.Website;
using LumaTestingFramework.Website.Pages;
using System;
using TechTalk.SpecFlow;

namespace LumaTests.FrameworkTests;

[Binding]
public class CheckoutPageStepDefinitions
{
    SL_Website _website;

    [Before]
    [OneTimeSetUp]
    public void Setup()
    {
        _website = new(3,3,false);
    }

    [Ignore("ignored until add to basket implemented")]
    [Given(@"I am on the checkout page")]
    public void GivenIAmOnTheCheckoutPage()
    {
        _website.CheckoutPage.Navigate();
    }

    [Ignore("ignored until add to basket implemented")]
    [Given(@"I have entered the required details")]
    public void GivenIHaveEnteredTheRequiredDetails()
    {
        _website.CheckoutPage.EnterEmail("dog@dog.net");
        _website.CheckoutPage.EnterFirstName("dog");
        _website.CheckoutPage.EnterLastName("boy");
        _website.CheckoutPage.EnterAddressLine1("1 dog street");
        _website.CheckoutPage.EnterPostcode("123456");
        _website.CheckoutPage.EnterPhoneNumber("12345678910");

        _website.CheckoutPage.SelectState("Texas");
        _website.CheckoutPage.SelectCountry("United States");
    }

    [Ignore("ignored until add to basket implemented")]
    [Given(@"I have selected a shipping method")]
    public void GivenIHaveSelectedAShippingMethod()
    {
        _website.CheckoutPage.SelectDefaultShipping();
    }

    [Ignore("ignored until add to basket implemented")]
    [When(@"I click next")]
    public void WhenIClickNext()
    {
        _website.CheckoutPage.PressContinue();
    }

    [Ignore("ignored until add to basket implemented")]
    [Then(@"I will be taken to the payment method page")]
    public void ThenIWillBeTakenToThePaymentMethodPage()
    {
        Assert.That(_website.GetCurrentPageUrl(), Is.EqualTo("https://magento.softwaretestingboard.com/checkout/#payment");
    }
}
