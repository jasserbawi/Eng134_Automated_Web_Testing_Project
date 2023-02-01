Feature: CheckoutPage

As a customer I need to checkout so I can input my shipping details

@HappyPath
@AC8.1
Scenario: Checkout with valid details
	Given I am on the checkout page
	And I have entered the required details
	And I have selected a shipping method
	When I click next
	Then I will be taken to the payment method page
