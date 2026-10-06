---
Title: "StopwatchReporter"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "StopwatchReporter"
  namespace: "Fanstatic.Helpers"
  symbol: "class"
  source: "StopwatchReporter.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Helpers](/api/7.2.0/fanstatic.helpers)
- **Source File:** StopwatchReporter.cs

This class is used to report the time taken to execute The stopwatch is started and stopped around parts of the code that we want to measure.

## Public Methods

### Start

```csharp
public void Start(string stepName)
```

Start the stopwatch for the given step name.

**Parameters:**

- `stepName` (*string*)


### Stop

```csharp
public void Stop(string stepName, int itemCount)
```

Stop the stopwatch for the given step name.

**Parameters:**

- `stepName` (*string*)
- `itemCount` (*int*)


### LogReport

```csharp
public void LogReport(string siteTitle)
```

Generate a report of the time taken for each step.

**Parameters:**

- `siteTitle` (*string*)


