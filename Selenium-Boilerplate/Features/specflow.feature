Feature: SpecFlowFeature
	In order to avoid silly mistakes
	As a browser user
	I want to make sure that page title is correct

	@example
	Scenario: Check page title
		Given I have opened the browser
		And I have entered page url
		And I have clicked "Apply now" button
		Then the page header should be "Information you will need to apply online"