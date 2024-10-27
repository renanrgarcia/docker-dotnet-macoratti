FROM mcr.microsoft.com/dotnet/runtime:8.0
LABEL version="3.0" description="ASP .NET Core MVC - Exercise"
COPY dist /app
WORKDIR /app
EXPOSE 8080/tcp
ENTRYPOINT ["dotnet","mvc2.dll"]