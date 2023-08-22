Feature: BillOfMaterials

Bill Of Materials Validation

@SmokeTests, @RegressionTests
Scenario: Adding Items to Bill Of Materials
	Given I am on the Open Project dashboard
	When I scroll up to Circuit Design Reference
	And I click Design Results
	And I click Add to Custom BoM Entry
	Then I should be able to see BoM Entry added
