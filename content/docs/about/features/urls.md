---
Title: URLs & Permalinks
Params:
  hasCode: true
---

Fanstatic generates clean, predictable URLs from your content structure. You can override or extend them per page.

## Default URL pattern

The URL for a page is derived from its file path under `content/`:

| File | Default URL |
|---|---|
| `content/about.md` | `/about/` |
| `content/blog/my-post.md` | `/blog/my-post/` |
| `content/blog/2024/trip.md` | `/blog/2024/trip/` |
| `content/blog/_index.md` | `/blog/` |

All URLs use the "pretty" format — a directory with an `index.html` inside, rather than a `.html` file.

## Overriding the URL

Set `URL` in front matter to use a custom path:

```yaml
---
Title: My Post
URL: /tutorials/getting-started/
---
```

This page will be built at `/tutorials/getting-started/` regardless of where the file lives.

## Aliases

Aliases create redirect pages at old URLs that point to the current page. Use them when you rename or move content to avoid breaking existing links.

```yaml
---
Title: My Post
Aliases:
  - /old-path/my-post
  - /2023/my-post
---
```

Fanstatic generates an HTML redirect file at each alias path:

```html
<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="refresh" content="0; url=/new-path/my-post/" />
</head>
</html>
```

## In templates

Use `page.Permalink` for absolute URLs and `page.RelPermalink` for relative paths:

```liquid
<a href="{{ page.Permalink }}">{{ page.Title }}</a>

<link rel="canonical" href="{{ page.Permalink }}" />

<img src="{{ page.RelPermalink }}hero.jpg" alt="" />
```

`page.Permalink` includes the domain (e.g. `https://example.com/blog/my-post/`).  
`page.RelPermalink` is the path only (e.g. `/blog/my-post/`).
