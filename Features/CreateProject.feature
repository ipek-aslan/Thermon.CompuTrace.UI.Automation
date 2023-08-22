Feature: CreateProject

@Test1, @SmokeTest, @RegressionTest
Scenario Outline: Create Project Without Advance Configuration

	 
	//Given I click on Create Project
	Given I click Dashboard button
	When I click on Create Project
	And I enter project name
	And I enter project number
	And I click on location column
	And I click on Next button on Project Reference page
	And I select default project units
		| Key               | Value                               |
		| Pipe Units        | Imperial Pipe / Imperial Insulation |
		| Temperature Units | F                                   |
		| Other Units       | Imperial                            |
		| Electrical Codes  | ATEX: Ordinary/Zones                |
	And I click on Next button on Set Project Units page
	And I click on Next button on Design Defaults page
	And I click on Finish button on Advance Configuration page
	Then I should be able to see project created

	 


@Test2, @SmokeTest, @RegressionTest
Scenario Outline: Create Project With Advance Configuration

	Given I click Dashboard button
	When I click on Create Project
	And I enter project name
	And I enter project number
	And I click on location column
	And I click on Next button on Project Reference page
	And I select default project units
		| Key               | Value                               |
		| Pipe Units        | Imperial Pipe / Imperial Insulation |
		| Temperature Units | F                                   |
		| Other Units       | Imperial                            |
		| Electrical Codes  | ATEX: Ordinary/Zones                |
	And I click on Next button on Set Project Units page
	And I click on Next button on Design Defaults page
	And I click on Advance Configuration checkbox
	And I click on Next button on Advance Configuration page
	And I click on Next button on Templates for Custom BoM Entries page
	And I click on Next button on Project Miscellaneous Defaults page
	And I click on Next button on Project Level Custom Components
	And I click on Next button on Project Extra Requirements
	And I click on Next button on Project Available Components
	And I click on Next button on Project Tag Defaults
	And I click on Finish button on Circuit Reference Drawing List
	Then I should be able to see project created


