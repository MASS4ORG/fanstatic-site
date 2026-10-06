---
Title: "ServeCommand"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "ServeCommand"
  namespace: "Fanstatic.Commands.Serve"
  symbol: "class"
  source: "ServeCommand.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.Serve](/api/7.2.0/fanstatic.commands.serve)
- **Source File:** ServeCommand.cs

Serve Command will live serve the site and watch any changes.

## Fields

### **BaseUrlDefault** (*string*) = `"http://localhost"`: Default values for the ServeCommand
### **PortDefault** (*int*) = `2341`: Default values for the ServeCommand
### **MaxPortTries** (*int*) = `10`: Default values for the ServeCommand

## Properties

### **PortUsed**

(*int*) { get; set }: The actual port being used after potential port selection


## Public Methods

### Create

```csharp
public static async Task<int> Create(ServeOptions options, ILogger logger)
```

Creates and executes a new ServeCommand instance

**Parameters:**

- `options` (*ServeOptions*): The serve options
- `logger` (*ILogger*): The logger instance

**Returns:** `Task<int>`

- A task with the result code (0 for success, 1 for failure)

### StartServer

```csharp
public void StartServer(string baseUrl = "", int requestedPort = 0)
```

Starts the server with intelligent port selection

**Parameters:**

- `baseUrl` (*string*): The base URL for the server. (Default: `""`)
- `requestedPort` (*int*): The port number for the server. (Default: `0`)


### Dispose

```csharp
public void Dispose()
```


