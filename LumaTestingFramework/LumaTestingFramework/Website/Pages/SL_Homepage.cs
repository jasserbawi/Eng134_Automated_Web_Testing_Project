using OpenQA.Selenium;
using SL_TestAutomationFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumaTestingFramework.Website.Pages;

public class SL_Homepage : SL_StandardPage, INavigate
{
    IWebElement ExampleObject;
    public SL_Homepage(IWebDriver driver) : base(driver)
    {
        //Setup IWebElements and custom objects
    }

    public void ExampleAction()
    {
        ExampleObject.Click();
    }

    public void Navigate()
    {
        _driver.Navigate().GoToUrl(AppConfigReader.BaseUrl);
    }
}
