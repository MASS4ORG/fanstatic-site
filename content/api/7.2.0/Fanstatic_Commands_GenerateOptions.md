---
Title: "GenerateOptions"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "GenerateOptions"
  namespace: "Fanstatic.Commands"
  symbol: "class"
  source: "GenerateOptions.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands](/api/7.2.0/fanstatic.commands)
- **Source File:** GenerateOptions.cs

Basic Command line options for the serve and build command.

## Properties

### **Verbose**

(*bool*) { get }

### **Source**

(*string*)

### **Draft**

(*bool*) { get }

### **Future**

(*bool*) { get }

### **Expired**

(*bool*) { get }

### **TemplateMetrics**

(*bool*) { get }

### **SourceArgument**

(*string*) { get } = `"./"`: The path of the source files

### **SourceOption**

(*string*) { get } = `string.Empty`: The path of the source files, as --source commandline option


