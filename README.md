GOGWizard-SteamBridge
=====================

Usage
-----

###Default Mode
**You must have a gfw_high.ico in your GOG.com game folder for this to install. All GOG.com games have this, if you have deleted this file, reinstall the game.
1. Choose the shortcut file (*.lnk) that starts the DOSBOX or ScummVM game that you downloaded off of GOG.com  
2. If you have selected a valid shortcut, the icon path should automatically be the gfw_high.ico for that game, but you can change this as you wish  
3. Press "Create Wrapper". Wait for about a few seconds, and it will generate a wrapper, you can now add this to Steam with the "Add Non-Steam Game" feature

###Batch Mode
1. Put all the shortcut files that run GOG.com DOSBOX and/or ScummVM games in one folder  
2. Select the folder with batch mode  
3. Click "Process Folder"  
4. Only valid Shortcuts that link to games will be processed. It will use the game's gfw_high.ico. After processing, the folder where you put all the shortcuts will pop up, this is where the wrappers have been made. Each wrapper uses the gamename taken from the shortcut file and ends in ".exe" You can now add these to Steam.

Compiling
---------
To build, run build.bat. This will build it in GOG-SteamBridge\bin\Debug
To create the portable SFX installer version, you must have WinRar installed. The trial version should work fine. Run build_sfx.bat, and it will output GOGWizard-SteamBridge.exe in the same folder.

If you have any problems, look into the build scripts and change the parameters, or compile it yourself with VS2010.

License
-------
The source code is licensed under GNU GPL v3. A copy of this source code is available in this repository.