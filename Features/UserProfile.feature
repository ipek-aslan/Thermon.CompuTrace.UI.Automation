Feature: UserProfile

 Add Connection String and User Profile Validations 


@Test1, @SmokeTest, @RegressionTest
Scenario: Add Connection
	
	Given I click User Profile button
	When I click on Add connection button & enter the details and click on save button
		| connectionName | connectionString                                                                                                                                                                  |
		| Connect1       | Data Source=devdata001.southcentralus.cloudapp.azure.com;Initial Catalog=CompuTrace.ProdSnapshot;User Id=computrace;Password=DefaultSQLServerP@ssw0rd;Persist Security Info=true; |
		| Connect2       | Data Source=devdata001.southcentralus.cloudapp.azure.com;Initial Catalog=CompuTrace.ProdSnapshot;User Id=computrace;Password=DefaultSQLServerP@ssw0rd;Persist Security Info=true; |
	Then I should see connection string added



@Test2, @SmokeTest, @RegressionTest
Scenario: User profile as a default user

	Given I click User Profile button
	When I enter User Domain Name 'QA Automation'		
	And I click Update button
	Then I should see success message


@Test3, @SmokeTest, @RegressionTest
Scenario: User Profile as a different user

	Given I click User Profile button
	When I enter user name 'Thermon Client'		
	And I enter user email 'thermonclient@gmail.com'		
	And I enter User Domain Name 'Thermon'	    
	And I click Update button
	Then I should see success message
 