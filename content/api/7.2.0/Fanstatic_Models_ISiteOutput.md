---
Title: "ISiteOutput"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "ISiteOutput"
  namespace: "Fanstatic.Models"
  symbol: "interface"
  source: "ISiteOutput.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** ISiteOutput.cs
## Properties

### **Fanstatic**

(*FanstaticInfo*) { get }: Fanstatic internal variables

### **Theme**

(*Theme?*) { get }: Theme used.

### **BaseUrl**

(*Uri*) { get }: The base URL that will be used to build public links.

### **Language**

(*LanguageSettings*) { get }: The current language of this site output.

### **Languages**

(*IReadOnlyList<LanguageSettings>*) { get }: All languages configured for the site, sorted by weight.

### **Taxonomies**

(*IReadOnlyDictionary<string, TaxonomyTerms>*) { get }: Terms grouped by taxonomy path segment for the current language and output format.

### **OutputReferences**

(*ConcurrentDictionary<Uri, IOutput>*) { get }: List of all pages, including generated, by their permalink.

### **Pages**

(*IEnumerable<IPage>*) { get }: List of all pages, including generated.

### **RegularPages**

(*IEnumerable<IPage>*) { get }: List of pages from the content folder.

### **AllRegularPages**

(*IEnumerable<IPage>*) { get }: All regular pages across every output format. Intended for cross-format outputs such as sitemap.

### **Home**

(*IPage?*) { get }: The page of the home page;


