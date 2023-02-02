using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using LumaTestingFramework.Website.Pages.Components;
using SL_TestAutomationFramework;

namespace LumaTestingFramework.Website.Pages
{
    public class SL_Basket : SL_StandardPage
    {

        public SL_Basket(IWebDriver driver) : base (driver)
        {

        }
        string _basketUrl = AppConfigReader.Basket;

        private IWebDriver Driver { get; }

        public List<IWebElement> cartItems => Driver.FindElements(By.ClassName("cart item")).ToList();

        

        // remove a item from a list
        
      //  public IWebElement _removeItem1 => Driver.FindElement(By.XPath("//*[@id=\"shopping-cart-table\"]/tbody[1]/tr[2]/td/div/a[2]"));
       // public IWebElement _removeItem2 => Driver.FindElement(By.XPath("//*[@id=\"shopping-cart-table\"]/tbody[2]/tr[2]/td/div/a[2]"));
     
        public IWebElement _proceedToCheckout => Driver.FindElement(By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[1]/ul/li[1]/button/span"));
        public IWebElement _totalPrice => Driver.FindElement(By.XPath("//*[@id=\"cart-totals\"]/div/table/tbody/tr[3]/td/strong/span"));


        public void ProceedToCheckout () => _proceedToCheckout.Click();
        

        public void RemoveItem(IWebElement itemToRemove)
        {
            int index = cartItems.IndexOf(itemToRemove);
            if (index >= 0)
            {
                cartItems.RemoveAt(index);
            }
        }
       
    }
}
