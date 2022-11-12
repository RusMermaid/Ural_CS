FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["UralFunc/UralFunc.fsproj", "UralFunc/"]
RUN dotnet restore "UralFunc/UralFunc.fsproj"
COPY . .
WORKDIR "/src/UralFunc"
RUN dotnet build "UralFunc.fsproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UralFunc.fsproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UralFunc.dll"]
