::Build Batch File 
::Requires .NET 4.0
@echo off
set netpath=c:\Windows\Microsoft.NET\Framework\v4.0.30319
set projpath=%cd%\GOG-SteamBridge\bin\Debug
set buildpath=%cd%
c:
cd "%netpath%"
msbuild "%buildpath%"\GOGWizard-SteamBridge.sln

pause