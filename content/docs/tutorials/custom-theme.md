---
Title: Building a Custom Theme
Weight: 2
Params:
  hasCode: true
---

This tutorial shows you how to build a complete Fanstatic theme from scratch. By the end you'll have a working theme with a navigation bar, styled article pages, a blog listing, tag pages, and an RSS feed.

## Prerequisites

- A Fanstatic site already set up ([Your First Blog](/docs/tutorials/your-first-blog) is a good starting point)
- Basic HTML/CSS knowledge

## 1. Scaffold the theme

From your site root:

```sh
fanstatic new-theme --output ./themes/my-theme --title "My Theme"
```

Activate it in `fanstatic.yaml`:

```yaml
Theme: my-theme
```

## 2. Understand the template hierarchy

Fanstatic resolves templates in this order for each page:

```
themes/my-theme/
  {section}/{kind}.html     ← most specific
  _default/{kind}.html      ← fallback
```

Where `kind` is `home`, `single`, `list`, `taxonomy`, or `term`.

So a page in the `blog` section looks for:
1. `blog/single.html`
2. `_default/single.html`

## 3. Create the base layout

`_default/baseof.html` is the outer HTML skeleton used by all pages. The `{{ page.Content }}` tag is where Fanstatic injects the rendered output of the matched template (`single.html`, `list.html`, etc.).

```liquid
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>{{ page.Title }} — {{ site.Title }}</title>
    <meta name="description" content="{{ site.Description }}" />
    <link rel="canonical" href="{{ page.Permalink }}" />
    <link rel="stylesheet" href="/style.css" />
    {% for fmt in page.OutputFormats %}
    {% if fmt == 'rss' %}
    <link rel="alternate" type="application/rss+xml"
          href="{{ page.Permalink }}index.xml"
          title="{{ site.Title }}" />
    {% endif %}
    {% endfor %}
</head>
<body>
    {% render 'partials/header.html' %}

    <main id="main">
        {{ page.Content }}
    </main>

    {% render 'partials/footer.html' %}
    <script src="/main.js" defer></script>
</body>
</html>
```

## 4. Create the header partial

Create `partials/header.html`:

```liquid
<header class="site-header">
    <div class="container">
        <a href="/" class="site-logo">{{ site.Title }}</a>

        <nav class="site-nav">
            {% for item in site.Params.MainMenu %}
            <a href="{{ item.url }}"
               {% if page.RelPermalink == item.url %}class="active"{% endif %}>
                {{ item.label }}
            </a>
            {% endfor %}
        </nav>
    </div>
</header>
```

Add the menu to `fanstatic.yaml`:

```yaml
Params:
  MainMenu:
    - url: /blog/
      label: Blog
    - url: /about/
      label: About
```

## 5. Create the footer partial

Create `partials/footer.html`:

```liquid
<footer class="site-footer">
    <div class="container">
        <p>{{ site.Copyright }}</p>
        <p>{{ site.Params.Footer }}</p>
    </div>
</footer>
```

## 6. Home page template

Create `_default/home.html`:

```liquid
<section class="hero">
    <h1>{{ site.Title }}</h1>
    <p>{{ site.Description }}</p>
    <a href="/blog/" class="btn">Read the Blog</a>
</section>

<section class="recent">
    <h2>Recent Posts</h2>
    {% assign posts = site.RegularPages | where: 'Section', 'blog' | sort: 'Date' | reverse %}
    <div class="post-grid">
    {% for post in posts limit: 6 %}
        <article class="post-card">
            <a href="{{ post.Permalink }}">
                <h3>{{ post.Title }}</h3>
            </a>
            <time>{{ post.Date | date: '%B %d, %Y' }}</time>
        </article>
    {% endfor %}
    </div>
    <a href="/blog/">All posts →</a>
</section>
```

## 7. Single page template

Create `_default/single.html`:

```liquid
<article class="post">
    <header class="post-header">
        <h1>{{ page.Title }}</h1>
        <div class="post-meta">
            <time datetime="{{ page.Date | date: '%Y-%m-%d' }}">
                {{ page.Date | date: '%B %d, %Y' }}
            </time>
            {% if page.Tags %}
            <div class="tags">
                {% for tag in page.Tags %}
                <a href="{{ tag.Permalink }}" class="tag">{{ tag.Title }}</a>
                {% endfor %}
            </div>
            {% endif %}
        </div>
    </header>

    <div class="post-content">
        {{ page.ContentPreRendered }}
    </div>

    <footer class="post-footer">
        <a href="/blog/">← Back to Blog</a>
    </footer>
</article>
```

## 8. List page template with pagination

Create `_default/list.html`:

```liquid
<div class="page-header">
    <h1>{{ page.Title }}</h1>
    {% if page.ContentPreRendered %}
    {{ page.ContentPreRendered }}
    {% endif %}
</div>

{% assign sorted = page.Pages | sort: 'Date' | reverse %}
{% assign pager = sorted | paginate: 10 %}

<div class="post-list">
{% for post in pager.PageItems %}
    <article class="post-item">
        <h2><a href="{{ post.Permalink }}">{{ post.Title }}</a></h2>
        <time>{{ post.Date | date: '%B %d, %Y' }}</time>
        {% if post.Tags %}
        <div class="tags">
            {% for tag in post.Tags %}
            <a href="{{ tag.Permalink }}" class="tag">{{ tag.Title }}</a>
            {% endfor %}
        </div>
        {% endif %}
    </article>
{% endfor %}
</div>

{% render 'partials/pagination.html', pager: pager %}
```

## 9. Taxonomy and term templates

Create `_default/taxonomy.html` (the `/tags/` index):

```liquid
<h1>{{ page.Title }}</h1>
<ul class="tag-list">
{% assign tags = page.Pages | sort: 'Title' %}
{% for tag in tags %}
    <li>
        <a href="{{ tag.Permalink }}">{{ tag.Title }}</a>
        <span class="count">({{ tag.Pages | size }})</span>
    </li>
{% endfor %}
</ul>
```

Create `_default/term.html` (individual tag pages like `/tags/tutorial/`):

```liquid
<h1>Posts tagged: {{ page.Title }}</h1>
{% assign sorted = page.Pages | sort: 'Date' | reverse %}
<ul class="post-list">
{% for post in sorted %}
    <li>
        <a href="{{ post.Permalink }}">{{ post.Title }}</a>
        <time>{{ post.Date | date: '%Y-%m-%d' }}</time>
    </li>
{% endfor %}
</ul>
```

## 10. RSS feed template

Create `_default/list.xml`:

```liquid
<?xml version="1.0" encoding="utf-8" standalone="yes"?>
<rss version="2.0" xmlns:atom="http://www.w3.org/2005/Atom">
  <channel>
    <title>{{ page.Title | append: ' — ' | append: site.Title }}</title>
    <link>{{ page.Permalink }}</link>
    <description>{{ site.Description }}</description>
    <language>en-us</language>
    <atom:link href="{{ page.Permalink }}index.xml" rel="self" type="application/rss+xml" />
    {% assign posts = page.Pages | sort: 'Date' | reverse %}
    {% for post in posts limit: 20 %}
    <item>
      <title>{{ post.Title }}</title>
      <link>{{ post.Permalink }}</link>
      <guid>{{ post.Permalink }}</guid>
      <pubDate>{{ post.Date | date: '%a, %d %b %Y 00:00:00 +0000' }}</pubDate>
      <description>{{ post.Plain | truncate: 500 }}</description>
    </item>
    {% endfor %}
  </channel>
</rss>
```

## 11. Add CSS

Create `static/style.css`. A minimal starting point:

```css
*, *::before, *::after { box-sizing: border-box; margin: 0; }

:root {
    --bg: #fff;
    --text: #111;
    --muted: #666;
    --accent: #0055cc;
    --border: #e0e0e0;
    --max-width: 720px;
}

body {
    font-family: system-ui, sans-serif;
    color: var(--text);
    background: var(--bg);
    line-height: 1.7;
}

.container { max-width: var(--max-width); margin: 0 auto; padding: 0 1.5rem; }

/* Header */
.site-header { border-bottom: 1px solid var(--border); padding: 1rem 0; }
.site-header .container { display: flex; align-items: center; justify-content: space-between; }
.site-logo { font-weight: 700; text-decoration: none; color: inherit; }
.site-nav { display: flex; gap: 1.5rem; }
.site-nav a { text-decoration: none; color: var(--muted); }
.site-nav a.active, .site-nav a:hover { color: var(--text); }

/* Main */
main { max-width: var(--max-width); margin: 3rem auto; padding: 0 1.5rem; }

/* Hero */
.hero { margin-bottom: 4rem; }
.hero h1 { font-size: 2.5rem; margin-bottom: 0.5rem; }
.hero p { color: var(--muted); font-size: 1.1rem; margin-bottom: 1.5rem; }

/* Post grid */
.post-grid { display: grid; grid-template-columns: repeat(auto-fill, minmax(280px, 1fr)); gap: 1.5rem; margin-bottom: 2rem; }
.post-card { border: 1px solid var(--border); border-radius: 8px; padding: 1.25rem; }
.post-card h3 { font-size: 1rem; margin-bottom: 0.5rem; }
.post-card a { text-decoration: none; color: inherit; }
.post-card a:hover { text-decoration: underline; }

/* Post */
.post-header { margin-bottom: 2rem; border-bottom: 1px solid var(--border); padding-bottom: 1rem; }
.post-header h1 { font-size: 2rem; margin-bottom: 0.5rem; }
.post-meta { color: var(--muted); font-size: 0.875rem; display: flex; gap: 1rem; flex-wrap: wrap; align-items: center; }
.post-content { max-width: 65ch; }
.post-content h2 { margin: 2rem 0 0.75rem; }
.post-content p { margin-bottom: 1rem; }
.post-content pre { background: #f5f5f5; padding: 1rem; border-radius: 6px; overflow-x: auto; margin-bottom: 1rem; }
.post-content code { font-size: 0.875rem; }
.post-content p code { background: #f0f0f0; padding: 2px 4px; border-radius: 3px; }

/* Post list */
.post-item { border-bottom: 1px solid var(--border); padding: 1.25rem 0; }
.post-item h2 { font-size: 1.15rem; margin-bottom: 0.25rem; }
.post-item a { text-decoration: none; color: inherit; }
.post-item a:hover { text-decoration: underline; }
.post-item time { color: var(--muted); font-size: 0.875rem; }

/* Tags */
.tags { display: flex; gap: 0.5rem; flex-wrap: wrap; }
.tag { background: #f0f0f0; color: var(--muted); padding: 2px 8px; border-radius: 4px; font-size: 0.8rem; text-decoration: none; }
.tag:hover { background: #e0e0e0; }

/* Footer */
.site-footer { border-top: 1px solid var(--border); padding: 2rem 0; color: var(--muted); font-size: 0.875rem; text-align: center; margin-top: 4rem; }

/* Button */
.btn { display: inline-block; background: var(--accent); color: #fff; padding: 0.5rem 1.25rem; border-radius: 6px; text-decoration: none; font-weight: 500; }
.btn:hover { opacity: 0.9; }

time { color: var(--muted); font-size: 0.875rem; }
```

## 12. Preview

```sh
fanstatic serve
```

Visit **http://localhost:2341** to see your theme. Any file you edit in `themes/` or `content/` triggers an automatic rebuild.

## Theme configuration

Your theme can have its own `fanstatic.yaml` for defaults:

```yaml
Title: My Theme
```

This is useful for documenting the theme and providing default Params that sites can override.

## Overriding built-in partials

Fanstatic includes built-in partials for common functionality. Override them by creating a file at the same path in your theme:

| Built-in | Path to override |
|---|---|
| Pagination nav | `partials/pagination.html` |
| Sitemap | `_default/sitemap.xml` |

## Next steps

- [Deploy to GitLab Pages](/docs/installation/gitlab)
- [Output formats](/docs/concepts/output-formats) — RSS, sitemaps, custom formats
- [Page variables reference](/docs/theme/variables/page) — all available template variables
