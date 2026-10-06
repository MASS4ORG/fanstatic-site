---
Title: "TemplateRenderException"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "TemplateRenderException"
  namespace: "Fanstatic.TemplateEngine"
  symbol: "class"
  source: "TemplateRenderException.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.TemplateEngine](/api/7.2.0/fanstatic.templateengine)
- **Source File:** TemplateRenderException.cs

Wraps a failure raised while rendering a template and locates it in the template source. Fluid reports no position for runtime failures, so the reference is matched against the template body to point at the tag that asked for the missing partial or base template.

## Properties

### **Line**

(*int*) { get }: One-based line of the failing tag, 0 when the position is unknown.

### **Column**

(*int*) { get }: One-based column of the failing tag, 0 when the position is unknown.

### **SourceExcerpt**

(*string?*) { get }: Source line holding the failing tag, null when the position is unknown.


## Public Methods

### MissingTemplate

```csharp
public static TemplateRenderException MissingTemplate(string missingTemplate, string templateBody, Exception innerException)
```

Describes `missingTemplate` as not found at the tag that references it.

**Parameters:**

- `missingTemplate` (*string*): The partial or base template Fluid could not load.
- `templateBody` (*string*): Body of the template that referenced it.
- `innerException` (*Exception*): The failure thrown by Fluid.

**Returns:** `TemplateRenderException`


