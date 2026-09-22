---
Title: Features
---

## Core

- **Sub-millisecond builds** — pages compile in under 1 ms each; the whole site rebuilds in seconds even at hundreds of pages
- **Single binary** — download one file, no runtime or dependencies required
- **Cross-platform** — Linux, macOS, and Windows all supported
- **Live reload** — `fanstatic serve` rebuilds and refreshes your browser on every save

## Content

- Markdown with [Markdig](https://github.com/xoofx/markdig) (tables, footnotes, alerts, code fences)
- YAML front matter for metadata (`Title`, `Date`, `Tags`, `Draft`, custom `Params`)
- Sections, subsections, and nested content hierarchies
- Aliases — redirect old URLs to new ones without breaking links
- Draft, future, and expired content controlled per page and per build
- **Multi-language** — content in any number of languages with language-prefixed URLs, i18n translation strings, and full translation-aware template variables

## URLs

- Clean, configurable URL patterns
- Permalink overrides per page
- Pretty URL support (e.g. `/blog/my-post/` instead of `/blog/my-post.html`)

## Templating

- [Liquid](https://shopify.github.io/liquid/) templates via the [Fluid](https://github.com/sebastienros/fluid) engine
- Full `page` and `site` objects available in every template
- Partials for reusable components
- Output formats — generate HTML, RSS, sitemap, or any custom format from the same content

## Pagination

- `page.Paginator` object on list pages (`Count`, `Current`, `Prev`, `Next`, `PageItems`, ...)
- `paginate` Liquid filter for template-driven pagination
- Built-in pagination partial — works out of the box, override when needed
- Configurable items per page and URL path

## SEO & Discovery

- Automatic `sitemap.xml` generation
- RSS feeds
- Canonical URLs
- Twitter/OpenGraph meta support (via theme)

## Developer experience

- C# API documentation generator — scan your .NET source and publish it as a site section
- `validate-links` command — check for broken internal and external links
- GitLab CI/CD example included
