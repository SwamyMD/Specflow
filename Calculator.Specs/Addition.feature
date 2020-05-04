Feature: Addition
	As a mathematician
	I want to input two numbers
	In order to display sum results on screen

Scenario: Add two positive numbers
	Given I have entered firstnumber 50 into the calculator
	And I have entered secondnumber 70 into the calculator
	When I press add
	Then the addition result should be 120 on the screen
