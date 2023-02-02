Feature: FilterTopsBottoms

A short summary of the feature

@HappyPath
@AC6.1
Scenario: Filter women's tops
Given I am on the women page
When I click the womens tops filter option
Then I should be redirected to the women's tops page

@HappyPath
@AC6.2
Scenario: Filter women's bottoms
Given I am on the women page
When I click the womens bottoms filter option
Then I should be redirected to the women's bottoms page

@HappyPath
@AC6.3
Scenario: Filter men's tops
Given I am on the men page
When I click the mens tops filter option
Then I should be redirected to the men's tops page

@HappyPath
@AC6.4
Scenario: Filter men's bottoms
Given I am on the men page
When I click the mens bottoms filter option
Then I should be redirected to the men's bottoms page