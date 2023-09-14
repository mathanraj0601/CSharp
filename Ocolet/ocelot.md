# Ocelot

ocelet is a open source nuget package which allows us to create API Gateway 

## What is a  Gateway

Gateway is the api that act as a interface to the client application and underlying web API's 

## Why Gateway

- It act as a proxy for the web api so we are not directly exposing URl to the client application
- It help us to implement middleware common for all API's and we can able to do authorization using JWT, rate limiting etc.,
- It make all the api to have common gateway / entry. There will be a chance of this api gateway going down but api gateway provides lost of advantages mentioned above.

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