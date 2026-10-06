---
Title: "DefaultPortSelectorTests"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "DefaultPortSelectorTests"
  namespace: "Fanstatic.Test.Commands"
  symbol: "class"
  source: "ServeCommandTests.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Test.Commands](/api/7.2.0/fanstatic.test.commands)
- **Source File:** ServeCommandTests.cs
## Public Methods

### SelectAvailablePort_WhenInitialPortAvailable_ReturnsSamePort

```csharp
public void SelectAvailablePort_WhenInitialPortAvailable_ReturnsSamePort()
```


### SelectAvailablePort_WhenPortHasTimeWaitConnections_ReturnsSamePort

```csharp
public async Task SelectAvailablePort_WhenPortHasTimeWaitConnections_ReturnsSamePort()
```

**Returns:** `Task`


### SelectAvailablePort_WhenInitialPortInUse_ReturnsNextAvailablePort

```csharp
public void SelectAvailablePort_WhenInitialPortInUse_ReturnsNextAvailablePort()
```


### SelectAvailablePort_WhenNoPortAvailable_ThrowsException

```csharp
public void SelectAvailablePort_WhenNoPortAvailable_ThrowsException()
```


