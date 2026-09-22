---
Title: serve
Params:
  hasCode: true
---

`fanstatic serve` starts a local development server that rebuilds your site whenever a file changes and reloads the page in your browser. Nothing is written to disk — the site is served entirely from memory.

## Usage

```sh
fanstatic serve [options]
```

Then open **http://localhost:2341** in your browser.

## Options

| Option | Short | Default | Description |
|---|---|---|---|
| `--source <path>` | `-s` | `./` | Site source directory |
| `--draft` | `-d` | off | Include draft pages |
| `--future` | `-f` | off | Include future-dated pages |
| `--expired` | `-e` | off | Include expired pages |
| `--verbose` | `-v` | off | Verbose logging |

There is no `--output` option — `serve` never writes to disk.

## Examples

```sh
# Serve the current directory
fanstatic serve

# Serve a site in a subdirectory
fanstatic serve --source ./my-site

# Include drafts so you can preview unpublished content
fanstatic serve --draft

# Include all content regardless of dates
fanstatic serve --draft --future --expired
```

## How live reload works

Fanstatic watches your `content/`, `themes/`, and `static/` directories. When any file changes:

1. The affected pages are recompiled in memory
2. The browser receives a reload signal via a small injected script
3. Your page refreshes automatically

The rebuild is fast enough that by the time you switch back to the browser, the page is already updated.

## Stopping the server

Press **Ctrl+C** to stop.
