---
Title: "PageTests"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "PageTests"
  namespace: "Fanstatic.Test.Models"
  symbol: "class"
  source: "PageTests.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Test.Models](/api/7.2.0/fanstatic.test.models)
- **Source File:** PageTests.cs
## Public Methods

### FrontMatter_ShouldCreateWithCorrectProperties

```csharp
public void FrontMatter_ShouldCreateWithCorrectProperties(string title, string sourcePath, string sourceFileNameWithoutExtension, string sourcePathDirectory)
```

**Parameters:**

- `title` (*string*)
- `sourcePath` (*string*)
- `sourceFileNameWithoutExtension` (*string*)
- `sourcePathDirectory` (*string*)


### FrontMatter_ShouldHaveDefaultValuesForOptionalProperties

```csharp
public void FrontMatter_ShouldHaveDefaultValuesForOptionalProperties()
```


### Aliases_ShouldParseAsUrls

```csharp
public void Aliases_ShouldParseAsUrls(string url)
```

**Parameters:**

- `url` (*string*)


### IsDateExpired_ShouldReturnExpectedResult

```csharp
public void IsDateExpired_ShouldReturnExpectedResult(int days, bool expected)
```

**Parameters:**

- `days` (*int*)
- `expected` (*bool*)


### IsDatePublishable_ShouldReturnCorrectValues

```csharp
public void IsDatePublishable_ShouldReturnCorrectValues(string? publishDate, string? date, bool expectedValue)
```

**Parameters:**

- `publishDate` (*string?*)
- `date` (*string?*)
- `expectedValue` (*bool*)


### IsValidPage_ShouldReturnCorrectValues

```csharp
public void IsValidPage_ShouldReturnCorrectValues(string? publishDate, string? date, bool? draft, bool draftOption, bool expectedValue)
```

**Parameters:**

- `publishDate` (*string?*)
- `date` (*string?*)
- `draft` (*bool?*)
- `draftOption` (*bool*)
- `expectedValue` (*bool*)


### IsValidDate_ShouldReturnExpectedResult

```csharp
public void IsValidDate_ShouldReturnExpectedResult(bool futureOption, bool expected)
```

**Parameters:**

- `futureOption` (*bool*)
- `expected` (*bool*)


### CreatePermalink_ShouldReturnCorrectUrl_WhenUrlIsNull

```csharp
public void CreatePermalink_ShouldReturnCorrectUrl_WhenUrlIsNull(string sourcePath, string expectedUrl)
```

**Parameters:**

- `sourcePath` (*string*)
- `expectedUrl` (*string*)


### Permalink_CreateWithDefaultOrCustomURLTemplate

```csharp
public void Permalink_CreateWithDefaultOrCustomURLTemplate(string? urlTemplate, string expectedPermalink)
```

**Parameters:**

- `urlTemplate` (*string?*)
- `expectedPermalink` (*string*)


### RegularPages_ShouldReturnCorrectPages_WhenKindIsSingle

```csharp
public void RegularPages_ShouldReturnCorrectPages_WhenKindIsSingle(Kind kind, bool isExpectedPage)
```

**Parameters:**

- `kind` (*Kind*)
- `isExpectedPage` (*bool*)


### WordCount_ShouldReturnCorrectCounts

```csharp
public void WordCount_ShouldReturnCorrectCounts(string rawContent, int wordCountExpected)
```

**Parameters:**

- `rawContent` (*string*)
- `wordCountExpected` (*int*)


### Plain_ShouldReturnCorrectPlainString

```csharp
public void Plain_ShouldReturnCorrectPlainString(string rawContent, string plain)
```

**Parameters:**

- `rawContent` (*string*)
- `plain` (*string*)


### Content_ShouldRenderTemplateOncePerPage

```csharp
public void Content_ShouldRenderTemplateOncePerPage()
```


### Content_ShouldAvoidDeadlockForConcurrentPageCycles

```csharp
public void Content_ShouldAvoidDeadlockForConcurrentPageCycles()
```


### Cascade_ShouldCascadeValues

```csharp
public void Cascade_ShouldCascadeValues(string url, int weight)
```

**Parameters:**

- `url` (*string*)
- `weight` (*int*)


### Cascade_ShouldCascadeParams

```csharp
public void Cascade_ShouldCascadeParams(string url, string? valueString)
```

**Parameters:**

- `url` (*string*)
- `valueString` (*string?*)


### TemplateLookup_ShouldDefaultGenerateAllCombinations

```csharp
public void TemplateLookup_ShouldDefaultGenerateAllCombinations()
```


### TemplateLookup_ShouldPreferTaxonomySpecificTemplates

```csharp
public void TemplateLookup_ShouldPreferTaxonomySpecificTemplates(Kind kind, string template)
```

**Parameters:**

- `kind` (*Kind*)
- `template` (*string*)


### TemplateLookup_ShouldGenerateAllCombinations

```csharp
public void TemplateLookup_ShouldGenerateAllCombinations(string type, string section, Kind kind, int expectedCount)
```

**Parameters:**

- `type` (*string*)
- `section` (*string*)
- `kind` (*Kind*)
- `expectedCount` (*int*)


### Permalink_ShouldReturnFullUrlWithBaseUrl

```csharp
public void Permalink_ShouldReturnFullUrlWithBaseUrl()
```


### PermalinkDir_ShouldReturnCorrectDirectory

```csharp
public void PermalinkDir_ShouldReturnCorrectDirectory(string baseUrl, string relPermalink, string expectedDir)
```

**Parameters:**

- `baseUrl` (*string*)
- `relPermalink` (*string*)
- `expectedDir` (*string*)


### PermalinkFilename_ShouldReturnCorrectFilename

```csharp
public void PermalinkFilename_ShouldReturnCorrectFilename(string relPermalink, string expectedFilename)
```

**Parameters:**

- `relPermalink` (*string*)
- `expectedFilename` (*string*)


### RelPermalinkDir_ShouldReturnCorrectDirectory

```csharp
public void RelPermalinkDir_ShouldReturnCorrectDirectory(string relPermalink, string expectedDir)
```

**Parameters:**

- `relPermalink` (*string*)
- `expectedDir` (*string*)


### RelPermalinkFilename_ShouldReturnCorrectFilename

```csharp
public void RelPermalinkFilename_ShouldReturnCorrectFilename(string relPermalink, string expectedFilename)
```

**Parameters:**

- `relPermalink` (*string*)
- `expectedFilename` (*string*)


