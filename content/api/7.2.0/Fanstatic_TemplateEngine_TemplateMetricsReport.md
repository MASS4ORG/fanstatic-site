---
Title: "TemplateMetricsReport"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "TemplateMetricsReport"
  namespace: "Fanstatic.TemplateEngine"
  symbol: "class"
  source: "TemplateMetricsReport.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.TemplateEngine](/api/7.2.0/fanstatic.templateengine)
- **Source File:** TemplateMetricsReport.cs

Formats aggregated template render metrics for build output.

## Public Methods

### Format

```csharp
public static string Format(IEnumerable<TemplateMetric> metrics)
```

Creates a table sorted by total render time, descending.

**Parameters:**

- `metrics` (*IEnumerable<TemplateMetric>*): The metrics to format.

**Returns:** `string`

- A text table suitable for logging.
**Remarks:**
Times are inclusive: Fluid-rendered partials contribute to their caller, but are not separate rows. A page's lazy `Content` time is charged to the first template that reads it.



