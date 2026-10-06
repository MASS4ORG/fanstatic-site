---
Title: "SourceFileWatcher"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "SourceFileWatcher"
  namespace: "Fanstatic.Helpers"
  symbol: "class"
  source: "SourceFileWatcher.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Helpers](/api/7.2.0/fanstatic.helpers)
- **Source File:** SourceFileWatcher.cs

The FileSystemWatcher object that monitors the source directory for file changes.

## Public Methods

### Start

```csharp
public void Start(string sourceAbsolutePath, Action<object, FileSystemEventArgs> onSourceFileChanged)
```

**Parameters:**

- `sourceAbsolutePath` (*string*)
- `onSourceFileChanged` (*Action<object, FileSystemEventArgs>*)


### Stop

```csharp
public void Stop()
```


### Dispose

```csharp
public void Dispose()
```


