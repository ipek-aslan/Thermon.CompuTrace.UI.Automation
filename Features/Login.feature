Feature: LoginPage

@SmokeTests, @RegressionTests
Scenario:01 Login using the Thermon credentials

    Given I navigate to the localhost login page
    When I click on Login button
    And I click Thermon account email 
    And I enter Thermon account password
    And I click on Sign in button
    And I click on Yes button on Microsoft sign on page
    Then I should see the CompuTrace Home Page


   
