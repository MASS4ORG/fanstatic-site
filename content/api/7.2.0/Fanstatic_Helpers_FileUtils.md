---
Title: "FileUtils"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "FileUtils"
  namespace: "Fanstatic.Helpers"
  symbol: "class"
  source: "FileUtils.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Helpers](/api/7.2.0/fanstatic.helpers)
- **Source File:** FileUtils.cs

Helper methods for scanning files.

## Fields

### **OutputFormats** (*FrozenDictionary<string, OutputFormat>*) = `new Dictionary<string, OutputFormat>
        {
            {
                "html", new OutputFormat
                {
                    Extension = "html"
                }
            },
            {
                "rss", new OutputFormat
                {
                    Extension = "xml",
                    NoUgly = true
                }
            },
            {
                "robots",
                new OutputFormat
                {
                    BaseName = "robots",
                    Extension = "xml",
                    NoUgly = true
                }
            },
            {
                "sitemap",
                new OutputFormat
                {
                    BaseName = "sitemap",
                    Extension = "xml",
                    NoUgly = true
                }
            }
        }.ToFrozenDictionary()`: Default Output Formats.

## Public Methods

### GetTemplate

```csharp
public static string GetTemplate(Site site, Page page, bool isBaseTemplate = false)
```

Gets the content of a template file based on the page and the theme path. The cache stores the resolved template path (not the file content).

**Parameters:**

- `site` (*Site*)
- `page` (*Page*): The page to determine the template index.
- `isBaseTemplate` (*bool*): Indicates whether the template is a base template. (Default: `false`)

**Returns:** `string`

- The content of the template file, or empty string when not found.

### GetTemplatePath

```csharp
public static string GetTemplatePath(Site site, Page page, bool isBaseTemplate = false)
```

Gets the resolved template file path based on the page and the theme path. The resolved path is cached for future lookups.

**Parameters:**

- `site` (*Site*)
- `page` (*Page*): The page to determine the template index.
- `isBaseTemplate` (*bool*): Indicates whether the template is a base template. (Default: `false`)

**Returns:** `string`

- The resolved template file path, or empty string when not found.

### GetTemplateLookupOrder

```csharp
public static IEnumerable<string> GetTemplateLookupOrder(Page page, bool isBaseTemplate)
```

Gets the lookup order for template files based on the theme path, page, and template type.

**Parameters:**

- `page` (*Page*): The page to determine the template index.
- `isBaseTemplate` (*bool*): Indicates whether the template is a base template.

**Returns:** `IEnumerable<string>`

- The list of template paths in the lookup order.

### GetBuiltinTemplate

```csharp
public static string GetBuiltinTemplate(Page page)
```

Returns the built-in inline template for the given output format, or empty string when none.

**Parameters:**

- `page` (*Page*)

**Returns:** `string`


