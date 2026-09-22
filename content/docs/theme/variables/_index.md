---
Title: Template Variables
---

Fanstatic provides two objects in every Liquid template: `page` and `site`.

**`page`** — properties of the current page being rendered. Changes for every page.

**`site`** — site-wide configuration and the full content collection. Same on every page.

## Quick reference

```liquid
{{ page.Title }}          ← current page title
{{ page.Permalink }}      ← absolute URL
{{ page.Date | date: '%Y-%m-%d' }}   ← formatted date
{{ page.ContentPreRendered }}         ← Markdown rendered to HTML

{{ site.Title }}          ← site name from fanstatic.yaml
{{ site.Params.Logo }}    ← custom param from fanstatic.yaml

{% for post in site.RegularPages %}  ← iterate all pages
{% endfor %}
```

For the full lists, see:

- [Page variables](/docs/theme/variables/page) — all `page.*` properties
- [Site variables](/docs/theme/variables/site) — all `site.*` properties
