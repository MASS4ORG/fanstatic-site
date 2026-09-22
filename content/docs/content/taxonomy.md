---
Title: Taxonomies
Params:
  hasCode: true
---

Taxonomies let you group and cross-reference content. The most common taxonomy is **Tags**. Fanstatic automatically generates list pages for each taxonomy term.

## Tags

Add `Tags` to any page's front matter:

```yaml
---
Title: Getting Started with Fanstatic
Tags:
  - tutorial
  - beginner
---
```

Fanstatic automatically creates:

- `/tags/` — list of all tags
- `/tags/tutorial/` — list of pages tagged `tutorial`
- `/tags/beginner/` — list of pages tagged `beginner`

## Linking to tag pages

From any template, you can link to a page's tags:

```liquid
{% for tag in page.Tags %}
<a href="{{ tag.Permalink }}">{{ tag.Title }}</a>
{% endfor %}
```

## Listing all tags on a page

To build a tag cloud or nav, iterate over all tag pages:

```liquid
{% assign tags = site.RegularPages | where: 'Section', 'tags' | sort: 'Title' %}
{% for tag in tags %}
<a href="{{ tag.Permalink }}">{{ tag.Title }} ({{ tag.Pages | size }})</a>
{% endfor %}
```

## Tag page templates

Tag term pages (e.g. `/tags/tutorial/`) use the `term.html` template. The taxonomy index page (`/tags/`) uses `taxonomy.html`. Both templates have access to `page.Pages`, which contains all pages with that tag.

Example `term.html`:

```liquid
<h1>Posts tagged: {{ page.Title }}</h1>
<ul>
{% for post in page.Pages %}
  <li><a href="{{ post.Permalink }}">{{ post.Title }}</a></li>
{% endfor %}
</ul>
```
