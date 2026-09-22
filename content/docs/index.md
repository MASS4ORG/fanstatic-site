---
Title: Quick Start
MainMenu: true
Url: "docs"
---

Get a Fanstatic site running in under two minutes.

## 1. Install

Download the binary for your platform from the [releases page](https://github.com/MASS4ORG/fanstatic/-/releases) and add it to your PATH.

Verify:

```sh
fanstatic --version
```

## 2. Create a site

```sh
fanstatic new-site ./my-site
cd my-site
```

This creates:

```
my-site/
├── content/
├── static/
├── themes/
└── fanstatic.yaml
```

## 3. Add a theme

Without a theme, Fanstatic renders bare unstyled HTML. Scaffold a minimal one:

```sh
fanstatic new-theme
```

Then set it in `fanstatic.yaml`:

```yaml
Theme: my-theme
```

## 4. Write your first post

Create `content/blog/hello-world.md`:

```markdown
---
Title: Hello, World!
Date: 2026-04-24
---

This is my first post on Fanstatic.
```

## 5. Preview

```sh
fanstatic serve
```

Open **http://localhost:2341**. Edit any file and the browser refreshes automatically.

## 6. Build for production

```sh
fanstatic build
```

The complete site is written to `public/`. Upload that directory to any static host.

## What's next?

- [Content guide](/docs/content) — front matter, sections, taxonomies
- [Theming guide](/docs/theme) — Liquid templates, partials, layouts
- [CLI reference](/docs/CLI) — all commands and options
- [Installation guides](/docs/installation) — Linux, Windows, GitLab CI/CD
