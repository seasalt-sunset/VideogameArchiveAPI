FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app/VideogameArchiveAPI
COPY ./VideogameArchiveAPI/*.csproj ./
RUN dotnet restore
COPY VideogameArchiveAPI/ ./
RUN dotnet publish -c Release --no-restore -o app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app/publish
COPY --from=build /app/publish ./
ENV ASPNETCORE_URLS=http://+:8080;http://+:8081
EXPOSE 8080
EXPOSE 8081
ENTRYPOINT ["dotnet", "VideogameArchiveAPI.dll"]
