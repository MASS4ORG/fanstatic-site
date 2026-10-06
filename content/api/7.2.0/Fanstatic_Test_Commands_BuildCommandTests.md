---
Title: "BuildCommandTests"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "BuildCommandTests"
  namespace: "Fanstatic.Test.Commands"
  symbol: "class"
  source: "BuildCommandTests.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Test.Commands](/api/7.2.0/fanstatic.test.commands)
- **Source File:** BuildCommandTests.cs
## Public Methods

### Constructor_ShouldNotThrowException_WhenParametersAreValid

```csharp
public void Constructor_ShouldNotThrowException_WhenParametersAreValid()
```


### Constructor_ShouldThrowArgumentNullException_WhenOptionsIsNull

```csharp
public void Constructor_ShouldThrowArgumentNullException_WhenOptionsIsNull()
```


### Run

```csharp
public void Run()
```


### CopyFolder_ShouldCallCreateDirectory_WhenSourceFolderExists

```csharp
public void CopyFolder_ShouldCallCreateDirectory_WhenSourceFolderExists()
```


### CopyFolder_ShouldNotCallCreateDirectory_WhenSourceFolderDoesNotExist

```csharp
public void CopyFolder_ShouldNotCallCreateDirectory_WhenSourceFolderDoesNotExist()
```


### CopyFolder_ShouldKeepSubfolders_WhenSourceFolderHasNestedFiles

```csharp
public void CopyFolder_ShouldKeepSubfolders_WhenSourceFolderHasNestedFiles()
```


### CopyFolder_ShouldNotCopyAnything_WhenSourceFolderHasNoFiles

```csharp
public void CopyFolder_ShouldNotCopyAnything_WhenSourceFolderHasNoFiles()
```


### Run_ShouldReturnFailure_WhenTemplateErrorsWereFound

```csharp
public async Task Run_ShouldReturnFailure_WhenTemplateErrorsWereFound(string testSitePath, int expectedExitCode, int expectedContinueOnErrorExitCode)
```

**Parameters:**

- `testSitePath` (*string*)
- `expectedExitCode` (*int*)
- `expectedContinueOnErrorExitCode` (*int*)

**Returns:** `Task`


### Run_ShouldCopyNestedStaticFolders

```csharp
public async Task Run_ShouldCopyNestedStaticFolders()
```

**Returns:** `Task`


### Run_ShouldLogOneMessagePerTemplate_WhenSyntaxErrorIsFound

```csharp
public async Task Run_ShouldLogOneMessagePerTemplate_WhenSyntaxErrorIsFound()
```

**Returns:** `Task`


