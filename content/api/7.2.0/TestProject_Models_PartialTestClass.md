---
Title: "PartialTestClass"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "PartialTestClass"
  namespace: "TestProject.Models"
  symbol: "class"
  source: "PartialClass1.cs, PartialClass2.cs, PartialClass3.cs"
  external_link: ""
---

- **Namespace:** [TestProject.Models](/api/7.2.0/testproject.models)
- **Source File:** PartialClass1.cs, PartialClass2.cs, PartialClass3.cs

This is a partial class for testing partial class merging functionality.

## Fields

### **FirstField** (*int*) = `1`: A field defined in the first partial file.
### **SecondField** (*int*) = `2`: A field defined in the second partial file.
### **ThirdField** (*int*) = `3`: A field defined in the third partial file.

## Properties

### **FirstProperty**

(*string*) { get; set } = `"First"`: A property defined in the first partial file.

### **SecondProperty**

(*string*) { get; set } = `"Second"`: A property defined in the second partial file.

### **ThirdProperty**

(*string*) { get; set } = `"Third"`: A property defined in the third partial file.

### **TotalFields**

(*int*): A property that uses all three fields.


## Public Methods

### FirstMethod

```csharp
public string FirstMethod(string value)
```

A method defined in the first partial file.

**Parameters:**

- `value` (*string*): The input value

**Returns:** `string`

- The processed value

### SecondMethod

```csharp
public string SecondMethod(string value)
```

A method defined in the second partial file.

**Parameters:**

- `value` (*string*): The input value

**Returns:** `string`

- The processed value

### CombinedMethod

```csharp
public string CombinedMethod()
```

A method that combines functionality from both partial files.

**Returns:** `string`

- Combined result

### ThirdMethod

```csharp
public string ThirdMethod(string value)
```

A method defined in the third partial file.

**Parameters:**

- `value` (*string*): The input value

**Returns:** `string`

- The processed value

### StaticMethod

```csharp
public static string StaticMethod()
```

A static method that demonstrates static members in partial classes.

**Returns:** `string`

- A static value

