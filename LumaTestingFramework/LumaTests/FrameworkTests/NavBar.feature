Feature: NavBar

As a user, I need a navigation bar, so I can navigate the site

@HappyPath
Scenario: Clicking the what's new link
	Given I am on a page with a nav bar
	When I click on the What's New link
	Then I land on the What's New page

Scenario: Clicking the women link
	Given I am on a page with a nav bar
	When I click on the Women link
	Then I land on the Women page

Scenario: Clicking the men link
	Given I am on a page with a nav bar
	When I click on the Men link
	Then I land on the Men page

Scenario: Clicking the gear link
	Given I am on a page with a nav bar
	When I click on the Gear link
	Then I land on the Gear page

Scenario: Clicking the training link
	Given I am on a page with a nav bar
	When I click on the Training link
	Then I land on the Training page

Scenario: Clicking the sale link
	Given I am on a page with a nav bar
	When I click on the Sale link
	Then I land on the Sale page
