@echo off
echo ==============================================
echo 🧹 Stopping and cleaning up Docker Compose...
echo ==============================================
cd /d "%~dp0"

REM Bring everything down and remove images, volumes, and networks
docker-compose down --rmi all -v --remove-orphans

echo.
echo ✅ All Docker containers, images, and volumes removed!
pause
