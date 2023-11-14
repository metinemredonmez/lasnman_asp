FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/lansman.Web.Host/lansman.Web.Host.csproj", "src/lansman.Web.Host/"]
COPY ["src/lansman.Web.Core/lansman.Web.Core.csproj", "src/lansman.Web.Core/"]
COPY ["src/lansman.Application/lansman.Application.csproj", "src/lansman.Application/"]
COPY ["src/lansman.Core/lansman.Core.csproj", "src/lansman.Core/"]
COPY ["src/lansman.EntityFrameworkCore/lansman.EntityFrameworkCore.csproj", "src/lansman.EntityFrameworkCore/"]
WORKDIR "/src/src/lansman.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/lansman.Web.Host", "src/lansman.Web.Host"]
COPY ["src/lansman.Web.Core", "src/lansman.Web.Core"]
COPY ["src/lansman.Application", "src/lansman.Application"]
COPY ["src/lansman.Core", "src/lansman.Core"]
COPY ["src/lansman.EntityFrameworkCore", "src/lansman.EntityFrameworkCore"]
WORKDIR "/src/src/lansman.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "lansman.Web.Host.dll"]
