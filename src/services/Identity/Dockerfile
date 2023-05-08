FROM mcr.microsoft.com/dotnet/sdk as build

WORKDIR /src

COPY ["Identity.csproj", "Identity.csproj"]
RUN dotnet restore
RUN dotnet publish --no-restore -o /app

FROM mcr.microsoft.com/dotnet/aspnet:7.0 as final
WORKDIR /app
COPY --from=build /app .
EXPOSE 80
ENTRYPOINT ["dotnet", "Identity.dll"]