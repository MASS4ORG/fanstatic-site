---
Title: "MethodInfo"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "MethodInfo"
  namespace: "Fanstatic.Commands.API.APIModels"
  symbol: "record"
  source: "MethodInfo.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.API.APIModels](/api/7.2.0/fanstatic.commands.api.apimodels)
- **Source File:** MethodInfo.cs

Represents information about a method within a class or struct, including its name, return type, modifiers, parameters, and associated documentation.

## Properties

### **Parameters**

(*List<ParameterInfo>*) { get } = `Parameters ?? []`: Represents the collection of parameters associated with the method. Provides detailed information about each parameter including its name, type, and optional default value.

### **Documentation**

(*DocumentationInfo*) { get } = `Documentation ?? new()`: Provides documentation details for the associated method such as summary, parameters, return value, usage example, remarks, and raw content of the documentation.


