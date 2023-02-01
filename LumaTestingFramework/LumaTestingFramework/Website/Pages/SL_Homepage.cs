using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumaTestingFramework.Website.Pages;

public class SL_Homepage : SL_StandardPage
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
}
