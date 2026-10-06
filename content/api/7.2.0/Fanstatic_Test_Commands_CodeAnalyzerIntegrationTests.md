---
Title: "CodeAnalyzerIntegrationTests"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "CodeAnalyzerIntegrationTests"
  namespace: "Fanstatic.Test.Commands"
  symbol: "class"
  source: "CodeAnalyzerIntegrationTests.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Test.Commands](/api/7.2.0/fanstatic.test.commands)
- **Source File:** CodeAnalyzerIntegrationTests.cs
## Public Methods

### AnalyzeTestProject_ShouldParseAllExpectedTypes

```csharp
public async Task AnalyzeTestProject_ShouldParseAllExpectedTypes(string expectedType)
```

**Parameters:**

- `expectedType` (*string*)

**Returns:** `Task`


### AnalyzeTestProject_ShouldCorrectlyParseNamespaces

```csharp
public async Task AnalyzeTestProject_ShouldCorrectlyParseNamespaces(string namespaceName, int expectedMinCount)
```

**Parameters:**

- `namespaceName` (*string*)
- `expectedMinCount` (*int*)

**Returns:** `Task`


### AnalyzeTestProject_SampleClass_ShouldHaveCorrectStructure

```csharp
public async Task AnalyzeTestProject_SampleClass_ShouldHaveCorrectStructure()
```

**Returns:** `Task`


### AnalyzeTestProject_ProcessDataMethod_ShouldHaveCorrectSignature

```csharp
public async Task AnalyzeTestProject_ProcessDataMethod_ShouldHaveCorrectSignature()
```

**Returns:** `Task`


### AnalyzeTestProject_CalculateMethod_ShouldHaveDefaultParameters

```csharp
public async Task AnalyzeTestProject_CalculateMethod_ShouldHaveDefaultParameters()
```

**Returns:** `Task`


### AnalyzeTestProject_SampleStatus_ShouldHaveCorrectEnumValues

```csharp
public async Task AnalyzeTestProject_SampleStatus_ShouldHaveCorrectEnumValues()
```

**Returns:** `Task`


### AnalyzeTestProject_Priority_ShouldHaveImplicitEnumValues

```csharp
public async Task AnalyzeTestProject_Priority_ShouldHaveImplicitEnumValues()
```

**Returns:** `Task`


### AnalyzeTestProject_UserRecord_ShouldHaveCorrectStructure

```csharp
public async Task AnalyzeTestProject_UserRecord_ShouldHaveCorrectStructure()
```

**Returns:** `Task`


### AnalyzeTestProject_Point_ShouldBeRecordStruct

```csharp
public async Task AnalyzeTestProject_Point_ShouldBeRecordStruct()
```

**Returns:** `Task`


### AnalyzeTestProject_Dimensions_ShouldHaveStructMembers

```csharp
public async Task AnalyzeTestProject_Dimensions_ShouldHaveStructMembers()
```

**Returns:** `Task`


### AnalyzeTestProject_IDataService_ShouldHaveInterfaceMethods

```csharp
public async Task AnalyzeTestProject_IDataService_ShouldHaveInterfaceMethods()
```

**Returns:** `Task`


### AnalyzeTestProject_ValidationResult_ShouldBeRecord

```csharp
public async Task AnalyzeTestProject_ValidationResult_ShouldBeRecord()
```

**Returns:** `Task`


### AnalyzeTestProject_SimpleClass_ShouldParseRegularComments

```csharp
public async Task AnalyzeTestProject_SimpleClass_ShouldParseRegularComments()
```

**Returns:** `Task`


### AnalyzeTestProject_SimpleStatus_ShouldParseRegularCommentedEnum

```csharp
public async Task AnalyzeTestProject_SimpleStatus_ShouldParseRegularCommentedEnum()
```

**Returns:** `Task`


### AnalyzeTestProject_ShouldGroupTypesByNamespace

```csharp
public async Task AnalyzeTestProject_ShouldGroupTypesByNamespace()
```

**Returns:** `Task`


### AnalyzeTestProject_ShouldHandleComplexDocumentation

```csharp
public async Task AnalyzeTestProject_ShouldHandleComplexDocumentation()
```

**Returns:** `Task`


