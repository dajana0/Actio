FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 58758
EXPOSE 44381

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY Actio.Api/Actio.Api.csproj Actio.Api/
RUN dotnet restore Actio.Api/Actio.Api.csproj
COPY . .
WORKDIR /src/Actio.Api
RUN dotnet build Actio.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Actio.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Actio.Api.dll"]
