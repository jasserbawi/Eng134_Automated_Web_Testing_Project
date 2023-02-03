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
          _website = new(10, 10, true);
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
            _website.BasketPage.ProceedToCheckout();
        }

        [Then(@"I should land on the checkout page")]
        public void ThenIShouldLandOnTheCheckoutPage()
        {
            string checkoutUrl = AppConfigReader.BaseUrl + AppConfigReader.Checkout + "/";
            Assert.That(_website.GetCurrentPageUrl, Is.EqualTo(checkoutUrl));
        }


        ///
        [Given(@"the basket contains some items")]
        public void GivenTheBasketContainsSomeItems()
        {
            _website.MensBottoms.Navigate();
            _website.MensBottoms.AddProductToBasket();

            _website.MensTops.Navigate();
            _website.MensTops.AddProductToBasket();


            Thread.Sleep(1000);
        }

        [When(@"I am on the basket page")]
        public void WhenIAmOnTheBasketPage()
        {
            _website.BasketPage.Navigate();

        }

        [Then(@"the total price of all items should be displayed correctly")]
        public void ThenTheTotalPriceOfAllItemsShouldBeDisplayedCorrectly()
        {
            //  _website.BasketPage.
            var totalPrice = _website.BasketPage._totalPrice.Text;
            Assert.That(totalPrice, Is.EqualTo("$45.00"));
        }

        ///

        [Given(@"I am on a store page")]
        public void GivenIAmOnAStorePage()
        {
            _website.MensTops.Navigate();

        }

        [When(@"I add a item to the basket")]
        public void WhenIAddAItemToTheBasket()
        {
            _website.MensTops.AddProductToBasket();
            Thread.Sleep(1000);
            _website.BasketPage.Navigate();
        }

        [Then(@"an item should be in the basket")]
        public void ThenAnItemShouldBeInTheBasket()
        {
            var productAddedToBasket = _website.BasketPage._productAddedToBasket.Text;
            Assert.That(productAddedToBasket, Is.EqualTo("Cassius Sparring Tank"));
        }

        ///

        [Given(@"I am on the basket page")]
        public void GivenIAmOnATheBasketPage()
        {
            _website.BasketPage.Navigate();
        }

        [When(@"I click to remove an item")]
        public void WhenIClickToRemoveAnItem()
        {
            _website.BasketPage.RemoveItem(0);
        }

        [Then(@"the item should removed from the basket")]
        public void ThenTheItemShouldRemovedFromTheBasket()
        {
            var noOfItemsInTheCart = _website.BasketPage.cartItems.Count();
            Assert.That(noOfItemsInTheCart, Is.EqualTo(1));
        }



    }
}
