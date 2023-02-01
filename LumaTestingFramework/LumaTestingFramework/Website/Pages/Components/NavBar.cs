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

    public void NavigateToWhatsNew()
    {
        WhatsNew.Click();
    }

    public void NavigateToWomen()
    {
        Women.Click();
    }

    public void NavigateToMen()
    {
        Men.Click();
    }

    public void NavigateToGear()
    {
        Gear.Click();
    }

    public void NavigateToTraining()
    {
        Training.Click();
    }

    public void NavigateToSale()
    {
        Sale.Click();
    }
}
