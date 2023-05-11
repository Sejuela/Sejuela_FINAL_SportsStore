FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
FROM mcr.microsoft.com/dotnet/core/sdk:3.1

COPY /bin/Release/netcoreapp3.1/publish/ Sejuela_SportsStore/

ENV ASPNETCORE_ENVIRONMENT Production

EXPOSE 5000
WORKDIR /Sejuela_SportsStore
ENTRYPOINT ["dotnet", "Sejuela_SportsStore.dll",  "--urls=http://0.0.0.0:5000"]
