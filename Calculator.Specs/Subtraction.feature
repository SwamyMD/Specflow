Feature: Subtraction
	As a mathematician
	I want to input two numbers
	In order to display subtraction result on screen

Background: 
	Given Calculator is resetted

Scenario Outline: Subtract two numbers using scenario outline
	Given I have entered first number <firstNumber> into the calculator
	And I have entered second number <secondNumber> into the calculator
	When I press subtract
	Then the result should be <subtractionResult> on the screen
Examples: 
	| firstNumber | secondNumber | subtractionResult |
	| 70          | 50           | 20                |
	| -70         | -50          | -20               |
