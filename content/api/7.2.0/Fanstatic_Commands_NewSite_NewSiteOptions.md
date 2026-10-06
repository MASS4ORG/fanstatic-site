---
Title: "NewSiteOptions"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "NewSiteOptions"
  namespace: "Fanstatic.Commands.NewSite"
  symbol: "class"
  source: "NewSiteOptions.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.NewSite](/api/7.2.0/fanstatic.commands.newsite)
- **Source File:** NewSiteOptions.cs

Command line options to generate a simple site from scratch.

## Properties

### **Output**

(*string*) { get } = `"./"`: The path of the output files.

### **Force**

(*bool*) { get }: Force site creation.

### **Title**

(*string*) { get } = `"My Site"`: Site title.

### **Description**

(*string*) { get } = `string.Empty`: Site description.

### **BaseUrl**

(*Uri*) { get } = `new("https://example.org/")`: Site base url.


