#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["src/Usuarios/CmsProject.Auth.Api/CmsProject.Auth.Api.csproj", "src/Usuarios/CmsProject.Auth.Api/"]
COPY ["src/Usuarios/CmsProject.Usuarios.Domain/CmsProject.Usuarios.Domain.csproj", "src/Usuarios/CmsProject.Usuarios.Domain/"]
COPY ["src/CmsProject.Core/CmsProject.Core.csproj", "src/CmsProject.Core/"]
COPY ["src/Usuarios/CmsProject.Usuarios.Infraestrutura/CmsProject.Usuarios.Infraestrutura.csproj", "src/Usuarios/CmsProject.Usuarios.Infraestrutura/"]
RUN dotnet restore "src/Usuarios/CmsProject.Auth.Api/CmsProject.Auth.Api.csproj"
COPY . .
WORKDIR "src/Usuarios/CmsProject.Auth.Api"
ARG Mode=Debug
RUN echo "$Mode"
RUN dotnet build "CmsProject.Auth.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CmsProject.Auth.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CmsProject.Auth.Api.dll"]