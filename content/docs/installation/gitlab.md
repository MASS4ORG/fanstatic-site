---
Title: GitLab
Draft: true
Params:
    hasCode: true
---

GitLab is a great place to host your site. This very site is there.

Just create `.gitlab-ci.yml` file in the root folder with this content:

```yml
image: ghcr.io/mass4org/fanstatic:alpine # use the latest version

pages:
  script:
    - Fanstatic     # The same as `fanstatic build ./`
  artifacts:
    paths:
      - public
  rules:
    - if: $CI_COMMIT_REF_NAME == $CI_DEFAULT_BRANCH
```

In case your theme, or any other part of the site, is place in a different repository,
add this:

```yml
variables:
  GIT_SUBMODULE_STRATEGY: normal
  GIT_SUBMODULE_UPDATE_FLAGS: --remote
```
