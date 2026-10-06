---
Title: "IDataService"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "IDataService"
  namespace: "TestProject.Services"
  symbol: "interface"
  source: "IDataService.cs"
  external_link: ""
---

- **Namespace:** [TestProject.Services](/api/7.2.0/testproject.services)
- **Source File:** IDataService.cs

Defines the contract for data service operations within the application. This interface provides methods for managing and retrieving data entities and is used to test the code analyzer's interface parsing capabilities.

### Remarks
This interface demonstrates various method signatures including synchronous and asynchronous operations, generic methods, and different parameter configurations.

## Public Methods

### GetUserAsync

```csharp
 Task<UserRecord?> GetUserAsync(int userId)
```

Retrieves a user by their unique identifier.

**Parameters:**

- `userId` (*int*): The unique identifier of the user to retrieve.

**Returns:** `Task<UserRecord?>`

- A task that represents the asynchronous operation. The task result contains the user if found, or null if not found.

### GetUsersAsync

```csharp
 Task<IEnumerable<UserRecord>> GetUsersAsync(Func<UserRecord, bool>? filter = null, int maxResults = 100)
```

Retrieves all users that match the specified criteria.

**Parameters:**

- `filter` (*Func<UserRecord, bool>?*): An optional filter function to apply to the user collection. (Default: `null`)
- `maxResults` (*int*): The maximum number of results to return. Defaults to 100. (Default: `100`)

**Returns:** `Task<IEnumerable<UserRecord>>`

- A task that represents the asynchronous operation. The task result contains a collection of matching users.

### CreateUserAsync

```csharp
 Task<UserRecord> CreateUserAsync(UserRecord user)
```

Creates a new user in the system.

**Parameters:**

- `user` (*UserRecord*): The user record to create.

**Returns:** `Task<UserRecord>`

- A task that represents the asynchronous operation. The task result contains the created user with assigned ID.

### UpdateUserAsync

```csharp
 Task<bool> UpdateUserAsync(int userId, UserRecord updatedUser)
```

Updates an existing user's information.

**Parameters:**

- `userId` (*int*): The ID of the user to update.
- `updatedUser` (*UserRecord*): The updated user information.

**Returns:** `Task<bool>`

- A task that represents the asynchronous operation. The task result indicates whether the update was successful.

### DeleteUserAsync

```csharp
 Task<bool> DeleteUserAsync(int userId)
```

Deletes a user from the system.

**Parameters:**

- `userId` (*int*): The ID of the user to delete.

**Returns:** `Task<bool>`

- A task that represents the asynchronous operation. The task result indicates whether the deletion was successful.

### GetStatistics

```csharp
 Dictionary<string, object> GetStatistics()
```

Retrieves statistics about the data in the system.

**Returns:** `Dictionary<string, object>`

- A dictionary containing various statistics as key-value pairs.

### ProcessEntitiesByStatus

```csharp
 int ProcessEntitiesByStatus(SampleStatus status, int batchSize = 50)
```

Processes data entities based on the specified status.

**Parameters:**

- `status` (*SampleStatus*): The status filter to apply during processing.
- `batchSize` (*int*): The number of entities to process in each batch. (Default: `50`)

**Returns:** `int`

- The number of entities that were successfully processed.

### ValidateDataIntegrityAsync

```csharp
 Task<ValidationResult> ValidateDataIntegrityAsync(bool performDeepCheck = false)
```

Validates the integrity of the data store.

**Parameters:**

- `performDeepCheck` (*bool*): Whether to perform a comprehensive validation check. (Default: `false`)

**Returns:** `Task<ValidationResult>`

- A task that represents the asynchronous operation. The task result contains validation results.

