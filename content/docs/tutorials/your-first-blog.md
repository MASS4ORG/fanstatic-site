---
Title: Your First Blog
Weight: 1
Params:
  hasCode: true
---

This tutorial walks you through building a complete blog with Fanstatic — from an empty directory to a styled, paginated site with an RSS feed. It takes about 15 minutes.

## Prerequisites

- Fanstatic installed ([installation guide](/docs/installation))
- A text editor
- Basic familiarity with Markdown

## 1. Create the site

```sh
fanstatic new-site ./my-blog --title "My Blog" --url "https://myblog.example.com"
cd my-blog
```

Your directory looks like this:

```
my-blog/
├── content/
├── static/
├── themes/
└── fanstatic.yaml
```

## 2. Create a theme

```sh
fanstatic new-theme --output ./themes/blog-theme --title "Blog Theme"
```

Activate it in `fanstatic.yaml`:

```yaml
Theme: blog-theme
```

## 3. Build the base layout

Edit `themes/blog-theme/_default/baseof.html`:

```liquid
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>{{ page.Title }} — {{ site.Title }}</title>
    <meta name="description" content="{{ site.Description }}" />
    <link rel="stylesheet" href="/style.css" />
    <link rel="alternate" type="application/rss+xml" href="/blog/index.xml" title="{{ site.Title }}" />
</head>
<body>
    <header>
        <nav>
            <a href="/" class="site-title">{{ site.Title }}</a>
            <a href="/blog/">Blog</a>
            <a href="/about/">About</a>
        </nav>
    </header>

    <main>
        {{ page.Content }}
    </main>

    <footer>
        <p>{{ site.Copyright }}</p>
    </footer>
</body>
</html>
```

## 4. Build the home page

Edit `themes/blog-theme/_default/home.html`:

```liquid
<section class="hero">
    <h1>{{ site.Title }}</h1>
    <p>{{ site.Description }}</p>
</section>

<section class="recent-posts">
    <h2>Recent Posts</h2>
    {% assign posts = site.RegularPages | where: 'Section', 'blog' | sort: 'Date' | reverse %}
    <ul>
    {% for post in posts limit: 5 %}
        <li>
            <a href="{{ post.Permalink }}">{{ post.Title }}</a>
            <time>{{ post.Date | date: '%B %d, %Y' }}</time>
        </li>
    {% endfor %}
    </ul>
    <a href="/blog/">All posts →</a>
</section>
```

## 5. Build the single post template

Edit `themes/blog-theme/_default/single.html`:

```liquid
<article>
    <header>
        <h1>{{ page.Title }}</h1>
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
    </header>

    <div class="content">
        {{ page.ContentPreRendered }}
    </div>
</article>
```

## 6. Build the blog list with pagination

Edit `themes/blog-theme/_default/list.html`:

```liquid
<h1>{{ page.Title }}</h1>

{% assign sorted = page.Pages | sort: 'Date' | reverse %}
{% assign pager = sorted | paginate: 10 %}

<ul class="post-list">
{% for post in pager.PageItems %}
    <li>
        <a href="{{ post.Permalink }}">{{ post.Title }}</a>
        <time>{{ post.Date | date: '%B %d, %Y' }}</time>
        {% if post.Tags %}
        <span class="tags">
            {% for tag in post.Tags %}
            <a href="{{ tag.Permalink }}">{{ tag.Title }}</a>
            {% endfor %}
        </span>
        {% endif %}
    </li>
{% endfor %}
</ul>

{% render 'partials/pagination.html', pager: pager %}
```

## 7. Add some content

Create `content/blog/_index.md`:

```markdown
---
Title: Blog
---
```

Create your first post at `content/blog/hello-world.md`:

```markdown
---
Title: Hello, World!
Date: 2026-04-24
Tags:
  - personal
---

Welcome to my blog. This is my first post.

I built this with [Fanstatic](https://fanstatic.brunomassa.com), a static site generator
written in C#. It was surprisingly easy to set up.
```

Add a second post at `content/blog/what-i-learned.md`:

```markdown
---
Title: What I Learned This Week
Date: 2026-04-17
Tags:
  - learning
  - weekly
---

Here's a quick summary of what I picked up this week...
```

## 8. Add an about page

Create `content/about.md`:

```markdown
---
Title: About
---

Hi! I'm writing about things I find interesting.
```

## 9. Add basic CSS

Create `themes/blog-theme/static/style.css`:

```css
*, *::before, *::after { box-sizing: border-box; }

body {
    font-family: system-ui, sans-serif;
    max-width: 720px;
    margin: 0 auto;
    padding: 2rem 1rem;
    color: #222;
    line-height: 1.7;
}

header nav { display: flex; gap: 1.5rem; margin-bottom: 3rem; }
header nav a { text-decoration: none; color: inherit; }
.site-title { font-weight: 700; }

h1 { font-size: 2rem; margin-bottom: 0.5rem; }
time { color: #666; font-size: 0.875rem; }

.post-list { list-style: none; padding: 0; }
.post-list li { border-bottom: 1px solid #eee; padding: 1rem 0; }
.post-list a { font-size: 1.1rem; text-decoration: none; color: inherit; font-weight: 600; }
.post-list a:hover { text-decoration: underline; }

.tag { background: #f0f0f0; padding: 2px 8px; border-radius: 4px; font-size: 0.8rem; margin-right: 4px; text-decoration: none; color: inherit; }

footer { margin-top: 4rem; color: #888; font-size: 0.875rem; }
```

## 10. Preview and build

```sh
# Preview with live reload
fanstatic serve

# Build for production
fanstatic build
```

Open **http://localhost:2341** to see your blog. The `/blog/` page lists all posts. Each post page shows the content with tags. The home page shows the 5 most recent posts.

## What you've built

- A complete blog with a home page, post listing, individual post pages, and an about page
- Pagination on the blog listing (10 posts per page by default)
- RSS feed automatically generated at `/blog/index.xml`
- Sitemap at `/sitemap.xml`
- Tag pages at `/tags/<tag-name>/`

## Next steps

- [Deploy to GitLab Pages](/docs/installation/gitlab)
- [Custom theme tutorial](/docs/tutorials/custom-theme) — take the theme further
- [Page front matter reference](/docs/content/page) — explore all available fields
