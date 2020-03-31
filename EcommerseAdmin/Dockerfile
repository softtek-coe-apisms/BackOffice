FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
RUN ls
# Uptaded manually outside VS2017 because we get COPY failed with the other COPY statement
COPY  ["EcommerseAdmin.csproj","EcommerseAdmin/"]
#This lines is set automatically assinged by VS2017
#COPY ["EcommerseAdmin/EcommerseAdmin.csproj", "EcommerseAdmin/"]
RUN dotnet restore "EcommerseAdmin/EcommerseAdmin.csproj"
COPY . .
WORKDIR "/src/EcommerseAdmin"
RUN ls
RUN dotnet build "EcommerseAdmin.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "EcommerseAdmin.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "EcommerseAdmin.dll"]