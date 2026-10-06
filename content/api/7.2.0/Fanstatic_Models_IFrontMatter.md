---
Title: "IFrontMatter"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "IFrontMatter"
  namespace: "Fanstatic.Models"
  symbol: "interface"
  source: "IFrontMatter.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** IFrontMatter.cs

Basic structure needed to generate user content and system content

## Properties

### **Title**

(*string?*) { get }: The content Title.

### **Description**

(*string?*) { get }: Description of the content.

### **Section**

(*string?*) { get }: The first directory where the content is located, inside content.

### **Type**

(*string?*) { get }: The type of content. It will be "page", if not specified.

### **Url**

(*string?*) { get }: The URL pattern to be used to create the url. Liquid template can be used to use tokens.

### **Draft**

(*bool?*) { get }: True for draft content. It will not be rendered unless an option `Draft` is set to `true`.

### **Date**

(*DateTime?*) { get }: Date of the post. Will be used as the `PublishDate` if it's not set. Unless the option `Future` is set to `true`, the dates set from the future will be ignored.

### **LastMod**

(*DateTime?*) { get }: Last modification date of the page. Useful to notify users that the content was updated.

### **PublishDate**

(*DateTime?*) { get }: Publish date of the page. If not set, the `Date` will be used instead. Unless the option `Future` is set to `true`, the dates set from the future will be ignored.

### **ExpiryDate**

(*DateTime?*) { get }: Expiry date of the page.

### **Aliases**

(*List<string>?*) { get }: A List of secondary URL patterns to be used to create the url. List URL, it will be parsed as liquid templates, so you can use page variables.

### **Weight**

(*int*) { get }: Page weight. Used for sorting by default.

### **Tags**

(*List<string>?*) { get }: A list of tags, if any.

### **ResourceDefinitions**

(*List<FrontMatterResources>?*) { get }: List of resource definitions.


