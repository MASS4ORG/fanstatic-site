---
Title: new-theme
Weight: 2
Params:
  hasCode: true
---

`fanstatic new-theme` scaffolds a minimal theme inside your site's `themes/` directory. The generated files are working templates you can customize immediately.

## Usage

```sh
fanstatic new-theme [options]
```

Run this from your site's root directory.

## Options

| Option | Short | Default | Description |
|---|---|---|---|
| `--output` | `-o` | `./themes/my-theme` | Output directory |
| `--force` | `-f` | off | Overwrite existing files |
| `--title` | | `"My Theme"` | Theme title in `fanstatic.yaml` |

## Examples

```sh
# Scaffold a theme in ./themes/my-theme
fanstatic new-theme

# Scaffold with a custom name
fanstatic new-theme --output ./themes/ocean --title "Ocean"
```

## Generated structure

```
themes/my-theme/
├── _default/
│   ├── baseof.html        ← base layout wrapping all pages
│   ├── single.html        ← individual content pages
│   ├── list.html          ← section and taxonomy list pages
│   └── home.html          ← the site home page
├── partials/              ← reusable template fragments
├── static/                ← CSS, JS, images bundled with the theme
└── fanstatic.yaml             ← theme metadata
```

## Activating the theme

Set the `Theme` key in your site's `fanstatic.yaml` to the theme directory name:

```yaml
Theme: my-theme
```

Then run `fanstatic serve` to preview your site with the new theme applied.

For a detailed walkthrough of building a theme from scratch, see the [Custom Theme Tutorial](/docs/tutorials/custom-theme).
