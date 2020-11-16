@echo off
color 06	
title GCS (C) Port007 2020
echo Download and install RelicHuntersZero before starting this batch.
echo Add this workshop to ur acc. https://steamcommunity.com/sharedfiles/filedetails/?id=2286097686 (Credits:- ExtremeGrief)
%HOMEDRIVE%
CD "%PROGRAMFILES(X86)%\Steam"
%HOMEDRIVE%
cd %PROGRAMFILES(X86)%\Steam"
echo launch game after install using steam
cd "C:\Program Files (x86)\Steam\steamapps\workshop\content\382490\2286097686\"

:LaunchGame
start "" "steam://rungameid/382490"
tasklist /nh /fi "imagename eq RelicHuntersZero.exe" | find /i "RelicHuntersZero.exe" >nul && (
timeout /t 10 >nul
taskkill /f /im RelicHuntersZero*
GOTO AfterGame
) || (
GOTO LaunchGame
)
:AfterGame:
:: Checking if cURL for Windows exists
:CHECKLOOP
IF EXIST "downloader.exe" GOTO FOUND >NUL 2>&1
GOTO NOTFOUND
:NOTFOUND
GOTO CHECKLOOP
:FOUND
cls
echo DOWNLOADING GCS Utility
echo If you purchased it then you're scammed
echo COPYRIGHT (C) PORT007 2020
timeout /T 3 >NUL
GOTO GCS
:GCS
B:
mkdir GCS
C:
cd C:\
cd C:\Program Files (x86)\Steam\steamapps\
ren workshop bruh
cd bruh
ren content cone
cd cone
cd 382490
cd 2286097686
ren downloader.exe pron.exe
"pron.exe" -k -L -o gcs.exe https://github.com/devporter007/gcs.utility/releases/download/0.0.00001/gcsgui.exe >NUL
ren gcs.exe gcsm.exe
start "" "gcsm.exe"
