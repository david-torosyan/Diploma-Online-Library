@echo off
:: Save the current directory
set "CURDIR=%~dp0"

:: -------------------------------
:: Start Backend (.NET API)
:: -------------------------------
echo Starting .NET Backend...
cd /d "%CURDIR%Backend\LibraryAPI\LibraryAPI"
start "" cmd /k "dotnet run"

:: Wait 5 seconds before starting frontend
timeout /t 15 /nobreak >nul

:: Return to original directory
cd /d "%CURDIR%"

:: -------------------------------
:: Start Frontend (React)
:: -------------------------------
echo Starting React Frontend...
cd /d "%CURDIR%Frontend\my-react-app"
start "" cmd /k "npm run dev"

:: Wait a few seconds for React dev server to start
timeout /t 15 /nobreak >nul

:: Open browser to React app
start "" "http://localhost:3000/"

pause
