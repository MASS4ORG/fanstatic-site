---
Title: "Build"
Type: api
Created: "2026-10-06 12:26:02"
Params:
  type: "Build"
  namespace: "Fanstatic.NUKE"
  symbol: "class"
  source: "Build.Compile.cs, Build.Release.GitHub.cs, Build.Release.GitLab.cs, Build.Pack.cs, Build.Publish.cs, Build.Package.Winget.cs, Build.Benchmark.cs, Build.Changelog.cs, Build.Test.cs, Build.Version.cs, Build.Container.cs, Build.Package.WindowsInstaller.cs, Build.Release.cs, Build.Package.Debian.cs, Build.cs, Build.Package.Flatpak.cs, Build.Solution.cs"
  external_link: ""
---

- **Namespace:** [Fanstatic.NUKE](/api/7.2.0/fanstatic.nuke)
- **Source File:** Build.Compile.cs, Build.Release.GitHub.cs, Build.Release.GitLab.cs, Build.Pack.cs, Build.Publish.cs, Build.Package.Winget.cs, Build.Benchmark.cs, Build.Changelog.cs, Build.Test.cs, Build.Version.cs, Build.Container.cs, Build.Package.WindowsInstaller.cs, Build.Release.cs, Build.Package.Debian.cs, Build.cs, Build.Package.Flatpak.cs, Build.Solution.cs

This is the main build file for the project. This partial is responsible for the build process.

## Properties

### **GitHubCreateTag**

(*Target*)

### **GitHubCreateRelease**

(*Target*): Creates the GitHub release for the current tag and uploads every archive in `ArtifactsDirectory` as a release asset.

### **GitLabCreateTag**

(*Target*)

### **GitLabCreateRelease**

(*Target*): Creates the GitLab release for the current tag: every archive in `ArtifactsDirectory` is uploaded to the project's generic package registry and linked from the release.

### **Pack**

(*Target*): // Not declared via .Produces(PackedArchive): that evaluates its argument eagerly while Nuke
// builds the target graph, before GitVersion's [GitVersion] field injection has run, and
// PackedArchive depends on Version (=> gitVersion.MajorMinorPatch), which would NRE.

### **WingetManifest**

(*Target*)

### **Benchmark**

(*Target*)

### **RecordReleaseBenchmark**

(*Target*): Records the benchmark entry for the version being released, so the release commit carries it. A regression is logged but does not stop the release: the history must show what was shipped.

### **UpdateChangelog**

(*Target*): Rewrites CHANGELOG.md: the commits since the last tag are grouped into a new "## [Version] - date" section (Keep a Changelog style), and a fresh empty "## [Unreleased]" section is left above it for subsequent commits.

### **TestReport**

(*Target*)

### **VersionMajor**

(*string*)

### **VersionMajorMinor**

(*string*)

### **CheckNewCommits**

(*Target*): Checks if there are new commits since the last tag. If there are no new commits, the whole publish process is skipped.

### **ContainerBuild**

(*Target*): Builds the container image to a throwaway archive on every commit, only to verify the release image still builds. It runs the exact same build as `ContainerPush` but writes a tarball instead of pushing, so it needs no container daemon and runs on any runner. The archive is discarded.

### **ContainerPush**

(*Target*): Pushes the image built by `ContainerBuild` to every repository listed in `ContainerAllRegistries`, tagged with both the release version and the generic tags. The CI job is responsible for supplying registry credentials beforehand.

### **WindowsInstaller**

(*Target*)

### **CreateReleaseCommit**

(*Target*): Commits the changelog once before creating the release tag.

### **CreateReleaseTag**

(*Target*)

### **DebianPackage**

(*Target*)

### **Flatpak**

(*Target*)


