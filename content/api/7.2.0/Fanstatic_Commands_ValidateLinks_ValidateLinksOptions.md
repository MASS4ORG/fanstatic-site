---
Title: "ValidateLinksOptions"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "ValidateLinksOptions"
  namespace: "Fanstatic.Commands.ValidateLinks"
  symbol: "class"
  source: "ValidateLinksOptions.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.ValidateLinks](/api/7.2.0/fanstatic.commands.validatelinks)
- **Source File:** ValidateLinksOptions.cs

Command line options for the validate-links command.

## Properties

### **CheckExternal**

(*bool*) { get }: Whether to check external links.

### **Ignore**

(*IEnumerable<string>*) { get } = `[]`: List of links to ignore when checking.

### **StrictBaseUrl**

(*bool*) { get }: Whether to require an absolute link's domain to match the site's BaseUrl before treating it as internal. When disabled (the default), a link is still resolved against the site's own pages if its path matches one, even when its domain doesn't match BaseUrl (e.g. content hardcodes the production URL while validating locally). Enable this to force such mismatched-domain links to be validated as external requests against the BaseUrl domain instead.


