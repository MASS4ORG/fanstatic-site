---
Title: "TemplateMetricCounter"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "TemplateMetricCounter"
  namespace: "Fanstatic.TemplateEngine"
  symbol: "class"
  source: "TemplateMetric.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.TemplateEngine](/api/7.2.0/fanstatic.templateengine)
- **Source File:** TemplateMetric.cs
## Public Methods

### Add

```csharp
public void Add(long elapsedTicks, bool cacheHit)
```

**Parameters:**

- `elapsedTicks` (*long*)
- `cacheHit` (*bool*)


### Snapshot

```csharp
public TemplateMetric Snapshot(string templatePath)
```

**Parameters:**

- `templatePath` (*string*)

**Returns:** `TemplateMetric`


