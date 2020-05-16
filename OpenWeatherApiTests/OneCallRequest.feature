Feature: OneCallRequest
	The One Call Request API should be able to provide a general overview of the Weather Forecast when requested

Scenario Outline: I am able to find the Hottest Day of the next week for a given City
	When I make a OneCall Request to get the Weather for '<city>'
	Then I receive the expected Weather Report for '<city>'
	And I am able to find the Hottest Day within the Response
	Examples:
	| city     |
	| london   |
	| paris    |
	| chicago  |
	| brisbane |
	| tokyo    |

Scenario: I am able to find the Minimum and Maximum Temperature for the current day for a given city
	When I make a OneCall Request to get the Weather for 'paris'
	Then I am able to find the minimum and maximum temperature for the current day