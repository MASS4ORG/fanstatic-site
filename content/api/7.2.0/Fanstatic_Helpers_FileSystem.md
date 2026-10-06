---
Title: "FileSystem"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "FileSystem"
  namespace: "Fanstatic.Helpers"
  symbol: "class"
  source: "IFileSystem.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Helpers](/api/7.2.0/fanstatic.helpers)
- **Source File:** IFileSystem.cs

Actual implementation of FS operations

## Public Methods

### DirectoryCreateDirectory

```csharp
public void DirectoryCreateDirectory(string path)
```

**Parameters:**

- `path` (*string*)


### DirectoryExists

```csharp
public bool DirectoryExists(string path)
```

**Parameters:**

- `path` (*string*)

**Returns:** `bool`


### DirectoryGetFiles

```csharp
public string[] DirectoryGetFiles(string path)
```

**Parameters:**

- `path` (*string*)

**Returns:** `string[]`


### DirectoryGetFiles

```csharp
public string[] DirectoryGetFiles(string path, string searchPattern)
```

**Parameters:**

- `path` (*string*)
- `searchPattern` (*string*)

**Returns:** `string[]`


### DirectoryGetFiles

```csharp
public string[] DirectoryGetFiles(string path, string searchPattern, bool recursive)
```

**Parameters:**

- `path` (*string*)
- `searchPattern` (*string*)
- `recursive` (*bool*)

**Returns:** `string[]`


### DirectoryGetDirectories

```csharp
public string[] DirectoryGetDirectories(string path)
```

**Parameters:**

- `path` (*string*)

**Returns:** `string[]`


### FileExists

```csharp
public bool FileExists(string path)
```

**Parameters:**

- `path` (*string*)

**Returns:** `bool`


### FileCopy

```csharp
public void FileCopy(string sourceFileName, string destFileName, bool overwrite)
```

**Parameters:**

- `sourceFileName` (*string*)
- `destFileName` (*string*)
- `overwrite` (*bool*)


### FileWriteAllText

```csharp
public void FileWriteAllText(string path, string? contents)
```

**Parameters:**

- `path` (*string*)
- `contents` (*string?*)


### FileReadAllText

```csharp
public string FileReadAllText(string path)
```

**Parameters:**

- `path` (*string*)

**Returns:** `string`


