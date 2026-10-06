---
Title: "StringBuilderExtensions"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "StringBuilderExtensions"
  namespace: "Fanstatic.Commands.API"
  symbol: "class"
  source: "StringBuilderExtensions.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.API](/api/7.2.0/fanstatic.commands.api)
- **Source File:** StringBuilderExtensions.cs

Provides a set of extension methods for constructing or appending structured content to `StringBuilder` instances. These extensions streamline the process of adding formatted documentation or metadata outputs, such as front matter, headers, or detailed class documentation.

## Public Methods

### AppendFrontMatter

```csharp
public static StringBuilder AppendFrontMatter(StringBuilder sb, string title, string type, (string key, string value)[] parameters)
```

Appends front matter metadata to the beginning of a StringBuilder instance. This metadata includes title, type, creation date, and an optional list of parameters.

**Parameters:**

- `sb` (*StringBuilder*): The `StringBuilder` instance to which the front matter is appended.
- `title` (*string*): The title to be included in the front matter.
- `type` (*string*): The type to be included in the front matter.
- `parameters` (*(string key, string value)[]*): An optional list of key-value pairs representing additional metadata parameters.

**Returns:** `StringBuilder`

- The modified `StringBuilder` instance with the appended front matter.

### AppendHeader

```csharp
public static StringBuilder AppendHeader(StringBuilder sb, ClassInfo classInfo, ApiGeneratorOptions options)
```

Appends a header for a class to the beginning of a StringBuilder instance. The header includes the class name, type kind, namespace link, and source file information.

**Parameters:**

- `sb` (*StringBuilder*): The `StringBuilder` instance to which the header is appended.
- `classInfo` (*ClassInfo*): An instance of `ClassInfo` containing metadata about the class, such as its name, namespace, and type kind.
- `options` (*ApiGeneratorOptions*): The options for generating the API documentation.

**Returns:** `StringBuilder`

- The modified `StringBuilder` instance with the appended header.

### AppendClassDocumentation

```csharp
public static StringBuilder AppendClassDocumentation(StringBuilder sb, ClassInfo classInfo)
```

Appends class-level documentation details to a StringBuilder instance. This includes the summary, remarks, and an optional example section if provided.

**Parameters:**

- `sb` (*StringBuilder*): The `StringBuilder` instance to which the documentation content is appended.
- `classInfo` (*ClassInfo*): The `ClassInfo` object containing the class documentation details to be appended.

**Returns:** `StringBuilder`

- The modified `StringBuilder` instance with the appended class documentation content.

### AppendEnumValues

```csharp
public static StringBuilder AppendEnumValues(StringBuilder sb, ClassInfo classInfo)
```

Appends a list of enum values with their names, optional values, and summaries to the provided StringBuilder instance in a formatted Markdown representation.

**Parameters:**

- `sb` (*StringBuilder*): The `StringBuilder` instance to which the enum values are appended.
- `classInfo` (*ClassInfo*): The `ClassInfo` instance containing information about the enum values.

**Returns:** `StringBuilder`

- The modified `StringBuilder` instance with the appended enum values, or the unmodified instance if no enum values are present.

### AppendFields

```csharp
public static StringBuilder AppendFields(StringBuilder sb, ClassInfo classInfo)
```

Appends field information from the provided `ClassInfo` to the given `StringBuilder` instance in a formatted style.

**Parameters:**

- `sb` (*StringBuilder*): The `StringBuilder` instance where the field information will be appended.
- `classInfo` (*ClassInfo*): The `ClassInfo` object containing the field data to be appended.

**Returns:** `StringBuilder`

- The modified `StringBuilder` instance with the appended field information.

### AppendProperties

```csharp
public static StringBuilder AppendProperties(StringBuilder sb, ClassInfo classInfo)
```

Appends a formatted list of properties to the provided `StringBuilder` instance based on the given `ClassInfo` object. If the `ClassInfo` object contains no properties, no content is appended.

**Parameters:**

- `sb` (*StringBuilder*): The `StringBuilder` instance to which the property information will be appended.
- `classInfo` (*ClassInfo*): The `ClassInfo` object containing property information to format and append.

**Returns:** `StringBuilder`

- The modified `StringBuilder` instance with the formatted property information appended.

### AppendMethods

```csharp
public static StringBuilder AppendMethods(StringBuilder sb, ClassInfo classInfo)
```

Appends documentation for public methods of a class to the given StringBuilder instance. Each public method's documentation is formatted and included as a separate line.

**Parameters:**

- `sb` (*StringBuilder*): The `StringBuilder` instance to append the method documentation to.
- `classInfo` (*ClassInfo*): An instance of `ClassInfo` containing information about the class and its public methods.

**Returns:** `StringBuilder`

- The modified `StringBuilder` instance with appended method documentation.

### AppendTypeList

```csharp
public static StringBuilder AppendTypeList(StringBuilder sb, List<ClassInfo> classes)
```

Appends a formatted list of type links to the StringBuilder instance. Each type is represented as a list item containing an icon, modifiers, and a hyperlink to the type's documentation.

**Parameters:**

- `sb` (*StringBuilder*): The `StringBuilder` instance to which the type list is appended.
- `classes` (*List<ClassInfo>*): A list of `ClassInfo` objects representing the types to be included in the list.

**Returns:** `StringBuilder`

- The modified `StringBuilder` instance with the appended type list.

### AppendNamespaceList

```csharp
public static StringBuilder AppendNamespaceList(StringBuilder sb, Dictionary<string, List<ClassInfo>> namespaceClasses, ApiGeneratorOptions options)
```

Appends a list of namespaces and their associated classes to a StringBuilder instance. The namespaces are ordered alphabetically, and each namespace includes the names of its classes.

**Parameters:**

- `sb` (*StringBuilder*): The `StringBuilder` instance to which the namespaces and class lists are appended.
- `namespaceClasses` (*Dictionary<string, List<ClassInfo>>*): A dictionary where the keys represent namespace names and the values are lists of `ClassInfo` instances corresponding to the classes within each namespace.
- `options` (*ApiGeneratorOptions*): The options for generating the API documentation.

**Returns:** `StringBuilder`

- The modified `StringBuilder` instance with the appended namespace and class information.

