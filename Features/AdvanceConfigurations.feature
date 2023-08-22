Feature: AdvanceConfigurations

Advance Configuration Validations

@Test1, @SmokeTest, @RegressionTest
Scenario Outline: Templates For Custom BoM Entries
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
	And I Add new items on Templates For Custom BoM Entries page
		| catalog number | part number |
		| dsx-3-1        | 25615       |
		| dsb-6-1        | 34355       |
	Then I should be able to see item added on Templates For Custom BoM Entries page
	 



@Test2, @SmokeTest, @RegressionTest
Scenario: Project Level Miscellaneous Defaults
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
	And I click on Next button on Templates For Custom BoM Entries page
	And I select Controller Type
		| Key             | Value                 |
		| Controller Type | Mechanical Thermostat |
	Then I should be able to see selected controller type

	


@Test3, @SmokeTest, @RegressionTest
Scenario: Project Level Custom Components
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
	And I click on Next button on Templates For Custom BoM Entries page
	And I click on Next button on  Project Level Miscellaneous Defaults page
	And I Add new items on Templates For project level custom components
		| catalog number | part number | component type  |
		| dsx-3-1        | 25615       | PowerConnection |
		| dsb-6-1        | 34355       | PowerConnection |
	Then I should be able to see item added on Project Level Custom Components Page

	


@Test4, @SmokeTest, @RegressionTest
Scenario: Project Extra Requirements
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
	And I click on Next button on Templates For Custom BoM Entries page
	And I click on Next button on  Project Level Miscellaneous Defaults page
	And I click on Next button on Project Level Custom Components page
	And I select component type on Project Extra Components page
		| component type | catalog number |
		| Banding        | 1952A          |
	And I select Catalog Part from dropdown on Project Extra Components page
		| Catalog Part |
		| 1952A        |
		| B-10         |
	Then I should be able to see component type and catalog part added

	#And I click remove all items button
	#And I click remove all extra components 



@Test5, @SmokeTest, @RegressionTest
Scenario: Project Available Components
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
	And I click on Next button on Templates For Custom BoM Entries page
	And I click on Next button on  Project Level Miscellaneous Defaults page
	And I click on Next button on Project Level Custom Components page
	And I click on Next button on Project Extra Requirements page
	And I select component type from lists to add to available components
	Then I should be able to see component type added

	#And I click remove all items button
	#And I click remove all extra components 
	#import 
	#export



@Test6, @SmokeTest, @RegressionTest
Scenario: Project Tag Defaults
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
	And I click on Next button on Templates For Custom BoM Entries page
	And I click on Next button on  Project Level Miscellaneous Defaults page
	And I click on Next button on Project Level Custom Components page
	And I click on Next button on Project Extra Requirements page
	And I click on Next button on Project Available Components page
	And I click use default button
	Then I should be able to see Project Tag Defaults added

	#Import controls 
	#export controls

@Test7, @SmokeTest, @RegressionTest
Scenario: Circuit Reference Drawing List
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
	And I click on Next button on Templates For Custom BoM Entries page
	And I click on Next button on  Project Level Miscellaneous Defaults page
	And I click on Next button on Project Level Custom Components page
	And I click on Next button on Project Extra Requirements page
	And I click on Next button on Project Available Components page
	And I click on Next button on Project Tag Defaults page
	And I click Import Circuit Reference Drawing Type button
	Then I should be able to see Circuit Reference Drawing List
	
	#And I click remove all items button
	#import circuit reference drawing type clicking
    #file should be add 
