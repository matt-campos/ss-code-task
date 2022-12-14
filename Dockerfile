# global arg to make available for all stages
ARG buildProject=AppCode.Dev
ARG publishOutputDir=publishedOutput

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

# redefine for use in stage
ARG buildProject
ARG publishOutputDir

WORKDIR /app

# copy everything else and build app
COPY . ./AppCode/
WORKDIR /app/AppCode/$buildProject
RUN dotnet publish -c Release -o $publishOutputDir


FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime

# redefine for use in stage
ARG buildProject
ARG publishOutputDir

WORKDIR /app
COPY --from=build /app/AppCode/$buildProject/$publishOutputDir .
ENV ASPNETCORE_URLS="http://+"

RUN touch appExecutor.sh
RUN echo "dotnet ${buildProject}.dll" >> appExecutor.sh
RUN chmod +x appExecutor.sh
ENTRYPOINT ./appExecutor.sh

