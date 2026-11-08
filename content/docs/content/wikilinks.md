---
Title: Wikilinks
---

Wikilinks are Obsidian-style link shorthand you write between double square brackets. They resolve at build time to the permalink of another page or of a taxonomy term, so you never hard-code a URL.

## Syntax

| Form | Result |
|---|---|
| `[[target]]` | links to the resolved target, shown as `target` |
| `[[target\|label]]` | links to the resolved target, shown as `label` |

The `target` is one of:

| Target | Resolves to |
|---|---|
| `posts/my-post.md`, `/posts/my-post.md` | a content path, exactly like [`ref`](/docs/content/shortcodes), using the calling page's directory for relative paths |
| `tags/coffee` | a taxonomy term, as `<plural>/<name>` |
| `coffee` | a taxonomy term first, then a page |

A bare target tries a taxonomy term first and then a page, so `[[coffee]]` links to the `coffee` tag when one exists, and to a page otherwise. The calling page's language and output format are the defaults, matching `ref`.

Inside a pipe table, escape the label separator: `[[coffee\|bean]]`. This keeps the separator inside the cell while displaying `bean` as the link text.

Wikilinks also resolve when Markdown is rendered inside a shortcode, such as `details`, or through the `markdownify` template filter. Taxonomy links use the calling page's language and output format, so a Portuguese RSS page links to the Portuguese RSS term page.

Plain text and image alternative text contain only the target or display label, without link markup or URL resolution. For example, `![See [[coffee|bean]]](coffee.png)` has the alternative text `See bean`.

## When a target is missing

By default an unresolved target renders a link to `./` and logs an error, and the build continues. Set `MissingWikiLinkAsError: true` in `fanstatic.yaml` to fail the build instead:

```yaml
MissingWikiLinkAsError: true
```

## See also

- [Shortcodes](/docs/content/shortcodes) for `ref` and `relref`, which resolve content paths from templates and content
- [Taxonomy](/docs/content/taxonomy) for how terms, their names and their URLs are built
