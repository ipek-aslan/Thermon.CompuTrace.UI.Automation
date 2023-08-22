Feature: EquipmentCoord

Equipment Coordinates Validations

@Test1, @SmokeTests, @RegressionTests
Scenario: Add Item to List
	Given I am on the Open Project dashboard
	When I scroll up to Circuit Design Reference
	And I click Reference Drawing Type
	And I click Add button
	And I click Import Reference Drawing Type dropdown
	And I select Reference
	And I enter number '<number>'
	And I click Add button
	Then I should be able to see Reference added
