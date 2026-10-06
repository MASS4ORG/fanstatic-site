---
Title: "StaticFileRequest"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "StaticFileRequest"
  namespace: "Fanstatic.ServerHandlers"
  symbol: "class"
  source: "StaticFileRequest.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.ServerHandlers](/api/7.2.0/fanstatic.serverhandlers)
- **Source File:** StaticFileRequest.cs

Check if it is one of the Static files (serve the actual file)

## Public Methods

### Check

```csharp
public bool Check(Uri requestPath)
```

**Parameters:**

- `requestPath` (*Uri*)

**Returns:** `bool`


### Handle

```csharp
public async Task<string> Handle(IHttpListenerResponse response, Uri requestPath, DateTime serverStartTime)
```

**Parameters:**

- `response` (*IHttpListenerResponse*)
- `requestPath` (*Uri*)
- `serverStartTime` (*DateTime*)

**Returns:** `Task<string>`


