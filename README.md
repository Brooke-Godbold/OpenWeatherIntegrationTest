# Ziglu - Automation Test

Create a backend automation framework using the following API:
 Open Weather API - https://openweathermap.org
(You will need to create an account on OpenWeatherApi as this will give you an API key to be able to conduct the tests)

If you have any questions throughout don’t hesitate to ask.

## The user journeys to automate

1. Using the Open Weather API, get the weather forecast for the week for 5 different cities. Then get the hottest day for each city (in this forecast window) - think of how to present this data, which formats are understandable.

2. The next scenario is to get the minimum and maximum temperature in the city of Paris

## Test & Environment Setup

The best way to run the Tests is via Visual Studio Code. This will allow the User to run the Tests through the GUI, and see the results in a clearer manner.

The NuGet Packages for the Project are set to be ignored by Git, so after downloading for the first time, Package Restore will need to be run: https://docs.microsoft.com/en-us/nuget/consume-packages/package-restore

Regardless of how the Tests are run, they require Registration with SpecFlow using your Microsoft Account; running Tests for first time will give a warning around this, and provide link which can be clicked to go straight to registration

To run via the Command Line, The User must have MSBuild on their Path Variable; for Users using Visual Studio Code, this should be located in a path similar to this:
```bash
C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\MSBuild.exe
```

The Tests also require the User to Register with Open Weather and retrieve their API Key (see above). Once this is done, the User should go into Properties > Settings within the OpenWeatherApiTests Directory, and add their API Key to API_KEY field

## Running the Tests

The Tests can be run from either an IDE, or via the Command Line.

For running in Visual Studio Code, simply navigate to the Test menu on the Toolbar, and run the Tests in the manner wished.

For running via the Command Line:
```bash
cd OpenWeatherApiTests
./runtests.cmd
```

## Looking Forward

There are further improvements which could be made to this Test Suite. Given the time, I would look to investigate the HTML Report functionality, which I was not able to get involved in due to time considerations. I would also seek to make improvements to how the User API Key is stored, to make it more secure, and also make improvements to how the Test Data is stored and retrieved, to make it more intuitive for non-technical Users.

## Further Questions

Q. How long did you spend on the technical test?

A. I spent around 6 hours on this Project. This included getting the Environment set up (done from a machine which hasn't seen much C# Programming'), investigating concepts which I had never tackled in C# before (making Rest Calls, manipulating Json, running Assertions, getting SpecFlow set up), and of course designing the Tests themselves.

Q. What do you think is the most interesting trend in test automation?

A. The trends which I have noticed have been more focused around Front-End Automation. I was particularly impressed with how powerful a tool Cypress was when I had the chance to use it, having come off of the back of Selenium and Protractor.

Q. Please describe yourself using JSON

A.

{
	"firstName": "Brooke",
	"lastName": "Godbold",
	"dateOfBirth": "29/11/1991",
	"address": {
		"houseNumber": "14",
		"streetName": "BelgraviaClose",
		"city": "Barnet",
		"postCode": "EN55XA"
	},
	"hobbies": [
		{
			"name": "Foreign Languages",
			"averageTimePerWeek": 5
		},
		{
			"name": "Unity Game Development",
			"averageTimePerWeek": 8
		},
		{
			"name": "Gym & Fitness",
			"averageTimePerWeek": 6
		}
		{
			"name": "Retro Game Collecting",
			"averageTimePerWeek": 3
		}
	]
}