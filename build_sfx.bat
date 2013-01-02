::Build Batch File 
::Requires MSBuild 
::Uses the included batchcompile.exe to create a standalone package
::Run in C Drive, or it will fail.
@echo off

set fileversion=1,1,0,0
set netpath=c:\Windows\Microsoft.NET\Framework\v4.0.30319
set projpath=%cd%\GOGWrappers-Steam\bin\Debug
set buildpath=%cd%
%netpath%\msbuild "%buildpath%\GOGWrappers-for-Steam.sln"
echo start GOGWrappers.exe > start.bat
GOGWrappers-Steam\batchcompile.exe -bat "%buildpath%\start.bat" -save "%buildpath%\GOGWrappers.exe" -icon "%buildpath%\GOGWrappers-Steam\GOGWrappers.ico" -invisible -temp -include "%projpath%\batchcompile.exe" -include "%projpath%\GOGWrappers.exe" -overwrite -fileversion %fileversion% -productversion 1,0,0,0 -productname "GOGWrappers for Steam" -description "Easily add GOG.com DOSBOX and ScummVM games to Steam" -internalname "GOGWrappers"
del start.bat
echo Built to %buildpath%\GOGWrappers.exe
pause