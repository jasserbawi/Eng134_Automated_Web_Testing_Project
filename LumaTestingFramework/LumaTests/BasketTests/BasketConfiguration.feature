Feature: BasketConfiguration

As a customer, I would like to be taken to the checkout page so that I can order my items.

@HappyPath
Scenario: Proceed to checkout
	Given the basket contains an item 
	When I click proceed to checkout
	Then I should land on the checkout page
	

