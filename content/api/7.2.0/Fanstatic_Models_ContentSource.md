---
Title: "ContentSource"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "ContentSource"
  namespace: "Fanstatic.Models"
  symbol: "class"
  source: "ContentSource.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** ContentSource.cs

Content Source = front matter + raw content

## Properties

### **FrontMatter**

(*FrontMatter*) { get }: Internal front matter

### **Title**

(*string?*)

### **Description**

(*string?*)

### **Section**

(*string?*)

### **Type**

(*string?*) { get; set }

### **Url**

(*string?*)

### **Draft**

(*bool?*)

### **Date**

(*DateTime?*)

### **LastMod**

(*DateTime?*)

### **PublishDate**

(*DateTime?*)

### **ExpiryDate**

(*DateTime?*)

### **Aliases**

(*List<string>?*)

### **Weight**

(*int*)

### **Tags**

(*List<string>?*)

### **ResourceDefinitions**

(*List<FrontMatterResources>?*) { get; set }

### **RawContent**

(*string*) { get; set }

### **BundleType**

(*BundleType*) { get }

### **Kind**

(*Kind*) { get; set } = `Kind.single`

### **ContentSourceToPages**

(*List<IPage>*) { get } = `[]`

### **ContentSourceParent**

(*ContentSource?*) { get; set }

### **ContentSourceTags**

(*List<ContentSource>*) { get } = `[]`

### **ContentSourceTaxonomies**

(*Dictionary<string, List<ContentSource>>*) { get } = `new(StringComparer.OrdinalIgnoreCase)`: Term sources grouped by taxonomy path segment.

### **Params**

(*Dictionary<string, object>*) { get; set }

### **SourceRelativePath**

(*string*) { get; set }

### **SourceRelativePathDirectory**

(*string*)

### **LogicalFileNameWithoutExtension**

(*string?*) { get; set }: The logical filename without extension and without the language suffix (e.g. `hello` for `hello.pt-br.md`). Used to build language-neutral URLs.

### **SourceFileNameWithoutExtension**

(*string*)

### **Language**

(*string*) { get; set } = `string.Empty`: The language code of this content (e.g. `en`, `pt-br`).

### **TranslationKey**

(*string*) { get; set } = `string.Empty`: The language-neutral logical path (directory + logical filename) shared by all translations of the same logical document.

### **Translations**

(*List<ContentSource>*) { get } = `[]`: All content sources that are translations of this one, including itself. Populated after the whole content tree has been scanned.

### **Children**

(*HashSet<ContentSource>*) { get; set } = `[]`: List of children content.

### **RawResources**

(*Collection<ContentSourceResource>?*) { get; set }: List of attached resources


## Public Methods

### ScanForResources

```csharp
public ContentSource ScanForResources(ISite site)
```

Scan and collect resources for this content source

**Parameters:**

- `site` (*ISite*)

**Returns:** `ContentSource`


