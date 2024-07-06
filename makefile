build:
	dotnet build src/Enigma.sln

clean:
	dotnet clean src/Enigma.sln

test:
	dotnet test src/Enigma.sln

run: 
	dotnet run --project src/Cli/cli.csproj