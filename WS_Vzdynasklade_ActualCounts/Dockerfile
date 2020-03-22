FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["WS_Vzdynasklade_ActualCounts/WS_Vzdynasklade_ActualCounts.csproj", "WS_Vzdynasklade_ActualCounts/"]
RUN dotnet restore "WS_Vzdynasklade_ActualCounts/WS_Vzdynasklade_ActualCounts.csproj"
COPY . .
WORKDIR "/src/WS_Vzdynasklade_ActualCounts"
RUN dotnet build "WS_Vzdynasklade_ActualCounts.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WS_Vzdynasklade_ActualCounts.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
EXPOSE 80
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WS_Vzdynasklade_ActualCounts.dll"]