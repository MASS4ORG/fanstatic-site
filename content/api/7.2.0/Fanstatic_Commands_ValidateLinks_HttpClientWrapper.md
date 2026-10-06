---
Title: "HttpClientWrapper"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "HttpClientWrapper"
  namespace: "Fanstatic.Commands.ValidateLinks"
  symbol: "class"
  source: "HttpClientWrapper.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.ValidateLinks](/api/7.2.0/fanstatic.commands.validatelinks)
- **Source File:** HttpClientWrapper.cs

Default implementation of IHttpClientWrapper

## Public Methods

### GetAsync

```csharp
public Task<HttpResponseMessage> GetAsync(Uri uri)
```

Sends a GET request to the specified URI

**Parameters:**

- `uri` (*Uri*): The URI to send the request to

**Returns:** `Task<HttpResponseMessage>`

- The HTTP response message

