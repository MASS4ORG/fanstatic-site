---
Title: "FluidTemplateEngine"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "FluidTemplateEngine"
  namespace: "Fanstatic.TemplateEngine"
  symbol: "class"
  source: "FluidTemplateEngine.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.TemplateEngine](/api/7.2.0/fanstatic.templateengine)
- **Source File:** FluidTemplateEngine.cs

Fluid template engine.

## Public Methods

### Initialize

```csharp
public void Initialize(Site site)
```

**Parameters:**

- `site` (*Site*)


### PreCompileTheme

```csharp
public IReadOnlyList<TemplateError> PreCompileTheme(string themePath)
```

**Parameters:**

- `themePath` (*string*)

**Returns:** `IReadOnlyList<TemplateError>`


### Render

```csharp
public string Render(string templatePathOrInlineKey, ISite site, IPage page, int? counter = null)
```

**Parameters:**

- `templatePathOrInlineKey` (*string*)
- `site` (*ISite*)
- `page` (*IPage*)
- `counter` (*int?*) (Default: `null`)

**Returns:** `string`


### RenderInline

```csharp
public string RenderInline(string templateBody, ISite site, IPage page)
```

**Parameters:**

- `templateBody` (*string*)
- `site` (*ISite*)
- `page` (*IPage*)

**Returns:** `string`


### GetTemplateMetrics

```csharp
public IReadOnlyList<TemplateMetric> GetTemplateMetrics()
```

**Returns:** `IReadOnlyList<TemplateMetric>`


