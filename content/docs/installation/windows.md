---
Title: Windows
Params:
  hasCode: true
---

## Download

1. Go to the [releases page](https://github.com/MASS4ORG/fanstatic/-/releases)
2. Download `fanstatic-win-x64.exe`
3. Rename it to `fanstatic.exe` and place it somewhere convenient, e.g. `C:\Tools\fanstatic.exe`

## Add to PATH (optional but recommended)

Adding Fanstatic to your PATH lets you run `fanstatic` from any directory.

1. Press **Win + S**, search for **Environment Variables**, and open it
2. Under **System Variables**, select **Path** and click **Edit**
3. Click **New** and add the folder containing `fanstatic.exe` (e.g. `C:\Tools`)
4. Click **OK** on all dialogs

Open a new terminal and verify:

```powershell
fanstatic --version
```

## Running without PATH

If you prefer not to modify PATH, run Fanstatic with its full path:

```powershell
C:\Tools\fanstatic.exe new-site ./my-site
```

Or place `fanstatic.exe` in the same directory as your site and run:

```powershell
.\fanstatic.exe serve
```

## Package managers

Chocolatey, Scoop, and Winget packages are not yet available. The manual install above is the recommended method.
