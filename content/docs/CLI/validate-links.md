---
Title: validate-links
Params:
  hasCode: true
---

`fanstatic validate-links` scans your generated site for broken internal and external links. Run this after a build to ensure a high-quality experience for your visitors.

## Usage

```sh
fanstatic validate-links [options]
```

## Options

| Option | Short | Description |
|---|---|---|
| `--external` | `-x` | Also check external links (this can be slow) |
| `--ignore <links>` | `-i` | Comma-separated list of link patterns to ignore |
| `--source <path>` | `-s` | Site source directory (default: `./`) |
| `--draft` | `-d` | Include draft pages in the scan |
| `--verbose` | `-v` | Verbose logging |

## Examples

```sh
# Check all internal links
fanstatic validate-links

# Check internal and external links, ignoring specific domains
fanstatic validate-links --external --ignore "https://twitter.com/*,https://linkedin.com/*"
```

## Recommendation

It is highly recommended to run `validate-links` as part of your CI/CD pipeline. This prevents merging content with broken links that could frustrate users or harm your SEO.
