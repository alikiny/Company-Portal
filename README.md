# Company Portal project

- Simple fullstack with minimum UI to load and fetch data into the application via PRH Api
- Check the documentation [here](https://avoindata.prh.fi/ytj_en.html)
  ![TypeScript](https://img.shields.io/badge/TypeScript-v.4-green)
  ![SASS](https://img.shields.io/badge/SASS-v.4-hotpink)
  ![React](https://img.shields.io/badge/React-v.18-blue)
  ![Redux toolkit](https://img.shields.io/badge/Redux-v.1.9-brown)
  ![.NET Core](https://img.shields.io/badge/.NET%20Core-v.7-purple)
  ![EF Core](https://img.shields.io/badge/EF%20Core-v.7-cyan)
  ![PostgreSQL](https://img.shields.io/badge/PostgreSQL-v.14-drakblue)

## Prerequisites

- NodeJS version >16
- .Net version >6
- PostgreSQL (If running in local database) version > 12

## Install project

1. Run `git clone https://github.com/alikiny/Company-Portal.git`
2. Switch to `develop` branch to see main code: `git checkout develop`
3. Setup extra configuration file for `server`
4. Run server: `dotnet run`
5. Run client: `npm start`

## Setting Up for folder `server`

1. Create `appsettings.json` (and `appsettings.*.json` if needed) file in the root of folder `server`. You can refer to the content of file `example.json`. Change the `"DefaultConnection"` to the connectin string of database of your choice
2. Run `dotnet restore` to install the missing dependencies
