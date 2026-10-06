---
Title: "TemplateErrorOverlay"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "TemplateErrorOverlay"
  namespace: "Fanstatic.TemplateEngine"
  symbol: "class"
  source: "TemplateErrorOverlay.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.TemplateEngine](/api/7.2.0/fanstatic.templateengine)
- **Source File:** TemplateErrorOverlay.cs

Renders a `TemplateError` as a standalone HTML page so the dev server can show it in the browser.

## Public Methods

### Render

```csharp
public static string Render(TemplateError error)
```

Builds the overlay page for the given error.

**Parameters:**

- `error` (*TemplateError*): The template error to display.

**Returns:** `string`

- A complete HTML document describing the failure.

