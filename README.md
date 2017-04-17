# nancy-veil-sample

A sample of using Veil with Nancy


## Run locally
```
dotnet restore
dotnet run
open http://localhost:5000
```

## Run in docker
```
dotnet restore
dotnet build -c Release
docker build -t nancy-veil-sample .
dotnet run --rm -p 5000:5000 nancy-veil-sample
```
