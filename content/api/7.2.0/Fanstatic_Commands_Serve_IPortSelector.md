---
Title: "IPortSelector"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "IPortSelector"
  namespace: "Fanstatic.Commands.Serve"
  symbol: "interface"
  source: "IPortSelector.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.Serve](/api/7.2.0/fanstatic.commands.serve)
- **Source File:** IPortSelector.cs

Interface for port selection strategy

## Public Methods

### SelectAvailablePort

```csharp
 int SelectAvailablePort(string baseUrl, int initialPort, int maxTries)
```

Selects an available port, trying alternative ports if needed

**Parameters:**

- `baseUrl` (*string*): Base URL to bind
- `initialPort` (*int*): Initially requested port
- `maxTries` (*int*): Maximum number of port selection attempts

**Returns:** `int`

- An available port number

