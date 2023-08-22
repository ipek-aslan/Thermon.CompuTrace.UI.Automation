Feature: DesignPalette

Design Palette Validations

@Test1, @SmokeTests, @RegressionTests
Scenario: Save Created Project 
	Given I am on Open Project
	When I click Save Project button
	Then I should see project Saved success message


@Test2, @SmokeTests, @RegressionTests
Scenario: Folder Button
	Given I am on Open Project
	When I click Folder button
	Then I should see folder opened


@Test3, @SmokeTests, @RegressionTests
Scenario: Search Button
	Given I am on Open Project
	When I click Search button
	Then I should see Search bar opened


@Test4, @SmokeTests, @RegressionTests
Scenario: Settings Button
	Given I am on Open Project
	When I click Settings button
	Then I should see Settings dialog opened



@Test5, @SmokeTests, @RegressionTests
Scenario: Help Button
	Given I am on Open Project
	When I click Help button
	Then I should see Help dialog opened