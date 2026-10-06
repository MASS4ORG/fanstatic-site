---
Title: "ISiteSettings"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "ISiteSettings"
  namespace: "Fanstatic.Models"
  symbol: "interface"
  source: "ISiteSettings.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** ISiteSettings.cs

The main configuration of the program, extracted from the app.yaml file.

## Properties

### **Title**

(*string*) { get }: Site Title/Name.

### **Description**

(*string?*) { get }: Site description

### **Copyright**

(*string?*) { get }: Copyright information

### **BaseUrl**

(*Uri*) { get; set }: The base URL that will be used to build public links.

### **UglyUrLs**

(*bool*) { get }: The appearance of a URL is either ugly or pretty.

### **KindOutputFormats**

(*Dictionary<Kind, List<string>>*) { get }: The output format for each content kind

### **TaxonomyDefinitions**

(*Dictionary<string, string>*) { get }: Taxonomy names and their content path segments.

### **Paginate**

(*int*) { get }: Number of regular pages shown per paginated page.

### **PaginatePath**

(*string*) { get }: URL path segment used for paginated pages.

### **Languages**

(*Dictionary<string, LanguageSettings>*) { get }: The languages configured for the site, keyed by their language code.

### **DefaultLanguage**

(*string*) { get }: The default content language code. Used for content files without a language suffix and as the fallback for template helpers.

### **DefaultContentLanguageInSubdir**

(*bool*) { get }: When true, content in the default language also gets a language prefix in its URL (e.g. `/en/about/`). When false (default) the default language has no URL prefix.


