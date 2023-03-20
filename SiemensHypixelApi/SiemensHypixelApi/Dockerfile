FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SiemensHypixelApi/SiemensHypixelApi.csproj", "SiemensHypixelApi/"]
RUN dotnet restore "SiemensHypixelApi/SiemensHypixelApi.csproj"
COPY . .
WORKDIR "/src/SiemensHypixelApi"
RUN dotnet build "SiemensHypixelApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SiemensHypixelApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SiemensHypixelApi.dll"]
