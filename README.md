# Open Weather Automation Test

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
