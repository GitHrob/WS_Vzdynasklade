FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["WS_Vzdynasklade_Statistiky/WS_Vzdynasklade_Statistiky.csproj", "WS_Vzdynasklade_Statistiky/"]
RUN dotnet restore "WS_Vzdynasklade_Statistiky/WS_Vzdynasklade_Statistiky.csproj"
COPY . .
WORKDIR "/src/WS_Vzdynasklade_Statistiky"
RUN dotnet build "WS_Vzdynasklade_Statistiky.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WS_Vzdynasklade_Statistiky.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WS_Vzdynasklade_Statistiky.dll"]