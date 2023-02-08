Feature: BasketConfiguration

US.23.As a customer, I would like to be taken to the checkout page so that I can order my items.
US.2.As a customer, I would like to check the total price of my basket so that I know how much I am going to spend.
US.3.As a customer, I would like to add to the basket so that I can manage purchases.
US.4.As a customer, I would like to be able to remove items from the basket so that I can manage purchases. 

@ignore
@HappyPath
@AC.23.1
Scenario: Proceed to checkout
	Given the basket contains an item 
	When I click proceed to checkout
	Then I should land on the checkout page
	
@HappyPath
@AC.2.1
Scenario: Total price
	Given the basket contains some items 
	When I am on the basket page 
	Then the total price of all items should be displayed correctly

@HappyPath
@AC.2.1
Scenario: Adding an Item to the basket
	Given I am on a store page 
	When I add a item to the basket
	Then an item should be in the basket

@HappyPath
@AC.4.1
Scenario: Removing an item from the basket
	Given the basket contains some items
	And I am on the basket page
	When I click to remove an item
	Then the item should removed from the basket




