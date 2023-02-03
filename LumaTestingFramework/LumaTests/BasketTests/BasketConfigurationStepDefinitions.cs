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
            _driver.
            var productList = Product.ProductsList(_driver);
            productList[0].AddRandomItemToCart();
            Thread.Sleep(1000);
            IWebElement basketContents = _driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[2]/div[2]/div/div/div/a"));
            basketContents.Click();
                
        }

        [When(@"I click proceed to checkout")]
        public void WhenIClickProceedToCheckout()
        {
            IWebElement proceedToCheckout = _driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[1]/ul/li[1]/button/span"));
            proceedToCheckout.Click();
        }

        [Then(@"I should land on the checkout page")]
        public void ThenIShouldLandOnTheCheckoutPage()
        {
            string checkoutUrl = AppConfigReader.BaseUrl + AppConfigReader.Checkout;
            Assert.That(_driver.Url, Is.EqualTo(checkoutUrl));
        }
    }
}
