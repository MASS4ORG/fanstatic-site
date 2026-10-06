---
Title: "Dimensions"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "Dimensions"
  namespace: "TestProject.Models"
  symbol: "struct"
  source: "SampleStruct.cs"
  external_link: ""
---

- **Namespace:** [TestProject.Models](/api/7.2.0/testproject.models)
- **Source File:** SampleStruct.cs

Represents a lightweight data structure for storing dimensional information. This struct is designed to test the code analyzer's ability to parse struct declarations and their associated properties, fields, and documentation.

### Remarks
Structs are value types that are typically used for small data structures that have value semantics. This example demonstrates various features including constructors, properties, and methods.

### Example
```csharp
var dimensions = new Dimensions(1920, 1080); var area = dimensions.CalculateArea();
```

## Fields

### **MaxWidth** (*int*) = `7680`: A constant representing the maximum allowed width value.
### **MaxHeight** (*int*) = `4320`: A constant representing the maximum allowed height value.
### **IsInitialized** (*bool*): A public field that indicates whether the dimensions have been initialized.

## Properties

### **Width**

(*int*) { get; set }: Gets or sets the width value.

### **Height**

(*int*) { get; set }: Gets or sets the height value.

### **AspectRatio**

(*double*): Gets the aspect ratio of the dimensions.

### **IsSquare**

(*bool*): Gets a value indicating whether the dimensions represent a square.


## Public Methods

### CalculateArea

```csharp
public readonly long CalculateArea()
```

Calculates the total area represented by these dimensions.

**Returns:** `long`

- The area as a long value to handle large dimensions.
**Example:**
```csharp
` var dims = new Dimensions(1920, 1080); var area = dims.CalculateArea(); // Returns 2073600 `
```



### IsValidForDisplay

```csharp
public readonly bool IsValidForDisplay()
```

Determines whether the current dimensions are valid for display purposes.

**Returns:** `bool`

- True if both width and height are positive and within maximum limits.
**Remarks:**
This method checks that the dimensions are within reasonable bounds for typical display scenarios.



### Scale

```csharp
public readonly Dimensions Scale(double factor)
```

Scales the dimensions by the specified factor.

**Parameters:**

- `factor` (*double*): The scaling factor to apply.

**Returns:** `Dimensions`

- A new `Dimensions` instance with scaled values.

### ToString

```csharp
public override readonly string ToString()
```

Returns a string representation of the dimensions.

**Returns:** `string`

- A string in the format "Width x Height".

### Equals

```csharp
public override readonly bool Equals(object? obj)
```

Determines whether two dimensions instances are equal.

**Parameters:**

- `obj` (*object?*): The object to compare with the current instance.

**Returns:** `bool`

- True if the specified object is equal to the current instance.

### GetHashCode

```csharp
public override readonly int GetHashCode()
```

Returns a hash code for the current instance.

**Returns:** `int`

- A hash code for the current instance.

