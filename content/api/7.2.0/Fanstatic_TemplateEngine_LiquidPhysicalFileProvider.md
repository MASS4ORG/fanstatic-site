---
Title: "LiquidPhysicalFileProvider"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "LiquidPhysicalFileProvider"
  namespace: "Fanstatic.TemplateEngine"
  symbol: "class"
  source: "LiquidPhysicalFileProvider.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.TemplateEngine](/api/7.2.0/fanstatic.templateengine)
- **Source File:** LiquidPhysicalFileProvider.cs

Custom IFileProvider that strips the ".liquid" extension Fluid appends, serves files directly from disk, and falls back to built-in partials. Does NOT extend PhysicalFileProvider to avoid creating internal FileSystemWatchers that would trigger the SourceFileWatcher and cause infinite site recreation.

## Public Methods

### GetFileInfo

```csharp
public IFileInfo GetFileInfo(string subpath)
```

Remove the ".liquid" extension; serve from disk; fall back to built-in partials.

**Parameters:**

- `subpath` (*string*)

**Returns:** `IFileInfo`


### GetDirectoryContents

```csharp
public IDirectoryContents GetDirectoryContents(string subpath)
```

**Parameters:**

- `subpath` (*string*)

**Returns:** `IDirectoryContents`


### Watch

```csharp
public IChangeToken Watch(string filter)
```

Returns a no-op token — no file watching so serve mode does not loop.

**Parameters:**

- `filter` (*string*)

**Returns:** `IChangeToken`


