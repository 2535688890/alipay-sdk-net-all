/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2024-05-20
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using AlipaySDKNet.OpenAPI.Client;
using AlipaySDKNet.OpenAPI.Model;
using AlipaySDKNet.OpenAPI.Util;
using AlipaySDKNet.OpenAPI.Util.Model;

namespace AlipaySDKNet.OpenAPI.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayOpenAuthTokenAppApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 查询某个应用授权AppAuthToken的授权信息
        /// </summary>
        /// <remarks>
        /// 当商户把服务窗、店铺等接口的权限授权给ISV之后，支付宝会给ISV颁发一个app_auth_token。如若授权成功之后，ISV想知道用户的授权信息，如授权者、授权接口列表等信息，可以调用本接口查询某个app_auth_token对应的授权信息
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appAuthToken">应用授权令牌 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayOpenAuthTokenAppQueryResponseModel</returns>
        AlipayOpenAuthTokenAppQueryResponseModel Query(string appAuthToken = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询某个应用授权AppAuthToken的授权信息
        /// </summary>
        /// <remarks>
        /// 当商户把服务窗、店铺等接口的权限授权给ISV之后，支付宝会给ISV颁发一个app_auth_token。如若授权成功之后，ISV想知道用户的授权信息，如授权者、授权接口列表等信息，可以调用本接口查询某个app_auth_token对应的授权信息
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appAuthToken">应用授权令牌 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayOpenAuthTokenAppQueryResponseModel</returns>
        ApiResponse<AlipayOpenAuthTokenAppQueryResponseModel> QueryWithHttpInfo(string appAuthToken = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayOpenAuthTokenAppApi : IAlipayOpenAuthTokenAppApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayOpenAuthTokenAppApi : IAlipayOpenAuthTokenAppApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAuthTokenAppApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayOpenAuthTokenAppApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAuthTokenAppApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayOpenAuthTokenAppApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAuthTokenAppApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayOpenAuthTokenAppApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAuthTokenAppApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayOpenAuthTokenAppApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.Configuration = configuration;
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }


        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public AlipaySDKNet.OpenAPI.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public AlipaySDKNet.OpenAPI.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public AlipaySDKNet.OpenAPI.Client.ExceptionFactory ExceptionFactory
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
        /// 查询某个应用授权AppAuthToken的授权信息 当商户把服务窗、店铺等接口的权限授权给ISV之后，支付宝会给ISV颁发一个app_auth_token。如若授权成功之后，ISV想知道用户的授权信息，如授权者、授权接口列表等信息，可以调用本接口查询某个app_auth_token对应的授权信息
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appAuthToken">应用授权令牌 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayOpenAuthTokenAppQueryResponseModel</returns>
        public AlipayOpenAuthTokenAppQueryResponseModel Query(string appAuthToken = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayOpenAuthTokenAppQueryResponseModel> localVarResponse = QueryWithHttpInfo(appAuthToken, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询某个应用授权AppAuthToken的授权信息 当商户把服务窗、店铺等接口的权限授权给ISV之后，支付宝会给ISV颁发一个app_auth_token。如若授权成功之后，ISV想知道用户的授权信息，如授权者、授权接口列表等信息，可以调用本接口查询某个app_auth_token对应的授权信息
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appAuthToken">应用授权令牌 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayOpenAuthTokenAppQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayOpenAuthTokenAppQueryResponseModel> QueryWithHttpInfo(string appAuthToken = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.RequestOptions localVarRequestOptions = new AlipaySDKNet.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (appAuthToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "app_auth_token", appAuthToken));
            }

            localVarRequestOptions.Operation = "AlipayOpenAuthTokenAppApi.Query";
            localVarRequestOptions.OperationIndex = operationIndex;

            
            if (customizedParams != null)
            {
                //额外query参数
                if (customizedParams.QueryParams != null && customizedParams.QueryParams.Count > 0)
                {
                    foreach (var param in customizedParams.QueryParams)
                    {
                        localVarRequestOptions.QueryParameters.Add(param.Key, param.Value);
                    }
                }

                if (!string.IsNullOrEmpty(customizedParams.AppAuthToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("alipay-app-auth-token", customizedParams.AppAuthToken);
                }
                
                //额外非全局header参数
                if (customizedParams.HeaderParams != null && customizedParams.HeaderParams.Count > 0)
                {
                    foreach (var param in customizedParams.HeaderParams)
                    {
                        localVarRequestOptions.HeaderParameters.Add(param.Key, param.Value);
                    }
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AlipayOpenAuthTokenAppQueryResponseModel>("/v3/alipay/open/auth/token/app/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayOpenAuthTokenAppQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
                        }
                        catch (Exception e)
                        {
                            AlipayLogger.logBizWarn("解析default body内容失败", e);
                        }
                    }
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
