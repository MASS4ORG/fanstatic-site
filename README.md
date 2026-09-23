# Fanstatic site

> [!NOTE]
> This site is generated using Fanstatic itself. How cool is that?

If you are looking for the project itself, go to https://github.com/MASS4ORG/fanstatic.

## Features

* Docs: end-user documentation, tutorials and manuals.
* Blog
* API Reference: 

## Contributing

We welcome contributions to the **Fanstatic**! If you have any ideas, bug fixes, or feature suggestions, feel free to submit a pull request. Let's make **Fanstatic** even more magical together.

This site is powered by the incredible Bootstrap library and hosted on [GitHub Pages](https://github.com/MASS4ORG/fanstatic-site), giving it a juicy platform to shine.

## API Documentation Automation

To keep the website's API documentation in sync with the core Fanstatic engine, use the provided `update-api.cs` script. This script automates the following steps:
1. Detects the current version from the Fanstatic source code (`../Fanstatic`).
2. Generates the API reference using `fanstatic api`.

**Usage:**
```bash
dotnet update-api.cs
```

Note: Ensure the `Fanstatic` core project is cloned in the parent directory of this repository.

This project is licensed under the **MIT License**, so feel free to use it, modify it, and make it your own.

This Fanstatic is authored and maintained by [Bruno Massa](https://brunomassa.com).
