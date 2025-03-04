# Usa a imagem oficial do .NET SDK para build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copia os arquivos do projeto e restaura as dependências
COPY *.csproj ./
RUN dotnet restore

# Copia todos os arquivos e compila a aplicação
COPY . ./
RUN dotnet publish -c Release -o out

# Usa a imagem runtime do .NET para executar a API
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

# Expõe a porta da API (ajuste conforme necessário)
EXPOSE 8080

# Comando de inicialização da API
ENTRYPOINT ["dotnet", "LibraryApi.dll"]
