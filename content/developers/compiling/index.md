---
Title: Compiling
Weight: -1
Params:
    hasCode: true
---

### DotNET 8 SDK

If you plan to build **Fanstatic** from source, you'll need to install the *DotNET 8 SDK*. This SDK provides the necessary tools and libraries for building **Fanstatic** on your machine. Ensure that you have the DotNET 8 SDK installed before proceeding with the build process.

### NUKE

We use [NUKE build system](https://nuke.build) to perform the compilation and build process. It's not required, but it will perform the same tasks whenever you call it, locally in your pc, or in the cloud.

To install NUKE globally (optional), do the following

```bash
dotnet tool install Nuke.GlobalTool --global
```

to generate the optimized final build, use:

> [!NOTE]
> If you did not installed NUKE globally, replace `nuke` for `build.sh` (Linux) or `build.ps1` (Windows)

```bash
nuke publish
```

during development, you can just compile (it will not optimize)

```bash
nuke clean restore compile
```
