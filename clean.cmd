@ECHO OFF
dotnet msbuild %~dp0build\Build.proj -nologo /t:Clean