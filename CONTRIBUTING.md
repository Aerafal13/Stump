# Contributing to Stump

Thank you for wanting to contribute to the Stump project! Before you start, please take a quick look at the guidelines we set for contributors, to ensure a smooth collaboration!

- [Code of Conduct](#coc)
- [Issues and Bugs](#issue)
- [Pull Requests](#pull)
- [Coding Rules](#rules)
- [Commit Message Guidlines](#commit)

## <a name="coc"></a> Code Of Conduct

Help us keep Stump open and inclusive.
Please read and follow or [Code of Conduct][coc].

## <a name="issue"></a> Issues and Bugs

If you want to suggest enhancements or report bugs, please open an issue! We try to give each issue to individual attention it deserves, but still - be patient until we get to yours!

We created a few issue templates (for example for features requests or bug reports), which you are intended to use. If the type of issue you want to create doesn't fit a template, feel free to create an issue from scratch, but still include sufficient information for us to understand it.

At this time issues will persist forever - in the future we might close issues after a certain amount of inactivity.

## <a name="pull"></a> Pull Requests

If you worked on a new feature or fixed an open issue, please create a pull request so we can merge your work into ours.

If it is not immediately apparent which feature you added or which issue you addressed, please include an adequate description in your pull request. If you still need to work on the pull request before it can be merged please open it as a draft.

Note that if you do successfully terminate an issue, include `Closes #issue-id` in your commit message so the issue is automatically referenced.

Also do note that we try to enforce consistent coding styles among the repository, which we explain in the section [Coding Rules](#rules). We review every pull request, and we would appreciate it if you would accept the changes that we propose during our reviews.

## <a name="rules"></a> Coding Rules

In general we follow the standard [Microsoft C# naming conventions][nc]. If you want insights to individual variable naming conventions, please refer to the existing code in the repository.

## <a name="commit"></a> Commit Message Guidlines

This specification is inspired by and supersedes the [AngularJS commit message format][angular].

We have very precise rules over how our Git commit messages must be formatted.
This format leads to **easier to read commit history**.

Each commit message consists of a **header**, a **body**, and a **footer**.

```
<header>
<BLANK LINE>
<body>
<BLANK LINE>
<footer>
```

The `header` is mandatory when there have been major changes and must conform to the [Commit Message Header](#commit-header) format.

The `body` is mandatory for all commits except for those of type "docs".
When the body is present, it must be at least 20 characters and must conform to the format [Commit Message Body](#commit-body).

The "footer" is optional. The [Commit Message Footer](#commit-footer) format describes what the footer is for and what structure it should have.

#### <a name="commit-header"></a>Commit Message Header

```
<type>(<scope>): <short summary>
  │       │             │
  │       │             └─⫸ Summary in present tense. Not capitalized. No period at the end.
  │       │
  │       └─⫸ Commit Scope: core|orm|protocol|tools|auth|base|world
  │
  └─⫸ Commit Type: build|docs|feat|fix|perf|refactor
```
##### Type

Must be one of the following:

* **build**: Changes that affect the build system or external dependencies (example scopes: nuget, dll)
* **docs**: Documentation only changes
* **feat**: A new feature
* **fix**: A bug fix
* **perf**: A code change that improves performance
* **refactor**: A code change that neither fixes a bug nor adds a feature

##### Scope

The scope should be the name of the library or server affected (as perceived by the person reading the changelog generated from commit messages).

The following is the list of supported scopes:

* `core`
* `orm`
* `protocol`
* `tools`
* `base`
* `auth`
* `world`

##### Summary

Use the summary field to provide a succinct description of the change:

* use the imperative, present tense: "change" not "changed" nor "changes"
* don't capitalize the first letter
* no dot (.) at the end


#### <a name="commit-body"></a>Commit Message Body

Just as in the summary, use the imperative, present tense: "fix" not "fixed" nor "fixes".

Explain the motivation for the change in the commit message body. This commit message should explain _why_ you are making the change.
You can include a comparison of the previous behavior with the new behavior in order to illustrate the impact of the change.


#### <a name="commit-footer"></a>Commit Message Footer

The footer can contain information about breaking changes and deprecations and is also the place to reference GitHub issues and other PRs that this commit closes or is related to.
For example:

```
BREAKING CHANGE: <breaking change summary>
<BLANK LINE>
<breaking change description + migration instructions>
<BLANK LINE>
<BLANK LINE>
Fixes #<issue number>
```

or

```
DEPRECATED: <what is deprecated>
<BLANK LINE>
<deprecation description + recommended update path>
<BLANK LINE>
<BLANK LINE>
Closes #<pr number>
```

Breaking Change section should start with the phrase "BREAKING CHANGE: " followed by a summary of the breaking change, a blank line, and a detailed description of the breaking change that also includes migration instructions.

Similarly, a Deprecation section should start with "DEPRECATED: " followed by a short description of what is deprecated, a blank line, and a detailed description of the deprecation that also mentions the recommended update path.

[coc]: CODE_OF_CONDUCT.md
[nc]: https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/general-naming-conventions
[angular]: https://docs.google.com/document/d/1QrDFcIiPjSLDn3EL15IJygNPiHORgU1_OOAqWjiDU5Y/edit#