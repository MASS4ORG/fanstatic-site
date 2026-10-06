---
Title: "DocumentationGenerator"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "DocumentationGenerator"
  namespace: "Fanstatic.Commands.API"
  symbol: "class"
  source: "DocumentationGenerator.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.API](/api/7.2.0/fanstatic.commands.api)
- **Source File:** DocumentationGenerator.cs

The DocumentationGenerator class is responsible for generating documentation for the structure of a project including classes, records, enums, and namespaces.

## Public Methods

### GenerateDocumentationAsync

```csharp
public async Task GenerateDocumentationAsync(ProjectStructure structure, ApiGeneratorOptions options)
```

Asynchronously generates documentation for the given project structure, including class, namespace, and index files, and writes them to the specified output directory.

**Parameters:**

- `structure` (*ProjectStructure*): The structure of the project, including all classes and their namespaces, to generate documentation for.
- `options` (*ApiGeneratorOptions*): The options for generating the documentation.

**Returns:** `Task`

- A task that represents the asynchronous documentation generation operation.

