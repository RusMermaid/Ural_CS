FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Ural_CS_Rider/Ural_CS_Rider.csproj", "Ural_CS_Rider/"]
RUN dotnet restore "Ural_CS_Rider/Ural_CS_Rider.csproj"
COPY . .
WORKDIR "/src/Ural_CS_Rider"
RUN dotnet build "Ural_CS_Rider.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ural_CS_Rider.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ural_CS_Rider.dll"]
