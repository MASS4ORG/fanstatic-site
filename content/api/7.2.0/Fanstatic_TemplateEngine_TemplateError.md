---
Title: "TemplateError"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "TemplateError"
  namespace: "Fanstatic.TemplateEngine"
  symbol: "record"
  source: "TemplateError.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.TemplateEngine](/api/7.2.0/fanstatic.templateengine)
- **Source File:** TemplateError.cs

A template failure captured while validating the theme or while rendering a page.

## Properties

### **Location**

(*string*): Quoted failure location, with the position when the engine reports one.


## Public Methods

### FromFluidParseError

```csharp
public static TemplateError FromFluidParseError(string templatePath, string? parseError, string? templateBody)
```

Builds an error from Fluid's parse output, splitting off the position and the source excerpt.

**Parameters:**

- `templatePath` (*string*): Template the parse failure belongs to.
- `parseError` (*string?*): Fluid parse error text.
- `templateBody` (*string?*): Template body, used to derive an excerpt when Fluid reports none.

**Returns:** `TemplateError`


### FromRenderException

```csharp
public static TemplateError FromRenderException(string templatePath, string? pageSourceRelativePath, Exception exception)
```

Builds an error from an exception raised while rendering a template.

**Parameters:**

- `templatePath` (*string*): Template being rendered.
- `pageSourceRelativePath` (*string?*): Content file being rendered.
- `exception` (*Exception*): Exception raised by the template engine.

**Returns:** `TemplateError`


### ToString

```csharp
public override string ToString()
```

**Returns:** `string`


