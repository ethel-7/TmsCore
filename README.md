# TmsCore

Training Management System Core - C# fundamentals and language features training project.

## Project Structure

```
TmsCore/
├── Program.cs
├── Models.cs
├── EnrollmentService.cs
├── TmsCore.csproj
└── .gitignore
```

## Branches

### `main`
Basic console application setup with minimal configuration.

### `module-1-session-1`
C# fundamentals and type safety features:
- Nullable reference types and null-coalescing operators
- String interpolation and formatting
- Decimal precision for financial calculations
- Records for immutable data
- Property validation with field keyword
- Interfaces and polymorphism

**Additional Files:**
- `Models.cs`

### `module-1-session-2`
LINQ queries and enrollment service:
- Enrollment validation service with guard clauses
- LINQ filtering, ordering, and grouping
- Pattern matching with switch expressions
- Collection expressions with spread operator
- Academic standing classification

**Additional Files:**
- `EnrollmentService.cs`

### `module-1-session-3`
Async programming and exception handling:
- Async/await patterns
- Task parallelization with Task.WhenAll
- Async data fetching simulation
- Custom exception classes
- Exception handling and error reporting
- Performance measurement with Stopwatch

**Key Features:**
- Custom `CapacityReachedException` for domain-specific errors
- `TmsDatabaseException` for data layer errors
- Enrollment summary reporting

## Getting Started

```bash
# Clone the repository
git clone https://github.com/ethel-7/TmsCore.git

# Navigate to the project
cd TmsCore

# Checkout a specific branch
git checkout module-1-session-1

# Run the application
dotnet run
```

## Requirements

- .NET 10.0 or later
- Visual Studio 2022 or VS Code
