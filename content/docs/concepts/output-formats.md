---
Title: Output Formats
Weight: 1
Params:
  hasCode: true
---

Fanstatic can generate multiple output files from the same content page. Each output format has its own template and produces a different file. The most common formats are HTML and RSS, but you can define custom formats for any file type.

## Built-in formats

### HTML

The default output for every page. Uses templates in `_default/` (or type-specific overrides).

### RSS

Fanstatic generates an RSS feed for section list pages. A blog section at `/blog/` automatically gets a feed at `/blog/index.xml`.

The feed uses the `list.xml` template from your theme, or Fanstatic's built-in RSS template if none is provided.

### Sitemap

A `sitemap.xml` is automatically generated for the home page using `site.AllRegularPages`. Submit it to search engines to improve indexing:

```
https://yourdomain.com/sitemap.xml
```

The sitemap uses Fanstatic's built-in template unless your theme provides `_default/sitemap.xml`.

## How template lookup works for formats

For a page with section `blog`, kind `single`, and format `html`, Fanstatic checks templates in this order:

1. `blog/single.html`
2. `_default/single.html`
3. Built-in fallback

For `list.xml` (RSS):

1. `blog/list.xml`
2. `_default/list.xml`
3. Built-in RSS template

For `sitemap.xml`:

1. `_default/sitemap.xml`
2. Built-in sitemap template

Format-specific templates (`list.xml`, `sitemap.xml`) are checked before generic kind templates, so `_default/list.xml` won't accidentally override the built-in sitemap format.

## Customizing the RSS feed

Override the built-in RSS by creating `themes/my-theme/_default/list.xml`:

```liquid
<?xml version="1.0" encoding="utf-8" standalone="yes"?>
<rss version="2.0" xmlns:atom="http://www.w3.org/2005/Atom">
  <channel>
    <title>{{ page.Title }} — {{ site.Title }}</title>
    <link>{{ page.Permalink }}</link>
    <description>{{ site.Description }}</description>
    <atom:link href="{{ page.Permalink }}index.xml" rel="self" type="application/rss+xml" />
    {% assign sorted = page.Pages | sort: 'Date' | reverse %}
    {% for post in sorted limit: 20 %}
    <item>
      <title>{{ post.Title }}</title>
      <link>{{ post.Permalink }}</link>
      <pubDate>{{ post.Date | date: '%a, %d %b %Y %H:%M:%S +0000' }}</pubDate>
      <description>{{ post.Plain | truncate: 300 }}</description>
    </item>
    {% endfor %}
  </channel>
</rss>
```

## Customizing the sitemap

Override by creating `themes/my-theme/_default/sitemap.xml`:

```liquid
<?xml version="1.0" encoding="utf-8" standalone="yes"?>
<urlset xmlns="http://www.sitemaps.org/schemas/sitemap/0.9">
{% for p in site.AllRegularPages %}
  <url>
    <loc>{{ p.Permalink }}</loc>
    {% if p.Lastmod %}<lastmod>{{ p.Lastmod | date: '%Y-%m-%d' }}</lastmod>{% endif %}
    <changefreq>weekly</changefreq>
  </url>
{% endfor %}
</urlset>
```

## Linking to alternate formats

In your `<head>` template, link to RSS and other formats:

```liquid
<link
    rel="alternate"
    type="application/rss+xml"
    href="{{ page.Permalink }}index.xml"
    title="{{ site.Title }}"
/>
```

The `page.OutputFormats` variable lists all formats available for the current page.
