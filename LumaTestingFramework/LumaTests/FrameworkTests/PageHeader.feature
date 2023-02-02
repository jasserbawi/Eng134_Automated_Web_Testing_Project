Feature: PageHeader

As a user, I need a page header, so I can access the homepage, sign in, create account, search and my cart.

@HappyPath
Scenario: Clicking the sign in link
	Given I am on a page with a page header
	When I click the sign in link
	Then I land on the sign in page

Scenario: Clicking the create an account link
	Given I am on a page with a page header
	When I click the create an account link
	Then I land on the create account page

Scenario: Clicking the luma logo
	Given I am on a page with a page header
	When I click the luma logo
	Then I land on the homepage