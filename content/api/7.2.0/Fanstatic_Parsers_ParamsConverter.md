---
Title: "ParamsConverter"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "ParamsConverter"
  namespace: "Fanstatic.Parsers"
  symbol: "class"
  source: "ParamsConverter.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Parsers](/api/7.2.0/fanstatic.parsers)
- **Source File:** ParamsConverter.cs

A custom YAML type converter for dictionaries with string keys and object values.

## Public Methods

### Accepts

```csharp
public bool Accepts(Type type)
```

Checks if the converter can handle the specified type.

**Parameters:**

- `type` (*Type*): The type to check.

**Returns:** `bool`

- True if the type is a dictionary with string keys and object values, false otherwise.

### ReadYaml

```csharp
public object ReadYaml(IParser parser, Type type, ObjectDeserializer rootDeserializer)
```

Reads a YAML stream and deserializes it into a dictionary.

**Parameters:**

- `parser` (*IParser*): The YAML parser.
- `type` (*Type*): The type of the object to deserialize.
- `rootDeserializer` (*ObjectDeserializer*)

**Returns:** `object`

- A dictionary deserialized from the YAML stream.

### WriteYaml

```csharp
public void WriteYaml(IEmitter emitter, object? value, Type type, ObjectSerializer serializer)
```

Writes an object to a YAML stream.

**Parameters:**

- `emitter` (*IEmitter*): The YAML emitter.
- `value` (*object?*): The object to serialize.
- `type` (*Type*): The type of the object to serialize.
- `serializer` (*ObjectSerializer*)


