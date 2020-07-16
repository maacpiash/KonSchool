# The following tools must be installed for this to work:
# `xunit`, `opencover.portable`, `codecov`, and `dotnet-reportgenerator-globaltool`

# These can be installed via the following commands:
# choco install xunit opencover.portable codecov
# dotnet tool install --global dotnet-reportgenerator-globaltool

OpenCover.Console.exe `
    -register:user `
    -target:"C:\Program Files\dotnet\dotnet.exe" `
    -targetargs:test `
    -filter:"+[KonSchool*]* -[KonSchool.Tests*]*" `
    -excludebyfile:"SchoolService.cs" `
    -output:".\report\KonSchool_coverage.xml" `
    -oldstyle

reportgenerator -reports:.\report\KonSchool_coverage.xml -reporttypes:Html -targetdir:.\report
dotnet serve -d .\report -p 5050

# The following command opens the report in the default web browser:
# Invoke-Expression “cmd.exe /C start http://localhost:5050"

# Or, just ctrl-click on the link above 😁
