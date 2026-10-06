---
Title: "TaxonomyTerm"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "TaxonomyTerm"
  namespace: "Fanstatic.Models"
  symbol: "class"
  source: "TaxonomyTerm.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** TaxonomyTerm.cs

A taxonomy term and the content pages assigned to it.

## Properties

### **Name**

(*string*) { get } = `page.SourcePathLastDirectory ?? page.Title ?? string.Empty`: The term's content path name.

### **Title**

(*string*): The term's display title.

### **Permalink**

(*Uri*) { get } = `page.Permalink`: The term page's public URL.

### **Pages**

(*IReadOnlyList<IPage>*) { get } = `page.RegularPages.ToList()`: Content pages assigned to the term.

### **Count**

(*int*): The number of content pages assigned to the term.

### **Page**

(*IPage*) { get } = `page`: The underlying term page.


