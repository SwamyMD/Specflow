Feature: Multiplication using weakly, strongly and dynamic typed table data
	As a mathematician
	I want to input two numbers
	In order to display multiplication result on screen

Scenario: Multiply two numbers using weakly typed data table 
	Given I have entered following attributes into calc and using weakly typed data
	| attribute    | value |
	| firstNumber  | 2     |
	| secondNumber | 3     |
	When I press multiply
	Then the multiplication result should be 6 on the screen

Scenario: Multiply two numbers using strongly typed data table 
	Given I have entered following attributes into cal and using strongly typed data
	| attribute    | value |
	| firstNumber  | 2     |
	| secondNumber | 3     |
	When I press multiply
	Then the multiplication result should be 6 on the screen

Scenario: Multiply two numbers using dynamic typed data table 
	Given I have entered following attributes into cal and using dynamic typed data
	| attribute    | value |
	| firstNumber  | 2     |
	| secondNumber | 3     |
	When I press multiply
	Then the multiplication result should be 6 on the screen

Scenario Outline: Multiply two numbers using scenario outline and data table
	Given I have entered following attributes into calc and using weakly typed data
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

