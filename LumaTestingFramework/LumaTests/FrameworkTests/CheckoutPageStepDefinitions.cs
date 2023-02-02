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

    [Given(@"I am on the checkout page")]
    public void GivenIAmOnTheCheckoutPage()
    {
        _website.CheckoutPage.Navigate();
    }

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

    [Given(@"I have not entered required details")]
    public void GivenIHaveNotEnteredAnyRequiredDetails()
    {
    
    }

    [Given(@"I have selected a shipping method")]
    public void GivenIHaveSelectedAShippingMethod()
    {
        _website.CheckoutPage.SelectDefaultShipping();
    }

    [When(@"I click next")]
    public void WhenIClickNext()
    {
        _website.CheckoutPage.PressContinue();
    }

    [Then(@"I will be taken to the payment method page")]
    public void ThenIWillBeTakenToThePaymentMethodPage()
    {
        Assert.That(_website.GetCurrentPageUrl(), Is.EqualTo("https://magento.softwaretestingboard.com/checkout/#payment"));
    }

    

    [Then(@"Each required field will be highlighted with an error message")]
    public void ThenEachRequiredFieldWillBeHighlightedWithAnErrorMessage()
    {
        int requiredFields = _website.CheckoutPage.GetNumberOfInvalidFields();
        Assert.That(requiredFields, Is.EqualTo(8));
    }

}
