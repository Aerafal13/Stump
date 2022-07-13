<h1 align="center">Stump - Dofus 2 game emulator</h1>

<p align="center">
    <img src="Stump.png" alt="stump-logo" height="180px">
    </br>
    <i>This repository's main purpose is to improve and offer a new version of Stump, performance level, update the libraries and use the new technologies offered by .NET</i>
</p>

<p align="center">
    <a href="CONTRIBUTING.md">Contributing Guidlines</a>
    •
    <a href="https://github.com/Aerafal13/Stump/issues">Submit an issue</a>
    •
    <a href="LICENSE">License</a>
</p>

<hr>

## Prerequisites
- [.NET7 SDK][dotnet]
- [VisualStudio Preview][visualstudio] | [Rider][rider]

## Architecture
| Libraries | Servers |
| --- | --- |
| [Stump.Core][core] | [Stump.Servers.BaseServer][base] |
| [Stump.ORM][orm] | [Stump.Servers.AuthServer][auth] |
| [Stump.Protocol][protocol] | [Stump.Servers.WorldServer][world] |
| [Stump.Tools][tools] |

## Changelog
[Learn about the latest improvements][changelog]

## Contributing

### Contributing Guidelines
Read through our [contributing guidelines][contributing] to learn about our submission process, coding rules and more.

### Code of conduct
Help us keep Stump open and inclusive. Please read and follow our [Code of Conduct][codeofconduct].

[dotnet]: https://dotnet.microsoft.com/en-us/download/dotnet/7.0
[visualstudio]: https://visualstudio.microsoft.com/fr/vs/preview/
[rider]: https://www.jetbrains.com/fr-fr/rider/
[changelog]: CHANGELOG.md
[contributing]: CONTRIBUTING.md
[codeofconduct]: CODE_OF_CONDUCT.md
[core]: libs/Stump.Core
[orm]: libs/Stump.ORM
[protocol]: libs/Stump.Protocol
[tools]: libs/Stump.Tools
[base]: src/Stump.Servers.BaseServer
[auth]: src/Stump.Servers.AuthServer
[world]: src/Stump.Servers.WorldServer