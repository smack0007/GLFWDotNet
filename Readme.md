[![The MIT License](https://img.shields.io/badge/license-MIT-orange.svg?style=flat-square)](http://opensource.org/licenses/MIT)
[![Build Status](https://dev.azure.com/smack0007/Github/_apis/build/status/smack0007.GLFWDotNet?branchName=master)](https://dev.azure.com/smack0007/Github/_build/latest?definitionId=13?branchName=master)
[![BotBuilder Badge](https://buildstats.info/nuget/GLFWDotNet)](https://www.nuget.org/packages/GLFWDotNet/)  

# GLFWDotNet

.NET bindings for [GLFW](http://www.glfw.org). Currently only tested / works on Windows but should be
fairly easy to make it work on other platforms. Pull requests are welcome.

## Usage

Use one of the following options:

* Use the [NuGet](https://www.nuget.org/packages/GLFWDotNet/) package.
* Include [GLFW.cs](https://github.com/smack0007/GLFWDotNet/blob/master/src/GLFWDotNet/GLFW.cs) directly
  in your project.
  
### Native DLLs
  
If you include GLFW.cs directly into your project, the GLFW dlls must be
copied into x86/x64 subdirectories relative to the GLFWDotNet.dll. See the
output of the samples. An example MSBuild Target can be seen in the
[Directory.Build.targets](https://github.com/smack0007/GLFWDotNet/blob/master/samples/Directory.Build.targets)
of the samples.

```XML
<Target Name="CopyGLFWDlls" AfterTargets="AfterBuild">
  <Copy SourceFiles="$(RepositoryRootDirectory)ext\GLFW\x64\glfw3.dll"
        DestinationFolder="$(TargetDir)x64\" />

  <Copy SourceFiles="$(RepositoryRootDirectory)ext\GLFW\x86\glfw3.dll"
        DestinationFolder="$(TargetDir)x86\" />
</Target>
```

`RepositoryRootDirectory` comes from the [Directory.Build.props](https://github.com/smack0007/GLFWDotNet/blob/master/Directory.Build.props) in the root directory.

## Samples

There are a few [samples](https://github.com/smack0007/GLFWDotNet/tree/master/samples) showing how to use GLFWDotNet.

* [HelloWorld](https://github.com/smack0007/GLFWDotNet/blob/master/samples/HelloWorld/Program.cs) Basic HelloWorld program to get you started.
* [GLFWInfo](https://github.com/smack0007/GLFWDotNet/blob/master/samples/GLFWInfo/Program.cs) Writes information about the system out to the console.
