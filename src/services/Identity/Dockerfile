FROM mcr.microsoft.com/dotnet/sdk:7.0 as build

WORKDIR /src

COPY ["services/Identity/Identity.csproj", "services/Identity/"]
RUN dotnet restore services/Identity/Identity.csproj

COPY . .

RUN dotnet publish services/Identity/Identity.csproj --no-restore -o /app 

FROM mcr.microsoft.com/dotnet/aspnet:7.0 as final
WORKDIR /app
COPY --from=build /app .
EXPOSE 80
ENTRYPOINT ["dotnet", "Identity.dll"]