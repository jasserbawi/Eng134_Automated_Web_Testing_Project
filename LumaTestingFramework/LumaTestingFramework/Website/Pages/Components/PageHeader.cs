using OpenQA.Selenium;

namespace LumaTestingFramework.Website.Pages.Components;

public class PageHeader
{
    public IWebElement SignIn { get; private set; }
    public IWebElement CreateAccount { get; private set; }
    public IWebElement LumaLogo { get; private set; }
    public IWebElement SearchBar { get; private set; }
    public IWebElement CartIcon { get; private set; }

    public PageHeader(IWebElement pageHeaderElement)
    {
        SignIn = pageHeaderElement.FindElement(By.CssSelector("ul.header:nth-child(2) > li:nth-child(2) > a:nth-child(1)"));
        CreateAccount = pageHeaderElement.FindElement(By.CssSelector("ul.header:nth-child(2) > li:nth-child(3) > a:nth-child(1)"));
        LumaLogo = pageHeaderElement.FindElement(By.ClassName("logo"));
        SearchBar = pageHeaderElement.FindElement(By.Id("search"));
        CartIcon = pageHeaderElement.FindElement(By.CssSelector(".showcart"));
    }

    public void ClickSignInLink() => SignIn.Click();
    public void ClickCreateAccount() => CreateAccount.Click();
    public void ClickLumaLogo() => LumaLogo.Click();
    public void TypeInSearchBar(string input) => SearchBar.SendKeys(input);
    public void ClickCartIcon() => CartIcon.Click();
}