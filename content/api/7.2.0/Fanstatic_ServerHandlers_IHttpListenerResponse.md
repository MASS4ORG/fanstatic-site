---
Title: "IHttpListenerResponse"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "IHttpListenerResponse"
  namespace: "Fanstatic.ServerHandlers"
  symbol: "interface"
  source: "IHttpListenerResponse.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.ServerHandlers](/api/7.2.0/fanstatic.serverhandlers)
- **Source File:** IHttpListenerResponse.cs

Defines the contract for an HTTP listener response.

## Properties

### **OutputStream**

(*Stream*) { get }: Gets the output stream for writing the response body.

### **ContentType**

(*string?*) { get; set }: Gets or sets the content type of the response.

### **ContentLength64**

(*long*) { get; set }: Gets or sets the length of the content to be sent.


