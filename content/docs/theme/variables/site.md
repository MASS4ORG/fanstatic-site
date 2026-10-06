---
Title: Site Variables
Params:
  hasCode: true
---

The `site` object is available in every template and gives access to site-wide configuration and all content.

## Configuration variables

These come from `fanstatic.yaml`:

| Variable | Description |
|---|---|
| `site.Title` | Site title |
| `site.BaseURL` | Absolute base URL (e.g. `https://example.com`) |
| `site.Description` | Site description |
| `site.Copyright` | Copyright string (may contain HTML) |
| `site.GoogleAnalytics` | Google Analytics measurement ID |
| `site.Paginate` | Default items per page for pagination |
| `site.PaginatePath` | URL segment for paginated pages (default: `page`) |
| `site.Params` | All custom `Params` from `fanstatic.yaml` |

### Accessing custom Params

```liquid
{{ site.Params.Logo }}
{{ site.Params.Author.Name }}

{% for item in site.Params.MainMenu %}
<a href="{{ item.url }}">{{ item.label }}</a>
{% endfor %}
```

## Content collections

| Variable | Description |
|---|---|
| `site.Pages` | All pages including section, taxonomy, and home pages (filtered by current language) |
| `site.RegularPages` | Regular content pages only (filtered by current language) |
| `site.RegularPagesByDate` | Regular pages sorted by date, ascending |
| `site.RegularPagesByLastMod` | Regular pages sorted by last modification, ascending |
| `site.RegularPagesByWeight` | Regular pages sorted by weight, ascending |
| `site.RegularPagesByTitle` | Regular pages sorted by title |
| `site.AllRegularPages` | All regular pages across all languages and output formats — use for sitemaps and global listings |
| `site.Home` | The home page object for the current language |
| `site.Taxonomies` | Taxonomy term lists keyed by path; each term exposes `Name`, `Permalink`, `Count`, and `Pages` |

## Language variables

Available on multi-language sites (see [Localization](/docs/content/localization)).

| Variable | Description |
|---|---|
| `site.Language` | The `LanguageSettings` for the current output language |
| `site.Languages` | List of all configured `LanguageSettings` objects |

### Filtering and sorting pages

The cached `site.RegularPagesBy*` views are available in Fanstatic 7.2.0 and later. They sort ascending; use
`reverse` for descending order. The shipped `list.xml` and `baseof.html` templates intentionally keep Liquid's
`sort` filter because their ordering behavior is part of those templates.

```liquid
{% comment %} All blog posts, newest first {% endcomment %}
{% assign posts = site.RegularPagesByDate | where: 'Section', 'blog' | reverse %}

{% comment %} Pages in a section, sorted by weight {% endcomment %}
{% assign docs = site.RegularPagesByWeight | where: 'Section', 'docs' %}
```

## Usage examples

### Navigation from Params

```liquid
<nav>
    {% for item in site.Params.MainMenu %}
    <a href="{{ item.url }}" {% if page.RelPermalink == item.url %}class="active"{% endif %}>
        {{ item.label }}
    </a>
    {% endfor %}
</nav>
```

### Listing recent posts

```liquid
{% assign recent = site.RegularPages | where: 'Section', 'blog' | sort: 'Date' | reverse %}
{% for post in recent limit: 5 %}
<a href="{{ post.Permalink }}">{{ post.Title }}</a>
{% endfor %}
```

### Sitemap template

```liquid
<?xml version="1.0" encoding="utf-8" standalone="yes"?>
<urlset xmlns="http://www.sitemaps.org/schemas/sitemap/0.9">
{% for page in site.AllRegularPages %}
  <url>
    <loc>{{ page.Permalink }}</loc>
    {% if page.Lastmod %}<lastmod>{{ page.Lastmod | date: '%Y-%m-%d' }}</lastmod>{% endif %}
  </url>
{% endfor %}
</urlset>
```

### Footer with site info

```liquid
<footer>
    <p>{{ site.Copyright }}</p>
    <p>{{ site.Params.Footer }}</p>
</footer>
```
