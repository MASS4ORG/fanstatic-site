---
Title: Shortcodes
Params:
  hasCode: true
---

Shortcodes are small Liquid templates you call from Markdown content. They are compatible with Hugo shortcodes, and add parameter schemas, list and map arguments, `:::` directives and a template tag for layouts.

## Calling a shortcode

```md
{{</* audio src="/audio/intro.mp3" */>}}

{{</* note */>}}
Some **important** text.
{{</* /note */>}}
```

There are two notations:

| Notation | Output |
|---|---|
| `{{</* name */>}}` | HTML, inserted after Markdown is rendered and never wrapped in `<p>` |
| `{{%/* name */%}}` | Markdown, inserted before Markdown is rendered, so it goes through Markdig with the rest of the page |

A shortcode whose template uses `inner` needs a closing tag (`{{</* /note */>}}`) or the self-closing form (`{{</* note /*/>}}`). Shortcodes nest, and a nested shortcode renders first, so its parent receives the rendered output as `inner`.

## Arguments

Arguments are separated by spaces and may span several lines. Pass them by name or by position, but not both (unless the template declares a [schema](#parameter-schemas)):

```md
{{</* figure src="cat.jpg" alt="A cat" width=300 */>}}
{{</* youtube dQw4w9WgXcQ */>}}
```

| Form | Value |
|---|---|
| `"text"`, `'text'` | a string; `\"` escapes a double quote |
| `` `raw` `` | a raw string, which may span lines |
| `true`, `false`, `42`, `1.5` | a boolean or a number when unquoted |
| `["a", "b"]` | a list |
| `{w: 300, h: 200}` | a map |

To show a shortcode literally, comment it out: `{{</*/* name */*/>}}` renders as `{{</* name */>}}`.

## Writing a shortcode

Create `shortcodes/<name>.html` in your site or in your theme. A site file overrides a theme file of the same name, and both override the built-ins. Names may include folders: `{{</* media/audio */>}}` uses `shortcodes/media/audio.html`.

```liquid
<audio controls preload="auto" src="{{ src }}" title="{{ page.Title }}"></audio>
```

Inside the template:

| Variable | Content |
|---|---|
| `page`, `site`, `fanstatic` | the calling page, its site and Fanstatic info |
| each named argument | `{{ src }}` for `src="…"` |
| `inner` | the content between the opening and closing tags |
| `params` | the arguments: a map for named ones (`params.src`), a list for positional ones (`params[0]`) |
| `shortcode.Name`, `shortcode.Params`, `shortcode.IsNamedParams` | the call |
| `shortcode.Inner`, `shortcode.InnerDeindent` | the inner content, as is or without its common indentation |
| `shortcode.Ordinal`, `shortcode.Parent` | the position among sibling calls and the enclosing shortcode |
| `shortcode.Position` | the call location as `file:line:col` |

Helpful filters:

- `{{ inner | markdownify }}` renders Markdown, dropping the `<p>` of a single paragraph; `markdownify: "block"` keeps it.
- `{{ "src is required" | errorf }}` fails the build with the call location; `{{ "deprecated: %s" | warnf: name }}` logs a warning.

`page.Shortcodes` lists the shortcodes a page calls, so a layout can load assets only where needed:

```liquid
{% if page.Shortcodes contains "audio" %}<link rel="stylesheet" href="/css/audio.css">{% endif %}
```

### Language and output format variants

Within each folder, the most specific file wins:

1. `name.<lang>.<format>.<ext>`, e.g. `audio.pt-br.rss.xml`
2. `name.<format>.<ext>`, e.g. `audio.rss.xml`
3. `name.<lang>.<ext>`, e.g. `audio.pt-br.html`
4. `name.<ext>`, e.g. `audio.html`

Output formats other than HTML fall back to the HTML templates.

### Parameter schemas

A template may start with YAML front matter declaring its parameters. Fanstatic then validates every call at build time, with the call location, and applies defaults:

```liquid
---
Positional: [src, width]
Params:
  src:   { Type: string, Required: true }
  width: { Type: int, Default: 300 }
  kind:  { Type: string, Allowed: [note, warn] }
---
<img src="{{ src }}" width="{{ width }}" class="{{ kind }}">
```

Types are `string`, `int`, `float`, `bool`, `list`, `map` and `any`. `Positional` names the positional arguments, so `{{</* card "a.jpg" kind="warn" */>}}` is valid.

## Directives

A Docusaurus-style container directive calls the shortcode of the same name in Markdown notation, with the text after the attributes as `title`:

```md
:::note{kind=warn} Read this first
Directive **content** becomes `inner`.
:::
```

Longer fences (`::::`) nest. When no shortcode has that name, the block is rendered as a Markdig custom container, as before.

## Shortcodes in layouts

Layouts call shortcodes with the `shortcode` tag. Arguments are Liquid expressions:

```liquid
{% shortcode 'audio', src: page.Params.audio %}

{% shortcode 'note' %}
Written by **{{ page.Params.author }}**.
{% endshortcode %}
```

The block form is used when the shortcode uses `inner`. Unlike `{% render 'shortcodes/audio' %}`, the tag follows the language and format lookup, site overrides and schemas, and also reaches the built-ins.

## Built-in shortcodes

| Shortcode | Arguments |
|---|---|
| `ref`, `relref` | path (with an optional `#anchor`), `lang`, `outputFormat` |
| `details` | `summary`, `open`, `class`, `name`, `title`; inner content |
| `figure` | `src` (a page resource first), `link`, `target`, `rel`, `alt`, `title`, `caption`, `attr`, `attrlink`, `class`, `width`, `height`, `loading` |
| `highlight` | language, options such as `"linenos=table,hl_lines=2 4-5,linenostart=10"`; inner code |
| `instagram` | post id |
| `param` | a dotted key read from the page params, then the site params |
| `qr` | `text` or inner content, `level`, `scale`, `alt`, `class`, `title`, `loading` |
| `vimeo` | `id`, `class`, `title`, `allowFullScreen`, `loading` |
| `x` | `user`, `id`; fetched once through oEmbed and cached |
| `youtube` | `id`, `start`, `end`, `autoplay`, `mute`, `loop`, `controls`, `allowFullScreen`, `class`, `title`, `loading` |

`highlight` only writes markup: a fenced code block with `language-*`, `line-numbers` and `data-line` attributes for a client-side highlighter such as Prism or highlight.js. `qr` embeds the PNG in the page, `youtube` uses `youtube-nocookie.com`, and `vimeo` sets `dnt=1`. When `x` cannot reach the network, it renders a link to the post and logs a warning.

## Errors

An unknown shortcode, a syntax error, a schema violation or a template failure is reported with its location and fails the build:

```
[ERR] 'content/blog/post.md:12:1': shortcode 'audoi' not found
  {{</* audoi src="/a.mp3" */>}}
```

While `fanstatic serve` is running, the error is shown in the browser instead of the page.
