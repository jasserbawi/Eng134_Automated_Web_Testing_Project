using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V107.DOM;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using SL_TestAutomationFramework;

namespace LumaTestingFramework.Website.Pages;

public class SL_CheckoutPage
{
    private IWebDriver _driver;

    #region IWebElements
    private IWebElement _email;
    private IWebElement _firstName;
    private IWebElement _lastName;

    private IWebElement _company;

    private IWebElement _addressLine1;
    private IWebElement _addressLine2;
    private IWebElement _addressLine3;
    private IWebElement _city;
    private IWebElement _postcode;

    private IWebElement _phoneNumber;

    private IWebElement _state;
    private IWebElement _country;
    private SelectElement _stateDropdown;
    private SelectElement _countryDropdown;

    private IWebElement _shippingMethod;
    private List<IWebElement> _shippingMethodChoices;
    private IWebElement _submitButton;

    private List<(IWebElement, bool)> _requiredFields;
    #endregion

    public SL_CheckoutPage(IWebDriver driver)
    {
        _driver = driver;
    }
    public void Navigate()
    {
        _driver.Navigate().GoToUrl(AppConfigReader.BaseUrl + AppConfigReader.Checkout);
        //GetPageElements();
    }

    #region Public input functions
    public void EnterEmail(string email) => _email.SendKeys(email);
    public void EnterFirstName(string firstName) => _firstName.SendKeys(firstName);
    public void EnterLastName(string lastName) => _lastName.SendKeys(lastName);
    public void EnterCompany(string company) => _company.SendKeys(company);
    public void EnterAddress(string addressLine1 = "", string addressLine2 = "", string addressLine3 = "")
    {
        _addressLine1.SendKeys(addressLine1);
        _addressLine2.SendKeys(addressLine2);
        _addressLine3.SendKeys(addressLine3);
    }
    public void EnterCity(string city) => _city.SendKeys(city);
    public void EnterPostcode(string postcode) => _postcode.SendKeys(postcode);
    public void EnterPhoneNumber(string postcode) => _phoneNumber.SendKeys(postcode);
    public void SelectCountry(string countryName) => _countryDropdown.SelectByText(countryName);
    public void SelectState(string stateName) => _stateDropdown.SelectByText(stateName);
    public void SelectDefaultShipping() => _shippingMethodChoices[0].Click();
    public int GetNumberOfInvalidFields() => _requiredFields.Where((x)=> x.Item2).Count();
    public void PressContinue()
    {
        _submitButton.Click();
        //If submission did not work, refresh elements
        if (_driver.Url == AppConfigReader.BaseUrl + AppConfigReader.Checkout)
        {
            GetPageElements();
        }
    }
    #endregion

    #region Private functions for retrieving elements
    private void GetPageElements()
    {
        GetTextInputElements();
        GetDropDownMenus();
        GetShippingMethods();
        GetRequiredFields();
    }
    
    private void GetTextInputElements()
    {
        _email = _driver.FindElement(By.Id("customer-email"));
        _firstName = _driver.FindElement(By.XPath("/html/body/div[2]/main/div[2]/div/div[2]/div[4]/ol/li[1]/div[2]/form[2]/div/div[1]/div/input"));
        _lastName = _driver.FindElement(By.XPath("/html/body/div[2]/main/div[2]/div/div[2]/div[4]/ol/li[1]/div[2]/form[2]/div/div[2]/div/input"));
        _company = _driver.FindElement(By.XPath("/html/body/div[2]/main/div[2]/div/div[2]/div[4]/ol/li[1]/div[2]/form[2]/div/div[3]/div/input"));
        _addressLine1 = _driver.FindElement(By.XPath("/html/body/div[2]/main/div[2]/div/div[2]/div[4]/ol/li[1]/div[2]/form[2]/div/fieldset/div/div[1]/div/input"));
        _addressLine2 = _driver.FindElement(By.XPath("/html/body/div[2]/main/div[2]/div/div[2]/div[4]/ol/li[1]/div[2]/form[2]/div/fieldset/div/div[2]/div/input"));
        _addressLine3 = _driver.FindElement(By.XPath("/html/body/div[2]/main/div[2]/div/div[2]/div[4]/ol/li[1]/div[2]/form[2]/div/fieldset/div/div[3]/div/input"));
        _city = _driver.FindElement(By.XPath("/html/body/div[2]/main/div[2]/div/div[2]/div[4]/ol/li[1]/div[2]/form[2]/div/div[4]/div/input"));
        _postcode = _driver.FindElement(By.XPath("/html/body/div[2]/main/div[2]/div/div[2]/div[4]/ol/li[1]/div[2]/form[2]/div/div[7]/div/input"));
        _phoneNumber = _driver.FindElement(By.XPath("/html/body/div[2]/main/div[2]/div/div[2]/div[4]/ol/li[1]/div[2]/form[2]/div/div[9]/div/input"));
    }
    private void GetDropDownMenus()
    {
        _state = _driver.FindElement(By.XPath("/html/body/div[2]/main/div[2]/div/div[2]/div[4]/ol/li[1]/div[2]/form[2]/div/div[5]/div/select"));
        _stateDropdown = new SelectElement(_state);
        _country = _driver.FindElement(By.XPath("/html/body/div[2]/main/div[2]/div/div[2]/div[4]/ol/li[1]/div[2]/form[2]/div/div[8]/div/select"));
        _stateDropdown = new SelectElement(_country);
        _submitButton = _driver.FindElement(By.CssSelector(".button.action.continue.primary"));
    }
    private void GetShippingMethods()
    {
        _shippingMethodChoices = 
            _driver
            .FindElement(By.ClassName("table-checkout-shipping-method"))
            .FindElements(By.ClassName("radio"))
            .ToList();
    }
    private void GetRequiredFields()
    {
        List<IWebElement> fields = new()
        {
            _email,
            _firstName,
            _lastName,
            _addressLine1,
            _city,
            _state,
            _postcode,
            _country,
            _phoneNumber
        };

        _requiredFields = new();

        foreach(IWebElement field in fields)
        {
            try
            {
                field.FindElement(By.ClassName("field-error"));
                _requiredFields.Add((field, true));
            }
            catch
            {
                _requiredFields.Add((field, false));
            }
        }
    }
    #endregion
}
