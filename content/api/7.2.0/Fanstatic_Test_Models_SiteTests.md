---
Title: "SiteTests"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "SiteTests"
  namespace: "Fanstatic.Test.Models"
  symbol: "class"
  source: "SiteTests.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Test.Models](/api/7.2.0/fanstatic.test.models)
- **Source File:** SiteTests.cs

Unit tests for the Site class.

## Public Methods

### ScanAllMarkdownFiles_ShouldContainFilenames

```csharp
public void ScanAllMarkdownFiles_ShouldContainFilenames(string fileName)
```

**Parameters:**

- `fileName` (*string*)


### Home_ShouldReturnAHomePage

```csharp
public void Home_ShouldReturnAHomePage(string sitePath)
```

**Parameters:**

- `sitePath` (*string*)


### ScanAndParseSourceFiles_ShouldReportInvalidFrontMatterWithoutStackTraceAndKeepGoing

```csharp
public void ScanAndParseSourceFiles_ShouldReportInvalidFrontMatterWithoutStackTraceAndKeepGoing()
```


### ProcessPages_ShouldReportDuplicatePermalinksWithAbsoluteSourcePaths

```csharp
public void ProcessPages_ShouldReportDuplicatePermalinksWithAbsoluteSourcePaths()
```


### ScanAndParseSourceFiles_ShouldLinkPagesInPathOrderAndPreserveCascade

```csharp
public void ScanAndParseSourceFiles_ShouldLinkPagesInPathOrderAndPreserveCascade()
```


### Page_IsSection_ShouldReturnExpectedQuantityOfPages

```csharp
public void Page_IsSection_ShouldReturnExpectedQuantityOfPages(string sitePath, int expectedQuantity)
```

**Parameters:**

- `sitePath` (*string*)
- `expectedQuantity` (*int*)


### PagesReference_ShouldReturnExpectedQuantityOfPages

```csharp
public void PagesReference_ShouldReturnExpectedQuantityOfPages(string sitePath, int expectedQuantity)
```

**Parameters:**

- `sitePath` (*string*)
- `expectedQuantity` (*int*)


### Page_IsPage_ShouldReturnExpectedQuantityOfPages

```csharp
public void Page_IsPage_ShouldReturnExpectedQuantityOfPages(string sitePath, int expectedQuantity)
```

**Parameters:**

- `sitePath` (*string*)
- `expectedQuantity` (*int*)


### Page_Weight_ShouldReturnTheRightOrder

```csharp
public void Page_Weight_ShouldReturnTheRightOrder()
```


### Page_Weight_ShouldReturnZeroWeight

```csharp
public void Page_Weight_ShouldReturnZeroWeight()
```


### PageCollections_ShouldCacheMaterializedLists

```csharp
public void PageCollections_ShouldCacheMaterializedLists()
```


### SortedPageViews_ShouldBeOrderedAndCached

```csharp
public void SortedPageViews_ShouldBeOrderedAndCached()
```


### RegularPagesByTitle_ShouldMatchLiquidSortForMixedCaseTitles

```csharp
public void RegularPagesByTitle_ShouldMatchLiquidSortForMixedCaseTitles()
```


### ProcessPages_ShouldNotCacheCollectionsDuringResourceRendering

```csharp
public void ProcessPages_ShouldNotCacheCollectionsDuringResourceRendering()
```


### PageCollections_ShouldExcludeVirtualPages

```csharp
public void PageCollections_ShouldExcludeVirtualPages()
```


### ResetCache_ShouldClearPageCollectionCaches

```csharp
public void ResetCache_ShouldClearPageCollectionCaches()
```


### TagSectionPage_Pages_ShouldReturnNumberTagPages

```csharp
public void TagSectionPage_Pages_ShouldReturnNumberTagPages()
```


### TagPage_Pages_ShouldReturnNumberReferences

```csharp
public void TagPage_Pages_ShouldReturnNumberReferences()
```


### ConfiguredTaxonomies_ShouldBuildTermsAndExposeTemplateData

```csharp
public void ConfiguredTaxonomies_ShouldBuildTermsAndExposeTemplateData()
```


### EmptyTaxonomyConfiguration_ShouldDisableGeneratedTaxonomyPages

```csharp
public void EmptyTaxonomyConfiguration_ShouldDisableGeneratedTaxonomyPages()
```


### Page_Content_ShouldReturnNullThemeContent

```csharp
public void Page_Content_ShouldReturnNullThemeContent(string url, string expectedContent)
```

**Parameters:**

- `url` (*string*)
- `expectedContent` (*string*)


### Page_Content_ShouldReturnNullThemeBaseofContent

```csharp
public void Page_Content_ShouldReturnNullThemeBaseofContent(string url, string expectedContentPreRendered, string expectedContent)
```

**Parameters:**

- `url` (*string*)
- `expectedContentPreRendered` (*string*)
- `expectedContent` (*string*)


### Page_Content_ShouldReturnThrowNullThemeBaseofContent

```csharp
public void Page_Content_ShouldReturnThrowNullThemeBaseofContent(string url)
```

**Parameters:**

- `url` (*string*)


### Page_Content_ShouldReturnThemeContent

```csharp
public void Page_Content_ShouldReturnThemeContent(string url, string expectedContentPreRendered, string expectedContent, string expectedOutputFile)
```

**Parameters:**

- `url` (*string*)
- `expectedContentPreRendered` (*string*)
- `expectedContent` (*string*)
- `expectedOutputFile` (*string*)


### Site_ShouldConsiderSectionPages

```csharp
public void Site_ShouldConsiderSectionPages()
```


### PageResources_ShouldBePublishedNextToTheirPage

```csharp
public void PageResources_ShouldBePublishedNextToTheirPage()
```


### PageResources_ShouldApplyResourceDefinitionCustomization

```csharp
public void PageResources_ShouldApplyResourceDefinitionCustomization()
```


### FilesParsedToReport_ShouldEqualMarkdownFileCount

```csharp
public void FilesParsedToReport_ShouldEqualMarkdownFileCount(string sitePath)
```

**Parameters:**

- `sitePath` (*string*)


### PagesCreatedToReport_ShouldCountEveryCreatedPage

```csharp
public void PagesCreatedToReport_ShouldCountEveryCreatedPage()
```


### PageCreate_ShouldAlsoCreateThePagesOfTheParent

```csharp
public void PageCreate_ShouldAlsoCreateThePagesOfTheParent()
```


