---
Title: "IFrontMatterParser"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "IFrontMatterParser"
  namespace: "Fanstatic.Parsers"
  symbol: "interface"
  source: "IMetadataParser.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Parsers](/api/7.2.0/fanstatic.parsers)
- **Source File:** IMetadataParser.cs

Responsible for parsing the content front matter

## Public Methods

### SplitFrontMatterAndContent

```csharp
 (string frontMatter, string rawContent) SplitFrontMatterAndContent(string fileContent)
```

Extract the front matter from the content.

**Parameters:**

- `fileContent` (*string*)

**Returns:** `(string frontMatter, string rawContent)`


### Parse

```csharp
 T Parse(string content)
```

Parse a string content to the T class.

**Parameters:**

- `content` (*string*)

**Returns:** `T`


### SerializeAndSave

```csharp
 void SerializeAndSave(T data, string fileFullPath)
```

Deserialize an object into a file.

**Parameters:**

- `data` (*T*)
- `fileFullPath` (*string*)


