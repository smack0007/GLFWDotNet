[![The MIT License](https://img.shields.io/badge/license-MIT-orange.svg?style=flat-square)](http://opensource.org/licenses/MIT)
![Build Status](https://smack0007.visualstudio.com/_apis/public/build/definitions/34bb64ac-53c0-4e81-9c7b-65d412b0d1c8/2/badge)

# GLFWDotNet

.NET bindings for [GLFW](http://www.glfw.org).

## Usage

Use one of the following options:

* Compile the GLFWDotNet assembly using Visual Studio or MSBuild.
* Include [GLFW.cs](https://github.com/smack0007/GLFWDotNet/blob/master/src/GLFWDotNet/GLFW.cs) directly
  in your project.
  
The glfw dlls must be copied into x86/x64 subdirectories relative to the GLFWDotNet.dll. See the output of the samples. An example MSBuild Target can be seen in the [Directory.Build.targets](https://github.com/smack0007/GLFWDotNet/blob/master/samples/Directory.Build.targets) of the samples.

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

* [HelloWorld](https://github.com/smack0007/GLFWDotNet/tree/master/Source/Samples/HelloWorld) Basic HelloWorld program to get you started.
