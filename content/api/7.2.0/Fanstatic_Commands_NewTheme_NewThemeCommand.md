---
Title: "NewThemeCommand"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "NewThemeCommand"
  namespace: "Fanstatic.Commands.NewTheme"
  symbol: "class"
  source: "NewThemeCommand.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.NewTheme](/api/7.2.0/fanstatic.commands.newtheme)
- **Source File:** NewThemeCommand.cs

Check links of a given site.

## Public Methods

### Create

```csharp
public static Task<int> Create(NewThemeOptions options, ILogger logger)
```

Creates and executes a new NewThemeCommand instance

**Parameters:**

- `options` (*NewThemeOptions*): The new theme options
- `logger` (*ILogger*): The logger instance

**Returns:** `Task<int>`

- A task with the result code (0 for success, 1 for failure)

### Run

```csharp
public int Run()
```

Run the app

**Returns:** `int`


