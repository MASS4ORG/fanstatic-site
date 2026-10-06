---
Title: "Page"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "Page"
  namespace: "Fanstatic.Models"
  symbol: "class"
  source: "Page.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** Page.cs

Each page data created from source files or from the system.

## Properties

### **ContentSource**

(*ContentSource*) { get }

### **SourcePathLastDirectory**

(*string?*)

### **Site**

(*ISiteOutput*) { get }

### **SiteInternal**

(*ISite*) { get }: The full site instance, used for internal access to the template engine and other services.

### **AliasesProcessed**

(*Collection<Uri>?*) { get; set }

### **PagesReferences**

(*ConcurrentBag<Uri>*) { get } = `[]`

### **Parent**

(*IPage?*) { get }

### **Plain**

(*string*)

### **TagsReference**

(*List<IPage>*)

### **Taxonomies**

(*IReadOnlyDictionary<string, IReadOnlyList<IPage>>*)

### **IsHome**

(*bool*)

### **IsPage**

(*bool*)

### **IsSection**

(*bool*)

### **WordCount**

(*int*)

### **ContentPreRendered**

(*string*)

### **Content**

(*string*) { get }

### **CompleteContent**

(*string*)

### **OutputFormat**

(*string*) { get; set }

### **OutputFormats**

(*List<string>*) { get; set }

### **Language**

(*LanguageSettings*)

### **IsDefaultLanguage**

(*bool*)

### **AllTranslations**

(*IEnumerable<IPage>*) { get }

### **Translations**

(*IEnumerable<IPage>*)

### **TranslationsByLanguage**

(*IReadOnlyDictionary<string, IPage>*) { get }

### **AlternativeOutputFormats**

(*IEnumerable<IPage>*)

### **Variants**

(*IEnumerable<IPage>*) { get }

### **Pages**

(*IEnumerable<IPage>*) { get }

### **RegularPages**

(*IEnumerable<IPage>*) { get }

### **PagesByDate**

(*IReadOnlyList<IPage>*)

### **PagesByLastMod**

(*IReadOnlyList<IPage>*)

### **PagesByWeight**

(*IReadOnlyList<IPage>*)

### **PagesByTitle**

(*IReadOnlyList<IPage>*)

### **RegularPagesByDate**

(*IReadOnlyList<IPage>*)

### **RegularPagesByLastMod**

(*IReadOnlyList<IPage>*)

### **RegularPagesByWeight**

(*IReadOnlyList<IPage>*)

### **RegularPagesByTitle**

(*IReadOnlyList<IPage>*)

### **AllOutputUrLs**

(*Dictionary<Uri, IOutput>*)

### **PageIndex**

(*int*) { get; set } = `1`: Which pagination page this instance represents (1-based). Page 1 is the original; pages 2+ are virtual instances created by RegisterPaginatedUrls.

### **Paginator**

(*Pager?*)

### **Title**

(*string?*)

### **Description**

(*string?*)

### **Section**

(*string?*)

### **Url**

(*string?*)

### **UrlTemplate**

(*string*): The URL template used to build the permalink, derived from `Url` or the default index/non-index templates.

### **Draft**

(*bool?*)

### **Aliases**

(*List<string>?*)

### **Date**

(*DateTime?*)

### **LastMod**

(*DateTime?*)

### **PublishDate**

(*DateTime?*)

### **ExpiryDate**

(*DateTime?*)

### **Weight**

(*int*)

### **Tags**

(*List<string>?*)

### **ResourceDefinitions**

(*List<FrontMatterResources>?*)

### **RawContent**

(*string*)

### **ContentSourceToPages**

(*List<IPage>*)

### **ContentSourceParent**

(*ContentSource?*)

### **SourceRelativePath**

(*string*)

### **SourceRelativePathDirectory**

(*string*)

### **SourceFileNameWithoutExtension**

(*string?*)

### **Type**

(*string?*)

### **Kind**

(*Kind*)

### **BundleType**

(*BundleType*)

### **ContentSourceTags**

(*List<ContentSource>*)

### **ContentSourceTaxonomies**

(*Dictionary<string, List<ContentSource>>*)

### **Params**

(*Dictionary<string, object>*) { get; set }

### **RelPermalink**

(*Uri*) { get; set } = `new Uri("", UriKind.RelativeOrAbsolute)`

### **Resources**

(*List<Resource>?*) { get; set }: List of attached resources

### **OutputFormatObj**

(*OutputFormat*) { get }: The actual object with OutputFormat data


## Public Methods

### PostProcess

```csharp
public void PostProcess(ISite site)
```

**Parameters:**

- `site` (*ISite*)


