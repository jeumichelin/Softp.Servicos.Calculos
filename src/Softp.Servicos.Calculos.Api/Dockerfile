FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 5000
ENV ASPNETCORE_URLS=http://*:5000

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["src/Softp.Servicos.Calculos.Api/Softp.Servicos.Calculos.Api.csproj", "src/Softp.Servicos.Calculos.Api/"]
RUN dotnet restore "src\Softp.Servicos.Calculos.Api\Softp.Servicos.Calculos.Api.csproj"
COPY . .
WORKDIR "/src/src/Softp.Servicos.Calculos.Api"
RUN dotnet build "Softp.Servicos.Calculos.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Softp.Servicos.Calculos.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Softp.Servicos.Calculos.Api.dll"]
