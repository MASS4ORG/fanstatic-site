---
Title: "DefaultPortSelector"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "DefaultPortSelector"
  namespace: "Fanstatic.Commands.Serve"
  symbol: "class"
  source: "DefaultPortSelector.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.Serve](/api/7.2.0/fanstatic.commands.serve)
- **Source File:** DefaultPortSelector.cs

Default implementation of port selection

## Public Methods

### SelectAvailablePort

```csharp
public int SelectAvailablePort(string baseUrl, int initialPort, int maxTries)
```

Check if a given port is available, if not, search for another available.

**Parameters:**

- `baseUrl` (*string*)
- `initialPort` (*int*)
- `maxTries` (*int*)

**Returns:** `int`


