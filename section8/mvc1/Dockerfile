FROM mcr.microsoft.com/dotnet/runtime:8.0
LABEL version="2.0" description="Aplicacao ASP .NET Core MVC"
COPY dist /app
WORKDIR /app
EXPOSE 8080/tcp
ENTRYPOINT ["dotnet","mvc1.dll"]