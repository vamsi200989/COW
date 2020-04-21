#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["COW.API/COW.API.csproj", "COW.API/"]
COPY ["COW.Service/COW.Service.csproj", "COW.Service/"]
COPY ["COW.Model/COW.Model.csproj", "COW.Model/"]
COPY ["COW.Data/COW.Data.csproj", "COW.Data/"]
RUN dotnet restore "COW.API/COW.API.csproj"
COPY . .
WORKDIR "/src/COW.API"
RUN dotnet build "COW.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "COW.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "COW.API.dll"]