@echo off
echo ==============================================
echo 🚀 Starting Docker Compose (with rebuild)...
echo ==============================================
set DOCKER_BUILDKIT=0

REM Navigate to the directory containing docker-compose.yml
cd /d "%~dp0"

REM Stop old containers (optional cleanup)
docker-compose down --remove-orphans

REM Rebuild images and start containers
docker-compose up --build -d

echo.
echo 🟢 Docker Compose started successfully!
echo To view logs, run: docker-compose logs -f
pause
