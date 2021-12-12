#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["LaunchpadCodeChallenge.API/LaunchpadCodeChallenge.API.csproj", "LaunchpadCodeChallenge.API/"]
COPY ["LaunchpadCodeChallenge.Repository/LaunchpadCodeChallenge.Repository.csproj", "LaunchpadCodeChallenge.Repository/"]
COPY ["LaunchpadCodeChallenge.Models/LaunchpadCodeChallenge.Models.csproj", "LaunchpadCodeChallenge.Models/"]
COPY ["LaunchpadCodeChallenge.Service/LaunchpadCodeChallenge.Service.csproj", "LaunchpadCodeChallenge.Service/"]
RUN dotnet restore "LaunchpadCodeChallenge.API/LaunchpadCodeChallenge.API.csproj"
COPY . .
WORKDIR "/src/LaunchpadCodeChallenge.API"
RUN dotnet build "LaunchpadCodeChallenge.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LaunchpadCodeChallenge.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LaunchpadCodeChallenge.API.dll"]
