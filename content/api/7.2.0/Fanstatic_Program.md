---
Title: "Program"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "Program"
  namespace: "Fanstatic"
  symbol: "class"
  source: "Program.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic](/api/7.2.0/fanstatic)
- **Source File:** Program.cs

The main entry point of the program.

### Remarks
Constructor

## Public Methods

### Main

```csharp
public static async Task<int> Main(string[] args)
```

Entry point of the program

**Parameters:**

- `args` (*string[]*)

**Returns:** `Task<int>`


### CreateLogger

```csharp
public static ILogger CreateLogger(bool verbose = false)
```

Create a log (normally from Serilog), depending on the verbose option

**Parameters:**

- `verbose` (*bool*) (Default: `false`)

**Returns:** `ILogger`


