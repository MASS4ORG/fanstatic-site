---
Title: "ITemplateEngine"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "ITemplateEngine"
  namespace: "Fanstatic.TemplateEngine"
  symbol: "interface"
  source: "ITemplateEngine.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.TemplateEngine](/api/7.2.0/fanstatic.templateengine)
- **Source File:** ITemplateEngine.cs

Interface for all template engines.

## Public Methods

### Initialize

```csharp
 void Initialize(Site site)
```

Initializes the template engine for the given site.

**Parameters:**

- `site` (*Site*): The site context.


### PreCompileTheme

```csharp
 IReadOnlyList<TemplateError> PreCompileTheme(string themePath)
```

Precompiles all templates from the theme path, reporting every template that fails to parse.

**Parameters:**

- `themePath` (*string*): The absolute theme path.

**Returns:** `IReadOnlyList<TemplateError>`

- One error per template with a syntax error, empty when the theme is valid.

### Render

```csharp
 string Render(string templatePathOrInlineKey, ISite site, IPage page, int? counter = null)
```

Renders a template identified by key/path.

**Parameters:**

- `templatePathOrInlineKey` (*string*): Template key or path.
- `site` (*ISite*): The site context.
- `page` (*IPage*): The page context.
- `counter` (*int?*): Optional counter for resource naming scenarios. (Default: `null`)

**Returns:** `string`

- The rendered template output.

### RenderInline

```csharp
 string RenderInline(string templateBody, ISite site, IPage page)
```

Renders an inline template body.

**Parameters:**

- `templateBody` (*string*): Inline template content.
- `site` (*ISite*): The site context.
- `page` (*IPage*): The page context.

**Returns:** `string`

- The rendered template output.

### GetTemplateMetrics

```csharp
 IReadOnlyList<TemplateMetric> GetTemplateMetrics()
```

Gets a snapshot of the collected template render metrics.

**Returns:** `IReadOnlyList<TemplateMetric>`

- Metrics grouped by template path.

