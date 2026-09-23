---
Title: "Introducing Fanstatic 7.0.0"
Date: 2026-09-18
Tags:
  - release
  - announcement
Params:
  socialmedia: |
    SuCoS is now Fanstatic — same C# static site generator, new name, new home under the MASS4 organization on GitHub.

    v7.0.0 carries forward every feature from SuCoS v1 through v6.9: Liquid templates, i18n, ref/relref shortcodes, validate-links, and the new Windows installer.

    #Fanstatic #SSG #DotNet

    https://fanstatic.brunomassa.com/v7.0.0/
---

**Fanstatic** is the new name for the static site generator you may have known as SuCoS. If you've used SuCoS,
you already know Fanstatic — the engine, the CLI, the Liquid templates, and every feature built up over six and
a half years of releases carry straight over. What changes with v7.0.0 is the name, the home, and the role: this
is no longer a personal project with a side hustle, it's first-class tooling under the
[MASS4](https://github.com/MASS4ORG) organization.

* [Why the rename](#why-the-rename)
* [What's still here](#whats-still-here)
* [What's new since v7.0.0](#whats-new-since-v7.0.0)
* [Get started](#get-started)

## Why the rename

SuCoS — "Tastiest C# Static Site Generator of the World" — was a personal project from day one, built to get
better at C# and to stop fighting Hugo's templating. Over nine major versions it grew Markdown extensions,
sections and taxonomies, multi-language support with full i18n, `ref`/`relref` shortcodes, and a `validate-links`
command that understands local versus production URLs. Somewhere along the way it quietly became the tool every
other project reached for, MASS4's sites included. **Fanstatic** — for Fans of a Fantastic Static Site
Generator — is that same tool, renamed to match what it actually is now: shared infrastructure, not a side
project. New source home at [github.com/MASS4ORG/fanstatic](https://github.com/MASS4ORG/fanstatic), still MIT
licensed.

## What's still here

Nothing was left behind in the move. Fanstatic v7.0.0 is the direct continuation of SuCoS v6.9.0, with the same
CLI surface:

```sh
fanstatic new-site <YOUR_SITE_PATH>             # To create your site
fanstatic <YOUR_SITE_PATH>                      # To build your site
fanstatic serve <YOUR_SITE_PATH>                # To build and run locally
fanstatic validate-links <YOUR_SITE_PATH>       # To check all links
fanstatic api <YOUR_CODE_PATH> <YOUR_SITE_PATH> # To generate API reference
```

That includes Liquid templating, Hugo-style shortcodes, full i18n with per-language sections and translation
strings, smart `validate-links` local-baseurl resolution, and — as of the last SuCoS release before the
rename — a native Windows installer.

## What's new since v7.0.0

The rename shipped alongside the work already in flight: v7.0.1 fixed the Windows installer placing `fanstatic`
correctly on the user `PATH`, and v7.0.2 added a [winget](https://learn.microsoft.com/windows/package-manager/winget/)
manifest, so Windows users can now install with:

```powershell
winget install MASS4ORG.Fanstatic
```

## Get started

Grab a release from [github.com/MASS4ORG/fanstatic](https://github.com/MASS4ORG/fanstatic) for Linux or Windows,
or install via winget on Windows. Everything you already know from SuCoS applies — the docs on this site are the
same docs, just living at a new address.
