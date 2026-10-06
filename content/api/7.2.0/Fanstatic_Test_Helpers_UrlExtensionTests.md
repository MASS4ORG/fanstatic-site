---
Title: "UrlExtensionTests"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "UrlExtensionTests"
  namespace: "Fanstatic.Test.Helpers"
  symbol: "class"
  source: "UrlExtensionTests.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Test.Helpers](/api/7.2.0/fanstatic.test.helpers)
- **Source File:** UrlExtensionTests.cs
## Public Methods

### Urlize_NullOrEmptyText_ThrowsArgumentNullException

```csharp
public void Urlize_NullOrEmptyText_ThrowsArgumentNullException(string? text)
```

**Parameters:**

- `text` (*string?*)


### UrlizePath_NullPath_ReturnsEmptyString

```csharp
public void UrlizePath_NullPath_ReturnsEmptyString(string? path)
```

**Parameters:**

- `path` (*string?*)


### Urlize_ValidText_ReturnsExpectedResult

```csharp
public void Urlize_ValidText_ReturnsExpectedResult(string text, char? replacementChar, bool lowerCase, bool replaceDot, string expectedResult)
```

**Parameters:**

- `text` (*string*)
- `replacementChar` (*char?*)
- `lowerCase` (*bool*)
- `replaceDot` (*bool*)
- `expectedResult` (*string*)


### UrlizePath_ValidPath_ReturnsExpectedResult

```csharp
public void UrlizePath_ValidPath_ReturnsExpectedResult(string path, char? replacementChar, bool lowerCase, bool replaceDot, string expectedResult)
```

**Parameters:**

- `path` (*string*)
- `replacementChar` (*char?*)
- `lowerCase` (*bool*)
- `replaceDot` (*bool*)
- `expectedResult` (*string*)


### Urlize_WithoutOptions_ReturnsExpectedResult

```csharp
public void Urlize_WithoutOptions_ReturnsExpectedResult()
```


### UrlizePath_WithoutOptions_ReturnsExpectedResult

```csharp
public void UrlizePath_WithoutOptions_ReturnsExpectedResult()
```


### Urlize_SpecialCharsInText_ReturnsOnlyHyphens

```csharp
public void Urlize_SpecialCharsInText_ReturnsOnlyHyphens()
```


### UrlizePath_SpecialCharsInPath_ReturnsOnlyHyphens

```csharp
public void UrlizePath_SpecialCharsInPath_ReturnsOnlyHyphens()
```


### CorrectRequestPath_BasicPaths_ReturnsExpectedResults

```csharp
public void CorrectRequestPath_BasicPaths_ReturnsExpectedResults(string input, string expectedStripped, string expectedFull)
```

**Parameters:**

- `input` (*string*)
- `expectedStripped` (*string*)
- `expectedFull` (*string*)


### CorrectRequestPath_WithQueryString_ReturnsExpectedResults

```csharp
public void CorrectRequestPath_WithQueryString_ReturnsExpectedResults(string input, string expectedStripped, string expectedFull)
```

**Parameters:**

- `input` (*string*)
- `expectedStripped` (*string*)
- `expectedFull` (*string*)


### CorrectRequestPath_WithAnchor_ReturnsExpectedResults

```csharp
public void CorrectRequestPath_WithAnchor_ReturnsExpectedResults(string input, string expectedStripped, string expectedFull)
```

**Parameters:**

- `input` (*string*)
- `expectedStripped` (*string*)
- `expectedFull` (*string*)


### CorrectRequestPath_WithQueryAndAnchor_ReturnsExpectedResults

```csharp
public void CorrectRequestPath_WithQueryAndAnchor_ReturnsExpectedResults(string input, string expectedStripped, string expectedFull)
```

**Parameters:**

- `input` (*string*)
- `expectedStripped` (*string*)
- `expectedFull` (*string*)


### CorrectRequestPath_AbsoluteUri_ReturnsRelativeUri

```csharp
public void CorrectRequestPath_AbsoluteUri_ReturnsRelativeUri(string input, string expectedStripped, string expectedFull)
```

**Parameters:**

- `input` (*string*)
- `expectedStripped` (*string*)
- `expectedFull` (*string*)


### CorrectRequestPath_Null_ThrowsArgumentNullException

```csharp
public void CorrectRequestPath_Null_ThrowsArgumentNullException()
```


### CorrectRequestPath_EmptyString_ReturnsRootIndex

```csharp
public void CorrectRequestPath_EmptyString_ReturnsRootIndex()
```


### CombineRelative_ValidPaths_ReturnsExpectedResults

```csharp
public void CombineRelative_ValidPaths_ReturnsExpectedResults(string basePath, string relativePath, string expected)
```

**Parameters:**

- `basePath` (*string*)
- `relativePath` (*string*)
- `expected` (*string*)


### CombineRelative_HandlesLeadingAndTrailingSlashes

```csharp
public void CombineRelative_HandlesLeadingAndTrailingSlashes(string basePath, string relativePath, string expected)
```

**Parameters:**

- `basePath` (*string*)
- `relativePath` (*string*)
- `expected` (*string*)


