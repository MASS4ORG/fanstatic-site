---
Title: "IContentSource"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "IContentSource"
  namespace: "Fanstatic.Models"
  symbol: "interface"
  source: "IContentSource.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** IContentSource.cs

Content Source = front matter + raw content

## Properties

### **RawContent**

(*string*) { get }: Raw content from the Markdown file, bellow the front matter.

### **BundleType**

(*BundleType*) { get }: The bundle type of the page.

### **Kind**

(*Kind*) { get }: The kind of the page, if it's a single page, a list of pages or the home page. It's used to determine the proper theme file.

### **ContentSourceToPages**

(*List<IPage>*) { get }: Pages created based on this Content Source

### **ContentSourceTags**

(*List<ContentSource>*) { get }: List of tags.

### **ContentSourceTaxonomies**

(*Dictionary<string, List<ContentSource>>*) { get }: Term sources grouped by taxonomy path segment.

### **ContentSourceParent**

(*ContentSource?*) { get }: The Content Source parent content

### **GetPublishDate**

(*DateTime?*): The date to be considered as the publishing date.


