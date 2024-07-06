# enigma-emulator
Emulates the Enigma machine used to encrypt and decrypt messages during WW2.

## Solution

This is a dotnet c# application following a domain driven architecture. Its primary interface is a cli but should allow for others in the future.

### Directory Structure

```
- Root  
  - src
    - Application   // Business logic: Use Cases and Helpers
      - Helpers
      - UseCases
    - cli           // User Interface
    - Data.Read     // Repositories for reading data
    - Data.Write    // Repositories for writing data
    - Model.Read    // Models required for reading data
    - Model.Write   // Models required for writing data
    - Tests         // Unit and Integration Tests
```

### Creating the Solution

The following `dotnet` commands were executed to build the solution.

```
mkdir src
cd src
dotnet new sln -n Enigma
dotnet new classlib -n Application -o Application -lang C# -f net8.0
dotnet new nunit -n Tests -o Tests -lang C# -f net8.0
dotnet new console -n cli -o Cli -lang C# -f net8.0
dotnet sln Enigma.sln add Application
dotnet sln Enigma.sln add Cli
dotnet sln Enigma.sln add Tests
dotnet add Cli/cli.csproj reference Application/Application.csproj
dotnet add Tests/Tests.csproj reference Cli/cli.csproj 
dotnet add Tests/Tests.csproj reference Application/Application.csproj
```
