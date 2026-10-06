---
Title: "PingRequests"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "PingRequests"
  namespace: "Fanstatic.ServerHandlers"
  symbol: "class"
  source: "PingRequests.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.ServerHandlers](/api/7.2.0/fanstatic.serverhandlers)
- **Source File:** PingRequests.cs

Return the server startup timestamp as the response

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


