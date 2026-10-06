---
Title: "RefShortcodeParser"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "RefShortcodeParser"
  namespace: "Fanstatic.Parsers"
  symbol: "class"
  source: "RefShortcodeParser.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Parsers](/api/7.2.0/fanstatic.parsers)
- **Source File:** RefShortcodeParser.cs

Resolves Hugo-style `{{&lt; ref &gt;}}` / `{{&lt; relref &gt;}}` shortcodes found in raw markdown content into permalinks, before the content is handed to Markdig. `ref` resolves to the absolute permalink, `relref` to the relative one. The target page is looked up using the calling page's output format and language, unless overridden with the `outputFormat` and `lang` named arguments.

## Public Methods

### Process

```csharp
public static string Process(string content, ISite site, IPage page)
```

Replaces every `ref`/`relref` shortcode occurrence in `content` with the resolved permalink of the target page.

**Parameters:**

- `content` (*string*)
- `site` (*ISite*)
- `page` (*IPage*)

**Returns:** `string`


