---
Title: "SimpleClass"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "SimpleClass"
  namespace: "TestProject.Models"
  symbol: "class"
  source: "SimpleClass.cs"
  external_link: ""
---

- **Namespace:** [TestProject.Models](/api/7.2.0/testproject.models)
- **Source File:** SimpleClass.cs

// This is a simple class with only regular comments
// Used to test the documentation parser's handling of non-XML comments

## Fields

### **Name** (*string*): // A simple field
### **Value** (*int*) = `42`: // Another field with a comment

## Properties

### **IsActive**

(*bool*) { get; set }: // A property with getter and setter


## Public Methods

### DoSomething

```csharp
public void DoSomething()
```

// A method that does something simple


### GetDescription

```csharp
public string GetDescription(string prefix)
```

// Method with parameters and return value

**Parameters:**

- `prefix` (*string*)

**Returns:** `string`


