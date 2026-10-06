---
Title: "FrontMatter"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "FrontMatter"
  namespace: "Fanstatic.Models"
  symbol: "class"
  source: "FrontMatter.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** FrontMatter.cs

A scaffold structure to help creating system-generated content, like tag, section or index pages

## Properties

### **Title**

(*string?*) { get; set } = `string.Empty`

### **Description**

(*string?*) { get; set }

### **Type**

(*string?*) { get; set } = `"page"`

### **Url**

(*string?*) { get; set }

### **Draft**

(*bool?*) { get; set }

### **Aliases**

(*List<string>?*) { get; set }

### **Section**

(*string?*) { get; set } = `string.Empty`

### **Date**

(*DateTime?*) { get; set }

### **LastMod**

(*DateTime?*) { get; set }

### **PublishDate**

(*DateTime?*) { get; set }

### **ExpiryDate**

(*DateTime?*) { get; set }

### **Weight**

(*int*) { get; set }

### **Tags**

(*List<string>?*) { get; set }

### **ResourceDefinitions**

(*List<FrontMatterResources>?*) { get; set }

### **Params**

(*Dictionary<string, object>*) { get; set } = `[]`

### **Cascade**

(*FrontMatter?*) { get; set }: Cascade front matter data to its children.


## Public Methods

### Parse

```csharp
public static FrontMatter Parse(string frontMatterString, string fileFullPath, string fileRelativePath, IFrontMatterParser parser)
```

Create a front matter from a given front matter + content

**Parameters:**

- `frontMatterString` (*string*)
- `fileFullPath` (*string*)
- `fileRelativePath` (*string*)
- `parser` (*IFrontMatterParser*)

**Returns:** `FrontMatter`


### Parse

```csharp
public static (FrontMatter, string) Parse(string fileFullPath, string fileRelativePath, IFrontMatterParser parser, string content)
```

Create a front matter from a given content

**Parameters:**

- `fileFullPath` (*string*)
- `fileRelativePath` (*string*)
- `parser` (*IFrontMatterParser*)
- `content` (*string*)

**Returns:** `(FrontMatter, string)`


### Merge

```csharp
public FrontMatter Merge(FrontMatter other)
```

**Parameters:**

- `other` (*FrontMatter*)

**Returns:** `FrontMatter`


