#  Local Business Lookup - an API Solution

#### By Vera Weikel 

#### This is a project to build Basic Web Api Application using ASP .Net and EF Core databases.

## Technologies Used

* .Net 6 SDK
* C#
* EFCore
* ASP.Net 
* Swagger
* Api
* RestSharp
* Newtonsoft

## Goals/Objectives

This project shows how to connect an ASP.NET Core MVC project to a MySQL database using [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/).

## Description

This project in an ASP.NET Core API project to authenticate users.

## Endpoints: 

Document our API's endpoints, make sure we consider what is in our API. For example, in our API:

* We have multiple endpoints, all of which we want to include in our documentation.
* Some endpoints include optional query strings that we'll want to document.
* Some endpoints require a body to be included along with the request.
<br> 
GET http://localhost:5155/api/tryjson/  (*pagination)<br> 
GET http://localhost:5155/api/businesses/<br> 
GET http://localhost:5155/api/businesses/{id}<br> 
POST http://localhost:5155/api/businesses/<br> 
PUT http://localhost:5155/api/businesses/{id}<br> 
DELETE http://localhost:5155/api/businesses/{id}<br> 

Note: The {id} in the URL is a variable and it should be replaced with the id number of the business the user wants to GET, PUT, or DELETE.

pageNumber	    | int	| not required	| Returns a specified page number of query items<br> 
resultsPerPage	| int	| not required	| Returns a specified number of query items per page

| type              | String           | not required   | Returns businesses with a matching type value|<br> 

◊ GET http://localhost:5155/api/businesses/tryjson?pagenumber=[ENTER-AN-INT-A-PAGE-NUMBER]&resultperpage=[ENTER-AN-INT-RESULTS-PER-PAGE]
name	    | String	| not required	 | Returns businesses with a matching type value 

◊ GET http://localhost:5155/api/businesses?type=[ENTER-MATCHING-TYPE-VALUE]
name	    | String	| not required	 | Returns businesses with a matching name value 

◊ GET http://localhost:5155/api/businesses?name=[ENTER-MATCHING-NAME-VALUE]
minumumYearsInBusiness | Number	| not required  | Returns businesses that have a yearsinbusiness value that is greater than or equal to the specified minumumYearsInBusiness value

◊ GET http://localhost:5155/api/businesses?minumumYearsInBusiness=[ENTER-MINIMUM-YEARS-IN-BUSINESS-INTEGER-VALUE]
type&minumumYearsInBusiness | String & Number | neither required	| Returns businesses with a matching type value and a yearsinbusiness value that is greater than or equal to the specified minumumYearsInBusiness value

◊ GET http://localhost:5155/api/businesses?type=[ENTER-MATCHING-TYPE-VALUE]&minumumYearsInBusiness=[ENTER-MINIMUM-YEARS-IN-BUSINESS-INTEGER-VALUE]

◊ POST request to http://localhost:5155/api/businesses/, must have a JSON body included when being made. Here is an example body in JSON:

```json 
{
  "type": "Shop",
  "name": "Tyrannosaurus Rex Toys",
  "yearsInBusiness": 8
}
``` 

◊ PUT request we would send the previous body to:

http://localhost:5155/api/businesses/1
Notice that the value of businessId needs to match the id number in the URL. In this example, they are both 1.

## Pagination for the API

Access the API endpoint with a query parameter that specifies the page that should be returned and the number of results per page. For example, the query string /records?page=2 might return page 2 of the results. This creates a page that does simple grouping.

GET http://localhost:5155/api/business/api/tryjson/


## How To Run This Project

If you have not already, install the `dotnet-ef` tool by running the following command in your terminal:

``` bash
$ dotnet tool install --global dotnet-ef --version 6.0.0
$ dotnet add package RestSharp --version 108.0.3
$ dotnet add package Newtonsoft.Json --version 13.0.2
```

### Set Up and Run Project

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory.
3. Within the production directory create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. For the LearnHowToProgram.com lessons, we always assume the `uid` is `root` and the `pwd` is `epicodus`.

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*", 
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=business_api;uid=[YOUR-USERNAME];pwd=[YOUR-PASSWORD];"
  }
}

```
5. Within the production directory create a new file called `appsettings.Development.json`.
6. Within `appsettings.Development.json`, put in the following code:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Trace",
      "Microsoft.AspNetCore": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}
```

5. Update the database using the migrations in the  project. Open your shell (e.g., Terminal or GitBash) to the production directory, and run `dotnet ef database update`. 
6. Within the production directory, run `dotnet watch run` in the command line to start the project in development mode with a watcher.
4. Open the browser to _https://localhost:5155/swagger / localhost:5155/swagger/index.html. If you cannot access localhost:5155/swagger or localhost:5155/swagger/index.html it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/lessons/redirecting-to-https-and-issuing-a-security-certificate).

## Database Instructions 

* In your terminal type to create a db migration: $ dotnet ef migrations add Initial
* Updating the Database with the Migration: $ dotnet ef database update

## DB (Optional)

* If you would like to see a current view of the database: Open SQL workbench.
* Navigate to the "Administration" tab in SQL Workbench.
* Click "Schema" 
* Right hand mouse click "Refresh All".
* The _Name the schema "project_name" of the database in this current project will be in view

## Known Bugs

* None

## License

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) 2023 Vera Weikel 

