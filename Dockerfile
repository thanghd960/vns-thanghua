FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

EXPOSE 5000

COPY ./out .

CMD ASPNETCORE_URLS=http://*:$PORT dotnet Vns.Web.dll

