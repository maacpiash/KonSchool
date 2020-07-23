# The following tools must be installed for this to work:
# `coverlet` and `dotnet-reportgenerator-globaltool`

# These can be installed via the following commands:
# dotnet tool install --global coverlet.console
# dotnet tool install --global dotnet-reportgenerator-globaltool

# First, build the projects
dotnet build

# Now, let's run the tests and collect the coverage
coverlet tests/bin/Debug/netcoreapp3.1/KonSchool.Tests.dll \
    --target "dotnet" \
    --targetargs "test tests/KonSchool.Tests.csproj --no-build" \
    --format opencover

reportgenerator -reports:./coverage.opencover.xml -reporttypes:Html -targetdir:./report

# After generating the report, you can either open `report/index.html` file
# directly in your browser, or you can use `dotnet-serve` tool to serve
# the `report` directory.

# You can install the tool by  the following command:
# dotnet tool install --global dotnet-serve

dotnet serve -d ./report -p 5050

# The following command opens the report in the default web browser:
# Invoke-Expression “cmd.exe /C start http://localhost:5050"

# Or, just ctrl-click on the link above 😁
