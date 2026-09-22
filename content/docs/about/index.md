---
Title: Introduction
Weight: -10
---

Fanstatic is a static site generator (SSG) written in C# and targeting .NET. It reads Markdown files and a YAML configuration, then outputs a complete static website you can host anywhere — no server runtime, no database.

The name stands for **Su**per **Co**ol **S**tatic Sites. It follows Hugo's conventions closely, so if you've used Hugo before, you'll feel at home.

## How it works

When you run `fanstatic build`, Fanstatic:

1. Scans your `content/` directory for Markdown files
2. Parses YAML front matter from each file
3. Renders Markdown to HTML using Markdig
4. Applies your Liquid theme templates
5. Writes the finished HTML (plus RSS, sitemap, etc.) to `public/`

Nothing runs at request time. Visitors receive pre-built files served by a plain HTTP server, which means fast load times and minimal infrastructure.

## Who is Fanstatic for?

**Developers** who want a simple, fast tool to build personal blogs, project documentation, or portfolio sites. Fanstatic ships as a single binary — no runtime to install.

**Writers** who prefer Markdown over a CMS editor. Write in any editor, commit to Git, and deploy.

**Hugo users** who want a lighter-weight alternative or prefer building themes in C#/.NET.

## When Fanstatic may not be the right fit

- **Large teams with non-technical editors**: Fanstatic has no CMS UI; all content is Markdown files.
- **Sites with heavy dynamic requirements**: user authentication, real-time feeds, or complex server-side logic belong on a dynamic platform.
- **i18n-heavy sites**: multi-language support is not yet implemented.

## Next steps

- [Install Fanstatic](/docs/installation) — download the binary for your platform
- [Quick start](/docs) — create and preview your first site in two minutes
- [Theming](/docs/theme) — learn how Liquid templates work
