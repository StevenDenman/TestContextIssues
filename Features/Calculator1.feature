Feature: Calculator1

Scenario Outline: Add two numbers1
	Given the first number is 1
	And the second number is 1
	When the two numbers are added
	Then the result should be 2