---
Title: "ISite"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "ISite"
  namespace: "Fanstatic.Models"
  symbol: "interface"
  source: "ISite.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** ISite.cs

The main configuration of the program, primarily extracted from the app.yaml file.

## Properties

### **BaseUrl**

(*Uri*) { get; set }: The base URL that will be used to build public links.

### **Languages**

(*IReadOnlyList<LanguageSettings>*) { get }: All languages configured for the site, sorted by weight.

### **Options**

(*IGenerateOptions*) { get; set }: Command line options

### **SourceContentPath**

(*string*) { get }: The path of the content, based on the source path.

### **SourceStaticPath**

(*string*) { get }: The path of the static content (that will be copied as is), based on the source path.

### **SourceThemePath**

(*string*) { get }: The path theme.

### **CacheManager**

(*SiteCacheManager*) { get }: Manage all caching lists for the site

### **Parser**

(*IFrontMatterParser*) { get }: Front Matter parser

### **TemplateEngine**

(*ITemplateEngine*) { get }: The template engine.

### **Logger**

(*ILogger*) { get }: The logger instance.

### **TemplateErrors**

(*IReadOnlyList<TemplateError>*) { get }: Template failures found while validating the theme or rendering pages, one per template.

### **SourceFolders**

(*IEnumerable<string>*) { get }: List of all basic source folders

### **LanguageList**

(*IReadOnlyList<LanguageSettings>*) { get }: All resolved languages, sorted by weight then code.

### **DefaultLanguageObj**

(*LanguageSettings*) { get }: The resolved default language.

### **IsMultilingual**

(*bool*) { get }: True when the site declares more than one language.

### **I18N**

(*IReadOnlyDictionary<string, IReadOnlyDictionary<string, I18NEntry>>*) { get }: Translation strings loaded from the `i18n/` directory, keyed by language code then by translation key. Used by the `i18n` Liquid filter.


## Public Methods

### AddTemplateErrors

```csharp
 int AddTemplateErrors(IEnumerable<TemplateError> errors)
```

Records template failures, keeping only the first failure per template.

**Parameters:**

- `errors` (*IEnumerable<TemplateError>*): The failures to record.

**Returns:** `int`

- The number of failures added because no earlier failure used the same template.

### GetLanguage

```csharp
 LanguageSettings GetLanguage(string? code)
```

Returns the resolved language for the given code, falling back to the default.

**Parameters:**

- `code` (*string?*)

**Returns:** `LanguageSettings`


### IsConfiguredLanguage

```csharp
 bool IsConfiguredLanguage(string code)
```

True when the code matches a language explicitly configured under `languages`.

**Parameters:**

- `code` (*string*)

**Returns:** `bool`


### ResetCache

```csharp
 void ResetCache()
```

Resets the template cache to force a reload of all templates.


### ScanAndParseSourceFiles

```csharp
 void ScanAndParseSourceFiles(IFileSystem fs, string? directory = null, int level = 0, ContentSource? parent = null, FrontMatter? cascade = null)
```

Search recursively for all markdown files in the content folder, then parse their content for front matter and markdown.

**Parameters:**

- `fs` (*IFileSystem*)
- `directory` (*string?*): Folder to scan (Default: `null`)
- `level` (*int*): Folder recursive level (Default: `0`)
- `parent` (*ContentSource?*): Page of the upper directory (Default: `null`)
- `cascade` (*FrontMatter?*) (Default: `null`)


### BuildTranslationGroups

```csharp
 void BuildTranslationGroups()
```

Groups content sources that are translations of each other. Must be called after all source files have been scanned and before pages are processed.


### ProcessPages

```csharp
 void ProcessPages()
```

Expand the front matter to full-blown pages.


### RegisterPaginatedUrls

```csharp
 void RegisterPaginatedUrls()
```

Register paginated URL entries in OutputReferences after all pages are created. Must be called after ProcessPages so ContentSourceToPages is fully populated.


### CreatePermalink

```csharp
 Uri CreatePermalink(Page page, string? urlForce = null)
```

Gets the Permalink path for the file.

**Parameters:**

- `page` (*Page*)
- `urlForce` (*string?*): The URL to consider. If null use the predefined URL (Default: `null`)

**Returns:** `Uri`

- The output path.

### PostProcessPage

```csharp
 void PostProcessPage(IPage page, bool overwrite = false)
```

Extra calculation and automatic data for each page.

**Parameters:**

- `page` (*IPage*): The given page to be processed
- `overwrite` (*bool*) (Default: `false`)


### IsPageValid

```csharp
 bool IsPageValid(IContentSource frontMatter, IGenerateOptions? options)
```

Check if the page have the conditions to be published: valid date and not draft, unless a command line option to force it.

**Parameters:**

- `frontMatter` (*IContentSource*): Page or front matter
- `options` (*IGenerateOptions?*): options

**Returns:** `bool`


### IsDateValid

```csharp
 bool IsDateValid(IContentSource contentSource, IGenerateOptions? options)
```

Check if the page have a publishing date from the past.

**Parameters:**

- `contentSource` (*IContentSource*): Page or content Source
- `options` (*IGenerateOptions?*): options

**Returns:** `bool`


### IsDateExpired

```csharp
 bool IsDateExpired(IContentSource contentSource)
```

Check if the page is expired

**Parameters:**

- `contentSource` (*IContentSource*)

**Returns:** `bool`


### IsDatePublishable

```csharp
 bool IsDatePublishable(IContentSource contentSource)
```

Check if the page is publishable

**Parameters:**

- `contentSource` (*IContentSource*)

**Returns:** `bool`


### PageCreate

```csharp
 List<Page> PageCreate(ContentSource contentSource)
```

Create a Page from front matter

**Parameters:**

- `contentSource` (*ContentSource*)

**Returns:** `List<Page>`


### ContentSourceAdd

```csharp
 ContentSource? ContentSourceAdd(ContentSource? contentSource)
```

Include the Front Matter into the site

**Parameters:**

- `contentSource` (*ContentSource?*)

**Returns:** `ContentSource?`


### ParseAndRenderTemplate

```csharp
 string ParseAndRenderTemplate(Page page, bool b)
```

**Parameters:**

- `page` (*Page*)
- `b` (*bool*)

**Returns:** `string`


