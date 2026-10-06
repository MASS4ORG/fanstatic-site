---
Title: "IFileWatcher"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "IFileWatcher"
  namespace: "Fanstatic.Helpers"
  symbol: "interface"
  source: "IFileWatcher.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Helpers](/api/7.2.0/fanstatic.helpers)
- **Source File:** IFileWatcher.cs

The FileSystemWatcher object that monitors the source directory for file changes.

## Public Methods

### Start

```csharp
 void Start(string sourceAbsolutePath, Action<object, FileSystemEventArgs> onSourceFileChanged)
```

Starts the file watcher to monitor file changes in the specified source path.

**Parameters:**

- `sourceAbsolutePath` (*string*): The path to the source directory.
- `onSourceFileChanged` (*Action<object, FileSystemEventArgs>*)


### Stop

```csharp
 void Stop()
```

Disposes the file watcher


