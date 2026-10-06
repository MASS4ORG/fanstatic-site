---
Title: "ValidateLinksCommand"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "ValidateLinksCommand"
  namespace: "Fanstatic.Commands.ValidateLinks"
  symbol: "class"
  source: "ValidateLinksCommand.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.ValidateLinks](/api/7.2.0/fanstatic.commands.validatelinks)
- **Source File:** ValidateLinksCommand.cs

Validates internal and external links in generated HTML content.

## Fields

### **PagesWithFailedLinks** (*ConcurrentDictionary<IPage, List<(string Link, LinkStatus Status)>>*) = `[]`: Dictionary to store pages with their failed links

## Properties

### **DefaultRetryCount**

(*int*) { get } = `3`: Number of times to retry failed external link validations

### **DefaultRetryInterval**

(*int*) { get } = `1000`: Interval in milliseconds between retry attempts

### **DefaultTimeout**

(*int*) { get } = `10000`: Timeout in milliseconds for external link validation requests


## Public Methods

### Parse

```csharp
public async Task<ValidateLinksCommand> Parse()
```

Parses content and validates all links

**Returns:** `Task<ValidateLinksCommand>`

- The current command instance

### GenerateReport

```csharp
public Task<int> GenerateReport()
```

Generates validation report and returns exit code

**Returns:** `Task<int>`

- Exit code indicating success (0) or failure (1)

### ValidateInternalLink

```csharp
public static Task<LinkStatus> ValidateInternalLink(Uri linkStripped, Uri link, IDictionary<Uri, IOutput> outputReferences)
```

Validates if an internal link exists in output references

**Parameters:**

- `linkStripped` (*Uri*): Link to validate
- `link` (*Uri*)
- `outputReferences` (*IDictionary<Uri, IOutput>*): Dictionary of output references

**Returns:** `Task<LinkStatus>`

- True if link is valid, false otherwise

### ValidateExternalLink

```csharp
public async Task<LinkStatus> ValidateExternalLink(Uri link, IHttpClientWrapper httpClient)
```

Validates if an external link is accessible

**Parameters:**

- `link` (*Uri*): Link to validate
- `httpClient` (*IHttpClientWrapper*): HTTP client for making requests

**Returns:** `Task<LinkStatus>`

- True if link is valid, false otherwise

