using LumaTestingFramework.Website;
using LumaTestingFramework.Website.Driver;
using LumaTestingFramework.Website.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SL_TestAutomationFramework;
using System;
using TechTalk.SpecFlow;

namespace LumaTests.BasketTests
{

    [Binding]
    public class BasketConfigurationStepDefinitions
    {
        private SL_Website _website;

        [Before]
        public void Setup() 
        {
            _website = new SL_Website();
        }

        [Given(@"I am on the Basket Page")]
        public void GivenIAmOnTheBasketPage()
        {
            _website.BasketPage.Navigate();
        }

        [When(@"I click proceed to ckeckout")]
        public void WhenIClickProceedToCkeckout()
        {
            _website.BasketPage.ProceedToCheckout();
        }

        [Given(@"the basket is not empty")]
        public void WhenTheBasketIsNotEmpty()
        {
         
        }

        [Then(@"I should land on the checkout page")]
        public void ThenIShouldLandOnTheCheckoutPage()
        {

        }
    }
}
