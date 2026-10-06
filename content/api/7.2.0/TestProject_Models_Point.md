---
Title: "Point"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "Point"
  namespace: "TestProject.Models"
  symbol: "record"
  source: "SampleRecord.cs"
  external_link: ""
---

- **Namespace:** [TestProject.Models](/api/7.2.0/testproject.models)
- **Source File:** SampleRecord.cs

Represents a simple data structure for coordinate information.

## Public Methods

### DistanceFromOrigin

```csharp
public readonly double DistanceFromOrigin()
```

Calculates the distance from the origin (0,0) to this point.

**Returns:** `double`

- The distance as a double value.

### DistanceTo

```csharp
public readonly double DistanceTo(Point other)
```

Calculates the distance between this point and another point.

**Parameters:**

- `other` (*Point*): The other point to calculate distance to.

**Returns:** `double`

- The distance between the two points.

