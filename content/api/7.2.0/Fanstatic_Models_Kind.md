---
Title: "Kind"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "Kind"
  namespace: "Fanstatic.Models"
  symbol: "enum"
  source: "Kind.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** Kind.cs

The type of the output page, if it's a single page, a list of pages or the home page.

## Enum Values

- **single** = `1 << 1`: A single content page.
- **list** = `1 << 2`: List of contents
- **index** = `1 << 3`: Special page, like the home page. It will be rendered as index.html.
- **system** = `1 << 4`: Created by system
- **istaxonomy** = `1 << 5`: Taxonomy type of content
- **rss** = `1 << 6`: RSS
- **sitemap** = `1 << 7`: Sitemap
- **robottxt** = `1 << 8`: robot.txt to prevent indexing
- **code404** = `1 << 9`: 404 page
- **home** = `system | index | list`: Special page, like the home page. It will be rendered as index.html.
- **section** = `system | list`: Root content list type
- **taxonomy** = `system | istaxonomy | list`: Taxonomy group is equivalent to Section
- **term** = `system | single | istaxonomy | list`: Each taxonomy (category, tags) item

