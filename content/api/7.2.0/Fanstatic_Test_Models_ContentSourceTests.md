---
Title: "ContentSourceTests"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "ContentSourceTests"
  namespace: "Fanstatic.Test.Models"
  symbol: "class"
  source: "ContentSourceTests.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Test.Models](/api/7.2.0/fanstatic.test.models)
- **Source File:** ContentSourceTests.cs
## Public Methods

### SourceFileNameWithoutExtension_Returns_Correct_FileName

```csharp
public void SourceFileNameWithoutExtension_Returns_Correct_FileName(string sourcePath, string expectedFileName)
```

**Parameters:**

- `sourcePath` (*string*)
- `expectedFileName` (*string*)


### SourcePathDirectory_Returns_Correct_Directory

```csharp
public void SourcePathDirectory_Returns_Correct_Directory(string sourcePath, string expectedDirectory)
```

**Parameters:**

- `sourcePath` (*string*)
- `expectedDirectory` (*string*)


### GetPublishDate_Returns_PublishDate_If_Not_Null_Otherwise_Date

```csharp
public void GetPublishDate_Returns_PublishDate_If_Not_Null_Otherwise_Date(string? dateString, string? publishDateString, string? expectedDateString)
```

**Parameters:**

- `dateString` (*string?*)
- `publishDateString` (*string?*)
- `expectedDateString` (*string?*)


