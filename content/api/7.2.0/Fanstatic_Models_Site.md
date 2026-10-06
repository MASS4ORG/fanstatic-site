---
Title: "Site"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "Site"
  namespace: "Fanstatic.Models"
  symbol: "class"
  source: "Site.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** Site.cs

The main configuration of the program, primarily extracted from the app.yaml file.

## Properties

### **Params**

(*Dictionary<string, object>*) { get; set }

### **Title**

(*string*)

### **Description**

(*string?*)

### **Copyright**

(*string?*)

### **BaseUrl**

(*Uri*) { get; set }: The base URL that will be used to build public links.

### **UglyUrLs**

(*bool*)

### **Paginate**

(*int*)

### **PaginatePath**

(*string*)

### **KindOutputFormats**

(*Dictionary<Kind, List<string>>*)

### **TaxonomyDefinitions**

(*Dictionary<string, string>*)

### **Languages**

(*Dictionary<string, LanguageSettings>*)

### **DefaultLanguage**

(*string*)

### **DefaultContentLanguageInSubdir**

(*bool*)

### **I18N**

(*IReadOnlyDictionary<string, IReadOnlyDictionary<string, I18NEntry>>*) { get; set } = `new Dictionary<string, IReadOnlyDictionary<string, I18NEntry>>()`

### **LanguageList**

(*IReadOnlyList<LanguageSettings>*) { get; set } = `[]`: All resolved languages, sorted by weight then code.

### **DefaultLanguageObj**

(*LanguageSettings*) { get; set } = `new()`: The resolved default language.

### **IsMultilingual**

(*bool*): True when the site declares more than one language.

### **Fanstatic**

(*FanstaticInfo*) { get } = `new FanstaticInfo()`

### **Options**

(*IGenerateOptions*) { get; set }

### **Theme**

(*Theme?*) { get }

### **SourceContentPath**

(*string*)

### **SourceStaticPath**

(*string*)

### **SourceThemePath**

(*string*)

### **OutputReferences**

(*ConcurrentDictionary<Uri, IOutput>*) { get } = `[]`

### **Pages**

(*IEnumerable<IPage>*) { get }

### **AllRegularPages**

(*IEnumerable<IPage>*)

### **RegularPages**

(*IEnumerable<IPage>*) { get }

### **Home**

(*IPage?*) { get; set }

### **CacheManager**

(*SiteCacheManager*) { get } = `new()`

### **Parser**

(*IFrontMatterParser*) { get }

### **TemplateEngine**

(*ITemplateEngine*) { get }

### **Logger**

(*ILogger*) { get }

### **TemplateErrors**

(*IReadOnlyList<TemplateError>*) { get }: Template failures found while validating the theme or rendering pages, one per template.

### **SourceFolders**

(*IEnumerable<string>*)

### **FilesParsedToReport**

(*int*): Number of Markdown files read, used in the report.

### **PagesCreatedToReport**

(*int*): Number of pages created, used in the report.


## Public Methods

### GetLanguage

```csharp
public LanguageSettings GetLanguage(string? code)
```

Returns the resolved language for the given code, falling back to the default language.

**Parameters:**

- `code` (*string?*)

**Returns:** `LanguageSettings`


### IsConfiguredLanguage

```csharp
public bool IsConfiguredLanguage(string code)
```

True when the given code matches a language explicitly configured under the `languages` key (used to recognize filename language suffixes).

**Parameters:**

- `code` (*string*)

**Returns:** `bool`


### LoadTranslations

```csharp
public void LoadTranslations()
```

Loads translation strings from `i18n/*.yaml` files. Each file is named `{languageCode}.yaml` and contains a flat or Hugo-compatible mapping of translation keys to their localized values.


### AddTemplateErrors

```csharp
public int AddTemplateErrors(IEnumerable<TemplateError> errors)
```

**Parameters:**

- `errors` (*IEnumerable<TemplateError>*)

**Returns:** `int`


### ResetCache

```csharp
public void ResetCache()
```


### ScanAndParseSourceFiles

```csharp
public void ScanAndParseSourceFiles(IFileSystem fs, string? directory, int level = 0, ContentSource? parent = null, FrontMatter? cascade = null)
```

**Parameters:**

- `fs` (*IFileSystem*)
- `directory` (*string?*)
- `level` (*int*) (Default: `0`)
- `parent` (*ContentSource?*) (Default: `null`)
- `cascade` (*FrontMatter?*) (Default: `null`)


### PostProcessPage

```csharp
public void PostProcessPage(IPage page, bool overwrite = false)
```

**Parameters:**

- `page` (*IPage*)
- `overwrite` (*bool*) (Default: `false`)


### CreatePermalink

```csharp
public Uri CreatePermalink(Page page, string? urlTemplate = null)
```

**Parameters:**

- `page` (*Page*)
- `urlTemplate` (*string?*) (Default: `null`)

**Returns:** `Uri`


### IsPageValid

```csharp
public bool IsPageValid(IContentSource contentSource, IGenerateOptions? options)
```

**Parameters:**

- `contentSource` (*IContentSource*)
- `options` (*IGenerateOptions?*)

**Returns:** `bool`


### IsDateValid

```csharp
public bool IsDateValid(IContentSource contentSource, IGenerateOptions? options)
```

**Parameters:**

- `contentSource` (*IContentSource*)
- `options` (*IGenerateOptions?*)

**Returns:** `bool`


### IsDateExpired

```csharp
public bool IsDateExpired(IContentSource contentSource)
```

**Parameters:**

- `contentSource` (*IContentSource*)

**Returns:** `bool`


### IsDatePublishable

```csharp
public bool IsDatePublishable(IContentSource contentSource)
```

**Parameters:**

- `contentSource` (*IContentSource*)

**Returns:** `bool`


### PageCreate

```csharp
public List<Page> PageCreate(ContentSource contentSource)
```

**Parameters:**

- `contentSource` (*ContentSource*)

**Returns:** `List<Page>`


### ProcessPages

```csharp
public void ProcessPages()
```

Create pages from content source


### RegisterPaginatedUrls

```csharp
public void RegisterPaginatedUrls()
```


### BuildTranslationGroups

```csharp
public void BuildTranslationGroups()
```

Groups content sources that share a translation key, so each page can enumerate its translations. Must be called after all source files have been scanned.


### ContentSourceAdd

```csharp
public ContentSource? ContentSourceAdd(ContentSource? contentSource)
```

**Parameters:**

- `contentSource` (*ContentSource?*)

**Returns:** `ContentSource?`


### ParseAndRenderTemplate

```csharp
public string ParseAndRenderTemplate(Page page, bool isBaseTemplate)
```

**Parameters:**

- `page` (*Page*)
- `isBaseTemplate` (*bool*)

**Returns:** `string`


