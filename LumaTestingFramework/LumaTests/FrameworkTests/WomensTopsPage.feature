Feature: WomensTopsPage

As a tester, I want a womens tops page, so that I can add womens tops to the basket

@HappyPath
Scenario: Add an item to an empty basket
	Given I am on the womens tops page
	And My basket is empty
	When I add a random item to the basket
	Then The number of items in my basket is 1
