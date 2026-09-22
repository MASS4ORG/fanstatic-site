---
Title: What is a Static Site Generator?
---

A static site generator (SSG) transforms content files — usually Markdown — into a complete website made of plain HTML, CSS, and JavaScript. The output has no server-side code: visitors receive pre-built files directly from a CDN or web server.

## Static vs. dynamic

A traditional dynamic site (WordPress, Django, Rails) builds each page on demand:

1. Browser requests `/blog/my-post`
2. Server queries the database
3. Server renders the template
4. Server returns HTML

Every request carries that overhead. A static site skips all of it:

1. You run `fanstatic build` once on your machine
2. Fanstatic writes out every page as an HTML file
3. You upload the files to any host
4. Browser requests `/blog/my-post` → instant file response

## Why choose static?

**Performance** — A file served from a CDN edge node loads in tens of milliseconds. Dynamic sites routinely spend 100–500 ms just on server processing before a byte reaches the browser.

**Security** — No database, no PHP/Ruby/Python runtime, no login endpoints. The attack surface shrinks to the web server itself.

**Cost** — Static hosting (GitLab Pages, Cloudflare Pages, GitHub Pages, Netlify) is free or near-free. You're not paying for CPU cycles on every page view.

**Reliability** — No dynamic failures, no "database connection refused" at 2 AM.

**Version control** — Content is plain files in a Git repo. Every change is tracked, reversible, and reviewable.

## When static isn't enough

Static sites don't fit every scenario:

- **User authentication** — login systems need a server (though you can combine static with a headless auth provider)
- **Real-time content** — live feeds, chat, collaborative editing require a persistent connection
- **Complex forms with server logic** — contact forms can use third-party services, but anything more involved needs a backend

For most content-oriented sites — blogs, documentation, portfolios, marketing pages — static is the right default.

## Where Fanstatic fits

Fanstatic is a static site generator targeting .NET developers. It compiles your Markdown content and Liquid templates into a static website. The build runs in seconds, and the result can be deployed to any host that serves static files.

→ [Get started with Fanstatic](/docs)
