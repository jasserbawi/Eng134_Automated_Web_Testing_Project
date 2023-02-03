using OpenQA.Selenium;
using SL_TestAutomationFramework;
using LumaTestingFramework.Website.Pages.Components;

namespace LumaTestingFramework.Website.Pages;

public class SL_WomenPage : SL_StandardPage, INavigate
{
    public NavBar NavBar { get; private set; }
    public PageHeader PageHeader { get; private set; }
    public List<Product> Products { get; private set; }

    public SL_WomenPage(IWebDriver driver) : base(driver)
    {
        Products = Product.ProductsList(_driver);
    }

    public void Navigate()
    {
        _driver.Navigate().GoToUrl(AppConfigReader.BaseUrl + AppConfigReader.WomensPage);
        NavBar = new NavBar(_driver.FindElement(By.TagName("nav")));
        PageHeader = new PageHeader(_driver.FindElement(By.CssSelector("header[class='page-header']")));
    }
}
