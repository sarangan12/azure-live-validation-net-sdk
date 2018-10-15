# IO.Swagger.Api.ProdValidateApi

All URIs are relative to *http://localhost:5002/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ToolsLiveValidationProdValidate**](ProdValidateApi.md#toolslivevalidationprodvalidate) | **POST** /prod/validate | 


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
            var apiInstance = new ProdValidateApi();
            var liveValidationParameter = new LiveValidationParameter(); // LiveValidationParameter | Live Validation Parameter

            try
            {
                LiveValidationResponse result = apiInstance.ToolsLiveValidationProdValidate(liveValidationParameter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProdValidateApi.ToolsLiveValidationProdValidate: " + e.Message );
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

