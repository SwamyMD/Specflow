Feature: Calculate
	As a mathematician
	I want to input two numbers and calc type
	In order to display result on screen

Scenario: Based on calc type perform calculation 
	Given I have entered number 50 into the calculator
	And I have also entered number 70 into the calculator
	When I select calc type Add and press calc
	Then the calculated result should be 120 on the screen
