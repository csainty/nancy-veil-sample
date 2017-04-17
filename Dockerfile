FROM microsoft/aspnetcore
WORKDIR /app
COPY bin/Release/netcoreapp1.1/ .
ENTRYPOINT ["dotnet", "nancy-veil-sample.dll"]


