using OpenQA.Selenium;
using SL_TestAutomationFramework;

namespace LumaTestingFramework.Website.Pages;

public class SL_Homepage : SL_StandardPage
{
    IWebElement ExampleObject;
    string _homePageUrl = AppConfigReader.BaseUrl;
    public SL_Homepage(IWebDriver driver) : base(driver)
    {
        //Setup IWebElements and custom objects
    }

    public void ExampleAction()
    {
        ExampleObject.Click();
    }
}
