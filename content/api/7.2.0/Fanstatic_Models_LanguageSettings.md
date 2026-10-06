---
Title: "LanguageSettings"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "LanguageSettings"
  namespace: "Fanstatic.Models"
  symbol: "class"
  source: "LanguageSettings.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** LanguageSettings.cs

Per-language configuration, as defined under the `languages` key of the site settings file. Values not set here fall back to the root site settings.

## Properties

### **Code**

(*string*) { get; set } = `string.Empty`: The language code (e.g. `en`, `pt-br`). Filled in from the `languages` dictionary key, so it is not read from the YAML body.

### **Title**

(*string?*) { get; set }: Language-specific site title. Falls back to the root title when null.

### **Description**

(*string?*) { get; set }: Language-specific site description.

### **LanguageName**

(*string?*) { get; set }: The human-readable name of the language (e.g. `English`, `Português`), typically used in language switchers.

### **LanguageDirection**

(*string*) { get; set } = `"ltr"`: Text direction of the language, `ltr` (default) or `rtl`.

### **Weight**

(*int*) { get; set }: Ordering weight used to sort the list of languages.

### **BaseUrl**

(*Uri?*) { get; set }: Language-specific base URL. Falls back to the root base URL when null.

### **IsDefault**

(*bool*) { get; set }: True when this is the site's default language.

### **RelPermalink**

(*Uri*) { get; set } = `new("/", UriKind.Relative)`: The relative URL of this language's home page (e.g. `/` for the default language, `/pt-br/` otherwise). Useful as a fallback target in language switchers when the current page has no translation in a given language.

### **Params**

(*Dictionary<string, object>*) { get; set } = `[]`


