---
Title: "TaxonomyTerms"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "TaxonomyTerms"
  namespace: "Fanstatic.Models"
  symbol: "class"
  source: "TaxonomyTerms.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** TaxonomyTerms.cs

A collection of taxonomy terms with pre-computed orderings by count and by name.

## Properties

### **ByCount**

(*IReadOnlyList<TaxonomyTerm>*): Terms ordered by page count descending, then by name ascending.

### **ByName**

(*IReadOnlyList<TaxonomyTerm>*): Terms ordered by name ascending.

### **Count**

(*int*)


## Public Methods

### GetEnumerator

```csharp
public IEnumerator<TaxonomyTerm> GetEnumerator()
```

**Returns:** `IEnumerator<TaxonomyTerm>`


