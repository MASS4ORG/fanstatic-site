---
Title: "Resource"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "Resource"
  namespace: "Fanstatic.Models"
  symbol: "class"
  source: "Resource.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** Resource.cs

Page resources. All files that accompany a page.

## Properties

### **Site**

(*ISiteOutput*) { get }

### **Title**

(*string?*) { get; set }

### **SourceRelativePath**

(*string*) { get }

### **RelPermalink**

(*Uri*) { get; set } = `new(".", UriKind.RelativeOrAbsolute)`

### **Params**

(*Dictionary<string, object>*) { get; set } = `[]`


