---
Title: Page Resources
Params:
  hasCode: true
---

A **page bundle** groups a page together with the files that belong to it — images, PDFs, data files, audio, anything. Those accompanying files are called **page resources**. Fanstatic copies every resource to the output, right next to the page that owns it, so you can reference them with simple relative paths.

## Creating a bundle

Turn a single Markdown file into a bundle by giving the page its own directory and naming the Markdown file `index.md`:

```
content/blog/introducing-turian/
├── index.md
└── cover.webp
```

The directory becomes the page URL `/blog/introducing-turian/`, and `cover.webp` is published alongside it at `/blog/introducing-turian/cover.webp`.

Every file in the directory other than `index.md` is treated as a resource and copied automatically — you don't need to list them anywhere.

```
content/blog/introducing-turian/
├── index.md
├── cover.webp        →  /blog/introducing-turian/cover.webp
├── diagram.png       →  /blog/introducing-turian/diagram.png
└── data.csv          →  /blog/introducing-turian/data.csv
```

## Referencing resources in Markdown

Because resources are published in the same directory as the page, you reference them with a **relative path** — just the filename:

```markdown
![Cover](cover.webp)

[Download the data](data.csv)
```

These resolve correctly in the browser: the page lives at `/blog/introducing-turian/` and `cover.webp` at `/blog/introducing-turian/cover.webp`, so the relative link points to the right place. No need to hard-code the full path or worry about the site's base URL.

## Leaf bundles vs. branch bundles

The bundle type determines what counts as a resource.

| Bundle | Marker file | Resources |
|---|---|---|
| **Leaf** | `index.md` | Every other file in the directory, **including** other `.md` files |
| **Branch** | `_index.md` | Every non-Markdown file in the directory; other `.md` files become child **pages** |

A leaf bundle (`index.md`) is a single, self-contained page — it has no children, so everything beside it is a resource. A branch bundle (`_index.md`) is a section that lists child pages, so its Markdown files are rendered as their own pages while images and other assets still travel with the section.

```
content/gallery/            ← branch bundle
├── _index.md               → /gallery/        (section list page)
├── banner.jpg              → /gallery/banner.jpg   (resource)
├── sunset.md               → /gallery/sunset/      (child page)
└── sunrise.md              → /gallery/sunrise/     (child page)
```

## Accessing resources in templates

Each page exposes its resources through `page.Resources`. Iterate over them in a template to build galleries, attachment lists, or pick out a specific file:

```liquid
{% for resource in page.Resources %}
  <img src="{{ resource.RelPermalink }}" alt="{{ resource.Title }}">
{% endfor %}
```

Each resource provides:

| Property | Description |
|---|---|
| `RelPermalink` | URL path of the published resource, e.g. `/blog/introducing-turian/cover.webp` |
| `Permalink` | Absolute URL, including the site's base URL |
| `Title` | Display title; defaults to the original filename |
| `Params` | Map of custom values (see below) |

## Customizing resources

You can attach metadata to resources from the page's front matter with `resourceDefinitions`. Match files by name or glob with `src`, then override the published filename or attach metadata:

```yaml
---
Title: Introducing Turian
resourceDefinitions:
  - src: "cover.webp"
    name: "hero"
    title: "Turian cover art"
    params:
      alt: "The Turian mascot waving"
  - src: "*.png"
    params:
      lazy: true
---
```

Each definition accepts:

| Field | Description |
|---|---|
| `src` | Filename or glob (e.g. `*.png`) matched against the page's resources |
| `name` | Renames the published file. `hero` above publishes `cover.webp` as `hero.webp` |
| `title` | Sets the resource's `Title` (otherwise the original filename) |
| `params` | Arbitrary metadata exposed as `resource.Params` in templates |

`name` and `title` are rendered as templates, so they can include values like `{{ page.Title }}`. The original file extension is always preserved.

Those values are then available on the matching resources in your templates:

```liquid
{% for resource in page.Resources %}
  <img src="{{ resource.RelPermalink }}"
       alt="{{ resource.Params.alt }}"
       {% if resource.Params.lazy %}loading="lazy"{% endif %}>
{% endfor %}
```

Resources without a matching `resourceDefinitions` entry are still published — the definitions only add metadata, they are never required to get a file copied.
