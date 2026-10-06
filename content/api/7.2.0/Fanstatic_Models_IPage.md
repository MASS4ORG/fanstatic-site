---
Title: "IPage"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "IPage"
  namespace: "Fanstatic.Models"
  symbol: "interface"
  source: "IPage.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** IPage.cs

Each page data created from source files or from the system.

## Properties

### **ContentSource**

(*ContentSource*) { get }: The underlining content source

### **SourcePathLastDirectory**

(*string?*): The source directory of the file.

### **AliasesProcessed**

(*Collection<Uri>?*) { get }: Secondary URL patterns to be used to create the url.

### **PagesReferences**

(*ConcurrentBag<Uri>*) { get }: Other content that mention this content. Used to create the tags list and Related Posts section.

### **Parent**

(*IPage?*) { get }: Other content that mention this content. Used to create the tags list and Related Posts section.

### **Plain**

(*string*) { get }: Plain markdown content, without HTML.

### **TagsReference**

(*List<IPage>*) { get }: A list of tags, if any.

### **Taxonomies**

(*IReadOnlyDictionary<string, IReadOnlyList<IPage>>*) { get }: The taxonomy term pages assigned to this page, keyed by taxonomy path segment.

### **IsHome**

(*bool*): Just a simple check if the current page is the home page

### **IsPage**

(*bool*): Just a simple check if the current page is a "page"

### **IsSection**

(*bool*): Just a simple check if the current page is a section page

### **WordCount**

(*int*) { get }: The number of words in the main content

### **ContentPreRendered**

(*string*) { get }: The markdown content converted to HTML

### **Content**

(*string*) { get }: The processed content.

### **CompleteContent**

(*string*) { get }: Creates the output file by applying the theme templates to the page content.

### **OutputFormat**

(*string*) { get; set }: The output format used

### **OutputFormats**

(*List<string>*) { get }: All output formats of the content has

### **Language**

(*LanguageSettings*) { get }: The language of this page.

### **IsDefaultLanguage**

(*bool*): True when this page is in the site's default language.

### **AllTranslations**

(*IEnumerable<IPage>*) { get }: All translations of this page, including itself, in the same output format, sorted by language weight. Useful for language switchers.

### **Translations**

(*IEnumerable<IPage>*) { get }: The translations of this page in other languages (excluding itself), in the same output format.

### **TranslationsByLanguage**

(*IReadOnlyDictionary<string, IPage>*) { get }: This page's translations keyed by language code (including itself), in the same output format. Handy for building a switcher over `site.Languages`: look up each language code and fall back to the language home when it is missing.

### **AlternativeOutputFormats**

(*IEnumerable<IPage>*) { get }: The alternate output formats of this page (including itself) in the same language, e.g. the RSS or JSON representation of an HTML page.

### **Variants**

(*IEnumerable<IPage>*) { get }: Every alternate representation of this logical page across all languages and all output formats (including itself). The unified variant model.

### **Pages**

(*IEnumerable<IPage>*) { get }: Other content that mention this content. Used to create the tags list and Related Posts section.

### **RegularPages**

(*IEnumerable<IPage>*) { get }: List of pages from the content folder.

### **PagesByDate**

(*IReadOnlyList<IPage>*) { get }: Pages ordered by date, computed once for this page.

### **PagesByLastMod**

(*IReadOnlyList<IPage>*) { get }: Pages ordered by last modification date, computed once for this page.

### **PagesByWeight**

(*IReadOnlyList<IPage>*) { get }: Pages ordered by weight, computed once for this page.

### **PagesByTitle**

(*IReadOnlyList<IPage>*) { get }: Pages ordered by title, computed once for this page.

### **RegularPagesByDate**

(*IReadOnlyList<IPage>*) { get }: Regular pages ordered by date, computed once for this page.

### **RegularPagesByLastMod**

(*IReadOnlyList<IPage>*) { get }: Regular pages ordered by last modification date, computed once for this page.

### **RegularPagesByWeight**

(*IReadOnlyList<IPage>*) { get }: Regular pages ordered by weight, computed once for this page.

### **RegularPagesByTitle**

(*IReadOnlyList<IPage>*) { get }: Regular pages ordered by title, computed once for this page.

### **AllOutputUrLs**

(*Dictionary<Uri, IOutput>*) { get }: Get all URLs related to this content.

### **Paginator**

(*Pager?*) { get }: Pagination metadata for list pages. Null when the page has fewer items than the paginate threshold.


## Public Methods

### PostProcess

```csharp
 void PostProcess(ISite site)
```

Final steps of parsing the content.

**Parameters:**

- `site` (*ISite*)


