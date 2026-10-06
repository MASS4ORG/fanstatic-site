---
Title: "SiteCacheManager"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "SiteCacheManager"
  namespace: "Fanstatic.Helpers"
  symbol: "class"
  source: "SiteCacheManager.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Helpers](/api/7.2.0/fanstatic.helpers)
- **Source File:** SiteCacheManager.cs

Manages all the lists and dictionaries used for cache for the site

## Properties

### **ContentTemplateCache**

(*Dictionary<CacheTemplateIndex, string>*) { get } = `[]`: Cache for content templates.

### **BaseTemplateCache**

(*Dictionary<CacheTemplateIndex, string>*) { get } = `[]`: Cache for base templates.

### **AutomaticContentCache**

(*ConcurrentDictionary<string, ContentSource>*) { get } = `new()`: Cache for tag page.


## Public Methods

### ResetCache

```csharp
public void ResetCache()
```

Resets the template cache to force a reload of all templates.


