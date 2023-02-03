# Eng134_Automated_Web_Testing_Project
An automated web testing framework written in C# using Selenium driver and Nunit for the storefront at https://magento.softwaretestingboard.com/

## Installation
1. Install [Visual Studio](https://visualstudio.microsoft.com/)
2. Download and unzip the project from the releases sidebar
3. Create an NUnit test project to hold your tests
5. Add a reference to the testing framework library to your solution

## Usage
The framework is built around the SL_Website class which contains a website driver and page objects representating each page on the website. You can navigate to a page using that page object's `Navigate()` function, for example the following code navigates to the women page.

``` C#
    _website = new SL_Website();
    _website.WomenPage.Navigate();
```

Each page object contains properties or fields representing each of the interactable elements found on that page and helper functions used to interact with or extract information from the page, once all the helper functions are written most features should be testable using these. The following code will click on the Tops link in the Women page.

``` C#
    _website.WomenPage.ClickTopsLink();
```

## Examples
We have included some example tests using the [specflow](https://specflow.org/tools/specflow/) BDD tool in the repository which can be used as an additional reference.
