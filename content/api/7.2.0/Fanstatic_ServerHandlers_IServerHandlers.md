---
Title: "IServerHandlers"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "IServerHandlers"
  namespace: "Fanstatic.ServerHandlers"
  symbol: "interface"
  source: "IServerHandlers.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.ServerHandlers](/api/7.2.0/fanstatic.serverhandlers)
- **Source File:** IServerHandlers.cs

Handle server requests

## Public Methods

### Check

```csharp
 bool Check(Uri requestPath)
```

Check if the condition is met to handle the request

**Parameters:**

- `requestPath` (*Uri*)

**Returns:** `bool`


### Handle

```csharp
 Task<string> Handle(IHttpListenerResponse response, Uri requestPath, DateTime serverStartTime)
```

Process the request

**Parameters:**

- `response` (*IHttpListenerResponse*)
- `requestPath` (*Uri*)
- `serverStartTime` (*DateTime*)

**Returns:** `Task<string>`


