Feature: ProjectDashboard

Project Dashboard and Home Page Validations


@Test1, @SmokeTest, @RegressionTest
Scenario: Project Dashboard Validation

	Given I am on the Project Dashboard Page
	Then verify project list on dashboard page



@Test2, @SmokeTest, @RegressionTest
Scenario: Home Page Validation

    Given I navigate to the localhost login page
    When I click on dashboard button
    Then I should see the CompuTrace Home Page

#
#@Test3, @SmokeTest, @RegressionTest
#Scenario: Import Project
#
#	Given I click Import Project button
#	When I select file
#	Then I should see file imported



