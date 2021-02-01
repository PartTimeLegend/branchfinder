# BranchFinder

[![.NET](https://github.com/PartTimeLegend/branchfinder/workflows/.NET/badge.svg?branch=master)](https://github.com/PartTimeLegend/branchfinder/actions) ![GitHub top language](https://img.shields.io/github/languages/top/PartTimeLegend/branchfinder) ![GitHub](https://img.shields.io/github/license/parttimelegend/branchfinder) ![GitHub repo size](https://img.shields.io/github/repo-size/PartTimeLegend/branchfinder) [![Nuget](https://img.shields.io/nuget/dt/branchfinder)](https://www.nuget.org/packages/branchfinder/) [![Nuget](https://img.shields.io/nuget/v/branchfinder)](https://www.nuget.org/packages/branchfinder/) ![GitHub last commit](https://img.shields.io/github/last-commit/PartTimeLegend/branchfinder)

This is a library designed to be able to be included via [NuGet](https://www.nuget.org/packages/TorlessCore/) which returns the current branch as a JSON object such as:
```json
 { "branch": "master" }
```

This is mainly designed for applications that may require branch name in this format such as Terraform.

The package available here may work, it may not. I recommend you use the official nuget package source and install as follows.

## Install

### Package Manager

```powershell
Install-Package BranchFinder
```

### .NET CLI

```powershell
dotnet add package BranchFinder
```
