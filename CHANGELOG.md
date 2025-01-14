# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [1.0.0] / 2024-03-27
### Features
- Support version `2015` to `2030` in `SupportedRevitVersion`.
- Property `RevitVersion` to `DefineConstants` with `REVITXXXX` and `REVITXXXX_OR_GREATER`.
- Add `RevitVersionMinimal` `PropertyGroup` to set minimal version for `XXX_OR_GREATER`. (Default: `2019`)
- Update `XXX_OR_GREATER` implementation based on [discussions](https://github.com/Nice3point/RevitTemplates/discussions/43).
- `Test` project with `CountTests` for version `2017`, `2019`, `2021` and `2025`. (`RevitVersionMinimal` to `2017`) 

[vNext]: ../../compare/1.0.0...HEAD
[1.0.0]: ../../compare/1.0.0