---
Title: "SampleClass"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "SampleClass"
  namespace: "TestProject.Models"
  symbol: "class"
  source: "SampleClass.cs"
  external_link: ""
---

- **Namespace:** [TestProject.Models](/api/7.2.0/testproject.models)
- **Source File:** SampleClass.cs

Represents a sample class used for testing the code analyzer functionality. This class demonstrates various C# language features including properties, methods, fields, and comprehensive XML documentation.

### Remarks
This class is specifically designed to test the documentation parsing capabilities of the Fanstatic code analyzer. It includes examples of different documentation tags and various member types.

### Example
```csharp
var sample = new SampleClass("Test", 42); sample.ProcessData("input data");
```

## Fields

### **DefaultPrefix** (*string*) = `"Sample_"`: A public field that stores a constant value for testing purposes.
### **PublicField** (*int*) = `100`: A public field that can be modified externally.

## Properties

### **Name**

(*string*) { get; set }: Gets or sets the name of the sample instance.

### **Id**

(*int*) { get; set }: Gets the unique identifier for this sample instance.

### **CreatedAt**

(*DateTime*) { get; set } = `DateTime.Now`: Gets or sets the creation timestamp of this instance.

### **DisplayName**

(*string*): Gets a computed property that combines the name and ID.


## Public Methods

### ProcessData

```csharp
public string ProcessData(string data)
```

Processes the provided data and returns a formatted result.

**Parameters:**

- `data` (*string*): The input data to process.

**Returns:** `string`

- A formatted string containing the processed data.
**Example:**
```csharp
` var result = sample.ProcessData("test input"); Console.WriteLine(result); // Outputs: "Processed: test input" `
```



### Calculate

```csharp
public double Calculate(int x, int y, double multiplier = 1.0)
```

Calculates a value based on the provided parameters.

**Parameters:**

- `x` (*int*): The first operand.
- `y` (*int*): The second operand.
- `multiplier` (*double*): An optional multiplier to apply to the result. Defaults to 1.0. (Default: `1.0`)

**Returns:** `double`

- The calculated result as a double.
**Remarks:**
This method performs a simple calculation for demonstration purposes. The calculation formula is: (x + y) * multiplier



### GetSampleItems

```csharp
public static List<string> GetSampleItems()
```

Retrieves a list of sample items for testing purposes.

**Returns:** `List<string>`

- A list of strings representing sample items.

### UpdateAsync

```csharp
public async Task<bool> UpdateAsync(string newName, int delay = 0)
```

Updates the instance with new data asynchronously.

**Parameters:**

- `newName` (*string*): The new name to set.
- `delay` (*int*): Optional delay in milliseconds before updating. (Default: `0`)

**Returns:** `Task<bool>`

- A task representing the asynchronous operation.

### ToString

```csharp
public override string ToString()
```

Returns a string representation of this instance.

**Returns:** `string`

- A string that represents the current object.

