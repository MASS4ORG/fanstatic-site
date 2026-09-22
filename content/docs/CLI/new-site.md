---
Title: new-site
Weight: 1
Params:
  hasCode: true
---

`fanstatic new-site` scaffolds a minimal site structure so you can start writing content immediately.

## Usage

```sh
fanstatic new-site <path> [options]
```

The path argument is required and sets the output directory.

## Options

| Option | Short | Default | Description |
|---|---|---|---|
| `--force` | `-f` | off | Overwrite existing files |
| `--title` | | `"My Site"` | Site title written to `fanstatic.yaml` |
| `--description` | | `""` | Site description |
| `--url` | | `"https://example.org/"` | Base URL |

## Examples

```sh
# Scaffold a site in ./my-blog
fanstatic new-site ./my-blog

# Scaffold with a title and URL
fanstatic new-site ./my-blog --title "My Blog" --url "https://myblog.example.com"

# Overwrite an existing directory
fanstatic new-site ./my-blog --force
```

## Generated structure

```
my-blog/
├── content/          ← your Markdown files go here
├── static/           ← images, fonts, and other assets
├── themes/           ← one or more Liquid themes
└── fanstatic.yaml        ← site configuration
```

After scaffolding, run:

```sh
cd my-blog
fanstatic serve
```

Your site is live at **http://localhost:2341**. Add a theme to see a styled result — see the [theming guide](/docs/theme) or scaffold one with `fanstatic new-theme`.
