---
Title: Page Variables
Params:
  hasCode: true
---

Every template receives a `page` object. These variables are available in all templates (`baseof.html`, `single.html`, `list.html`, `home.html`, `term.html`, etc.).

## Front matter variables

These come directly from the page's YAML front matter.

| Variable | Type | Description |
|---|---|---|
| `page.Title` | string | Page title |
| `page.Description` | string | Content description |
| `page.Date` | date | Publication date |
| `page.PublishDate` | date | Publish date (defaults to `Date`) |
| `page.ExpiryDate` | date | Date after which the page is excluded |
| `page.Lastmod` | date | Last modification date |
| `page.Draft` | bool | Whether the page is a draft |
| `page.Tags` | string list | Tag names assigned to this page (legacy) |
| `page.Taxonomies` | dictionary of page lists | Assigned taxonomy terms keyed by taxonomy path (e.g. `page.Taxonomies.tags`) |
| `page.TagsReference` | page list | Assigned tag term pages (legacy) |
| `page.Weight` | int | Sort weight |
| `page.Type` | string | Content type; defaults to section name |
| `page.Params` | map | Any custom front matter fields |

### Accessing custom Params

```liquid
{{ page.Params.HeroImage }}
{{ page.Params.Author }}
```

## Computed variables

These are set by Fanstatic at build time, not from front matter.

| Variable | Type | Description |
|---|---|---|
| `page.Permalink` | string | Absolute URL including domain |
| `page.RelPermalink` | string | URL path without domain |
| `page.Section` | string | Top-level directory name |
| `page.Kind` | string | `home`, `page`, `section`, `taxonomy`, `term` |
| `page.IsHome` | bool | True if this is the home page |
| `page.IsSection` | bool | True if this is a section page |
| `page.Pages` | page list | Child pages (on section/taxonomy pages) |
| `page.PagesByDate` | page list | Child pages sorted by date, ascending |
| `page.PagesByLastMod` | page list | Child pages sorted by last modification, ascending |
| `page.PagesByWeight` | page list | Child pages sorted by weight, ascending |
| `page.PagesByTitle` | page list | Child pages sorted by title |
| `page.RegularPagesByDate` | page list | Regular child pages sorted by date, ascending |
| `page.RegularPagesByLastMod` | page list | Regular child pages sorted by last modification, ascending |
| `page.RegularPagesByWeight` | page list | Regular child pages sorted by weight, ascending |
| `page.RegularPagesByTitle` | page list | Regular child pages sorted by title |
| `page.Site` | site | The site object (same as `site`) |
| `page.Parent` | page | Parent page in the hierarchy |
| `page.OutputFormats` | list | Available output formats for this page |
| `page.Paginator` | pager | Pagination object (on list pages) |
| `page.WordCount` | int | Number of words in the content |

## Translation variables

Available on pages in multi-language sites (see [Localization](/docs/content/localization)).

| Variable | Type | Description |
|---|---|---|
| `page.Language` | LanguageSettings | The page's language object (`Code`, `LanguageName`, `Weight`, `Title`, etc.) |
| `page.IsDefaultLanguage` | bool | True if this page is in the site's default language |
| `page.Translations` | page list | Same page content in other languages (excludes self) |
| `page.AllTranslations` | page list | All translations including self, sorted by weight |
| `page.TranslationsByLanguage` | dictionary | Translations keyed by language code (includes self) |
| `page.Variants` | page list | Every representation across all languages and output formats |
| `page.AlternativeOutputFormats` | page list | Output formats (RSS, JSON, etc.) for the same language |

## Content variables

| Variable | Type | Description |
|---|---|---|
| `page.Content` | string | Fully rendered page content (Markdown → HTML, then Liquid processed) |
| `page.ContentPreRendered` | string | Markdown → HTML only (no Liquid processing) |
| `page.RawContent` | string | Raw Markdown, before any processing |
| `page.Plain` | string | Content with all HTML tags stripped |

## URL and alias variables

| Variable | Type | Description |
|---|---|---|
| `page.Aliases` | string list | Redirect URLs pointing to this page |

## Usage examples

The cached `*ByDate`, `*ByLastMod`, `*ByWeight`, and `*ByTitle` views are available in Fanstatic 7.2.0 and later.
Use them instead of sorting the same page collection repeatedly. They sort ascending; reverse a view when the
newest, latest, or heaviest items should appear first.

### Single page template

```liquid
<article>
    <h1>{{ page.Title }}</h1>
    <time datetime="{{ page.Date | date: '%Y-%m-%d' }}">
        {{ page.Date | date: '%B %d, %Y' }}
    </time>

    {% if page.Taxonomies.tags %}
    <div class="tags">
        {% for tag in page.Taxonomies.tags %}
        <a href="{{ tag.Permalink }}">{{ tag.Title }}</a>
        {% endfor %}
    </div>
    {% endif %}

    <div class="content">
        {{ page.ContentPreRendered }}
    </div>
</article>
```

### List template with pagination

```liquid
{% assign sorted = page.Pages | sort: 'Date' | reverse %}
{% assign pager = sorted | paginate: 10 %}

{% for post in pager.PageItems %}
<article>
    <h2><a href="{{ post.Permalink }}">{{ post.Title }}</a></h2>
    <time>{{ post.Date | date: '%Y-%m-%d' }}</time>
</article>
{% endfor %}

{% render 'partials/pagination.html', pager: pager %}
```

## The Paginator object

On list pages, `page.Paginator` exposes:

| Property | Description |
|---|---|
| `page.Paginator.PageItems` | Items for the current page (correctly sliced) |
| `page.Paginator.Current` | Current page number (1-based) |
| `page.Paginator.Count` | Total number of pages |
| `page.Paginator.First` | URL of the first page |
| `page.Paginator.Last` | URL of the last page |
| `page.Paginator.Prev` | URL of the previous page (nil at first page) |
| `page.Paginator.Next` | URL of the next page (nil at last page) |
| `page.Paginator.Pages` | All page numbers |
| `page.Paginator.BaseUrl` | Base URL without page segment |
