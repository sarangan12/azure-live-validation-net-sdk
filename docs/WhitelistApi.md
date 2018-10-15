# IO.Swagger.Api.WhitelistApi

All URIs are relative to *http://localhost:5002/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ToolsLiveValidationProdWhiteList**](WhitelistApi.md#toolslivevalidationprodwhitelist) | **GET** /prod/whitelist | 
[**ToolsLiveValidationWhiteList**](WhitelistApi.md#toolslivevalidationwhitelist) | **GET** /whitelist | 


<a name="toolslivevalidationprodwhitelist"></a>
# **ToolsLiveValidationProdWhiteList**
> LiveValidationWhiteListResponse ToolsLiveValidationProdWhiteList ()



Get list of safe properties is prod environments.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ToolsLiveValidationProdWhiteListExample
    {
        public void main()
        {
            var apiInstance = new WhitelistApi();

            try
            {
                LiveValidationWhiteListResponse result = apiInstance.ToolsLiveValidationProdWhiteList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhitelistApi.ToolsLiveValidationProdWhiteList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**LiveValidationWhiteListResponse**](LiveValidationWhiteListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toolslivevalidationwhitelist"></a>
# **ToolsLiveValidationWhiteList**
> LiveValidationWhiteListResponse ToolsLiveValidationWhiteList ()



Get list of safe properties in non-prod canary environments.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ToolsLiveValidationWhiteListExample
    {
        public void main()
        {
            var apiInstance = new WhitelistApi();

            try
            {
                LiveValidationWhiteListResponse result = apiInstance.ToolsLiveValidationWhiteList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhitelistApi.ToolsLiveValidationWhiteList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**LiveValidationWhiteListResponse**](LiveValidationWhiteListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

