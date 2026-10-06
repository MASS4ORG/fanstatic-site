---
Title: "UriTypeConverter"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "UriTypeConverter"
  namespace: "Fanstatic.Parsers"
  symbol: "class"
  source: "UriTypeConverter.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Parsers](/api/7.2.0/fanstatic.parsers)
- **Source File:** UriTypeConverter.cs

Required for converting the string into Uri

## Public Methods

### Accepts

```csharp
public bool Accepts(Type type)
```

**Parameters:**

- `type` (*Type*)

**Returns:** `bool`


### ReadYaml

```csharp
public object ReadYaml(IParser parser, Type type, ObjectDeserializer rootDeserializer)
```

**Parameters:**

- `parser` (*IParser*)
- `type` (*Type*)
- `rootDeserializer` (*ObjectDeserializer*)

**Returns:** `object`


### WriteYaml

```csharp
public void WriteYaml(IEmitter emitter, object? value, Type type, ObjectSerializer serializer)
```

**Parameters:**

- `emitter` (*IEmitter*)
- `value` (*object?*)
- `type` (*Type*)
- `serializer` (*ObjectSerializer*)


