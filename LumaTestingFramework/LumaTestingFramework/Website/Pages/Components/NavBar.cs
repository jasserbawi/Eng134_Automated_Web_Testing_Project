using OpenQA.Selenium;

namespace LumaTestingFramework.Website.Pages.Components;

public class NavBar
{
    IWebElement Womens { get; set; }
    IWebElement Mens { get; set; }


    public NavBar()
    {
        //add code to get the element addresses of the womens and mens links
    }

    public void NavigateToWomens()
    {
        Womens.Click();
    }
    public void NavigateToMens()
    {
        Mens.Click();
    }
}
