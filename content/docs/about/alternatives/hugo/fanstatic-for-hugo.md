---
Title: Fanstatic for Hugo Users
---

Already using Hugo? This guide maps Hugo concepts directly to their Fanstatic equivalents so you can get up to speed quickly.

## Configuration file

| Hugo | Fanstatic |
|---|---|
| `hugo.yaml`, `config.yaml`, `config.toml`, `config.json` | `fanstatic.yaml` |
| Supports YAML, TOML, JSON | YAML only |

The keys themselves are similar. Rename the file and you're most of the way there.

**Hugo:**
```yaml
# hugo.yaml
title: My Blog
baseURL: https://example.com
theme: my-theme
```

**Fanstatic:**
```yaml
# fanstatic.yaml
Title: My Blog
BaseURL: https://example.com
Theme: my-theme
```

## Front matter

Both use YAML front matter. The main differences:

| Hugo | Fanstatic |
|---|---|
| Lowercase or camelCase keys (`title`, `date`) | PascalCase keys (`Title`, `Date`) |
| TOML front matter (`+++`) supported | YAML only (`---`) |
| `lastmod` | `Lastmod` |
| `expiryDate` | `ExpiryDate` |
| `publishDate` | `PublishDate` |

**Hugo:**
```yaml
---
title: My Post
date: 2026-01-15
tags: [tutorial]
---
```

**Fanstatic:**
```yaml
---
Title: My Post
Date: 2026-01-15
Tags:
  - tutorial
---
```

## Templates

This is the most significant difference. Hugo uses Go's `text/template`; Fanstatic uses [Liquid](https://shopify.github.io/liquid/).

| Hugo | Fanstatic |
|---|---|
| `{{ .Title }}` | `{{ page.Title }}` |
| `{{ .Site.Title }}` | `{{ site.Title }}` |
| `{{ .Permalink }}` | `{{ page.Permalink }}` |
| `{{ .RelPermalink }}` | `{{ page.RelPermalink }}` |
| `{{ .Content }}` | `{{ page.Content }}` |
| `{{ .Date.Format "2006-01-02" }}` | `{{ page.Date \| date: '%Y-%m-%d' }}` |
| `{{ range .Pages }}` | `{% for p in page.Pages %}` |
| `{{ end }}` | `{% endfor %}` |
| `{{ partial "header.html" . }}` | `{% render 'partials/header.html' %}` |
| `{{ where .Site.RegularPages "Section" "blog" }}` | `{{ site.RegularPages \| where: 'Section', 'blog' }}` |

### Template file names

Template lookup follows the same principle in both tools:

| Hugo | Fanstatic |
|---|---|
| `layouts/_default/single.html` | `_default/single.html` |
| `layouts/_default/list.html` | `_default/list.html` |
| `layouts/_default/baseof.html` | `_default/baseof.html` |
| `layouts/blog/single.html` | `blog/single.html` |
| `layouts/partials/header.html` | `partials/header.html` |

Fanstatic templates live directly in the theme directory without a `layouts/` prefix.

## Shortcodes

Hugo shortcodes don't have a direct Fanstatic equivalent. Most shortcode use cases can be handled with Liquid `{% render %}` partials or Markdown extensions.

## Multilingual

Both have built-in i18n support. See the [Localization documentation](/docs/content/localization) for details on Fanstatic's implementation.

## Image processing

Hugo has a powerful image processing pipeline. Fanstatic does not yet include image processing.

## Data files

Hugo supports `data/` directory with JSON/YAML/TOML/CSV data files. Fanstatic does not yet support data files; use `site.Params` for custom data instead.

## Pagination

Both support paginated list pages. Fanstatic uses a Liquid filter:

**Hugo:**
```go
{{ $paginator := .Paginate (where .Site.RegularPages "Section" "blog") 10 }}
{{ range $paginator.Pages }}
    {{ .Title }}
{{ end }}
```

**Fanstatic:**
```liquid
{% assign posts = site.RegularPages | where: 'Section', 'blog' %}
{% assign pager = posts | paginate: 10 %}
{% for post in pager.PageItems %}
    {{ post.Title }}
{% endfor %}
{% render 'partials/pagination.html', pager: pager %}
```

## Feature comparison table

For a full list of Hugo page and site variables and their Fanstatic status, see the [Feature Comparison](/docs/about/alternatives/hugo/comparison).
