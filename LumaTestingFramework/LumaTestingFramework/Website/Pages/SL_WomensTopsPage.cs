using OpenQA.Selenium;
using SL_TestAutomationFramework;
using LumaTestingFramework.Website.Pages.Components;

namespace LumaTestingFramework.Website.Pages;

public class SL_WomensTopsPage : SL_StandardPage, INavigate
{
    public PageHeader PageHeader { get; private set; }
    public NavBar NavBar { get; private set; }
    public List<IWebElement> FilterBar { get; private set; }
    public List<Product> Products { get; private set; }
    public IWebElement MiniCart { get; private set; }

    public SL_WomensTopsPage(IWebDriver driver) : base(driver) { }

    public void Navigate()
    {
        _driver.Navigate().GoToUrl(AppConfigReader.BaseUrl + AppConfigReader.WomensTops);

        PageHeader = new PageHeader(_driver.FindElement(By.TagName("header")));
        NavBar = new NavBar(_driver.FindElement(By.TagName("nav")));
        FilterBar = _driver.FindElement(By.Id("layered-filter-block")).FindElements(By.TagName("a")).ToList();
        Products = Product.ProductsList(_driver);
        MiniCart = _driver.FindElement(By.ClassName("minicart-wrapper"));
    }
}