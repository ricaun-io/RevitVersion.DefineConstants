# RevitVersion.DefineConstants

[![Revit 2017](https://img.shields.io/badge/Revit-2017...2025-blue.svg)](../..)
[![Visual Studio 2022](https://img.shields.io/badge/Visual%20Studio-2022-blue)](../..)
[![Nuke](https://img.shields.io/badge/Nuke-Build-blue)](https://nuke.build/)
[![License MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![Build](../../actions/workflows/Build.yml/badge.svg)](../../actions)

Convert `RevitVersion` property to `DefineConstants` with version 2017 to 2025. 

## Installation

```xml
<PackageReference Include="RevitVersion.DefineConstants" Version="*-*" />
```

## Example
### RevitVersion 2024

```xml
<PropertyGroup>
  <RevitVersion>2024</RevitVersion>
</PropertyGroup>
```

Generate `DefineConstants`:
```xml
<PropertyGroup>
  <DefineConstants>$(DefineConstants);REVIT2024</DefineConstants>
  <DefineConstants>$(DefineConstants);REVIT2024_OR_GREATER;REVIT2023_OR_GREATER;REVIT2022_OR_GREATER;REVIT2021_OR_GREATER;REVIT2020_OR_GREATER;REVIT2019_OR_GREATER;REVIT2018_OR_GREATER;REVIT2017_OR_GREATER</DefineConstants>
  <DefineConstants>$(DefineConstants);REVIT2024_OR_LESS;REVIT2025_OR_LESS</DefineConstants>
</PropertyGroup>
```


## License

This project is [licensed](LICENSE) under the [MIT Licence](https://en.wikipedia.org/wiki/MIT_License).

---

Do you like this project? Please [star this project on GitHub](../../stargazers)!