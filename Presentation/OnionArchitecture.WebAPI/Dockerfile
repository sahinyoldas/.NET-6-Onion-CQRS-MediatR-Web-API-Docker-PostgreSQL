#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Presentation/OnionArchitecture.WebAPI/OnionArchitecture.WebAPI.csproj", "Presentation/OnionArchitecture.WebAPI/"]
COPY ["Infrastructure/OnionArchitecture.Infrastructure/OnionArchitecture.Infrastructure.csproj", "Infrastructure/OnionArchitecture.Infrastructure/"]
COPY ["Core/OnionArchitecture.Application/OnionArchitecture.Application.csproj", "Core/OnionArchitecture.Application/"]
COPY ["Core/OnionArchitecture.Domain/OnionArchitecture.Domain.csproj", "Core/OnionArchitecture.Domain/"]
COPY ["Infrastructure/OnionArchitecture.Persistence/OnionArchitecture.Persistence.csproj","Infrastructure/OnionArchitecture.Persistence/"]
RUN dotnet restore "Presentation/OnionArchitecture.WebAPI/OnionArchitecture.WebAPI.csproj"
COPY . .
WORKDIR "/src/Presentation/OnionArchitecture.WebAPI"
RUN dotnet build "OnionArchitecture.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OnionArchitecture.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OnionArchitecture.WebAPI.dll"]
