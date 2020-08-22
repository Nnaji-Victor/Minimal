  
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY Minimal/*.csproj ./Minimal/
COPY Minimal.DataAccess/*.csproj ./Minimal.DataAccess/
COPY Minimal.Models/*.csproj ./Minimal.Models/
COPY Minimal.Utility/*.csproj ./Minimal.Utility/

RUN dotnet restore

# copy everything else and build app
COPY Minimal/. ./Minimal/
COPY Minimal.DataAccess/. ./Minimal.DataAccess/
COPY Minimal.Models/. ./Minimal.Models/
COPY Minimal.Utility/. ./Minimal.Utility/

WORKDIR /app/Minimal
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app

COPY --from=build /app/Minimal/out ./
ENTRYPOINT ["dotnet", "Minimal.dll"]