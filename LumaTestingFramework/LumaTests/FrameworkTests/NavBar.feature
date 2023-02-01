Feature: NavBar

As a user, I need a navigation bar, so I can navigate the site

@HappyPath
Scenario: Clicking nav bar links
	Given I am on a page with a nav bar
	When I click on the What's New link
	Then I land on the What's New page

	Given I am on a page with a nav bar
	When I click on the Women link
	Then I land on the Women page

	Given I am on a page with a nav bar
	When I click on the Men link
	Then I land on the Men page

	Given I am on a page with a nav bar
	When I click on the Gear link
	Then I land on the Gear page

	Given I am on a page with a nav bar
	When I click on the Training link
	Then I land on the Training page

	Given I am on a page with a nav bar
	When I click on the Sale link
	Then I land on the Sale page
