using OpenQA.Selenium;
using SL_TestAutomationFramework;
using LumaTestingFramework.Website.Pages.Components;

namespace LumaTestingFramework.Website.Pages;

public class SL_WomenPage : SL_StandardPage, INavigate
{
    public PageHeader PageHeader { get; private set; }
    public NavBar NavBar { get; private set; }
    public List<IWebElement> SideBar { get; private set; }
    public List<IWebElement> PromoBlock { get; private set; }
    public List<Product> HotSellers { get; private set; }

    public SL_WomenPage(IWebDriver driver) : base(driver)
    {
    }

    public void Navigate()
    {
        _driver.Navigate().GoToUrl(AppConfigReader.WomensPage);

        PageHeader = new PageHeader(_driver.FindElement(By.CssSelector("header[class='page-header']")));
        NavBar = new NavBar(_driver.FindElement(By.TagName("nav")));
        SideBar = _driver.FindElement(By.ClassName("sidebar-main")).FindElements(By.ClassName("item")).ToList();
        PromoBlock = _driver.FindElement(By.CssSelector("div[class='block-promo']")).FindElements(By.TagName("a")).ToList();
        HotSellers = Product.ProductsList(_driver);
    }

    public void ClickYogaCollection() => PromoBlock[0].Click();
    public void ClickWomensTeesPromo() => PromoBlock[1].Click();
    public void ClickPantsPromo() => PromoBlock[2].Click();
    public void ClickTopsLink() => SideBar[0].Click();
    public void ClickBottomsLink() => SideBar[1].Click();
}
