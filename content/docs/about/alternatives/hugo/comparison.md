---
Title: Feature Comparison
Weight: 1
---

**Fanstatic**, a young software aiming to replicate Hugo's functionalities, is committed to providing users with a seamless transition. While still in its early stages, **Fanstatic** has made significant progress in emulating Hugo's capabilities. However, there are numerous features yet to be implemented, showcasing the platform's potential for growth.

### Page variables

[Page variables](/docs/theme/variables/page-variables) that can be used in templates.

{: .table .table-dark .table-striped .table-hover }
Name                      | Fanstatic Implemented? | Since
--------------------------|--------------------|-------
.Aliases                  | [🍏](/docs/theme/variables/page-variables/#aliases) | [1.1.0](/v1.1.0)
.AlternativeOutputFormats | [🍏](/docs/content/localization#translation-aware-page-variables) | [6.7.0](/v6.7.0)
.Ancestors                |
.BundleType               |
.Content                  | [🍏](/docs/theme/variables/page-variables/#content) | [1.0.0](/v1.0.0)
.ContentPreRendered       | [🥤](/docs/theme/variables/page-variables/#contentprerendered) | [1.0.0](/v1.0.0)
.Data                     |
.Date                     | [🍏](/docs/theme/variables/page-variables/#date) | [1.1.0](/v1.1.0)
.Description              |
.Draft                    |
.ExpiryDate               | [🍏](/docs/theme/variables/page-variables/#expirydate) | [1.1.0](/v1.1.0)
.File                     |
.Fragments                |
.FuzzyWordCount           |
.IsHome                   | [🍏](/docs/theme/variables/page-variables/#ishome) | [1.3.0](/v1.3.0)
.IsNode                   |
.IsPage                   | [🍏](/docs/theme/variables/page-variables/#isnode) | [1.3.0](/v1.3.0)
.IsSection                | [🍏](/docs/theme/variables/page-variables/#issection) | [1.3.0](/v1.3.0)
.IsTranslated             | [🍏](/docs/content/localization#translation-aware-page-variables) | [6.7.0](/v6.7.0)
.Keywords                 |
.Kind                     | [🍏](/docs/theme/variables/page-variables/#kind) | [1.0.0](/v1.0.0)
.Language                 |
.Lastmod                  | [🍏](/docs/theme/variables/page-variables/#lastmod) | [1.1.0](/v1.1.0)
.LinkTitle                |
.Next                     |
.NextInSection            |
.OutputFormats            | [🍏](/docs/theme/variables/page-variables/#outputformats) | [5.0.0](/v5.0.0)
.Pages                    | [🍏](/docs/theme/variables/page-variables/#pages) | [1.0.0](/v1.0.0)
.Params                   | [🍏](/docs/theme/variables/page-variables/#params) | [1.1.0](/v1.1.0)
.Parent                   | [🥤](/docs/theme/variables/page-variables/#parent) | [1.3.0](/v1.3.0)
.Permalink                | [🍏](/docs/theme/variables/page-variables/#permalink) | [1.0.0](/v1.0.0)
.Plain                    | [🍏](/docs/theme/variables/page-variables/#plain) | [2.0.0](/v2.0.0)
.PlainWords               |
.Prev                     |
.PrevInSection            |
.PublishDate              | [🍏](/docs/theme/variables/page-variables/#publishdate) | [1.1.0](/v1.1.0)
.RawContent               | [🍏](/docs/theme/variables/page-variables/#rawcontent) | [1.0.0](/v1.0.0)
.ReadingTime              |
.Ref                      |
.RelPermalink             | [🍏](/docs/theme/variables/page-variables/#relpermalink) | [6.0.0](/v6.0.0)
.RelRef                   |
.Site                     | [🍏](/docs/theme/variables/page-variables/#site) | [1.0.0](/v1.0.0)
.Sites                    |
.Sites.First              |
.Summary                  |
.TableOfContents          |
.Title                    | [🍏](/docs/theme/variables/page-variables/#title) | [1.0.0](/v1.0.0)
.TranslationKey           |
.Translations             | [🍏](/docs/content/localization#translation-aware-page-variables) | [6.7.0](/v6.7.0)
.Truncated                |
.Type                     | [🍏](/docs/theme/variables/page-variables/#type) | [1.0.0](/v1.0.0)
.Weight                   | [🍏](/docs/theme/variables/page-variables/#weight) | [1.3.0](/v1.3.0)
.WordCount                | [🍏](/docs/theme/variables/page-variables/#wordcount) | [2.0.0](/v2.0.0)

- 🥤 Only in **Fanstatic**!!
- 🍏 Implemented and behaves similarly
- 🍋 Implemented but behaves differently
- 🍅 Not yet implemented

### Site variables

[Site variables](/docs/theme/variables/site-variables) that can be used in templates.

{: .table .table-dark .table-striped .table-hover }
Name                      | Fanstatic Implemented? | Since
--------------------------|--------------------|-------
.AllRegularPages          | [🍏](/docs/theme/variables/site#content-collections) | [6.5.0](/v6.5.0)
.AllPages                 |
.BaseURL                  | [🍏](/docs/theme/variables/site-variables/#baseurl) | [1.0.0](/v1.0.0)
.BuildDrafts              |
.Copyright                | [🍏](/docs/theme/variables/site-variables/#copyright) | [2.0.0](/v2.0.0)
.Description              | [🍏](/docs/theme/variables/site-variables/#description) | [2.0.0](/v2.0.0)
.Data                     |
.DisqusShortname          | 🍋 via Params
.GoogleAnalytics          | 🍋 via Params
.Home                     | [🍏](/docs/theme/variables/site-variables/#home) | [1.0.0](/v1.0.0)
.IsMultiLingual           | [🥤](/docs/content/localization) | [6.7.0](/v6.7.0)
.IsServer                 |
.Language.Lang            | [🍏](/docs/content/localization#language-settings) | [6.7.0](/v6.7.0)
.Language.LanguageName    | [🍏](/docs/content/localization#language-settings) | [6.7.0](/v6.7.0)
.Language.Weight          | [🍏](/docs/content/localization#language-settings) | [6.7.0](/v6.7.0)
.Language                 | [🍏](/docs/content/localization#translation-aware-page-variables) | [6.7.0](/v6.7.0)
.LanguageCode             | [🍏](/docs/content/localization#language-settings) | [6.7.0](/v6.7.0)
.LanguagePrefix           | [🥤](/docs/content/localization#url-structure) | [6.7.0](/v6.7.0)
.Languages                | [🍏](/docs/content/localization#translation-aware-page-variables) | [6.7.0](/v6.7.0)
.LastChange               |
.Menus                    |
.Pages                    | [🍏](/docs/theme/variables/site-variables/#pages) | [1.0.0](/v1.0.0)
.Params                   | [🍏](/docs/theme/variables/site-variables/#params) | [1.1.0](/v1.1.0)
.RegularPages             | [🍏](/docs/theme/variables/site-variables/#regularpages) | [1.0.0](/v1.0.0)
.Sections                 |
.Taxonomies               |
.Title                    | [🍏](/docs/theme/variables/site-variables/#title) | [1.0.0](/v1.0.0)

- 🥤 Only in **Fanstatic**!!
- 🍏 Implemented and behaves similarly
- 🍋 Implemented but behaves differently
- 🍅 Not yet implemented
