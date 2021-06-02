# EP Manifest Proof-of-Concept

## Stack

* UI Framework: Blazor Server
* UI Component Library: MudBlazor
* Web Framework: ASP.NET Core 5
* Data Access: Entity Framework Core
* Data Store: SQL Server
* Logging: Serilog
* Unit Testing: xUnit, bUnit

## How do I run this?

See <https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations> if you are new to Entity Framework Core.

Ensure you have LocalDB installed, or open appsettings.json and modify the data source of the "EPManifestContext" connection string.

### Build the project and restore packages

Using the .NET CLI:

```bash
dotnet build
```

### Create and seed the database with test data

.NET CLI:

```bash
dotnet ef database update
```

Or, using VS Package Manager Console (PowerShell):

```pwsh
Update-Database
```

### Run the app

.NET CLI:

```bash
dotnet run
```
