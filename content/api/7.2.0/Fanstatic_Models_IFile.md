---
Title: "IFile"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "IFile"
  namespace: "Fanstatic.Models"
  symbol: "interface"
  source: "IFile.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** IFile.cs

Basic structure needed to generate user content and system content

## Properties

### **SourceRelativePath**

(*string*) { get }: The source file/folder, relative to content folder

### **SourceRelativePathDirectory**

(*string*): The source directory of the file, without the file name.

### **SourceFileNameWithoutExtension**

(*string?*): The source filename, without the extension. ;)

### **Extension**

(*string*): File extension.

### **MimeType**

(*string*): File MIME type.

### **Size**

(*long*): File size in bytes.


## Public Methods

### SourceFullPath

```csharp
 string SourceFullPath(string basePath)
```

The source filename, without the extension. ;)

**Parameters:**

- `basePath` (*string*)

**Returns:** `string`


### SourceFullPathDirectory

```csharp
 string SourceFullPathDirectory(string basePath)
```

The full source directory of the file, without the file name.

**Parameters:**

- `basePath` (*string*)

**Returns:** `string`


