FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine3.20 AS base

WORKDIR /app

COPY . .

RUN dotnet build --configuration Release -o output

FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine3.20 AS runtime



WORKDIR /app

COPY --from=base /app/output .

ENTRYPOINT ["dotnet", "CrudClients.Applications.Provider.WebApi.dll"]