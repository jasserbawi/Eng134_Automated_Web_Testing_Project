using LumaTestingFramework.Website;
using LumaTestingFramework.Website._driver;
using LumaTestingFramework.Website.Pages;
using LumaTestingFramework.Website.Pages.Components;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SL_TestAutomationFramework;
using System;
using TechTalk.SpecFlow;

namespace LumaTests.BasketTests
{

    [Binding]
    [Scope(Feature = "BasketConfiguration")]
    public class BasketConfigurationStepDefinitions
    {
       SL_Website _website;

        [Before]
        public void Setup() 
        {
          _website = new(10, 10, false);
        }

        [Given(@"the basket contains an item")]
        public void WhenTheBasketContainsAnItem()
        {
            _website.MensBottoms.Navigate();
            _website.MensBottoms.AddProductToBasket();
            Thread.Sleep(1000);
            _website.BasketPage.Navigate();
        }

        [When(@"I click proceed to checkout")]
        public void WhenIClickProceedToCheckout()
        {
            Thread.Sleep(1000);
            _website.BasketPage.ProceedToCheckout();
        }

        [Then(@"I should land on the checkout page")]
        public void ThenIShouldLandOnTheCheckoutPage()
        {
            string checkoutUrl = AppConfigReader.BaseUrl + AppConfigReader.Checkout;
            Assert.That(_website.GetCurrentPageUrl, Is.EqualTo(checkoutUrl));
        }
    }
}
