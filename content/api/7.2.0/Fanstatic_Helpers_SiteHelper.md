---
Title: "SiteHelper"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "SiteHelper"
  namespace: "Fanstatic.Helpers"
  symbol: "class"
  source: "SiteHelper.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Helpers](/api/7.2.0/fanstatic.helpers)
- **Source File:** SiteHelper.cs

Helper methods for scanning files.

## Fields

### **MarkdownPipeline** (*MarkdownPipeline*) = `new MarkdownPipelineBuilder()
        .UseAdvancedExtensions()
        .Build()`: Markdig 20+ built-in extensions

## Public Methods

### Init

```csharp
public static Site Init(string configFile, IGenerateOptions options, IFrontMatterParser parser, ILogger logger, StopwatchReporter stopwatch, IFileSystem fs)
```

Creates the pages' dictionary.

**Parameters:**

- `configFile` (*string*)
- `options` (*IGenerateOptions*)
- `parser` (*IFrontMatterParser*)
- `logger` (*ILogger*)
- `stopwatch` (*StopwatchReporter*)
- `fs` (*IFileSystem*)

**Returns:** `Site`


### GetSection

```csharp
public static string GetSection(string filePath)
```

Get the section name from a file path

**Parameters:**

- `filePath` (*string*)

**Returns:** `string`


### ParseSettings

```csharp
public static SiteSettings ParseSettings(string configFile, IGenerateOptions options, IFrontMatterParser parser, IFileSystem fs)
```

Reads the application settings.

**Parameters:**

- `configFile` (*string*): The site settings file.
- `options` (*IGenerateOptions*): The generate options.
- `parser` (*IFrontMatterParser*): The front matter parser.
- `fs` (*IFileSystem*)

**Returns:** `SiteSettings`

- The site settings.

