---
Title: "BuildCommand"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "BuildCommand"
  namespace: "Fanstatic.Commands.Build"
  symbol: "class"
  source: "BuildCommand.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.Build](/api/7.2.0/fanstatic.commands.build)
- **Source File:** BuildCommand.cs

Build Command will build the site based on the source files.

## Public Methods

### Run

```csharp
public int Run()
```

Run the command

**Returns:** `int`


### Create

```csharp
public static Task<int> Create(BuildOptions options, ILogger logger)
```

Creates and executes a new BuildCommand instance

**Parameters:**

- `options` (*BuildOptions*): The build options
- `logger` (*ILogger*): The logger instance

**Returns:** `Task<int>`

- A task with the result code (0 for success, 1 for failure)

### CopyFolder

```csharp
public void CopyFolder(string source, string output)
```

Copy a folder content from source into the output folder, keeping subfolders.

**Parameters:**

- `source` (*string*): The source folder to copy from.
- `output` (*string*): The output folder to copy to.


