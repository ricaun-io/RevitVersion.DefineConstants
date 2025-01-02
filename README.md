# RevitVersion.DefineConstants

[![Revit 2017](https://img.shields.io/badge/Revit-2017...2025-blue.svg)](../..)
[![Visual Studio 2022](https://img.shields.io/badge/Visual%20Studio-2022-blue)](../..)
[![Nuke](https://img.shields.io/badge/Nuke-Build-blue)](https://nuke.build/)
[![License MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![Build](../../actions/workflows/Build.yml/badge.svg)](../../actions)
[![Release](https://img.shields.io/nuget/v/RevitVersion.DefineConstants?logo=nuget&label=release&color=blue)](https://www.nuget.org/packages/RevitVersion.DefineConstants)

Convert `RevitVersion` property to `DefineConstants` with version `2017` to `2025` with [or-greater-defines](https://github.com/dotnet/designs/blob/main/accepted/2020/or-greater-defines/or-greater-defines.md).

## Installation

```xml
<PackageReference Include="RevitVersion.DefineConstants" Version="*-*" />
```

RevitVersion | Define | Define with or-greater
-------------|--------|-------------------------------
`2017`| `REVIT2017` | `REVIT2017_OR_GREATER`
`2018`| `REVIT2018` | `REVIT2018_OR_GREATER`, `REVIT2017_OR_GREATER`
`2019`| `REVIT2019` | `REVIT2019_OR_GREATER`, `REVIT2018_OR_GREATER`, `REVIT2017_OR_GREATER`
`2020`| `REVIT2020` | `REVIT2020_OR_GREATER`, `REVIT2019_OR_GREATER`, `REVIT2018_OR_GREATER`, `REVIT2017_OR_GREATER`
`2021`| `REVIT2021` | `REVIT2021_OR_GREATER`, `REVIT2020_OR_GREATER`, `REVIT2019_OR_GREATER`, `REVIT2018_OR_GREATER`, `REVIT2017_OR_GREATER`
`2022`| `REVIT2022` | `REVIT2022_OR_GREATER`, `REVIT2021_OR_GREATER`, `REVIT2020_OR_GREATER`, `REVIT2019_OR_GREATER`, `REVIT2018_OR_GREATER`, `REVIT2017_OR_GREATER`
`2023`| `REVIT2023` | `REVIT2023_OR_GREATER`, `REVIT2022_OR_GREATER`, `REVIT2021_OR_GREATER`, `REVIT2020_OR_GREATER`, `REVIT2019_OR_GREATER`, `REVIT2018_OR_GREATER`, `REVIT2017_OR_GREATER`
`2024`| `REVIT2024` | `REVIT2024_OR_GREATER`, `REVIT2023_OR_GREATER`, `REVIT2022_OR_GREATER`, `REVIT2021_OR_GREATER`, `REVIT2020_OR_GREATER`, `REVIT2019_OR_GREATER`, `REVIT2018_OR_GREATER`, `REVIT2017_OR_GREATER`
`2025`| `REVIT2025` | `REVIT2025_OR_GREATER`, `REVIT2024_OR_GREATER`, `REVIT2023_OR_GREATER`, `REVIT2022_OR_GREATER`, `REVIT2021_OR_GREATER`, `REVIT2020_OR_GREATER`, `REVIT2019_OR_GREATER`, `REVIT2018_OR_GREATER`, `REVIT2017_OR_GREATER`

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
</PropertyGroup>
```

### Sample
```csharp
public class Revit
{
#if REVIT2025
    public class Revit2025 { }
#endif
#if REVIT2024
    public class Revit2024 { }
#endif
#if REVIT2023
    public class Revit2023 { }
#endif
#if REVIT2022
    public class Revit2022 { }
#endif
#if REVIT2021
    public class Revit2021 { }
#endif
#if REVIT2020
    public class Revit2020 { }
#endif
#if REVIT2019
    public class Revit2019 { }
#endif
#if REVIT2018
    public class Revit2018 { }
#endif
#if REVIT2017
    public class Revit2017 { }
#endif

#if REVIT2025_OR_GREATER
    public class Revit2025OrGreater { }
#endif
#if REVIT2024_OR_GREATER
    public class Revit2024OrGreater { }
#endif
#if REVIT2023_OR_GREATER
    public class Revit2023OrGreater { }
#endif
#if REVIT2022_OR_GREATER
    public class Revit2022OrGreater { }
#endif
#if REVIT2021_OR_GREATER
    public class Revit2021OrGreater { }
#endif
#if REVIT2020_OR_GREATER
    public class Revit2020OrGreater { }
#endif
#if REVIT2019_OR_GREATER
    public class Revit2019OrGreater { }
#endif
#if REVIT2018_OR_GREATER
    public class Revit2018OrGreater { }
#endif
#if REVIT2017_OR_GREATER
    public class Revit2017OrGreater { }
#endif
}
```


## License

This project is [licensed](LICENSE) under the [MIT License](https://en.wikipedia.org/wiki/MIT_License).

---

Do you like this project? Please [star this project on GitHub](../../stargazers)!