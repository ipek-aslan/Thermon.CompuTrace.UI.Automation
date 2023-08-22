Feature: ConnectionKits

Connection Kits Validations

@Test1, @SmokeTest, @RegressionTest
Scenario: Power Connection
	Given I am on the Open Project dashboard
	When I scroll up to Circuit Design Reference
	And I click Design Results
	And I click Override from Power Connection
	Then I should be able to see Override selected


@Test2, @SmokeTests, @RegressionTests
Scenario: Splice
	Given I am on the Open Project dashboard
	When I scroll up to Circuit Design Reference
	And I click Design Results
	And I click Override from Splice
	Then I should be able to see Override selected


@Test3, @SmokeTests, @RegressionTests
Scenario: Tee
	Given I am on the Open Project dashboard
	When I scroll up to Circuit Design Reference
	And I click Design Results
	And I click Override from End Seal
	Then I should be able to see Override selected


@Test4, @SmokeTests, @RegressionTests
Scenario: End Seal
	Given I am on the Open Project dashboard
	When I scroll up to Circuit Design Reference
	And I click Design Results
	And I click Override from End Seal
	Then I should be able to see Override selected




