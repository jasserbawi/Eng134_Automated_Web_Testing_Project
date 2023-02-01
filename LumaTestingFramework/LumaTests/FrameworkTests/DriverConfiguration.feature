Feature: DriverConfiguration

As a developer, I need a driver configuration class, so that I can configure the driver

@HappyPath
@AC9.1
Scenario: Creating A New Driver
	Given I use the driver configuration class with the following arguments:
		| Page load in seconds | Implicit wait in seconds | Headless? |
		| 3                    | 3                        | true      |
	When I access the driver
	Then The driver is configured with a page load of 3 seconds
	And The driver is configured with an implicit wait of 3 seconds
