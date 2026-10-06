---
Title: "SiteSettings"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "SiteSettings"
  namespace: "Fanstatic.Models"
  symbol: "class"
  source: "SiteSettings.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** SiteSettings.cs

The main configuration of the program, extracted from the app.yaml file.

## Properties

### **Title**

(*string*) { get; set } = `string.Empty`

### **Description**

(*string?*) { get; set } = `string.Empty`

### **Copyright**

(*string?*) { get; set }

### **BaseUrl**

(*Uri*) { get; set } = `new("http://localhost:2341",
        UriKind.RelativeOrAbsolute)`

### **KindOutputFormats**

(*Dictionary<Kind, List<string>>*) { get; set } = `new()
        {
            { Kind.home, ["html", "rss", "sitemap"] },
            { Kind.list, ["html", "rss"] },
            { Kind.section, ["html", "rss"] },
            { Kind.taxonomy, ["html", "rss"] },
            { Kind.term, ["html", "rss"] },
            { Kind.single, ["html", "rss"] },
            { Kind.rss, ["rss"] },
        }`

### **Taxonomies**

(*Dictionary<string, string>*) { get; set } = `new(StringComparer.OrdinalIgnoreCase)
        {
            { "tag", "tags" },
            { "category", "categories" }
        }`: Taxonomy names and their content path segments.

### **Languages**

(*Dictionary<string, LanguageSettings>*) { get; set } = `[]`

### **DefaultLanguage**

(*string*) { get; set } = `"en"`

### **DefaultContentLanguageInSubdir**

(*bool*) { get; set }

### **Outputs**

(*Dictionary<string, List<string>>*) { get; set } = `[]`: Types of outputs

### **Theme**

(*string?*) { get; set }: The global site theme.

### **ThemeDir**

(*string*) { get; set } = `"themes"`: The theme folder where all themes are placed (if any).

### **UglyUrLs**

(*bool*) { get; set }

### **Paginate**

(*int*) { get; set } = `10`: Number of items per pagination page.

### **PaginatePath**

(*string*) { get; set } = `"page"`: URL segment used for paginated pages.

### **Params**

(*Dictionary<string, object>*) { get; set } = `[]`


