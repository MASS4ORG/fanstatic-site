---
Title: "SampleStatus"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "SampleStatus"
  namespace: "TestProject.Models"
  symbol: "enum"
  source: "SampleEnum.cs"
  external_link: ""
---

- **Namespace:** [TestProject.Models](/api/7.2.0/testproject.models)
- **Source File:** SampleEnum.cs

Represents different status values that can be assigned to various entities in the system. This enum is used for testing the code analyzer's ability to parse enum declarations and their associated documentation.

### Remarks
This enumeration provides a set of predefined status values that help categorize the current state of objects within the application.

## Enum Values

- **None** = `0`: Indicates that the entity has not been initialized or is in an unknown state.
- **Pending** = `1`: Indicates that the entity is currently being processed or is in progress.
- **Active** = `2`: Indicates that the entity is currently active and operational.
- **Suspended** = `3`: Indicates that the entity has been temporarily suspended or paused.
- **Completed** = `100`: Indicates that the entity has completed its lifecycle successfully.
- **Failed** = `999`: Indicates that the entity has failed or encountered an error.

