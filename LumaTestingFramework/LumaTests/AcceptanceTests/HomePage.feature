Feature: HomePage

As a user, I want a home page, so that I can access new collections and suggested items.

@HappyPath
Scenario: Clicking on the New Luma Yoga Collection
	Given I am on the homepage
	When I click on the New Luma Yoga Collection
	Then I am taken to the New Luma Yoga Collection page

@HappyPath
Scenario: Clicking on the Luma Pants Collection Offer
	Given I am on the homepage
	When I click on the Luma Pants Collection Discount
	Then I am taken to the Luma Pants Collection Discount page

@HappyPath
Scenario: Clicking on the Tees Collection Offer
	Given I am on the homepage
	When I click on the Tees Collection Discount
	Then I am taken to the Tees Collection Discount page

@HappyPath
Scenario: Clicking on the Erin Recommends Collection
	Given I am on the homepage
	When I click Erin Recommends
	Then I am taken to the Erin Recommends page

@HappyPath
Scenario: Clicking on the Science Meets Performance Collection
	Given I am on the homepage
	When I click Shop Performance
	Then I am taken to the Science Meets Performance Collection page

@HappyPath
Scenario: Clicking on the Eco-Friendly Collection
	Given I am on the homepage
	When I click on the Eco-Friendly Collection
	Then I am taken to the Eco-Friendly Collection page