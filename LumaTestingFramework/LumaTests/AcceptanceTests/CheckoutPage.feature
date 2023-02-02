Feature: CheckoutPage

As a customer I need to checkout so I can input my shipping details

@ignore
@HappyPath
@AC8.1
Scenario: Checkout with valid details
	Given I am on the checkout page
	And I have entered the required details
	And I have selected a shipping method
	When I click next
	Then I will be taken to the payment method page

@ignore
@HappyPath
@AC8.5
Scenario: Getting to the checkout page with items in basket
	Given I have an item in the basket
	When I navigate to checkout
	Then I will be taken to the checkout page

@ignore
@HappyPath
@AC8.2
Scenario: Checkout with invalid details
	Given I am on the checkout page
	And I have not entered required details
	And I have selected a shipping method
	When I click next
	Then Each required field will be highlighted with an error message