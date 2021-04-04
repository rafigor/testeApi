FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

#Copiar
COPY *.csproj ./
RUN dotnet restore

RUN pwsh -Command Write-Host "Gerando imagem Docker e testando o PowerShell Core"

COPY . ./
RUN dotnet publish -c Release -o dist

# Build da imagem
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/dist .
ENTRYPOINT ["dotnet", "TaxaJurosAPI.dll"]