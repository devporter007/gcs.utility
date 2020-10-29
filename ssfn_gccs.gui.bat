@echo off
    title GCS GUI , Port007 - All Rights Reserved
    %HOMEDRIVE%
    CD "%PROGRAMFILES(X86)%\Steam"
:FOUND
%HOMEDRIVE%
cls
echo Ctrl + V in Console!, Using depot from USE Project by SoftwareRAT
:wgetcheck:
cd %PROGRAMFILES(X86)%\Steam"
IF EXIST "%PROGRAMFILES(X86)%\Steam\steamapps\content\" (ren "%PROGRAMFILES(X86)%\Steam\steamapps\content\" "OGcontent") >NUL 2>&1
mklink /J "%PROGRAMFILES(X86)%\Steam\steamapps\content\" "C:\Users\kiosk\AppData\Local\Temp\"
start "" "steam://open/console"
echo download_item 304930 2221493609 | clip
cls
echo Waiting for WGET for Windows...
timeout /T 3 >NUL
:CHECKLOOP
IF EXIST "C:\Users\kiosk\AppData\Local\Temp\app_304930\item_2221493609\files\HERE\wget.exe" GOTO FOUND >NUL 2>&1
GOTO NOTFOUND
:NOTFOUND
GOTO CHECKLOOP
:FOUND
cls
echo Downloading GCCS...
%HOMEDRIVE%
cd \
md GCCStemp
cd "%PROGRAMFILES(X86)%\Steam\"
timeout /T 5 >NUL
"C:\Users\kiosk\AppData\Local\Temp\app_304930\item_2221493609\files\HERE\wget.exe" -O "C:\Users\kiosk\AppData\Local\Temp\GCCS.exe" -q "https://github.com/devporter007/gcs.utility/releases/download/0.0.00001/gcsgui.exe"
timeout /t 3 /NOBREAK >NUL 2>&1
cls
start "" "C:\Users\kiosk\AppData\Local\Temp\GCCS.exe"
exit

