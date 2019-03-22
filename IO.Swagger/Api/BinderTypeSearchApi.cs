/* 
 * Abletech.Arxivar.Server.WebApi.Services
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBinderTypeSearchApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// This call returns binders by a given search object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">The search object</param>
        /// <returns>List&lt;BinderDTO&gt;</returns>
        List<BinderDTO> BinderTypeSearchGetBindersByAdvancedSearch (SearchConcreteDTO search);

        /// <summary>
        /// This call returns binders by a given search object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">The search object</param>
        /// <returns>ApiResponse of List&lt;BinderDTO&gt;</returns>
        ApiResponse<List<BinderDTO>> BinderTypeSearchGetBindersByAdvancedSearchWithHttpInfo (SearchConcreteDTO search);
        /// <summary>
        /// This call returns a search object for a search by binder type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="binderTypeId">The identifier of the binder type</param>
        /// <returns>SearchConcreteDTO</returns>
        SearchConcreteDTO BinderTypeSearchGetSearchByBinderType (int? binderTypeId);

        /// <summary>
        /// This call returns a search object for a search by binder type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="binderTypeId">The identifier of the binder type</param>
        /// <returns>ApiResponse of SearchConcreteDTO</returns>
        ApiResponse<SearchConcreteDTO> BinderTypeSearchGetSearchByBinderTypeWithHttpInfo (int? binderTypeId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// This call returns binders by a given search object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">The search object</param>
        /// <returns>Task of List&lt;BinderDTO&gt;</returns>
        System.Threading.Tasks.Task<List<BinderDTO>> BinderTypeSearchGetBindersByAdvancedSearchAsync (SearchConcreteDTO search);

        /// <summary>
        /// This call returns binders by a given search object
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">The search object</param>
        /// <returns>Task of ApiResponse (List&lt;BinderDTO&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<BinderDTO>>> BinderTypeSearchGetBindersByAdvancedSearchAsyncWithHttpInfo (SearchConcreteDTO search);
        /// <summary>
        /// This call returns a search object for a search by binder type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="binderTypeId">The identifier of the binder type</param>
        /// <returns>Task of SearchConcreteDTO</returns>
        System.Threading.Tasks.Task<SearchConcreteDTO> BinderTypeSearchGetSearchByBinderTypeAsync (int? binderTypeId);

        /// <summary>
        /// This call returns a search object for a search by binder type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="binderTypeId">The identifier of the binder type</param>
        /// <returns>Task of ApiResponse (SearchConcreteDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<SearchConcreteDTO>> BinderTypeSearchGetSearchByBinderTypeAsyncWithHttpInfo (int? binderTypeId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BinderTypeSearchApi : IBinderTypeSearchApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BinderTypeSearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BinderTypeSearchApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinderTypeSearchApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BinderTypeSearchApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// This call returns binders by a given search object 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">The search object</param>
        /// <returns>List&lt;BinderDTO&gt;</returns>
        public List<BinderDTO> BinderTypeSearchGetBindersByAdvancedSearch (SearchConcreteDTO search)
        {
             ApiResponse<List<BinderDTO>> localVarResponse = BinderTypeSearchGetBindersByAdvancedSearchWithHttpInfo(search);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call returns binders by a given search object 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">The search object</param>
        /// <returns>ApiResponse of List&lt;BinderDTO&gt;</returns>
        public ApiResponse< List<BinderDTO> > BinderTypeSearchGetBindersByAdvancedSearchWithHttpInfo (SearchConcreteDTO search)
        {
            // verify the required parameter 'search' is set
            if (search == null)
                throw new ApiException(400, "Missing required parameter 'search' when calling BinderTypeSearchApi->BinderTypeSearchGetBindersByAdvancedSearch");

            var localVarPath = "/api/BinderTypeSearches";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (search != null && search.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(search); // http body (model) parameter
            }
            else
            {
                localVarPostBody = search; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BinderTypeSearchGetBindersByAdvancedSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<BinderDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BinderDTO>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BinderDTO>)));
        }

        /// <summary>
        /// This call returns binders by a given search object 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">The search object</param>
        /// <returns>Task of List&lt;BinderDTO&gt;</returns>
        public async System.Threading.Tasks.Task<List<BinderDTO>> BinderTypeSearchGetBindersByAdvancedSearchAsync (SearchConcreteDTO search)
        {
             ApiResponse<List<BinderDTO>> localVarResponse = await BinderTypeSearchGetBindersByAdvancedSearchAsyncWithHttpInfo(search);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call returns binders by a given search object 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">The search object</param>
        /// <returns>Task of ApiResponse (List&lt;BinderDTO&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<BinderDTO>>> BinderTypeSearchGetBindersByAdvancedSearchAsyncWithHttpInfo (SearchConcreteDTO search)
        {
            // verify the required parameter 'search' is set
            if (search == null)
                throw new ApiException(400, "Missing required parameter 'search' when calling BinderTypeSearchApi->BinderTypeSearchGetBindersByAdvancedSearch");

            var localVarPath = "/api/BinderTypeSearches";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (search != null && search.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(search); // http body (model) parameter
            }
            else
            {
                localVarPostBody = search; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BinderTypeSearchGetBindersByAdvancedSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<BinderDTO>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BinderDTO>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BinderDTO>)));
        }

        /// <summary>
        /// This call returns a search object for a search by binder type 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="binderTypeId">The identifier of the binder type</param>
        /// <returns>SearchConcreteDTO</returns>
        public SearchConcreteDTO BinderTypeSearchGetSearchByBinderType (int? binderTypeId)
        {
             ApiResponse<SearchConcreteDTO> localVarResponse = BinderTypeSearchGetSearchByBinderTypeWithHttpInfo(binderTypeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call returns a search object for a search by binder type 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="binderTypeId">The identifier of the binder type</param>
        /// <returns>ApiResponse of SearchConcreteDTO</returns>
        public ApiResponse< SearchConcreteDTO > BinderTypeSearchGetSearchByBinderTypeWithHttpInfo (int? binderTypeId)
        {
            // verify the required parameter 'binderTypeId' is set
            if (binderTypeId == null)
                throw new ApiException(400, "Missing required parameter 'binderTypeId' when calling BinderTypeSearchApi->BinderTypeSearchGetSearchByBinderType");

            var localVarPath = "/api/BinderTypeSearches/{binderTypeId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (binderTypeId != null) localVarPathParams.Add("binderTypeId", Configuration.ApiClient.ParameterToString(binderTypeId)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BinderTypeSearchGetSearchByBinderType", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchConcreteDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchConcreteDTO) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchConcreteDTO)));
        }

        /// <summary>
        /// This call returns a search object for a search by binder type 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="binderTypeId">The identifier of the binder type</param>
        /// <returns>Task of SearchConcreteDTO</returns>
        public async System.Threading.Tasks.Task<SearchConcreteDTO> BinderTypeSearchGetSearchByBinderTypeAsync (int? binderTypeId)
        {
             ApiResponse<SearchConcreteDTO> localVarResponse = await BinderTypeSearchGetSearchByBinderTypeAsyncWithHttpInfo(binderTypeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call returns a search object for a search by binder type 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="binderTypeId">The identifier of the binder type</param>
        /// <returns>Task of ApiResponse (SearchConcreteDTO)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SearchConcreteDTO>> BinderTypeSearchGetSearchByBinderTypeAsyncWithHttpInfo (int? binderTypeId)
        {
            // verify the required parameter 'binderTypeId' is set
            if (binderTypeId == null)
                throw new ApiException(400, "Missing required parameter 'binderTypeId' when calling BinderTypeSearchApi->BinderTypeSearchGetSearchByBinderType");

            var localVarPath = "/api/BinderTypeSearches/{binderTypeId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (binderTypeId != null) localVarPathParams.Add("binderTypeId", Configuration.ApiClient.ParameterToString(binderTypeId)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BinderTypeSearchGetSearchByBinderType", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchConcreteDTO>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchConcreteDTO) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchConcreteDTO)));
        }

    }
}