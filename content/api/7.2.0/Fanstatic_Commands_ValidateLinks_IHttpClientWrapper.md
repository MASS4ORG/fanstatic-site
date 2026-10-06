---
Title: "IHttpClientWrapper"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "IHttpClientWrapper"
  namespace: "Fanstatic.Commands.ValidateLinks"
  symbol: "interface"
  source: "IHttpClientWrapper.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.ValidateLinks](/api/7.2.0/fanstatic.commands.validatelinks)
- **Source File:** IHttpClientWrapper.cs

Wrapper interface for `HttpClient` to improve testability.

## Public Methods

### GetAsync

```csharp
 Task<HttpResponseMessage> GetAsync(Uri uri)
```

Sends a GET request to the specified URI.

**Parameters:**

- `uri` (*Uri*): The URI to send the request to.

**Returns:** `Task<HttpResponseMessage>`

- A task representing the asynchronous operation, containing the `HttpResponseMessage`.

