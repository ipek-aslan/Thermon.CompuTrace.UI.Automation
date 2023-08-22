Feature: SDR.DesignResults

Design Results Validations

@Test1, @SmokeTests, @RegressionTests
Scenario: Circuit Results
	Given I am on the Open Project dashboard
	When I scroll up to Segment Design Reference
	And I click Design Results tab
	And I check Circut results in Design Results column
	Then I should be able to see success message in design results column


@Test2, @SmokeTests, @RegressionTests
Scenario: Segment Results
	Given I am on the Open Project dashboard
	When I scroll up to Segment Design Reference
	And I click Design Results tab
	And I check Segment results in Design Results column
	Then I should be able to see success message in design results column

