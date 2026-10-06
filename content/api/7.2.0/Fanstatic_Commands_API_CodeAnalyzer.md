---
Title: "CodeAnalyzer"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "CodeAnalyzer"
  namespace: "Fanstatic.Commands.API"
  symbol: "class"
  source: "CodeAnalyzer.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.API](/api/7.2.0/fanstatic.commands.api)
- **Source File:** CodeAnalyzer.cs

The CodeAnalyzer class provides functionality to analyze the structure of a C# project. It processes all C# files within a given project directory and extracts information about namespaces and classes defined in the project.

## Public Methods

### AnalyzeProjectAsync

```csharp
public async Task<ProjectStructure> AnalyzeProjectAsync(string projectPath)
```

Analyzes the structure of a C# project by processing all .cs files in the specified project directory.

**Parameters:**

- `projectPath` (*string*): The file path to the root directory of the project to analyze.

**Returns:** `Task<ProjectStructure>`

- Returns a `ProjectStructure` object containing the analyzed structure of namespaces and classes.

### AnalyzeSourceCodeAsync

```csharp
public Task<ProjectStructure> AnalyzeSourceCodeAsync(string sourceCode, string sourceFileName = "Unknown.cs")
```

Analyzes the content of a C# source code and returns a project structure for a single file. This is a drop-in replacement for AnalyzeProjectAsync when analyzing single file content.

**Parameters:**

- `sourceCode` (*string*): The C# source code content to analyze.
- `sourceFileName` (*string*): The name of the source file (for reference purposes). (Default: `"Unknown.cs"`)

**Returns:** `Task<ProjectStructure>`

- Returns a `ProjectStructure` object containing the analyzed structure of the source code.

