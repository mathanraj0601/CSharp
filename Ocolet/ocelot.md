# Ocelot
ocelot is a open source Nuget package which allows us to create API Gateway 

![ocelot-block-diagram](https://github.com/mathanraj0601/CSharp/assets/98396468/f8b1f834-058d-4cfa-91fd-fb2e9e41cee6)


## What is a  Gateway

Gateway is the API that acts as an interface to the client application and underlying web APIs 

## Why Gateway

- It acts as a proxy for the web API so we are not directly exposing URl to the client application
- It helps us to implement middleware common for all API and we can able to do authorization using JWT, rate limiting, etc.,
- It makes all the API to have a common gateway/entry. There will be a chance of this API gateway going down but API gateway provides lot of advantages mentioned above.

## Ocelet in c#

program.cs
```csharp
builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("octlet.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables();

```
- Making the configuration in program.cs by assigning the base path to look for the json file (root directory of the project)
- Optional is to throw when the file not exist
- reloadonchange is to make the program to use the updated json file mostly in development
- Add all the environmental variable from os

ocelot.json

```json
{
  "Routes": [
    {
      "upstreamPathTemplate": "/api/IMS/GetAllIntern",
      "upstreamHttpMethod": [ "Get" ],
      "downstreamScheme": "http",
      "downstreamHostAndPorts": [
        {
          "host": "localhost",
          "port": 5032
        }
      ],
      "downstreamPathTemplate": "/api/User/GetAllIntern"
    }
  ],
  "GlobalConfiguration": {
    "BaseUrl": ""
  }
}


```
The above is the octlet.json for routing the request to underlying API

- Upstream : The Template (part of URL) in which client  hit the API
- Upstream method : What are the action method ? example : GET, POST etc.,
- DownStream Scheme : To set the protocol (http / https)  
- Downstream : The Template (part of URL) in which gateway  route the request.
- DownStream host and ports : host is the ip of underlying API system and which port the api is listening in the system.
- Global configuration is to set common for all routes or through out application
- Base url - to set the URl of the host / host and port of the gateway application where client request.
