Remove-Item -Recurse -Force TestResults, coveragereport -ErrorAction SilentlyContinue

dotnet test --collect:"XPlat Code Coverage"
if ($LASTEXITCODE -ne 0) { exit $LASTEXITCODE }

dotnet reportgenerator -reports:"**/coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
Start-Process .\coveragereport\index.html