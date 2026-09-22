---
Title: Localization
Params:
  hasCode: true
---

Fanstatic supports building sites in multiple languages. Content in different languages shares templates and site configuration, while getting language-prefixed URLs, per-language translations, and a full i18n string system.

* [Configuration](#configuration)
* [Language Settings](#language-settings)
* [Content Naming](#content-naming)
* [URL Structure](#url-structure)
* [Internationalization (i18n)](#internationalization-i18n)
* [Translation-Aware Page Variables](#translation-aware-page-variables)
* [Template Examples](#template-examples)
* [Language Scoping](#language-scoping)

## Configuration

Enable multi-language by adding a `languages` map to your `fanstatic.yaml`:

```yaml
Title: "My Site"
BaseURL: https://example.com

languages:
  en:
    LanguageName: English
    Weight: 1
    Title: "My Site"
    IsDefault: true
  pt-br:
    LanguageName: "Português (Brasil)"
    Weight: 2
    Title: "Meu Site"
    LanguageCode: pt-BR
  fr:
    LanguageName: Français
    Weight: 3
    Title: "Mon Site"
```

The first language added (or the one with `IsDefault: true`) is the site's default language. If no `languages` block is present, a single default entry is synthesized automatically — existing sites work without changes.

## Language Settings

Each language entry supports these fields:

| Field | Description |
|---|---|
| `LanguageCode` | Code used in `<html lang="...">` attribute; defaults to the key |
| `LanguageName` | Display name, e.g. "Português (Brasil)" |
| `Weight` | Sort order (lower = first) |
| `Title` | Site title for this language; falls back to root `Title` |
| `IsDefault` | Set to `true` to mark the default language |
| `ContentDir` | Content directory for this language; defaults to `content/` |
| `Params` | Per-language custom parameters |

Any field not set falls back to the root site settings. If the configured default language is missing from the `languages` dictionary, an entry is synthesized automatically.

## Content Naming

Fanstatic detects a page's language from its filename. Append the language code before the `.md` extension:

```
content/
├── _index.md                →  /         (default language)
├── about.md                 →  /about/   (default language)
├── about.pt-br.md           →  /pt-br/about/
├── about.fr.md              →  /fr/about/
└── blog/
    ├── _index.md            →  /blog/        (default)
    ├── _index.pt-br.md      →  /pt-br/blog/
    ├── hello.md             →  /blog/hello/  (default)
    └── hello.pt-br.md       →  /pt-br/blog/hello/
```

The language code must match one of the keys declared in the `languages` configuration. Files without a recognized suffix are assigned to the default language.

Pages with the same logical name (directory + filename without language suffix) across different languages are automatically grouped as **translations** of one another. For example, `about.md` and `about.pt-br.md` share the translation key `about` and appear in each other's `Translations` list.

## URL Structure

By default, the default language uses clean URLs without a prefix:

| Language | URL |
|---|---|
| English (default) | `/about/` |
| Português | `/pt-br/about/` |
| Français | `/fr/about/` |

Set `DefaultContentLanguageInSubdir: true` in `fanstatic.yaml` to give all languages a prefix:

| Language | URL |
|---|---|
| English (default) | `/en/about/` |
| Português | `/pt-br/about/` |

`LanguageSettings.RelPermalink` provides the language's home URL (e.g. `/` or `/pt-br/`) for use in templates.

## Internationalization (i18n)

Translation strings let you render UI text in the page's language — navigation labels, "Read more" links, date formats, and theme copy.

### Translation files

Create YAML files in the `i18n/` directory at your site root, one per language:

```yaml
# i18n/en.yaml
read_more:
  one: "Read more"
  other: "Read more"

posts:
  one: "{{ count }} post"
  other: "{{ count }} posts"

footer_copyright: "All rights reserved."
```

```yaml
# i18n/pt-br.yaml
read_more:
  one: "Leia mais"
  other: "Leia mais"

posts:
  one: "{{ count }} post"
  other: "{{ count }} posts"

footer_copyright: "Todos os direitos reservados."
```

Each key can be:
- A plain string (mapped to `other` automatically)
- A map with `one` and `other` keys for pluralization (Hugo-compatible format)

### Using translations in templates

The `i18n` filter looks up a key in the current page's language:

```liquid
<a href="{{ page.RelPermalink }}">{{ "read_more" | i18n }}</a>
```

Pass a count for pluralization:

```liquid
{% assign count = site.RegularPages.size %}
<p>{{ "posts" | i18n: count }}</p>
```

If `site.RegularPages.size` is 1, this renders `1 post` in English and `1 post` in Portuguese. If it is 10, it renders `10 posts` in both languages.

The `one` form is used when count equals 1, `other` for any other count (including 0).

When a translation key is missing in the current language, Fanstatic falls back to the default language's translation file automatically. This lets you roll out translations incrementally — untranslated strings gracefully degrade to the default language.

### Inline Liquid in translations

If a translation value contains `{{` characters, it is rendered as an inline Liquid template before being returned. This enables dynamic content inside translations:

```yaml
# i18n/en.yaml
welcome: "Welcome, {{ site.Params.Author.Name }}!"
```

## Translation-Aware Page Variables

Every page exposes translation navigation properties:

| Variable | Type | Description |
|---|---|---|
| `page.Translations` | page list | Same-page content in other languages (excludes self); sorted by language weight |
| `page.AllTranslations` | page list | All translations including self; sorted by weight |
| `page.TranslationsByLanguage` | dictionary | Translations keyed by language code (includes self) |
| `page.Variants` | page list | Every representation across all languages and output formats |
| `page.AlternativeOutputFormats` | page list | All output formats (HTML, RSS, JSON) for the same language |
| `page.IsDefaultLanguage` | bool | True when the page is in the site's default language |

Site-level language variables:

| Variable | Type | Description |
|---|---|---|
| `site.Languages` | list | All configured `LanguageSettings` objects |
| `site.Language` | LanguageSettings | Current language context for this output |
| `site.AllRegularPages` | page list | All regular pages across *all* languages and output formats (use for sitemaps) |

Each `LanguageSettings` object exposes:

| Property | Description |
|---|---|
| `LanguageSettings.LanguageCode` | Language tag (e.g. `en`, `pt-BR`) |
| `LanguageSettings.LanguageName` | Display name |
| `LanguageSettings.Weight` | Sort order |
| `LanguageSettings.Title` | Per-language site title |
| `LanguageSettings.RelPermalink` | Home URL for this language (e.g. `/` or `/pt-br/`) |

### Language scoping

`page.Pages`, `site.Pages`, and `site.RegularPages` now filter by the current language — translated children no longer leak into the wrong language's listing. Use `site.AllRegularPages` when you need cross-language listings (sitemaps, RSS).

## Template Examples

### Language switcher

```liquid
{% if page.Translations.size > 0 %}
<nav class="language-switcher">
  {% for t in page.Translations %}
  <a href="{{ t.RelPermalink }}" hreflang="{{ t.Language }}" lang="{{ t.Language }}">
    {{ t.LanguageName }}
  </a>
  {% endfor %}
</nav>
{% endif %}
```

### HTML lang attribute

```html
<html lang="{{ site.Language.LanguageCode }}">
```

### Link alternate tags

```liquid
{% for t in page.AllTranslations %}
<link rel="alternate" hreflang="{{ t.Language }}" href="{{ t.Permalink }}">
{% endfor %}
```

### Per-language site title

```liquid
<title>{{ page.Title }} — {{ site.Language.Title }}</title>
```

### Fallback to default language homepage

```liquid
{% assign lang = site.Languages | where: "LanguageCode", "fr" | first %}
<a href="{{ lang.RelPermalink }}">{{ lang.LanguageName }}</a>
```

### Home page per language

```liquid
{% for lang in site.Languages %}
{% assign home = page.TranslationsByLanguage[lang.LanguageCode] %}
{% if home %}
  <a href="{{ home.RelPermalink }}">{{ lang.LanguageName }}</a>
{% else %}
  <a href="{{ lang.RelPermalink }}">{{ lang.LanguageName }}</a>
{% endif %}
{% endfor %}
```

## Auto-Generated Sections and Taxonomies

Section and taxonomy pages (directories and tag listings) are automatically generated for every configured language. If a directory has an `_index.md` only in English, Fanstatic synthesizes stub `ContentSource` entries for the other languages. This ensures non-default language sections have correct `Pages` collections and URL structures without requiring manually duplicated `_index.{lang}.md` files.

To customize a section page for a specific language, simply create the corresponding `_index.{lang}.md` file in the directory. The auto-generated stub is replaced by your custom content.
