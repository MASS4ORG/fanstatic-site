---
Title: "SiteOutput"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "SiteOutput"
  namespace: "Fanstatic.Models"
  symbol: "class"
  source: "SiteOutput.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** SiteOutput.cs
## Properties

### **Language**

(*LanguageSettings*)

### **Languages**

(*IReadOnlyList<LanguageSettings>*)

### **Taxonomies**

(*IReadOnlyDictionary<string, TaxonomyTerms>*)

### **OutputFormat**

(*string*)

### **Params**

(*Dictionary<string, object>*) { get }

### **Title**

(*string*)

### **Description**

(*string?*)

### **Copyright**

(*string?*)

### **BaseUrl**

(*Uri*)

### **UglyUrLs**

(*bool*)

### **Paginate**

(*int*)

### **PaginatePath**

(*string*)

### **KindOutputFormats**

(*Dictionary<Kind, List<string>>*)

### **Fanstatic**

(*FanstaticInfo*)

### **Theme**

(*Theme?*)

### **SourceContentPath**

(*string*)

### **SourceStaticPath**

(*string*)

### **SourceThemePath**

(*string*)

### **OutputReferences**

(*ConcurrentDictionary<Uri, IOutput>*)

### **Pages**

(*IEnumerable<IPage>*)

### **RegularPages**

(*IEnumerable<IPage>*)

### **RegularPagesByDate**

(*IReadOnlyList<IPage>*): Regular pages ordered by date and cached for this output _variant.

### **RegularPagesByLastMod**

(*IReadOnlyList<IPage>*): Regular pages ordered by last modification date and cached for this output _variant.

### **RegularPagesByWeight**

(*IReadOnlyList<IPage>*): Regular pages ordered by weight and cached for this output _variant.

### **RegularPagesByTitle**

(*IReadOnlyList<IPage>*): Regular pages ordered by title and cached for this output _variant.

### **AllRegularPages**

(*IEnumerable<IPage>*): // AllRegularPages intentionally spans every language: it is the cross-cutting accessor
// used by outputs such as sitemaps that should list the whole site.

### **Home**

(*IPage?*)

### **CacheManager**

(*SiteCacheManager*)

### **Parser**

(*IFrontMatterParser*)

### **TemplateEngine**

(*ITemplateEngine*)

### **Logger**

(*ILogger*)

### **SourceFolders**

(*IEnumerable<string>*)


## Public Methods

### ProcessPages

```csharp
public void ProcessPages()
```


