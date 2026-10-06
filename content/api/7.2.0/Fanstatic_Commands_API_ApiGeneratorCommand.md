---
Title: "ApiGeneratorCommand"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "ApiGeneratorCommand"
  namespace: "Fanstatic.Commands.API"
  symbol: "class"
  source: "ApiGeneratorCommand.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.API](/api/7.2.0/fanstatic.commands.api)
- **Source File:** ApiGeneratorCommand.cs

Check links of a given site.

## Public Methods

### Create

```csharp
public static Task<int> Create(ApiGeneratorOptions options, ILogger logger, IFileSystem fileSystem)
```

Creates and executes a new NewSiteCommand instance

**Parameters:**

- `options` (*ApiGeneratorOptions*): The new site options
- `logger` (*ILogger*): The logger instance
- `fileSystem` (*IFileSystem*)

**Returns:** `Task<int>`

- A task with the result code (0 for success, 1 for failure)

### Run

```csharp
public static ApiGeneratorCommand Run(ApiGeneratorOptions options, ILogger logger, IFileSystem fileSystem)
```

Creates a new instance of NewSiteCommand with the specified options, logger, and file system.

**Parameters:**

- `options` (*ApiGeneratorOptions*)
- `logger` (*ILogger*)
- `fileSystem` (*IFileSystem*)

**Returns:** `ApiGeneratorCommand`


### Run

```csharp
public async Task<int> Run()
```

Run the app

**Returns:** `Task<int>`


