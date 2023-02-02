Feature: BasketConfiguration

As a customer, I would like to be taken to the checkout page so that I can order my items.

@HappyPath
Scenario: [Proceed to checkout]
	Given I am on the Basket Page
	And the basket is not empty
	When I click proceed to ckeckout
	Then I should land on the checkout page
