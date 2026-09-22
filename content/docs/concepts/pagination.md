---
Title: Pagination
Weight: 2
Params:
  hasCode: true
---

Pagination splits a list of content across multiple pages. Fanstatic provides first-class pagination through the `paginate` Liquid filter and the `page.Paginator` object.

## How pagination works

Pagination in Fanstatic is template-driven: the theme template decides whether to paginate and how many items to show per page. Content authors don't need to configure anything.

When a template calls `| paginate: N`, Fanstatic:

1. Slices the provided list into pages of N items each
2. Creates virtual pages (e.g. `/blog/page/2/`, `/blog/page/3/`) for pages beyond the first
3. Exposes a `Pager` object the template uses to render navigation

## Basic example

```liquid
{% comment %} themes/my-theme/_default/list.html {% endcomment %}

{% assign sorted = page.Pages | sort: 'Date' | reverse %}
{% assign pager = sorted | paginate: 10 %}

{% for post in pager.PageItems %}
<article>
    <h2><a href="{{ post.Permalink }}">{{ post.Title }}</a></h2>
    <time>{{ post.Date | date: '%B %d, %Y' }}</time>
</article>
{% endfor %}

{% render 'partials/pagination.html', pager: pager %}
```

`pager.PageItems` contains only the items for the current page — the filtering happens automatically based on the current URL.

### Automatic pagination

If you omit the number of items, Fanstatic uses the `Paginate` value from your `fanstatic.yaml`:

```liquid
{% assign pager = sorted | paginate %}
```

## The Pager object
...
## Pagination Performance

Fanstatic is optimized for large paginated collections. Since v6.5.0, several caching layers ensure that even sites with thousands of pages remain fast:

- **Template Caching**: Compiled Fluid templates are cached, so the pagination logic doesn't need to be re-parsed for every sub-page.
- **Content Caching**: Rendered HTML for each page is cached, preventing Markdig from re-processing the same content across different paginated views.
- **Memory Efficiency**: Fanstatic uses optimized data structures like `FrozenDictionary` for internal lookups, keeping memory usage low during large builds.

The `paginate` filter returns a `Pager` with these properties:

| Property | Type | Description |
|---|---|---|
| `PageItems` | page list | Items for the current page |
| `Current` | int | Current page number (1-based) |
| `Count` | int | Total number of pages |
| `First` | string | URL of the first page |
| `Last` | string | URL of the last page |
| `Prev` | string | URL of the previous page (`nil` on page 1) |
| `Next` | string | URL of the next page (`nil` on last page) |
| `Pages` | int list | All page numbers (useful for numbered nav) |
| `BaseUrl` | string | Base URL without the page segment |
| `PaginatePath` | string | URL segment (default: `page`) |

## Configuring defaults

Set defaults in `fanstatic.yaml`:

```yaml
Paginate: 10        # items per page
PaginatePath: page  # URL segment: /blog/page/2/
```

These are the defaults; you can override items-per-page per template by passing a different number to the filter.

Also available in templates:

```liquid
{{ site.Paginate }}
{{ site.PaginatePath }}
```

## Built-in pagination partial

Fanstatic ships a built-in `partials/pagination.html` that renders previous/next navigation. Use it with:

```liquid
{% render 'partials/pagination.html', pager: pager %}
```

Output (simplified):

```html
<nav>
  <a href="/blog/">← Previous</a>
  <a href="/blog/page/2/">Next →</a>
</nav>
```

## Custom pagination navigation

Override the built-in partial by creating `themes/my-theme/partials/pagination.html`:

```liquid
{% if pager.Count > 1 %}
<nav class="pagination" aria-label="Page navigation">
    {% if pager.Prev %}
    <a href="{{ pager.Prev }}" class="btn">← Previous</a>
    {% endif %}

    <span>Page {{ pager.Current }} of {{ pager.Count }}</span>

    {% if pager.Next %}
    <a href="{{ pager.Next }}" class="btn">Next →</a>
    {% endif %}
</nav>
{% endif %}
```

## Numbered pagination

Use `pager.Pages` to render a numbered nav bar:

```liquid
<nav class="pagination">
    {% for num in pager.Pages %}
    {% if num == pager.Current %}
    <span class="current">{{ num }}</span>
    {% else %}
    {% if num == 1 %}
    <a href="{{ pager.BaseUrl }}">{{ num }}</a>
    {% else %}
    <a href="{{ pager.BaseUrl }}{{ site.PaginatePath }}/{{ num }}/">{{ num }}</a>
    {% endif %}
    {% endif %}
    {% endfor %}
</nav>
```

## URL structure

With the default `PaginatePath: page` and a blog at `/blog/`:

| Page | URL |
|---|---|
| First page | `/blog/` |
| Second page | `/blog/page/2/` |
| Third page | `/blog/page/3/` |

The first page always uses the section's base URL, not `/blog/page/1/`.

## Pagination across sections

Paginate any collection, not just the current page's children:

```liquid
{% assign allPosts = site.RegularPages | where: 'Section', 'blog' | sort: 'Date' | reverse %}
{% assign pager = allPosts | paginate: 5 %}
```

This is useful for home pages that paginate across the entire blog.
