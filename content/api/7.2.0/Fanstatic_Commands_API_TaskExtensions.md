---
Title: "TaskExtensions"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "TaskExtensions"
  namespace: "Fanstatic.Commands.API"
  symbol: "class"
  source: "TaskExtensions.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Commands.API](/api/7.2.0/fanstatic.commands.api)
- **Source File:** TaskExtensions.cs

Helper extension for Task.WhenAll with IEnumerable

## Public Methods

### WhenAll

```csharp
public static Task WhenAll(Task[] tasks)
```

Creates a task that completes when all of the provided tasks have completed.

**Parameters:**

- `tasks` (*Task[]*): An array of tasks to wait on for completion.

**Returns:** `Task`

- A task that represents the completion of all the provided tasks.

