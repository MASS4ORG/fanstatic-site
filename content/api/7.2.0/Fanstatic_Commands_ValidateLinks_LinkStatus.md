---
Title: "LinkStatus"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "LinkStatus"
  namespace: "Fanstatic.Commands.ValidateLinks"
  symbol: "enum"
  source: "ValidateLinksCommand.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.ValidateLinks](/api/7.2.0/fanstatic.commands.validatelinks)
- **Source File:** ValidateLinksCommand.cs

Link validation status flags

## Enum Values

- **Ok** = `0`: Link is valid and accessible
- **NotFound** = `1`: Link target does not exist
- **FragmentNotFound** = `2`: Link target exists but fragment/anchor not found
- **Timeout** = `4`: Request timed out
- **HttpError** = `8`: Other HTTP error occurred

