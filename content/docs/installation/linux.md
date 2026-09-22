---
Title: Linux
Params:
  hasCode: true
---

## Download

```sh
# Download the latest release
curl -LO https://github.com/MASS4ORG/fanstatic/-/releases/permalink/latest/downloads/fanstatic-linux-x64

# Rename and make it executable
mv fanstatic-linux-x64 fanstatic
chmod +x fanstatic
```

## Install system-wide

Move the binary to `/usr/local/bin` so it's available to all users:

```sh
sudo mv fanstatic /usr/local/bin/fanstatic
```

## Install for your user only

If you don't have sudo access, install it in `~/bin`:

```sh
mkdir -p ~/bin
mv fanstatic ~/bin/fanstatic

# Add ~/bin to PATH if it isn't already
echo 'export PATH="$HOME/bin:$PATH"' >> ~/.bashrc
source ~/.bashrc
```

## Verify

```sh
fanstatic --version
```

## Troubleshooting

**Permission denied when running fanstatic**

```sh
chmod +x /path/to/fanstatic
```

**SELinux systems (Fedora, RHEL, CentOS)**

If SELinux blocks execution, update the security context:

```sh
sudo chcon -t bin_t /usr/local/bin/fanstatic
```

**Package managers** (apt, dnf, pacman, Snap, Flatpak) are not yet supported. The binary install above is the recommended method.
