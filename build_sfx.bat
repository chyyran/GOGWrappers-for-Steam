::Build Batch File 
::Requires WinRAR.EXE and MSBuild 
::You can use 7z SFX as well, but you'll have to create your own build file for it
::Uses WinRAR.EXE to create SFX for portable EXE
::Get WinRAR.EXE at http://www.rarlab.com
::Trial version should work.
::Someone please write a script for an alternative SFX archiver
@echo off
set netpath=c:\Windows\Microsoft.NET\Framework\v4.0.30319
set projpath=%cd%\GOGWrappers-Steam\bin\Debug
set buildpath=%cd%
set rarpath=%programfiles%\WinRAR
c:
cd "%netpath%"
msbuild "%buildpath%\GOGWrappers-for-Steam.sln"
cd "%rarpath%"
winrar a -r -ep1 -sfx -iicon"%buildpath%\GOGWrappers-Steam\GOGWrappers.ico" -z"%buildpath%\build.conf" "%buildpath%\GOGWrappers" "%projpath%\GOGWrappers.exe" "%projpath%\batchcompile.exe"

pause