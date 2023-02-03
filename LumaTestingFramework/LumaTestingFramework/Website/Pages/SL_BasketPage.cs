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

        public IWebElement _proceedToCheckout;
        public IWebElement _totalPrice => _driver.FindElement(By.XPath("//*[@id=\"cart-totals\"]/div/table/tbody/tr[3]/td/strong/span"));

        public void GetCheckoutButton()
        {
            _proceedToCheckout = _driver.FindElement(By.CssSelector(".action.primary.checkout"));

        }
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
            GetCheckoutButton();
        }

    }
}
