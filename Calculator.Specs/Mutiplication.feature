Feature: Multiplication
	As a mathematician
	I want to input two numbers
	In order to display multiplication result on screen

Scenario: Multiply two numbers using data table
	Given I have entered following attributes into the calculator
	| attribute    | value |
	| firstNumber  | 2     |
	| secondNumber | 3     |
	When I press multiply
	Then the multiplication result should be 6 on the screen


Scenario Outline: Multiply two numbers using scenario outline and data table
	Given I have entered following attributes into the calculator
	| attribute    | value          |
	| firstNumber  | <firstNumber>  |
	| secondNumber | <secondNumber> |
	When I press multiply
	Then the multiplication result should be <multiplicationResult> on the screen
Examples: 
	| firstNumber | secondNumber | multiplicationResult |
	| 2           | 1            | 2                    |
	| 2           | 2            | 4                    |
	| 2           | 3            | 6                    |
	| 2           | 4            | 8                    |
	| 2           | 5            | 10                   |

