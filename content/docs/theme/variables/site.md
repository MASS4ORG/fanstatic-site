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
| `site.AllRegularPages` | All regular pages across all languages and output formats — use for sitemaps and global listings |
| `site.Home` | The home page object for the current language |

## Language variables

Available on multi-language sites (see [Localization](/docs/content/localization)).

| Variable | Description |
|---|---|
| `site.Language` | The `LanguageSettings` for the current output language |
| `site.Languages` | List of all configured `LanguageSettings` objects |

### Filtering and sorting pages

```liquid
{% comment %} All blog posts, newest first {% endcomment %}
{% assign posts = site.RegularPages | where: 'Section', 'blog' | sort: 'Date' | reverse %}

{% comment %} Pages in a section, sorted by weight {% endcomment %}
{% assign docs = site.RegularPages | where: 'Section', 'docs' | sort: 'Weight' %}
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
