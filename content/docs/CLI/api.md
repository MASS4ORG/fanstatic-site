---
Title: api
Params:
  hasCode: true
---

`fanstatic api` generates documentation pages from C# source code. It analyzes your projects and creates Markdown files that Fanstatic can then render into a complete API reference.

## Usage

```sh
fanstatic api --project <path> [options]
```

## Options

| Option | Short | Description |
|---|---|---|
| `--project <path>` | `-p` | **Required.** Path(s) to the source C# project(s) or solution. Multiple paths can be separated by semicolons. |
| `--output <path>` | `-o` | Relative output path for the generated Markdown files. |
| `--output-policy` | | Fail if output directory already exists. |
| `--filter <regex>` | | Filter which assemblies or namespaces to include. |
| `--include-private` | | Include private/internal members in the documentation. |
| `--external-link` | `-e` | External repository link for source code linking (e.g., `github.com/user/repo`). |
| `--source <path>` | `-s` | Site source directory (default: `./`) |
| `--verbose` | `-v` | Verbose logging |

## Examples

```sh
# Generate API docs for a single project
fanstatic api --project ./src/MyProject/MyProject.csproj --output content/api

# Generate from multiple projects and link to GitHub
fanstatic api -p "./src/Core;./src/Extensions" -o content/api -e github.com/username/repo
```

## How it works

1. **Analysis**: Fanstatic uses Roslyn to parse the C# source code and extract types, methods, properties, and XML documentation comments.
2. **Generation**: It creates a directory structure of Markdown files mirroring your project's namespaces.
3. **Metadata**: Each generated file contains front matter with type information, which the theme can use to render rich API pages.

The generated Markdown files are intended to be processed by Fanstatic just like any other content.
