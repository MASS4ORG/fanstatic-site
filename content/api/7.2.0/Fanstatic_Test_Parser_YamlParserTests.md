---
Title: "YamlParserTests"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "YamlParserTests"
  namespace: "Fanstatic.Test.Parser"
  symbol: "class"
  source: "YAMLParserTests.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Test.Parser](/api/7.2.0/fanstatic.test.parser)
- **Source File:** YAMLParserTests.cs
## Public Methods

### Parse_WithScalarWhereListExpected_ShouldThrowConciseFormatException

```csharp
public void Parse_WithScalarWhereListExpected_ShouldThrowConciseFormatException()
```


### Parse_ShouldSupportConcurrentCallsOnSharedParser

```csharp
public void Parse_ShouldSupportConcurrentCallsOnSharedParser()
```


### GetSection_ShouldReturnFirstFolderName

```csharp
public void GetSection_ShouldReturnFirstFolderName()
```


### ParseFrontMatter_ShouldParseTitleCorrectly

```csharp
public void ParseFrontMatter_ShouldParseTitleCorrectly(string fileContent, string expectedTitle)
```

**Parameters:**

- `fileContent` (*string*)
- `expectedTitle` (*string*)


### ParseFrontMatter_ShouldParseDateCorrectly

```csharp
public void ParseFrontMatter_ShouldParseDateCorrectly(string fileContent, string expectedDateString)
```

**Parameters:**

- `fileContent` (*string*)
- `expectedDateString` (*string*)


### ParseFrontMatter_ShouldParseOtherFieldsCorrectly

```csharp
public void ParseFrontMatter_ShouldParseOtherFieldsCorrectly()
```


### ParseFrontMatter_ShouldThrowFormatException_WhenInvalidYAMLSyntax

```csharp
public void ParseFrontMatter_ShouldThrowFormatException_WhenInvalidYAMLSyntax()
```


### ParseSiteSettings_ShouldReturnSiteWithCorrectSettings

```csharp
public void ParseSiteSettings_ShouldReturnSiteWithCorrectSettings()
```


### ParseParams_ShouldFillParamsWithNonMatchingFields

```csharp
public void ParseParams_ShouldFillParamsWithNonMatchingFields()
```


### ParseFrontMatter_ShouldParseContentInSiteFolder

```csharp
public void ParseFrontMatter_ShouldParseContentInSiteFolder()
```


### ParseFrontMatter_ShouldCreateTags

```csharp
public void ParseFrontMatter_ShouldCreateTags()
```


### FrontMatterParse_RawContentNull

```csharp
public void FrontMatterParse_RawContentNull()
```


### ParseYAML_ShouldThrowExceptionWhenFrontMatterIsInvalid

```csharp
public void ParseYAML_ShouldThrowExceptionWhenFrontMatterIsInvalid()
```


### ParseYAML_ShouldSplitTheFrontMatter

```csharp
public void ParseYAML_ShouldSplitTheFrontMatter()
```


### ParseSiteSettings_ShouldReturnSiteSettings

```csharp
public void ParseSiteSettings_ShouldReturnSiteSettings()
```


### ParseSiteSettings_ShouldDefaultAndAllowDisablingTaxonomies

```csharp
public void ParseSiteSettings_ShouldDefaultAndAllowDisablingTaxonomies()
```


### SiteParams_ShouldHandleEmptyContent

```csharp
public void SiteParams_ShouldHandleEmptyContent()
```


### SiteParams_ShouldPopulateParamsWithExtraFields

```csharp
public void SiteParams_ShouldPopulateParamsWithExtraFields()
```


### FrontMatter_ShouldIgnoreCase

```csharp
public void FrontMatter_ShouldIgnoreCase(string fileContent)
```

**Parameters:**

- `fileContent` (*string*)


### SiteSettings_ShouldIgnoreCase

```csharp
public void SiteSettings_ShouldIgnoreCase(string fileContent)
```

**Parameters:**

- `fileContent` (*string*)


