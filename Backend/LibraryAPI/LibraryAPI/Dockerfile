# syntax=docker/dockerfile:1
# Stage 1: Build
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy solution and projects
COPY LibraryAPI.sln ./
COPY Library.DAL/ ./Library.DAL/
COPY LibraryAPI/ ./LibraryAPI/

# Restore and publish
WORKDIR /src/LibraryAPI
RUN dotnet restore
RUN dotnet publish -c Release -o /app/out

# Stage 2: Runtime
FROM --platform=$TARGETPLATFORM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/out ./
EXPOSE 8080
ENTRYPOINT ["dotnet", "LibraryAPI.dll"]
