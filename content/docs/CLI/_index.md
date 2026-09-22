---
Title: CLI Reference
Weight: 100
Params:
  hasCode: true
---

`fanstatic` is a command-line tool. All functionality is accessed through subcommands. Note that the command is case-sensitive: **`fanstatic`**.

## Commands

| Command | Description |
|---|---|
| `fanstatic build` | Compile the site and write output to `public/` |
| `fanstatic serve` | Start a local dev server with live reload |
| `fanstatic new-site` | Scaffold a new site structure |
| `fanstatic new-theme` | Scaffold a new theme in `themes/` |
| `fanstatic api` | Generate API docs from C# source code |
| `fanstatic validate-links` | Check for broken internal and external links |

## Global options

These options are accepted by most commands:

| Option | Short | Description |
|---|---|---|
| `--source <path>` | `-s` | Site source directory (default: `./`) |
| `--verbose` | `-v` | Print detailed output |
| `--help` | `-h` | Show help |
| `--version` | | Show version number |

## Content filtering options

`build`, `serve`, `api`, and `validate-links` accept these flags to include content that is normally excluded:

| Option | Short | Description |
|---|---|---|
| `--draft` | `-d` | Include pages marked `Draft: true` |
| `--future` | `-f` | Include pages with a future `Date` |
| `--expired` | `-e` | Include pages past their `ExpiryDate` |

## Quick examples

```sh
# Build the site
fanstatic build

# Serve locally with live reload
fanstatic serve

# Build including drafts
fanstatic build --draft

# Build from a different directory
fanstatic build --source ./my-site --output ./dist
```
