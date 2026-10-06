---
Title: "ApiGeneratorOptions"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "ApiGeneratorOptions"
  namespace: "Fanstatic.Commands.API"
  symbol: "class"
  source: "ApiGeneratorOptions.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.API](/api/7.2.0/fanstatic.commands.api)
- **Source File:** ApiGeneratorOptions.cs

Options for generating API documentation.

## Properties

### **SourceProjects**

(*IEnumerable<string>*) { get } = `new[] { "./" }`: Paths to the source C# projects.

### **Output**

(*string*) { get } = `"api"`: Relative output path for API documentation.

### **OutputPolicy**

(*OutputPolicy*) { get } = `OutputPolicy.Delete`: Specifies how to handle an existing output directory.

### **Filter**

(*string?*) { get }: Filter which assemblies or namespaces to include in the API documentation.

### **IncludePrivate**

(*bool*) { get }: Include private/internal members in the API documentation.

### **ExternalLink**

(*string?*) { get }: External repository link for source code linking (e.g., github.com/user/repo).


