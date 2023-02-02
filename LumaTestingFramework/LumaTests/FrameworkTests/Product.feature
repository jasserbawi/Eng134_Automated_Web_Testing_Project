Feature: Products

As a user, I need a products class, so I can access the products I want to buy.

@HappyPath
Scenario: Clicking
	Given I am on a page with a nav bar
	When I click on the What's New link
	Then I land on the What's New page
	
	