# Desktop Application

This is a cross-platform desktop application that runs on ASP.NET Core along with [Electron.NET](https://github.com/ElectronNET/Electron.NET).

Tested on macOS High Sierra, Windows 10 and Ubuntu 18.04 LTS. Works fine on all of them :smile:

### Prerequisites
- .NET Core SDK (2.0 or higher)
- NPM

### How to run
After cloning this repository, simply go into this folder via command line and run the following command:
```
$ dotnet restore
$ dotnet electronize init
$ dotnet electronize start
```
The first two commands are to be run only for the first time. After that, only `dotnet electronize start` will do the job.
<br/>
<br/>
Note that these commands must be run in the folder that contains the `KonSchool_Desktop.csproj` file.