# everwealth-weather

## Development Notes

### Attempt 1
* DEV environment consists of Git Hub Desktop, Visual Studio Code, Powershell.
* Making use of the existing `dotnet` project templates
    * `dotnet new gitignore`
    * `dotnet new angular`
* Setup and install `node.js` and `chocolatey` as apparently neither are currently intalled, and are required by the default project template(s).
    * Another option would be to use docker containers to do the builds, which could then be used for a CI/CD pipeline as well.

* While performing intallation of `node.js` and `chocolatey` tools and dependencies. Found the following image to use a background
    * https://pixabay.com/photos/cloudscape-clouds-sky-cloudy-sky-5563794/
    * Licensed for usage without attribution in commercial prodcuts

* Well, using the template didn't work. Deleting and starting from a slight more simple basis.

### Attempt 2
* Setup a default angular page, and an empty webapi application and ensure that both run

* Created a new angular component to have the page information that was request

* Created a VERY basic `template` to hold the information, with data-binding driven from the component