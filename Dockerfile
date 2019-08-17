FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env
WORKDIR /app

COPY /WebApplication1/bin/Release/PublishOutput/ .
ENTRYPOINT ["dotnet", "WebApplication1.dll"]
