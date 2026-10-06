---
Title: "CodeAnalyzerTests"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "CodeAnalyzerTests"
  namespace: "Fanstatic.Test.Commands"
  symbol: "class"
  source: "CodeAnalyzerTests.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Test.Commands](/api/7.2.0/fanstatic.test.commands)
- **Source File:** CodeAnalyzerTests.cs
## Public Methods

### AnalyzeProjectAsync_ShouldReturnProjectStructure

```csharp
public async Task AnalyzeProjectAsync_ShouldReturnProjectStructure()
```

**Returns:** `Task`


### AnalyzeProjectAsync_ShouldCorrectlyIdentifyTypeKinds

```csharp
public async Task AnalyzeProjectAsync_ShouldCorrectlyIdentifyTypeKinds()
```

**Returns:** `Task`


### AnalyzeProjectAsync_ShouldCorrectlyParseNamespaces

```csharp
public async Task AnalyzeProjectAsync_ShouldCorrectlyParseNamespaces()
```

**Returns:** `Task`


### AnalyzeProjectAsync_ShouldParseClassMethods

```csharp
public async Task AnalyzeProjectAsync_ShouldParseClassMethods()
```

**Returns:** `Task`


### AnalyzeProjectAsync_ShouldParseClassProperties

```csharp
public async Task AnalyzeProjectAsync_ShouldParseClassProperties()
```

**Returns:** `Task`


### AnalyzeProjectAsync_ShouldParseClassFields

```csharp
public async Task AnalyzeProjectAsync_ShouldParseClassFields()
```

**Returns:** `Task`


### AnalyzeProjectAsync_ShouldParseEnumValues

```csharp
public async Task AnalyzeProjectAsync_ShouldParseEnumValues()
```

**Returns:** `Task`


### AnalyzeProjectAsync_ShouldParseInterfaceMethods

```csharp
public async Task AnalyzeProjectAsync_ShouldParseInterfaceMethods()
```

**Returns:** `Task`


### AnalyzeProjectAsync_ShouldParseRecordProperties

```csharp
public async Task AnalyzeProjectAsync_ShouldParseRecordProperties()
```

**Returns:** `Task`


### AnalyzeProjectAsync_ShouldParseStructMembers

```csharp
public async Task AnalyzeProjectAsync_ShouldParseStructMembers()
```

**Returns:** `Task`


### AnalyzeProjectAsync_ShouldSkipBinObjDirectories

```csharp
public async Task AnalyzeProjectAsync_ShouldSkipBinObjDirectories()
```

**Returns:** `Task`


### AnalyzeProjectAsync_ShouldHandleInvalidCSharpFiles

```csharp
public async Task AnalyzeProjectAsync_ShouldHandleInvalidCSharpFiles()
```

**Returns:** `Task`


### AnalyzeProjectAsync_ShouldCorrectlySetFullNames

```csharp
public async Task AnalyzeProjectAsync_ShouldCorrectlySetFullNames()
```

// [Fact]
// public async Task AnalyzeProjectAsync_ShouldHandleUnauthorizedAccessException()
// {
//     // Arrange
//     var nonExistentPath = "/root/non-existent-directory";
//     // Act & Assert - Should not throw exception
//     var result = await Analyzer.AnalyzeProjectAsync(nonExistentPath);
//     Assert.NotNull(result);
//     Assert.Empty(result.AllClasses);
// }

**Returns:** `Task`


### AnalyzeProjectAsync_ShouldSetCorrectSourceFileNames

```csharp
public async Task AnalyzeProjectAsync_ShouldSetCorrectSourceFileNames()
```

**Returns:** `Task`


### AnalyzeProjectAsync_ShouldCorrectlyIdentifySpecificTypeKinds

```csharp
public async Task AnalyzeProjectAsync_ShouldCorrectlyIdentifySpecificTypeKinds(string typeName, string expectedKind)
```

**Parameters:**

- `typeName` (*string*)
- `expectedKind` (*string*)

**Returns:** `Task`


### AnalyzeProjectAsync_ShouldFindExpectedType

```csharp
public async Task AnalyzeProjectAsync_ShouldFindExpectedType(string expectedTypeName)
```

**Parameters:**

- `expectedTypeName` (*string*)

**Returns:** `Task`


### AnalyzeSourceCodeAsync_ShouldHandleEmptyFile

```csharp
public async Task AnalyzeSourceCodeAsync_ShouldHandleEmptyFile()
```

**Returns:** `Task`


### AnalyzeSourceCodeAsync_ShouldAnalyzeSingleClass

```csharp
public async Task AnalyzeSourceCodeAsync_ShouldAnalyzeSingleClass()
```

**Returns:** `Task`


### AnalyzeSourceCodeAsync_ShouldAnalyzeMultipleTypes

```csharp
public async Task AnalyzeSourceCodeAsync_ShouldAnalyzeMultipleTypes()
```

**Returns:** `Task`


### AnalyzeSourceCodeAsync_ShouldIdentifyTypeKind

```csharp
public async Task AnalyzeSourceCodeAsync_ShouldIdentifyTypeKind(string expectedKind, string typeDeclaration)
```

**Parameters:**

- `expectedKind` (*string*)
- `typeDeclaration` (*string*)

**Returns:** `Task`


### AnalyzeProjectAsync_ShouldLogCorrectNumberOfFiles

```csharp
public async Task AnalyzeProjectAsync_ShouldLogCorrectNumberOfFiles()
```

**Returns:** `Task`


### AnalyzeProjectAsync_ShouldLogAnalyzedTypes

```csharp
public async Task AnalyzeProjectAsync_ShouldLogAnalyzedTypes()
```

**Returns:** `Task`


