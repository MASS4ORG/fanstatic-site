---
Title: "HtmlHelper"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "HtmlHelper"
  namespace: "Fanstatic.Commands.ValidateLinks"
  symbol: "class"
  source: "HtmlHelper.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.ValidateLinks](/api/7.2.0/fanstatic.commands.validatelinks)
- **Source File:** HtmlHelper.cs

Provides helper methods for working with HTML content.

## Public Methods

### ExtractLinks

```csharp
public static IEnumerable<string> ExtractLinks(string html)
```

Extracts all links from the provided HTML content.

**Parameters:**

- `html` (*string*): The HTML content to extract links from.

**Returns:** `IEnumerable<string>`

- An enumerable collection of link URLs.

### HasFragmentId

```csharp
public static bool HasFragmentId(string html, string fragment)
```

Determines whether the provided HTML content contains a specific fragment identifier.

**Parameters:**

- `html` (*string*): The HTML content to search.
- `fragment` (*string*): The fragment identifier to search for.

**Returns:** `bool`

- `true` if the fragment identifier is found; otherwise, `false`.

