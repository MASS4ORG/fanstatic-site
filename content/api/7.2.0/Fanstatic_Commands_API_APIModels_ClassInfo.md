---
Title: "ClassInfo"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "ClassInfo"
  namespace: "Fanstatic.Commands.API.APIModels"
  symbol: "record"
  source: "ClassInfo.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.API.APIModels](/api/7.2.0/fanstatic.commands.api.apimodels)
- **Source File:** ClassInfo.cs

Represents information about a class, including its name, namespace, source file, type kind, public methods, properties, fields, enum values, and accompanying documentation.

## Properties

### **PublicMethods**

(*List<MethodInfo>*) { get } = `PublicMethods ?? []`: Represents a collection of public method definitions associated with the class.

### **Properties**

(*List<PropertyInfo>*) { get } = `Properties ?? []`: Represents a collection of property definitions associated with the class.

### **Fields**

(*List<FieldInfo>*) { get } = `Fields ?? []`: Maintains a collection of field definitions associated with the class.

### **EnumValues**

(*List<EnumValueInfo>*) { get } = `EnumValues ?? []`: Contains information regarding the values of an enumerated type defined in the class.

### **ClassDocumentation**

(*DocumentationInfo*) { get } = `ClassDocumentation ?? new()`: Represents the documentation information associated with a class, struct, enum, or record in the source code.


