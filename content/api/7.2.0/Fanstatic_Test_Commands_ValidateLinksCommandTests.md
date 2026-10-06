---
Title: "ValidateLinksCommandTests"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "ValidateLinksCommandTests"
  namespace: "Fanstatic.Test.Commands"
  symbol: "class"
  source: "ValidateLinksCommandTests.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Test.Commands](/api/7.2.0/fanstatic.test.commands)
- **Source File:** ValidateLinksCommandTests.cs
## Public Methods

### Constructor_ShouldSetCheckExternalFlag

```csharp
public void Constructor_ShouldSetCheckExternalFlag(bool checkExternal, bool useSite)
```

**Parameters:**

- `checkExternal` (*bool*)
- `useSite` (*bool*)


### Constructor_ShouldThrowArgumentNullException_WhenOptionsIsNull

```csharp
public void Constructor_ShouldThrowArgumentNullException_WhenOptionsIsNull()
```


### ValidateInternalLink_ShouldHandleValidAndInvalidLinks

```csharp
public async Task ValidateInternalLink_ShouldHandleValidAndInvalidLinks(string link, int fails)
```

**Parameters:**

- `link` (*string*)
- `fails` (*int*)

**Returns:** `Task`


### ValidateInternalLink_ShouldHandleValidAndInvalidLinksWithFragments

```csharp
public async Task ValidateInternalLink_ShouldHandleValidAndInvalidLinksWithFragments(string link, int fails)
```

**Parameters:**

- `link` (*string*)
- `fails` (*int*)

**Returns:** `Task`


### ValidateSpecialLinks_ShouldBeIgnored

```csharp
public async Task ValidateSpecialLinks_ShouldBeIgnored(string link)
```

**Parameters:**

- `link` (*string*)

**Returns:** `Task`


### Parse_ShouldPopulatePagesWithFailedLinks

```csharp
public async Task Parse_ShouldPopulatePagesWithFailedLinks()
```

**Returns:** `Task`


### GenerateReport_ShouldReturnCorrectExitCode

```csharp
public async Task GenerateReport_ShouldReturnCorrectExitCode()
```

**Returns:** `Task`


### Run_ShouldIgnoreSpecifiedLinks

```csharp
public async Task Run_ShouldIgnoreSpecifiedLinks(string link)
```

**Parameters:**

- `link` (*string*)

**Returns:** `Task`


### ValidateExternalLink_ShouldHandleHttpStatusCodes

```csharp
public async Task ValidateExternalLink_ShouldHandleHttpStatusCodes(string url, HttpStatusCode statusCode, ValidateLinksCommand.LinkStatus expectedStatus)
```

**Parameters:**

- `url` (*string*)
- `statusCode` (*HttpStatusCode*)
- `expectedStatus` (*ValidateLinksCommand.LinkStatus*)

**Returns:** `Task`


### ValidateExternalLink_ShouldHandleFragments

```csharp
public async Task ValidateExternalLink_ShouldHandleFragments(string url, ValidateLinksCommand.LinkStatus expectedStatus)
```

**Parameters:**

- `url` (*string*)
- `expectedStatus` (*ValidateLinksCommand.LinkStatus*)

**Returns:** `Task`


### ValidateInternalLink_ShouldHandleFragmentCaseSensitivity

```csharp
public async Task ValidateInternalLink_ShouldHandleFragmentCaseSensitivity(string fragment, int fails)
```

**Parameters:**

- `fragment` (*string*)
- `fails` (*int*)

**Returns:** `Task`


### ValidateExternalLink_ShouldHandleSpecialFragments

```csharp
public async Task ValidateExternalLink_ShouldHandleSpecialFragments(string url, ValidateLinksCommand.LinkStatus expectedStatus)
```

**Parameters:**

- `url` (*string*)
- `expectedStatus` (*ValidateLinksCommand.LinkStatus*)

**Returns:** `Task`


### GenerateReport_ShouldReturnCorrectExitCodeAndLogMessages

```csharp
public async Task GenerateReport_ShouldReturnCorrectExitCodeAndLogMessages(bool hasFailedLinks, int expectedExitCode)
```

**Parameters:**

- `hasFailedLinks` (*bool*)
- `expectedExitCode` (*int*)

**Returns:** `Task`


### ValidateExternalLink_ShouldHandleOperationCanceledException

```csharp
public async Task ValidateExternalLink_ShouldHandleOperationCanceledException(bool shouldTimeout)
```

**Parameters:**

- `shouldTimeout` (*bool*)

**Returns:** `Task`


### ValidateExternalLink_ShouldHandleGenericException

```csharp
public async Task ValidateExternalLink_ShouldHandleGenericException(bool shouldFail)
```

**Parameters:**

- `shouldFail` (*bool*)

**Returns:** `Task`


### ValidateLinks_ShouldRespectCheckExternalFlag

```csharp
public async Task ValidateLinks_ShouldRespectCheckExternalFlag(bool checkExternal, int expectedFailures)
```

**Parameters:**

- `checkExternal` (*bool*)
- `expectedFailures` (*int*)

**Returns:** `Task`


### ValidatePageLinks_ShouldAccumulateFailedLinks

```csharp
public async Task ValidatePageLinks_ShouldAccumulateFailedLinks()
```

**Returns:** `Task`


### ValidatePageLinks_ShouldRespectIgnoreSettings

```csharp
public async Task ValidatePageLinks_ShouldRespectIgnoreSettings(string link, bool shouldBeIgnored)
```

**Parameters:**

- `link` (*string*)
- `shouldBeIgnored` (*bool*)

**Returns:** `Task`


### ValidatePageLinks_ShouldIgnoreMultipleLinks

```csharp
public async Task ValidatePageLinks_ShouldIgnoreMultipleLinks()
```

**Returns:** `Task`


### ValidatePageLinks_ShouldIgnoreWildcardPatterns

```csharp
public async Task ValidatePageLinks_ShouldIgnoreWildcardPatterns()
```

**Returns:** `Task`


### ValidateExternalLink_ShouldNotBeMisclassifiedAsInternalWhenSiteHasHomepage

```csharp
public async Task ValidateExternalLink_ShouldNotBeMisclassifiedAsInternalWhenSiteHasHomepage()
```

**Returns:** `Task`


### ValidateInternalLink_ShouldResolveLocallyWhenDomainDoesNotMatchBaseUrl

```csharp
public async Task ValidateInternalLink_ShouldResolveLocallyWhenDomainDoesNotMatchBaseUrl()
```

**Returns:** `Task`


### ValidateInternalLink_ShouldValidateAsExternalWhenStrictBaseUrlIsSet

```csharp
public async Task ValidateInternalLink_ShouldValidateAsExternalWhenStrictBaseUrlIsSet()
```

**Returns:** `Task`


### ValidateInternalLink_StrictBaseUrlSkipsMismatchedLinkWhenExternalCheckDisabled

```csharp
public async Task ValidateInternalLink_StrictBaseUrlSkipsMismatchedLinkWhenExternalCheckDisabled()
```

**Returns:** `Task`


### ValidatePageLinks_ShouldIgnoreMultipleExactLinks

```csharp
public async Task ValidatePageLinks_ShouldIgnoreMultipleExactLinks()
```

**Returns:** `Task`


