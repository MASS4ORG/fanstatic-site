---
Title: "OutputFormat"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "OutputFormat"
  namespace: "Fanstatic.Models"
  symbol: "record"
  source: "OutputFormat.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** OutputFormat.cs

Represents an output format.

## Properties

### **BaseName**

(*string*) { get } = `"index"`: The base name of the published file.

### **Extension**

(*string*) { get } = `"html"`: File extension of the output format.

### **MediaType**

(*bool*) { get }: The media type of the published file. This must match a defined media type, either built-in or custom.

### **Rel**

(*bool*) { get }: If provided, you can assign this value to rel attributes in link elements when iterating over output formats in your templates.

### **Permalinkable**

(*bool*) { get }: If true, the Permalink and RelPermalink methods on a Page object return the rendering output format rather than main output format (see below). Enabled by default for the html and amp output formats

### **NoUgly**

(*bool*) { get }: If true, disables ugly URLs for this output format when uglyURLs is true in your site configuration.

### **Ugly**

(*bool*) { get }: If true, enables uglyURLs for this output format when uglyURLs is false in your site configuration.


