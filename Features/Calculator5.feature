Feature: Calculator5

Scenario Outline: Add two numbers5
	Given the first number is 5
	And the second number is 5
	When the two numbers are added
	Then the result should be 10