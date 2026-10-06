---
Title: Taxonomy
Params:
  hasCode: true
---

Taxonomies group and cross-reference content. Fanstatic generates a taxonomy listing and a term page for every configured term.

## Configuration

Taxonomies map a name to its URL path. By default, `tag` maps to `tags` and `category` maps to `categories`:

```yaml
Taxonomies:
  tag: tags
  category: categories
  series: series
```

When you configure the mapping, it defines the site's complete taxonomy set; include `tag: tags` and
`category: categories` if you want to retain those defaults. Set `Taxonomies: {}` to disable taxonomy generation.

## Assigning terms

Use `Tags` for tags and the taxonomy's plural path for categories or custom terms:

```yaml
---
Title: Getting Started with Fanstatic
Tags:
  - tutorial
Categories:
  - guides
Series:
  - first-steps
---
```

Fanstatic generates `/tags/tutorial/`, `/categories/guides/`, and `/series/first-steps/`.

Customize a term's title, description, or weight with `content/<plural>/<term>/_index.md`:

```yaml
---
Title: First Steps
Description: A sequence of introductory articles.
Weight: 10
---
```

## Template data

`page.Taxonomies` contains the assigned term pages, grouped by taxonomy path:

```liquid
{% for tag in page.Taxonomies.tags %}
<a href="{{ tag.Permalink }}">{{ tag.Title }}</a>
{% endfor %}
```

`site.Taxonomies` contains site-wide terms. Each term has `Name`, `Permalink`, `Count`, and `Pages`. Iterating the
collection directly orders terms by descending page count, then by name. In code, the collection also exposes
`ByCount` and `ByName` orderings. In Liquid, use the built-in `sort` filter for alphabetical ordering:

```liquid
{% for tag in site.Taxonomies.tags %}
<a href="{{ tag.Permalink }}">{{ tag.Name }} ({{ tag.Count }})</a>
{% endfor %}
```

```liquid
{% assign tagsByName = site.Taxonomies.tags | sort: 'Name' %}
{% for tag in tagsByName %}
<a href="{{ tag.Permalink }}">{{ tag.Name }}</a>
{% endfor %}
```

The legacy `page.Tags` string list and `page.TagsReference` page list remain available.

## Taxonomy templates

Taxonomy listing pages (e.g. `/tags/`) use `<plural>/taxonomy.html`; term pages use `<plural>/term.html`. These fall
back to `_default/taxonomy.html` and `_default/term.html`. Output formats are controlled by the `taxonomy` and `term`
entries in `KindOutputFormats`.

Term pages expose assigned content through `page.Pages` and `page.RegularPages`:

```liquid
<h1>{{ page.Title }}</h1>
<ul>
{% for post in page.RegularPages %}
  <li><a href="{{ post.Permalink }}">{{ post.Title }}</a></li>
{% endfor %}
</ul>
```
