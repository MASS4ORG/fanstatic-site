---
Title: "NewSiteCommand"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "NewSiteCommand"
  namespace: "Fanstatic.Commands.NewSite"
  symbol: "class"
  source: "NewSiteCommand.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.NewSite](/api/7.2.0/fanstatic.commands.newsite)
- **Source File:** NewSiteCommand.cs

Check links of a given site.

## Public Methods

### Create

```csharp
public static Task<int> Create(NewSiteOptions options, ILogger logger)
```

Creates and executes a new NewSiteCommand instance

**Parameters:**

- `options` (*NewSiteOptions*): The new site options
- `logger` (*ILogger*): The logger instance

**Returns:** `Task<int>`

- A task with the result code (0 for success, 1 for failure)

### Run

```csharp
public static NewSiteCommand Run(NewSiteOptions options, ILogger logger, IFileSystem fileSystem)
```

Generate the needed data for the class

**Parameters:**

- `options` (*NewSiteOptions*)
- `logger` (*ILogger*)
- `fileSystem` (*IFileSystem*)

**Returns:** `NewSiteCommand`


### Run

```csharp
public int Run()
```

Run the app

**Returns:** `int`


