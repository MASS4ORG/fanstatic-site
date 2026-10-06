---
Title: build
Params:
  hasCode: true
---

`fanstatic build` compiles your site and writes all output files to the `public/` directory (or a custom path). Use this command to generate the files you'll deploy to your hosting provider.

## Usage

```sh
fanstatic build [options]
```

## Options

| Option | Short | Default | Description |
|---|---|---|---|
| `--source <path>` | `-s` | `./` | Site source directory |
| `--output <path>` | `-o` | `./public` | Output directory |
| `--draft` | `-d` | off | Include draft pages |
| `--future` | `-f` | off | Include future-dated pages |
| `--expired` | `-e` | off | Include expired pages |
| `--continue-on-error` | | off | Exit with 0 even when template errors were found |
| `--template-metrics` | | off | Report inclusive top-level template render time and compiled-template cache hits |
| `--verbose` | `-v` | off | Verbose logging |

## Examples

```sh
# Standard build (source: ./, output: ./public)
fanstatic build

# Custom source and output
fanstatic build --source ./my-site --output ./dist

# Build including drafts and future content
fanstatic build --draft --future

# Verbose build for debugging
fanstatic build --verbose

# Report time spent rendering each template
fanstatic build --template-metrics
```

Metrics are inclusive: work performed by `{% render %}` and `{% include %}` contributes to the caller's time, but
partials are not reported as separate rows. Lazy `page.Content` rendering time is charged to the first template
that reads it, and its value is cached afterward.

## Template errors

Templates are compiled before the build starts, so a broken theme is reported up front with the file, line, and
column of the offending tag:

```
[ERR] 'themes/my-theme/_default/baseof.html:34:5': 'unknown_tag' is not a known tag (rendering 'blog/post-1.md')
  {% unknown_tag %}
```

A build with template errors exits with a non-zero status code and no output files are considered trustworthy. Pass
`--continue-on-error` to still exit with 0 — useful when you want to inspect the generated pages despite a broken
theme, for example during `serve`:

```sh
# Keep going after template errors and exit with 0
fanstatic build --continue-on-error
```

## Output

After a successful build, `public/` contains your complete static site:

```
public/
├── index.html
├── sitemap.xml
├── blog/
│   ├── index.html
│   ├── index.xml        ← RSS feed
│   └── my-post/
│       └── index.html
└── static assets...
```

Deploy the entire `public/` directory to any static host.

## Content filtering

By default, `fanstatic build` only includes pages where:

- `Draft` is not `true`
- `Date` is in the past or present
- `ExpiryDate` is in the future (or not set)

Use `--draft`, `--future`, and `--expired` to override each rule individually.
