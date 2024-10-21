# Base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
# Metadata
LABEL version="1.0" description="Dotnet console Hello World"
# Copy application
COPY dist /app
# Set working directory
WORKDIR /app
# Expose port 8080/tcp
EXPOSE 8080/tcp
# Start application
ENTRYPOINT ["dotnet","appnetcore.dll"]