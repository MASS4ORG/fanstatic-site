---
Title: "IFileSystem"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "IFileSystem"
  namespace: "Fanstatic.Helpers"
  symbol: "interface"
  source: "IFileSystem.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Helpers](/api/7.2.0/fanstatic.helpers)
- **Source File:** IFileSystem.cs

Interface for the System.File class

## Public Methods

### DirectoryCreateDirectory

```csharp
 void DirectoryCreateDirectory(string path)
```

Directory.CreateDirectory

**Parameters:**

- `path` (*string*)


### DirectoryExists

```csharp
 bool DirectoryExists(string path)
```

Directory.Exists

**Parameters:**

- `path` (*string*)

**Returns:** `bool`


### DirectoryGetFiles

```csharp
 string[] DirectoryGetFiles(string path)
```

Directory.GetFiles

**Parameters:**

- `path` (*string*)

**Returns:** `string[]`


### DirectoryGetFiles

```csharp
 string[] DirectoryGetFiles(string path, string searchPattern)
```

Directory.GetFiles

**Parameters:**

- `path` (*string*)
- `searchPattern` (*string*)

**Returns:** `string[]`


### DirectoryGetFiles

```csharp
 string[] DirectoryGetFiles(string path, string searchPattern, bool recursive)
```

Directory.GetFiles

**Parameters:**

- `path` (*string*)
- `searchPattern` (*string*)
- `recursive` (*bool*): Whether to include files in subdirectories.

**Returns:** `string[]`


### DirectoryGetDirectories

```csharp
 string[] DirectoryGetDirectories(string path)
```

Directory.GetDirectories

**Parameters:**

- `path` (*string*)

**Returns:** `string[]`


### FileExists

```csharp
 bool FileExists(string path)
```

File.Exists

**Parameters:**

- `path` (*string*)

**Returns:** `bool`


### FileCopy

```csharp
 void FileCopy(string sourceFileName, string destFileName, bool overwrite)
```

File.Copy

**Parameters:**

- `sourceFileName` (*string*)
- `destFileName` (*string*)
- `overwrite` (*bool*)


### FileWriteAllText

```csharp
 void FileWriteAllText(string path, string? contents)
```

File.WriteAllText

**Parameters:**

- `path` (*string*)
- `contents` (*string?*)


### FileReadAllText

```csharp
 string FileReadAllText(string path)
```

File.ReadAllText

**Parameters:**

- `path` (*string*)

**Returns:** `string`


