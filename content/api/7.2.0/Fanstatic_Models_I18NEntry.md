---
Title: "I18NEntry"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "I18NEntry"
  namespace: "Fanstatic.Models"
  symbol: "class"
  source: "I18nEntry.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** I18nEntry.cs

A single translation entry, supporting both simple string values and plural-aware (one/other) format compatible with Hugo.

## Properties

### **One**

(*string?*) { get; set }: Singular form, used when count is 1.

### **Other**

(*string?*) { get; set }: Plural form, used when count is not 1.


