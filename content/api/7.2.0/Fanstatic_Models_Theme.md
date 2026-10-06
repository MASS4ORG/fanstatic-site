---
Title: "Theme"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "Theme"
  namespace: "Fanstatic.Models"
  symbol: "class"
  source: "Theme.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** Theme.cs

Representation of the theme.

## Properties

### **Title**

(*string*) { get; set } = `string.Empty`: Theme name

### **Path**

(*string*) { get; set } = `string.Empty`: Theme name

### **StaticFolder**

(*string*): The path of the static content (that will be copied as is)

### **DefaultLayoutFolder**

(*string*): folder that contains default layout files.

### **Folders**

(*IEnumerable<string>*): All default folders


## Public Methods

### Create

```csharp
public static Theme Create(Site site, string data)
```

Create a Theme from a given front matter content.

**Parameters:**

- `site` (*Site*)
- `data` (*string*)

**Returns:** `Theme`


### CreateFromSite

```csharp
public static Theme? CreateFromSite(Site site)
```

Create a Theme from a given front matter file path.

**Parameters:**

- `site` (*Site*)

**Returns:** `Theme?`


