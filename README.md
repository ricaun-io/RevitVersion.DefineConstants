# RevitVersion.DefineConstants

[![Revit 2019+](https://img.shields.io/badge/Revit-2019+-blue.svg)](https://github.com/ricaun-io/RevitVersion.DefineConstants)
[![Visual Studio 2022](https://img.shields.io/badge/Visual%20Studio-2022-blue)](https://github.com/ricaun-io/RevitVersion.DefineConstants)
[![Nuke](https://img.shields.io/badge/Nuke-Build-blue)](https://nuke.build/)
[![License MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![Build](https://github.com/ricaun-io/RevitVersion.DefineConstants/actions/workflows/Build.yml/badge.svg)](https://github.com/ricaun-io/RevitVersion.DefineConstants/actions)
[![Release](https://img.shields.io/nuget/v/RevitVersion.DefineConstants?logo=nuget&label=release&color=blue)](https://www.nuget.org/packages/ricaun.RevitVersion.DefineConstants)

Convert `RevitVersion` property to `DefineConstants` with version `2019+` with [or-greater-defines](https://github.com/dotnet/designs/blob/main/accepted/2020/or-greater-defines/or-greater-defines.md).

## Installation

Install the package using the `NuGet` package manager or using `PackageReference`.

```xml
<PackageReference Include="ricaun.RevitVersion.DefineConstants" Version="*">
  <PrivateAssets>all</PrivateAssets>
  <IncludeAssets>runtime; build; native; contentfiles; analyzers</IncludeAssets>
</PackageReference>
```

RevitVersion | Define | Define with or-greater
-------------|--------|-------------------------------
`2019`| `REVIT2019` | `REVIT2019_OR_GREATER`
`2020`| `REVIT2020` | `REVIT2020_OR_GREATER`, `REVIT2019_OR_GREATER`
`2021`| `REVIT2021` | `REVIT2021_OR_GREATER`, `REVIT2020_OR_GREATER`, `REVIT2019_OR_GREATER`
`2022`| `REVIT2022` | `REVIT2022_OR_GREATER`, `REVIT2021_OR_GREATER`, `REVIT2020_OR_GREATER`, `REVIT2019_OR_GREATER`
`2023`| `REVIT2023` | `REVIT2023_OR_GREATER`, `REVIT2022_OR_GREATER`, `REVIT2021_OR_GREATER`, `REVIT2020_OR_GREATER`, `REVIT2019_OR_GREATER`
`2024`| `REVIT2024` | `REVIT2024_OR_GREATER`, `REVIT2023_OR_GREATER`, `REVIT2022_OR_GREATER`, `REVIT2021_OR_GREATER`, `REVIT2020_OR_GREATER`, `REVIT2019_OR_GREATER`
`2025`| `REVIT2025` | `REVIT2025_OR_GREATER`, `REVIT2024_OR_GREATER`, `REVIT2023_OR_GREATER`, `REVIT2022_OR_GREATER`, `REVIT2021_OR_GREATER`, `REVIT2020_OR_GREATER`, `REVIT2019_OR_GREATER`

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
  <DefineConstants>$(DefineConstants);REVIT2024_OR_GREATER;REVIT2023_OR_GREATER;REVIT2022_OR_GREATER;REVIT2021_OR_GREATER;REVIT2020_OR_GREATER;REVIT2019_OR_GREATER</DefineConstants>
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
}
```

### RevitVersionMinimal

To set minimal version for `XXX_OR_GREATER` use `RevitVersionMinimal`:
```xml
<PropertyGroup>
  <RevitVersion>2024</RevitVersion>
  <RevitVersionMinimal>2021</RevitVersionMinimal>
</PropertyGroup>
```

Generate `DefineConstants`:
```xml
<PropertyGroup>
  <DefineConstants>$(DefineConstants);REVIT2024</DefineConstants>
  <DefineConstants>$(DefineConstants);REVIT2024_OR_GREATER;REVIT2023_OR_GREATER;REVIT2022_OR_GREATER;REVIT2021_OR_GREATER</DefineConstants>
</PropertyGroup>
```

**The default value of `RevitVersionMinimal` is `2019`.**

### SupportedRevitVersion

The `SupportedRevitVersion` is a `ItemGroup` that includes the version `2015`, `2016`, `2017`, `2018`, `2019`, `2020`, `2021`, `2022`, `2023`, `2024`, `2025`, `2026`, `2027`, `2028`, `2029` and `2030`.

That's the range of versions that can be used in the `RevitVersion` and `RevitVersionMinimal` property.

## License

This project is [licensed](LICENSE) under the [MIT License](https://en.wikipedia.org/wiki/MIT_License).

---

Do you like this project? Please [star this project on GitHub](https://github.com/ricaun-io/RevitVersion.DefineConstants/stargazers)!