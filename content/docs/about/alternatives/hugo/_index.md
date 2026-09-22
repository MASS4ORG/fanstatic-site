---
Title: Hugo
---

[Hugo](https://gohugo.io/) is the most widely used static site generator. It's written in Go, ships as a single binary, and is genuinely fast. Fanstatic follows many of Hugo's conventions, so users familiar with Hugo will find Fanstatic familiar — with a few deliberate differences.

## What Fanstatic and Hugo have in common

- Single binary, no runtime required
- Content in `content/` as Markdown with YAML front matter
- Sections and taxonomies
- Aliases (redirect pages)
- RSS feeds and sitemaps
- Live reload dev server

## Where Fanstatic differs

### Templates: Liquid vs. Go templates

Hugo uses Go's `text/template` package. The syntax is terse but quirky — pipeline chains, context binding, and the lack of a named `page` object make non-trivial templates hard to read:

```go
{{ range where .Site.RegularPages "Section" "blog" }}
    {{ .Title }}
{{ end }}
```

Fanstatic uses [Liquid](https://shopify.github.io/liquid/), the same language as Shopify and Jekyll. It's expressive, readable, and has an explicit `page` object:

```liquid
{% assign posts = site.RegularPages | where: 'Section', 'blog' %}
{% for post in posts %}
    {{ post.Title }}
{% endfor %}
```

### Configuration: YAML only

Hugo supports YAML, TOML, and JSON config files. Fanstatic uses YAML exclusively (`fanstatic.yaml`), which eliminates format ambiguity.

### Front matter: PascalCase

Hugo front matter keys are typically camelCase or lowercase. Fanstatic uses PascalCase (`Title`, `Date`, `Tags`). This is consistent throughout — front matter, template variables, and site config all use the same casing.

### Language: .NET vs. Go

Fanstatic is built on .NET. If you're a C# developer, you can read and contribute to the source, run the build tools you already know, and integrate Fanstatic into .NET-based workflows. It also ships with a C# API documentation generator.

## Migration from Hugo

See [Fanstatic for Hugo Users](/docs/about/alternatives/hugo/fanstatic-for-hugo) for a field-by-field migration guide.

See [Feature Comparison](/docs/about/alternatives/hugo/comparison) for a detailed table of which Hugo features are implemented in Fanstatic.
