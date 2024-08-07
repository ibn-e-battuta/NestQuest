#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 5000
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/NestQuest.Api/NestQuest.Api.csproj", "src/NestQuest.Api/"]
COPY ["src/NestQuest.Application/NestQuest.Application.csproj", "src/NestQuest.Application/"]
COPY ["src/NestQuest.Domain/NestQuest.Domain.csproj", "src/NestQuest.Domain/"]
COPY ["src/NestQuest.Infrastructure/NestQuest.Infrastructure.csproj", "src/NestQuest.Infrastructure/"]
RUN dotnet restore "./src/NestQuest.Api/NestQuest.Api.csproj"
COPY . .
WORKDIR "/src/src/NestQuest.Api"
RUN dotnet build "./NestQuest.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./NestQuest.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NestQuest.Api.dll"]