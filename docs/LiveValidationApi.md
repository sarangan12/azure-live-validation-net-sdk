# IO.Swagger.Api.LiveValidationApi

All URIs are relative to *http://localhost:5002/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ToolsLiveValidationProdValidate**](LiveValidationApi.md#toolslivevalidationprodvalidate) | **POST** /prod/validate | 
[**ToolsLiveValidationProdWhiteList**](LiveValidationApi.md#toolslivevalidationprodwhitelist) | **GET** /prod/whitelist | 
[**ToolsLiveValidationValidate**](LiveValidationApi.md#toolslivevalidationvalidate) | **POST** /validate | 
[**ToolsLiveValidationWhiteList**](LiveValidationApi.md#toolslivevalidationwhitelist) | **GET** /whitelist | 


<a name="toolslivevalidationprodvalidate"></a>
# **ToolsLiveValidationProdValidate**
> LiveValidationResponse ToolsLiveValidationProdValidate (LiveValidationParameter liveValidationParameter)



Process Prod environment ARM calls.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ToolsLiveValidationProdValidateExample
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **liveValidationParameter** | [**LiveValidationParameter**](LiveValidationParameter.md)| Live Validation Parameter | 

### Return type

[**LiveValidationResponse**](LiveValidationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
            var apiInstance = new LiveValidationApi();

            try
            {
                LiveValidationWhiteListResponse result = apiInstance.ToolsLiveValidationProdWhiteList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LiveValidationApi.ToolsLiveValidationProdWhiteList: " + e.Message );
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

<a name="toolslivevalidationvalidate"></a>
# **ToolsLiveValidationValidate**
> LiveValidationResponse ToolsLiveValidationValidate (LiveValidationParameter liveValidationParameter)



Process non-prod canary environment ARM calls.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ToolsLiveValidationValidateExample
    {
        public void main()
        {
            var apiInstance = new LiveValidationApi();
            var liveValidationParameter = new LiveValidationParameter(); // LiveValidationParameter | Live Validation Parameter

            try
            {
                LiveValidationResponse result = apiInstance.ToolsLiveValidationValidate(liveValidationParameter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LiveValidationApi.ToolsLiveValidationValidate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **liveValidationParameter** | [**LiveValidationParameter**](LiveValidationParameter.md)| Live Validation Parameter | 

### Return type

[**LiveValidationResponse**](LiveValidationResponse.md)

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
            var apiInstance = new LiveValidationApi();

            try
            {
                LiveValidationWhiteListResponse result = apiInstance.ToolsLiveValidationWhiteList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LiveValidationApi.ToolsLiveValidationWhiteList: " + e.Message );
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

