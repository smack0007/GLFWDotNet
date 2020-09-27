[![The MIT License](https://img.shields.io/badge/license-MIT-orange.svg?style=flat-square)](http://opensource.org/licenses/MIT)
[![Actions Status](https://github.com/smack0007/GLFWDotNet/workflows/CI/badge.svg)](https://github.com/smack0007/GLFWDotNet/actions)
[![NuGet Badge](https://buildstats.info/nuget/GLFWDotNet)](https://www.nuget.org/packages/GLFWDotNet/)

# GLFWDotNet

.NET bindings for [GLFW](http://www.glfw.org). Currently only tested / works on Windows but should be
fairly easy to make it work on other platforms. Pull requests are welcome.

## Usage

Use one of the following options:

* Use the [NuGet](https://www.nuget.org/packages/GLFWDotNet/) package.
* Include [GLFW.cs](https://github.com/smack0007/GLFWDotNet/blob/master/src/GLFWDotNet/GLFW.cs) directly
  in your project.
  
### Native DLLs

#### Windows  

If you include GLFW.cs directly into your project you'll need to implement the LoadAssembly() method of
the GLFW class yourself, the default implementation is in [GLFW.LoadAssembly.cs](https://github.com/smack0007/GLFWDotNet/blob/master/src/GLFWDotNet/GLFW.LoadAssembly.cs).

This can also just be included in your project of course, in which case the GLFW dlls must be copied into runtimes\\{win-x86|win-x64}\\native subdirectories relative to the GLFWDotNet.dll. See the
output of the samples. An example MSBuild Target can be seen in the
[CopyDependencies.targets](https://github.com/smack0007/GLFWDotNet/blob/master/build/CopyDependencies.targets)
build script.

```xml
<PropertyGroup>
  <GLFWDirectory>$(MSBuildThisFileDirectory)..\ext\GLFW\</GLFWDirectory>
</PropertyGroup>

<Target Name="CopyGLFW" AfterTargets="AfterBuild">
  <Copy
    SourceFiles="$(GLFWDirectory)x64\glfw3.dll"
    DestinationFolder="$(TargetDir)runtimes\win-x64\native" />

  <Copy
    SourceFiles="$(GLFWDirectory)x86\glfw3.dll"
    DestinationFolder="$(TargetDir)runtimes\win-x86\native" />
</Target>
```

#### Linux

Usage on Linux requires `libglfw.so` to be installed as well as `libdl.so`.

In Ubuntu the dependencies can be installed via the following command:

```bash
sudo apt install libc6-dev libglfw3-dev
```

#### MacOS

Usage on MacOS requires `libglfw.dylib` to be installed. Dependencies can be installed
via brew with the following command:

```bash
brew install glfw3
```

## Samples

There are a few [samples](https://github.com/smack0007/GLFWDotNet/tree/master/samples) showing how to use GLFWDotNet.

* [HelloWorld](https://github.com/smack0007/GLFWDotNet/blob/master/samples/HelloWorld/Program.cs) Basic HelloWorld program to get you started.
* [GLFWInfo](https://github.com/smack0007/GLFWDotNet/blob/master/samples/GLFWInfo/Program.cs) Writes information about the system out to the console.
