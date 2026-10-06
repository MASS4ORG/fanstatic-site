---
Title: "TemplateErrorTests"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "TemplateErrorTests"
  namespace: "Fanstatic.Test.TemplateEngine"
  symbol: "class"
  source: "TemplateErrorTests.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Test.TemplateEngine](/api/7.2.0/fanstatic.test.templateengine)
- **Source File:** TemplateErrorTests.cs
## Public Methods

### FromFluidParseError_ShouldSplitPositionAndExcerpt

```csharp
public void FromFluidParseError_ShouldSplitPositionAndExcerpt()
```


### FromFluidParseError_ShouldDeriveExcerptFromBody_WhenEngineOmitsIt

```csharp
public void FromFluidParseError_ShouldDeriveExcerptFromBody_WhenEngineOmitsIt()
```


### FromFluidParseError_ShouldUseFallbackMessage_WhenEngineReportsNothing

```csharp
public void FromFluidParseError_ShouldUseFallbackMessage_WhenEngineReportsNothing(string? parseError)
```

**Parameters:**

- `parseError` (*string?*)


### FromFluidParseError_ShouldIgnorePosition_WhenFormatIsUnexpected

```csharp
public void FromFluidParseError_ShouldIgnorePosition_WhenFormatIsUnexpected()
```


### FromFluidParseError_ShouldReturnNullExcerpt_WhenLineIsOutOfRange

```csharp
public void FromFluidParseError_ShouldReturnNullExcerpt_WhenLineIsOutOfRange()
```


### FromRenderException_ShouldNameTemplateAndPage_ForRuntimeError

```csharp
public void FromRenderException_ShouldNameTemplateAndPage_ForRuntimeError()
```


### FromRenderException_ShouldKeepPosition_ForFormatException

```csharp
public void FromRenderException_ShouldKeepPosition_ForFormatException()
```


### FromRenderException_ShouldThrow_WhenExceptionIsNull

```csharp
public void FromRenderException_ShouldThrow_WhenExceptionIsNull()
```


### Location_ShouldIncludePosition_WhenKnown

```csharp
public void Location_ShouldIncludePosition_WhenKnown()
```


### Location_ShouldOmitPosition_WhenUnknown

```csharp
public void Location_ShouldOmitPosition_WhenUnknown()
```


### ToString_ShouldIncludePageAndExcerpt

```csharp
public void ToString_ShouldIncludePageAndExcerpt()
```


### ToString_ShouldOmitPage_WhenValidationFailed

```csharp
public void ToString_ShouldOmitPage_WhenValidationFailed()
```


### FromRenderException_ShouldKeepPosition_WhenRenderFailureIsLocated

```csharp
public void FromRenderException_ShouldKeepPosition_WhenRenderFailureIsLocated()
```


### FromRenderException_ShouldOmitPosition_WhenMissingTemplateIsNotReferenced

```csharp
public void FromRenderException_ShouldOmitPosition_WhenMissingTemplateIsNotReferenced()
```


### MissingTemplate_ShouldThrow_WhenArgumentIsNull

```csharp
public void MissingTemplate_ShouldThrow_WhenArgumentIsNull()
```


