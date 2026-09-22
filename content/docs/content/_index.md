---
Title: Content
Weight: 2
Params:
  hasCode: true
---

Content in Fanstatic is Markdown files in the `content/` directory. The directory layout maps directly to URL structure, and YAML front matter at the top of each file provides metadata.

## Directory structure

```
content/
├── _index.md            → / (home page)
├── about.md             → /about/
├── blog/
│   ├── _index.md        → /blog/ (section list page)
│   ├── first-post.md    → /blog/first-post/
│   └── 2024/
│       └── trip.md      → /blog/2024/trip/
└── docs/
    ├── _index.md        → /docs/
    └── getting-started.md  → /docs/getting-started/
```

`_index.md` files define **section** pages (list pages that group child content). Any other `.md` file is a **regular** page rendered with your `single.html` template.

## Front matter

Every Markdown file can open with a YAML front matter block:

```yaml
---
Title: My First Post
Date: 2026-01-15
Tags:
  - tutorial
  - beginner
Draft: false
---

Your Markdown content starts here.
```

Key fields:

| Field | Description |
|---|---|
| `Title` | Page heading; used in templates and `<title>` tags |
| `Date` | Publication date; pages with future dates are excluded by default |
| `Tags` | List of tags; creates tag pages automatically |
| `Draft` | Set to `true` to exclude from normal builds |
| `Weight` | Integer used for manual ordering within a section |
| `Params` | Map of any custom values you want available in templates |

For the complete reference, see [Page front matter](/docs/content/page).

## Drafts

Set `Draft: true` to hide a page from normal builds and the serve output:

```yaml
---
Title: Work in Progress
Draft: true
---
```

Preview drafts locally with:

```sh
fanstatic serve --draft
```

## Page bundles

You can group a page with its own resources (images, PDFs, data files) by creating a directory with an `index.md`:

```
content/blog/my-post/
├── index.md
├── hero.jpg
└── data.csv
```

The directory becomes `/blog/my-post/` and the assets are available at `/blog/my-post/hero.jpg`. You can reference them from the Markdown with plain relative paths like `![](hero.jpg)`.

For the full reference — leaf vs. branch bundles, template access, and resource metadata — see [Page resources](/docs/content/page-resources).
