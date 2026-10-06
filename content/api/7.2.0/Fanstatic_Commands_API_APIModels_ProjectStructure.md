---
Title: "ProjectStructure"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "ProjectStructure"
  namespace: "Fanstatic.Commands.API.APIModels"
  symbol: "record"
  source: "ProjectStructure.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.API.APIModels](/api/7.2.0/fanstatic.commands.api.apimodels)
- **Source File:** ProjectStructure.cs

Represents the structure of a project, containing information about namespaces and their associated classes, as well as a collection of all the classes within the project.

## Properties

### **NamespaceClasses**

(*Dictionary<string, List<ClassInfo>>*) { get } = `NamespaceClasses ?? []`: Represents a dictionary that organizes classes into their respective namespaces.

### **AllClasses**

(*List<ClassInfo>*) { get } = `AllClasses ?? []`: Represents a collection of all classes identified within a project.


