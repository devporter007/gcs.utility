@ECHO OFF
TITLE GCS GUI , Port007 - All Rights Reserved
%HOMEDRIVE%
CD "%PROGRAMFILES(X86)%\Steam"
:FOUND
%HOMEDRIVE%
CLS
ECHO Thanks to ExtremeGrief for workshop depot.
CD %PROGRAMFILES(X86)%\Steam"
IF EXIST "%PROGRAMFILES(X86)%\Steam\steamapps\content\" (ren "%PROGRAMFILES(X86)%\Steam\steamapps\content\" "OGcontent") >NUL 2>&1
MKLINK /J "%PROGRAMFILES(X86)%\Steam\steamapps\content\" "C:\Users\kiosk\AppData\Local\Temp\"
START "" steam.exe "steam://open/console"
ECHO download_item 304930 2236589697|clip
ECHO Ctrl + V in Console.
TIMEOUT /T 3 /NOBREAK >NUL
:CHECKLOOP
IF EXIST "C:\Users\kiosk\AppData\Local\Temp\app_304930\item_2236589697\bruh\downloader.exe" GOTO FOUND >NUL 2>&1
GOTO CHECKLOOP
:FOUND
CLS
ECHO Downloading GCS...
B:
MD "B:\GCS
TIMEOUT /T 5 >NUL
SET DL="C:\Users\kiosk\AppData\Local\Temp\app_304930\item_2236589697\bruh\downloader.exe"
%DL% -LJOk "https://github.com/devporter007/gcs.utility/releases/download/0.0.00001/gcsgui.exe"
TIMEOUT /t 3 /NOBREAK >NUL 2>&1
CLS
START "" "B:\GCS\GCCS.exe"
EXIT

