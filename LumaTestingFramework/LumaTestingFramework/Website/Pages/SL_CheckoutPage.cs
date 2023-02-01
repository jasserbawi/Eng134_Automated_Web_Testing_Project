using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V107.DOM;
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

    private List<IWebElement> _requiredFields;
    #endregion

    public SL_CheckoutPage(IWebDriver driver)
    {
        _driver = driver;
        GetPageElements();
        _state = _driver.FindElement(By.Id("shippingAddress.region_id")).FindElement(By.ClassName("select"));
        _stateDropdown = new SelectElement(_state);
        _country = _driver.FindElement(By.Id("shippingAddress.country_id")).FindElement(By.ClassName("select"));
        _stateDropdown = new SelectElement(_country);
        _submitButton = _driver.FindElement(By.ClassName("button action continue primary"));

        GetShippingMethods();
        GetRequiredFields();
    }
    public void Navigate()
    {
        _driver.Navigate().GoToUrl(AppConfigReader.BaseUrl + AppConfigReader.Checkout);
    }
    public void EnterEmail(string email) => _email.SendKeys(email);
    public void EnterFirstName(string firstName) => _firstName.SendKeys(firstName);
    public void EnterLastName(string lastName) => _lastName.SendKeys(lastName);
    public void EnterCompany(string company) => _company.SendKeys(company);
    public void EnterAddressLine1(string addressLine) => _addressLine1.SendKeys(addressLine);
    public void EnterAddressLine2(string addressLine) => _addressLine2.SendKeys(addressLine);
    public void EnterAddressLine3(string addressLine) => _addressLine3.SendKeys(addressLine);
    public void EnterCity(string city) => _city.SendKeys(city);
    public void EnterPostcode(string postcode) => _postcode.SendKeys(postcode);
    public void EnterPhoneNumber(string postcode) => _phoneNumber.SendKeys(postcode);
    public void SelectCountry(string countryName) => _countryDropdown.SelectByText(countryName);
    public void SelectState(string stateName) => _stateDropdown.SelectByText(stateName);
    public void SelectDefaultShipping() => _shippingMethodChoices[0].Click();
    public void PressContinue() => _submitButton.Click();
    private void GetPageElements()
    {
        
        List<(string, IWebElement)> fields = new() {
            ("customer-email", _email),
            ("shippingAddress.firstName", _firstName),
            ("shippingAddress.lastName", _lastName),
            ("shippingAddress.company", _company),
            ("shippingAddress.street.0", _addressLine1),
            ("shippingAddress.street.1", _addressLine2),
            ("shippingAddress.street.2", _addressLine3),
            ("shippingAddress.city", _city),
            ("shippingAddress.postcode", _postcode),
            ("shippingAddress.telephone", _phoneNumber)
        };

        for(int i = 0; i < fields.Count; i++)
        {
            (string, IWebElement) field = fields[i];
            PopulateTextInputElement(field.Item2, field.Item1);
        }
    }

    private void PopulateTextInputElement(IWebElement? element, string className)
    {
        element = _driver.FindElement(By.Name(className)).FindElement(By.ClassName("input-text"));
    }

    private void GetShippingMethods()
    {
        _shippingMethod = _driver.FindElement(By.ClassName("table-checkout-shipping-method"));
        _shippingMethodChoices = _driver.FindElements(By.ClassName("radio")).ToList();
    }

    private void GetRequiredFields()
    {
        _requiredFields = new()
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
    }
}
