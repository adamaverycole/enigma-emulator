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