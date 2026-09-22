---
Title: Page Front Matter Reference
Params:
  hasCode: true
---

Every Markdown file in `content/` can include a YAML front matter block between `---` delimiters at the top of the file. These fields control how Fanstatic processes and renders the page.

## Example

```yaml
---
Title: Building a Blog with Fanstatic
Date: 2026-03-10
PublishDate: 2026-03-10
ExpiryDate: 2027-03-10
Tags:
  - tutorial
  - blog
Type: blog
Draft: false
Weight: 10
Aliases:
  - /old-url/building-blog
URL: /tutorials/building-a-blog
Params:
  Author: "Jane Smith"
  HeroImage: "/images/hero.jpg"
---

Page content here...
```

## Fields

### Title

The page's display title. Used in templates as `{{ page.Title }}`, in browser tab titles, and in list pages.

### Date

The content date. Typically used as the publish date for blog posts. Pages with a future `Date` are excluded from builds unless you pass `--future`.

```yaml
Date: 2026-03-10
```

### PublishDate

The date the content should become publicly visible. Defaults to `Date` if not set.

### ExpiryDate

After this date, the page is excluded from builds unless you pass `--expired`.

### Lastmod

The date of the last meaningful edit. Does not affect visibility — used for display and sitemaps.

### Tags

A list of tags. Fanstatic automatically generates a `/tags/` section with a page for each unique tag.

```yaml
Tags:
  - tutorial
  - beginner
```

### Draft

When `true`, the page is excluded from normal builds and `fanstatic serve`. Use `fanstatic build --draft` or `fanstatic serve --draft` to include drafts.

### Weight

An integer used to sort pages within a section. Lower weight comes first. Useful for documentation pages where alphabetical or date order isn't right.

### Type

The content type. Defaults to the section name. Used for template lookup — a page with `Type: landing` will first look for a `landing/single.html` template before falling back to `_default/single.html`.

### URL

Overrides the computed URL for this page.

```yaml
URL: /tutorials/building-a-blog/
```

### Aliases

A list of old URLs that should redirect to this page. Fanstatic creates HTML redirect files at each alias path.

```yaml
Aliases:
  - /old-path/my-post
  - /another/old-url
```

### Params

A map of custom key-value pairs. Access them in templates with `{{ page.Params.myKey }}`. Useful for per-page metadata that doesn't fit standard fields.

```yaml
Params:
  HeroImage: "/images/hero.jpg"
  ReadingTime: 5
  ShowComments: true
```
