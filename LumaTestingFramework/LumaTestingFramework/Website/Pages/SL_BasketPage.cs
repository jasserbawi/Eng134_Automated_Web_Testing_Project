using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using LumaTestingFramework.Website.Pages.Components;
using SL_TestAutomationFramework;

namespace LumaTestingFramework.Website.Pages
{
    public class SL_BasketPage : SL_StandardPage, INavigate
    {
        public SL_BasketPage(IWebDriver driver) : base (driver)
        {
            cartItems = new();
        }
        string _basketUrl = AppConfigReader.Basket;

        public List<IWebElement> cartItems { get; set; }

        public IWebElement _proceedToCheckout => _driver.FindElement(By.CssSelector(".action.primary.checkout"));
        public IWebElement _totalPrice => _driver.FindElement(By.XPath("//*[@id=\"cart-totals\"]/div/table/tbody/tr[3]/td/strong/span"));

        public IWebElement _shoppingCart => _driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[2]/div[2]/div/div/div/a"));

        public IWebElement _productAddedToBasket => _driver.FindElement(By.XPath("//*[@id=\"shopping-cart-table\"]/tbody/tr[1]/td[1]/div/strong/a"));
        public IWebElement _removedItemName => _driver.FindElement(By.XPath("//*[@id=\"shopping-cart-table\"]/tbody[1]/tr[1]/td[1]/div/strong/a"));
        public void ProceedToCheckout () => _proceedToCheckout.Click();

       
        public void UpdateCartItems()
        {
            cartItems =_driver.FindElements(By.CssSelector(".cart.item")).ToList();
        }
        

        public void RemoveItem(int itemToRemove)
        {
            cartItems[itemToRemove].FindElement(By.ClassName("action-delete")).Click();
            UpdateCartItems();
        }

        public void Navigate()
        {
            _driver.Navigate().GoToUrl(AppConfigReader.BaseUrl + AppConfigReader.Basket);
            UpdateCartItems();
        }




    }
}
