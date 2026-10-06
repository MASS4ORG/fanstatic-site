---
Title: "UrlExtension"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "UrlExtension"
  namespace: "Fanstatic.Helpers"
  symbol: "class"
  source: "UrlExtension.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.Helpers](/api/7.2.0/fanstatic.helpers)
- **Source File:** UrlExtension.cs

Helper class to convert a string to a URL-friendly string.

## Public Methods

### ConvertToUrlFriendly

```csharp
public static string ConvertToUrlFriendly(string? title, UrlSanitizationOptions? options = null)
```

Converts a string to a URL-friendly string. It will remove all non-alphanumeric characters and replace spaces with the replacement character.

**Parameters:**

- `title` (*string?*)
- `options` (*UrlSanitizationOptions?*) (Default: `null`)

**Returns:** `string`


### SanitizeUrlPath

```csharp
public static string SanitizeUrlPath(string? path, UrlSanitizationOptions? options = null)
```

Converts a path to a URL-friendly string.

**Parameters:**

- `path` (*string?*)
- `options` (*UrlSanitizationOptions?*) (Default: `null`)

**Returns:** `string`


### NormalizeToUnix

```csharp
public static string NormalizeToUnix(string? path)
```

Convert all paths to a unix path style

**Parameters:**

- `path` (*string?*)

**Returns:** `string`


### CorrectRequestPath

```csharp
public static (Uri stripped, Uri full) CorrectRequestPath(Uri requestPath)
```

Corrects the request path by ensuring it ends with a trailing slash and appends "index.html" if necessary. The method processes both absolute and relative URIs, extracting the path, query, and fragment components, and returns a tuple containing the stripped path (without query or fragment) and the full path (with query and fragment).

**Parameters:**

- `requestPath` (*Uri*): The input URI to be processed. Can be absolute or relative.

**Returns:** `(Uri stripped, Uri full)`

- A tuple containing two URIs: - `Uri``stripped`: The corrected path without query or fragment. - `Uri``full`: The corrected path with query and fragment appended (if any).
**Example:**
```csharp
` var (stripped, full) = CorrectRequestPath(new Uri("https://example.com/page#section?key=value")); // stripped: "/page/index.html" // full: "/page/index.html?key=value#section" `
```

**Remarks:**
If the input URI is null or empty, it is replaced with a default relative URI ("/"). For absolute URIs, the scheme, host, and port are stripped, and only the path, query, and fragment are processed. For relative URIs, a fake domain ("http://fakedomain.com") is temporarily added to enable the use of `GetComponents` for reliable extraction of path, query, and fragment components. The corrected path ensures that: - It ends with a trailing slash if it does not already contain a file extension. - "index.html" is appended if the path ends with a trailing slash. The query and fragment components are preserved and reattached to the corrected path in their original order.



### CombineRelative

```csharp
public static Uri CombineRelative(Uri basePath, Uri relativePath)
```

Combines a base URI and a relative URI into a single relative URI.

**Parameters:**

- `basePath` (*Uri*): The base URI. This should be a relative URI.
- `relativePath` (*Uri*): The relative URI to combine with the base URI. This should be a relative URI.

**Returns:** `Uri`

- A new relative URI that represents the combination of the base and relative URIs.
**Example:**
```csharp
` var baseUri = new Uri("/blog", UriKind.Relative); var relativeUri = new Uri("post1", UriKind.Relative); var result = UrlExtension.CombineRelative(baseUri, relativeUri); // Returns "/blog/post1" `
```



