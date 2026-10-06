---
Title: "IGenerateOptions"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "IGenerateOptions"
  namespace: "Fanstatic.Commands"
  symbol: "interface"
  source: "IGenerateOptions.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands](/api/7.2.0/fanstatic.commands)
- **Source File:** IGenerateOptions.cs

Command line options for the build and serve command.

## Properties

### **Verbose**

(*bool*) { get }: How verbose it must be.

### **Source**

(*string*) { get }: The path of the source files.

### **Draft**

(*bool*) { get }: Include draft content

### **Future**

(*bool*) { get }: Include future content

### **Expired**

(*bool*) { get }: Include expired content

### **TemplateMetrics**

(*bool*) { get }: Report template render metrics when supported by the command.


