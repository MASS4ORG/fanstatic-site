---
Title: "DocumentationParser"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "DocumentationParser"
  namespace: "Fanstatic.Commands.API"
  symbol: "class"
  source: "DocumentationParser.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.API](/api/7.2.0/fanstatic.commands.api)
- **Source File:** DocumentationParser.cs

Provides functionality to parse documentation comments and extract relevant information from syntax nodes in a C# code syntax tree.

## Public Methods

### ParseDocumentation

```csharp
public static DocumentationInfo ParseDocumentation(SyntaxNode node)
```

Parses the documentation associated with a given syntax node.

**Parameters:**

- `node` (*SyntaxNode*): The syntax node from which to extract documentation.

**Returns:** `DocumentationInfo`

- An instance of `DocumentationInfo` containing the extracted documentation details, including raw content and a summary if applicable.

