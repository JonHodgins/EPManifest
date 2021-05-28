# EP Manifest Proof-of-Concept

## Stack

Web Framework: ASP.NET Core 5
UI Framework: Blazor Server
UI Component Library: MudBlazor
Data Store: SQL Server
Logging: Serilog

## How do I run this?

See <https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations> if you are unfamiliar with Entity Framework Core.

Ensure you have LocalDB installed, or open appsettings.json and modify the data source of the "EPManifestContext" connection string.

### Build the project and restore packages

Using the .NET CLI:

```bash
dotnet build
```

### Create and seed the database with test data

Using the .NET CLI:

```bash
dotnet ef database update
```

Or, using VS Package Manager Console (PowerShell):

```pwsh
Update-Database
```

### Run the app

Using the .NET CLI:

```bash
dotnet run
```
