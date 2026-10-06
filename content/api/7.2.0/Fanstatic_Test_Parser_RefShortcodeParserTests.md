---
Title: "RefShortcodeParserTests"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "RefShortcodeParserTests"
  namespace: "Fanstatic.Test.Parser"
  symbol: "class"
  source: "RefShortcodeParserTests.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Test.Parser](/api/7.2.0/fanstatic.test.parser)
- **Source File:** RefShortcodeParserTests.cs

Tests for the Hugo-style `ref`/`relref` shortcode resolution in markdown content.

## Public Methods

### Ref_ShouldResolveToAbsolutePermalink

```csharp
public void Ref_ShouldResolveToAbsolutePermalink()
```


### Relref_ShouldResolveToRelativePermalink

```csharp
public void Relref_ShouldResolveToRelativePermalink()
```


### Ref_WithAnchor_ShouldAppendFragment

```csharp
public void Ref_WithAnchor_ShouldAppendFragment()
```


### Ref_WithLangArgument_ShouldResolveToTranslation

```csharp
public void Ref_WithLangArgument_ShouldResolveToTranslation()
```


### Ref_WithOutputFormatArgument_ShouldResolveToThatFormat

```csharp
public void Ref_WithOutputFormatArgument_ShouldResolveToThatFormat()
```


### Ref_WithMissingTranslation_ShouldFallBackToDefaultLanguage

```csharp
public void Ref_WithMissingTranslation_ShouldFallBackToDefaultLanguage()
```


### Ref_WithUnresolvablePath_ShouldFallBackToHash

```csharp
public void Ref_WithUnresolvablePath_ShouldFallBackToHash()
```


### Ref_WithUnresolvablePath_ShouldLogTheAbsoluteSourcePath

```csharp
public void Ref_WithUnresolvablePath_ShouldLogTheAbsoluteSourcePath()
```


### Content_WithoutRefShortcode_ShouldBeUnaffected

```csharp
public void Content_WithoutRefShortcode_ShouldBeUnaffected()
```


