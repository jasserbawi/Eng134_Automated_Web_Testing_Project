using OpenQA.Selenium;

namespace LumaTestingFramework.Website.Pages.Components;

public class NavBar
{
    public IWebElement WhatsNew { get; private set; }
    public IWebElement Women { get; private set; }
    public IWebElement Men { get; private set; }
    public IWebElement Gear { get; private set; }
    public IWebElement Training { get; private set; }
    public IWebElement Sale { get; private set; }

    public NavBar(IWebElement navElement)

    {
        WhatsNew = navElement.FindElement(By.Id("ui-id-3"));
        Women = navElement.FindElement(By.Id("ui-id-4"));
        Men = navElement.FindElement(By.Id("ui-id-5"));
        Gear = navElement.FindElement(By.Id("ui-id-6"));
        Training = navElement.FindElement(By.Id("ui-id-7"));
        Sale = navElement.FindElement(By.Id("ui-id-8"));
    }

    public void ClickOnWhatsNew()
    {
        WhatsNew.Click();
    }

    public void ClickOnWomen()
    {
        Women.Click();
    }

    public void ClickOnMen()
    {
        Men.Click();
    }

    public void ClickOnGear()
    {
        Gear.Click();
    }

    public void ClickOnTraining()
    {
        Training.Click();
    }

    public void ClickOnSale()
    {
        Sale.Click();
    }
}
