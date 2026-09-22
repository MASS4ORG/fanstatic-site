---
Title: Installation
Weight: -1
---

Fanstatic ships as a self-contained binary — no .NET runtime, no package manager, no dependencies. Download the file for your platform, make it executable, and you're done.

## Download

Get the latest release from GitLab:

**[https://github.com/MASS4ORG/fanstatic/-/releases](https://github.com/MASS4ORG/fanstatic/-/releases)**

Choose the binary for your platform:

| Platform | File |
|---|---|
| Linux x64 | `fanstatic-linux-x64` |
| Windows x64 | `fanstatic-win-x64.exe` |

## Platform guides

For step-by-step instructions including PATH setup and troubleshooting:

- [Linux installation](/docs/installation/linux)
- [Windows installation](/docs/installation/windows)
- [GitLab CI/CD deployment](/docs/installation/gitlab)

## Verify the installation

```sh
fanstatic --version
```

You should see the version number printed to the terminal.

## Optional: Git

Git is not required to run Fanstatic, but it is useful for:

- Hosting your site on [GitLab Pages], [GitHub Pages], [Cloudflare Pages], [Netlify], or [AWS Amplify]
- Installing a theme as a Git submodule
- Building Fanstatic from source

[GitLab Pages]: https://docs.gitlab.com/ee/user/project/pages/
[GitHub Pages]: https://pages.github.com/
[Cloudflare Pages]: https://pages.cloudflare.com/
[Netlify]: https://www.netlify.com/
[AWS Amplify]: https://aws.amazon.com/amplify/
