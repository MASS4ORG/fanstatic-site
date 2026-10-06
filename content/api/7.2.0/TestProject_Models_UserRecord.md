---
Title: "UserRecord"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "UserRecord"
  namespace: "TestProject.Models"
  symbol: "record"
  source: "SampleRecord.cs"
  external_link: ""
---

- **Namespace:** [TestProject.Models](/api/7.2.0/testproject.models)
- **Source File:** SampleRecord.cs

Represents a data transfer object for user information using C# record syntax. This record is designed to test the code analyzer's ability to parse record declarations and their associated properties and documentation.

### Remarks
Records provide value-based equality semantics and are immutable by default, making them ideal for data transfer objects and value types.

### Example
```csharp
var user = new UserRecord(1, "John", "Doe", "john.doe@example.com", new DateTime(1990, 1, 1)); var updatedUser = user with { Email = "john.newemail@example.com" };
```

## Properties

### **FullName**

(*string*): Gets the full name by combining first and last names.

### **Age**

(*int*): Gets the user's age calculated from their date of birth.

### **Metadata**

(*Dictionary<string, object>*) { get } = `new()`: Gets or sets additional metadata associated with the user.


## Public Methods

### IsValid

```csharp
public bool IsValid()
```

Validates whether the user record contains valid data.

**Returns:** `bool`

- True if the user data is valid; otherwise, false.
**Remarks:**
This method checks basic validation rules such as non-empty names and valid email format patterns.



### ToDisplayString

```csharp
public string ToDisplayString(bool includeEmail = true)
```

Creates a display-friendly representation of the user information.

**Parameters:**

- `includeEmail` (*bool*): Whether to include the email address in the display. (Default: `true`)

**Returns:** `string`

- A formatted string representation of the user.

