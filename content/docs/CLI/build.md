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
