Feature: Feedback Dialog

Submitting Feedback

@Test1, @SmokeTest, @RegressionTest
Scenario Outline: Submitting Feedback with Thermon Credentials

	Given I click on Feedback button
	When I enter username '<username>'
	And I enter email '<email>'
	And I enter feedback '<feedback>'
	And I click submit button
	#Then I should be able to see Feedback is submitted

Examples:
	| username       | email                     | feedback  |
	| Thermon Client | thermonclient@thermon.com | Thank you |

	

