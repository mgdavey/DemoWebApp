FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
FROM microsoft/dotnet:aspnetcore-runtime
EXPOSE 80
COPY /bin/Release/netcoreapp2.2/publish .
ENTRYPOINT ["dotnet", "DemoSvc.dll"]