
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app


COPY . ./


RUN dotnet restore


RUN dotnet build --configuration Release --output /out


FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app


COPY --from=build-env /out .


ENTRYPOINT ["dotnet", "BiblioSharp.dll"]