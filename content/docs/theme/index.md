---
Title: Theming
Weight: 5
Params:
  hasCode: true
---

Fanstatic themes are directories of [Liquid](https://shopify.github.io/liquid/) templates and static assets. A theme tells Fanstatic how to render your content as HTML.

## Theme structure

```
themes/my-theme/
├── _default/
│   ├── baseof.html      ← outer shell (html, head, body)
│   ├── single.html      ← regular pages
│   ├── list.html        ← section and taxonomy list pages
│   ├── home.html        ← site home page
│   ├── taxonomy.html    ← tag/category index (e.g. /tags/)
│   └── term.html        ← individual tag pages (e.g. /tags/tutorial/)
├── partials/            ← reusable template fragments
│   ├── header.html
│   └── footer.html
├── static/              ← CSS, JS, images served from site root
└── fanstatic.yaml           ← theme metadata
```

## Template lookup

Fanstatic resolves which template to use in this order:

1. Type-specific template (e.g. `blog/single.html`)
2. Kind-specific template (e.g. `_default/single.html`)
3. Base template (`_default/baseof.html`)

If a template isn't found in the theme, Fanstatic falls back to its built-in defaults.

## The `baseof.html` template

`baseof.html` wraps every page. It should contain the full HTML document skeleton:

```liquid
<!DOCTYPE html>
<html lang="en">
<head>
    <title>{{ page.Title }} — {{ site.Title }}</title>
    <meta charset="UTF-8" />
    <link rel="stylesheet" href="/style.css" />
</head>
<body>
    {% render 'partials/header.html' %}

    <main>
        {{ page.Content }}
    </main>

    {% render 'partials/footer.html' %}
</body>
</html>
```

## The `single.html` template

Rendered for regular content pages. `{{ page.Content }}` outputs the Markdown converted to HTML:

```liquid
<article>
    <h1>{{ page.Title }}</h1>
    <time>{{ page.Date | date: '%B %d, %Y' }}</time>
    {{ page.ContentPreRendered }}
</article>
```

## The `list.html` template

Rendered for section pages. `page.Pages` contains child pages:

```liquid
<h1>{{ page.Title }}</h1>
<ul>
{% assign sorted = page.Pages | sort: 'Date' | reverse %}
{% for post in sorted %}
    <li>
        <a href="{{ post.Permalink }}">{{ post.Title }}</a>
        <time>{{ post.Date | date: '%Y-%m-%d' }}</time>
    </li>
{% endfor %}
</ul>
```

## Partials

Partials are reusable template fragments. Include them with `{% render %}`:

```liquid
{% render 'partials/header.html' %}

{% comment %} Pass variables to a partial {% endcomment %}
{% render 'partials/card.html', post: post %}
```

## Static assets

Files in `themes/my-theme/static/` are copied to the site root during build. `themes/my-theme/static/style.css` becomes `/style.css`.

## Liquid reference

Fanstatic uses the [Fluid](https://github.com/sebastienros/fluid) Liquid engine. The full Liquid syntax reference is at [shopify.github.io/liquid](https://shopify.github.io/liquid/).

For all available template variables, see:
- [Page variables](/docs/theme/variables/page)
- [Site variables](/docs/theme/variables/site)
