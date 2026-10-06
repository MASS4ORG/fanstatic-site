---
Title: "YamlParser"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "YamlParser"
  namespace: "Fanstatic.Parsers"
  symbol: "class"
  source: "YAMLParser.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Parsers](/api/7.2.0/fanstatic.parsers)
- **Source File:** YAMLParser.cs

Responsible for parsing the content front matter using YAML

## Public Methods

### Parse

```csharp
public T Parse(string content)
```

**Parameters:**

- `content` (*string*)

**Returns:** `T`


### SerializeAndSave

```csharp
public void SerializeAndSave(T data, string fileFullPath)
```

**Parameters:**

- `data` (*T*)
- `fileFullPath` (*string*)


### SplitFrontMatterAndContent

```csharp
public (string, string) SplitFrontMatterAndContent(string fileContent)
```

**Parameters:**

- `fileContent` (*string*)

**Returns:** `(string, string)`


