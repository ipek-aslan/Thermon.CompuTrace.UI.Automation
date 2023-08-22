Feature: ControllerAndAccessories

Controller And Accessories Validations

@SmokeTests, @RegressionTests
Scenario: Mechanical Thermostat
	Given I am on the Open Project dashboard
	When I scroll up to Circuit Design Reference
	And I click Design Results
	And I click Controllers and Accessories
	And I click Mechnical Thermostat
	Then I should be able to see Mechnical Thermostat selected



