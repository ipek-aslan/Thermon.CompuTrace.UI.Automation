Feature: CreateCircuit

Circuit Design Reference - Input Data and Creating Circuit

Entering Circuit Values


@SmokeTest, @RegressionTest
Scenario: Creating Circuit
	Given I am on the Open Project dashboard
	When I scroll up to Circuit Design Reference
	And I click Analysis type dropdown
	And I select Temperature Maintenance from dropdown
	And I click All heater sets to single tie breaker
	And I click Circuit Config dropdown
	And I click Single Phase (P-N) from Circuit configuration dropdown
	And I click Volatge dropdown
	And I enter Voltage as '<voltage>'
	|240|
	And I click Heater Voltage dropdown
	And I enter Heater Voltage as '<voltage>'
	|240|
	And I click Breaker Size dropdown
	And I enter Breaker Size as '<breaker size>'
	|20|
	And I click Breaker Type dropdown
	And I enter Breaker Type as '<breaker type>'
	|QOB|
	And I click Maintanance Temp dropdown
	And I enter Maintanance Temperature '<temp>'
	|50|
	And I click Max Process Temp dropdown
	And I enter Max Process Temp '<temp>'
	|35|
	And I click Max Upset Process dropdown
	And I enter Max Upset Process '<temp>'
	|35|
	And I click Max Product Temp dropdown
	And I enter Max Product Temp '<temp>'
	|1000|
	And I click Min Ambient dropdown
	And I enter Min Ambient '<temp>'
	|0|
	And I click Max Ambient dropdown
	And I enter Max Ambient '<temp>'
	|104|
	And I click Start Up Ambient dropdown
	And I enter Start Up '<temp>'
	|0|
	And I click Chemical Exp dropdown 
	And I select Chemical Exp as InOrganics from dropdown 
	And I click Series from Heater Style
	And I click User Selects Heater Family from Heater Family Selection
	And I click cable dropdown
	And I select BSX cable from dropdown
	And I click Class dropdown from Area Classification
	And I select Ordinary from dropdown
	And I scroll up to Temperature Control
	And I click Type dropdown 
	And I select Pipe Sensing from dropdown
	And I scroll up to Heater Info 
	And I click Heater Installation Method dropdown
	And I select Fixing Tape/Banding from dropdown
	And I scroll up to toolbar tab
	And I click Run button
	Then I should be able to see circuit created



