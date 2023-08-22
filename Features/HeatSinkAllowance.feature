Feature: HeatSinkAllowance



@SmokeTests, @RegressionTests
Scenario: Heat Sink Allowance
	Given I am on Open Project
	When I click a circuit 
	And I click to Heat Sink Allowances tab
	And I click add button
	And I select value '<value>' from Heat Sink dropdown
	And I select allocation method '<allocationmethod>'
	And I select type '<type>'from dropdown
	And I select size '<size>'from dropdown
	And I add quantity '<quantity>'
	And I click done button
	Then I should see heat sink value added
	
