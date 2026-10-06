---
Title: "PartialClassMerger"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "PartialClassMerger"
  namespace: "Fanstatic.Helpers"
  symbol: "class"
  source: "PartialClassMerger.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Helpers](/api/7.2.0/fanstatic.helpers)
- **Source File:** PartialClassMerger.cs

Utility class for merging partial class definitions into single ClassInfo objects.

## Public Methods

### GroupPartialClasses

```csharp
public static List<ClassInfo> GroupPartialClasses(List<ClassInfo> allClasses)
```

Groups partial classes by their FullName and merges them into single entries.

**Parameters:**

- `allClasses` (*List<ClassInfo>*): All classes from the project structure

**Returns:** `List<ClassInfo>`

- A list of merged class info objects

### GroupNamespaceClasses

```csharp
public static Dictionary<string, List<ClassInfo>> GroupNamespaceClasses(Dictionary<string, List<ClassInfo>> namespaceClasses)
```

Groups namespace classes by merging partial classes within each namespace.

**Parameters:**

- `namespaceClasses` (*Dictionary<string, List<ClassInfo>>*): Dictionary of namespace to classes

**Returns:** `Dictionary<string, List<ClassInfo>>`

- Dictionary with grouped classes per namespace

