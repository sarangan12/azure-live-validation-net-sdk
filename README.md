# IO.Swagger - the C# library for the Live Validation Service Client

Client that can be used to access Live Validation Service.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            var apiInstance = new LiveValidationApi();
            var liveValidationParameter = new LiveValidationParameter(); // LiveValidationParameter | Live Validation Parameter

            try
            {
                LiveValidationResponse result = apiInstance.ToolsLiveValidationProdValidate(liveValidationParameter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LiveValidationApi.ToolsLiveValidationProdValidate: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost:5002/api*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*LiveValidationApi* | [**ToolsLiveValidationProdValidate**](docs/LiveValidationApi.md#toolslivevalidationprodvalidate) | **POST** /prod/validate | 
*LiveValidationApi* | [**ToolsLiveValidationProdWhiteList**](docs/LiveValidationApi.md#toolslivevalidationprodwhitelist) | **GET** /prod/whitelist | 
*LiveValidationApi* | [**ToolsLiveValidationValidate**](docs/LiveValidationApi.md#toolslivevalidationvalidate) | **POST** /validate | 
*LiveValidationApi* | [**ToolsLiveValidationWhiteList**](docs/LiveValidationApi.md#toolslivevalidationwhitelist) | **GET** /whitelist | 
*ProdValidateApi* | [**ToolsLiveValidationProdValidate**](docs/ProdValidateApi.md#toolslivevalidationprodvalidate) | **POST** /prod/validate | 
*ValidateApi* | [**ToolsLiveValidationValidate**](docs/ValidateApi.md#toolslivevalidationvalidate) | **POST** /validate | 
*WhitelistApi* | [**ToolsLiveValidationProdWhiteList**](docs/WhitelistApi.md#toolslivevalidationprodwhitelist) | **GET** /prod/whitelist | 
*WhitelistApi* | [**ToolsLiveValidationWhiteList**](docs/WhitelistApi.md#toolslivevalidationwhitelist) | **GET** /whitelist | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.LiveRequest](docs/LiveRequest.md)
 - [Model.LiveResponse](docs/LiveResponse.md)
 - [Model.LiveValidationParameter](docs/LiveValidationParameter.md)
 - [Model.LiveValidationResponse](docs/LiveValidationResponse.md)
 - [Model.LiveValidationWhiteListResponse](docs/LiveValidationWhiteListResponse.md)
 - [Model.RequestValidationResult](docs/RequestValidationResult.md)
 - [Model.ResponseValidationResult](docs/ResponseValidationResult.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
