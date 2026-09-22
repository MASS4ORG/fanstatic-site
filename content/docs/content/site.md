---
Title: Site Configuration
Params:
  hasCode: true
---

Site-wide settings live in `fanstatic.yaml` at your site root. These control the title, base URL, theme, and any custom parameters you want available in every template.

## Full example

```yaml
Title: "My Blog"
BaseURL: https://myblog.example.com
Description: "Thoughts on code and coffee"
Copyright: "<a href='https://example.com'>Your Name</a>"

Theme: my-theme
GoogleAnalytics: G-XXXXXXXXXX

Paginate: 10
PaginatePath: page

Params:
  Logo: /images/logo.png
  Footer: "Built with Fanstatic"
  Author:
    Name: "Your Name"
    Email: "you@example.com"
  MainMenu:
    - url: /blog
      label: Blog
    - url: /docs
      label: Docs
    - url: /about
      label: About
```

## Fields

### Title

The site name. Accessible in templates as `{{ site.Title }}`.

### BaseURL

The full URL where the site will be hosted, including the scheme and trailing slash:

```yaml
BaseURL: https://myblog.example.com/
```

Used to build absolute URLs. In templates: `{{ site.BaseURL }}`.

### Description

A short site description. Useful for `<meta name="description">` in your `<head>` template.

### Copyright

Copyright notice. May contain HTML. Accessible as `{{ site.Copyright }}`.

### Theme

The name of the theme directory inside `themes/` to use:

```yaml
Theme: my-theme
```

This tells Fanstatic to load templates from `themes/my-theme/`.

### GoogleAnalytics

Your Google Analytics measurement ID. Pass it to your theme's `<head>` template. Fanstatic makes it available as `{{ site.GoogleAnalytics }}`.

### Paginate

Number of items per page when using pagination. Default: `10`.

### PaginatePath

The URL segment used for paginated pages. Default: `page`. With the default, page 2 of `/blog/` becomes `/blog/page/2/`.

### Params

A map of custom values available in every template via `{{ site.Params.key }}`. Use it for anything your theme needs: navigation menus, social links, author details, feature flags.

## Accessing site config in templates

All site settings are accessible from any template via the `site` object:

```liquid
<title>{{ page.Title }} — {{ site.Title }}</title>
<meta name="description" content="{{ site.Description }}" />

{% if site.GoogleAnalytics %}
<!-- GA snippet here -->
{% endif %}
```

For the full list of site variables, see [Site Variables](/docs/theme/variables/site).
