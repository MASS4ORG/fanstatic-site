---
Title: "OutputPolicy"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "OutputPolicy"
  namespace: "Fanstatic.Models"
  symbol: "enum"
  source: "OutputPolicy.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Models](/api/7.2.0/fanstatic.models)
- **Source File:** OutputPolicy.cs

Specifies how to handle an existing output directory

## Enum Values

- **Delete**: Delete the existing directory and create a new one
- **Fail**: Throw an exception if the directory exists
- **Overwrite**: Keep the existing directory and overwrite files as needed (default)

