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
    public interface IAlipayEbppInvoiceExpensecontrolQuotaApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 创建余额/点券
        /// </summary>
        /// <remarks>
        /// 创建余额或者点券
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceExpensecontrolQuotaCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel</returns>
        AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel Create(AlipayEbppInvoiceExpensecontrolQuotaCreateModel alipayEbppInvoiceExpensecontrolQuotaCreateModel = default(AlipayEbppInvoiceExpensecontrolQuotaCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 创建余额/点券
        /// </summary>
        /// <remarks>
        /// 创建余额或者点券
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceExpensecontrolQuotaCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel</returns>
        ApiResponse<AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel> CreateWithHttpInfo(AlipayEbppInvoiceExpensecontrolQuotaCreateModel alipayEbppInvoiceExpensecontrolQuotaCreateModel = default(AlipayEbppInvoiceExpensecontrolQuotaCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 修改余额/点券
        /// </summary>
        /// <remarks>
        /// 修改余额或点券
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceExpensecontrolQuotaModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceExpensecontrolQuotaModifyResponseModel</returns>
        AlipayEbppInvoiceExpensecontrolQuotaModifyResponseModel Modify(AlipayEbppInvoiceExpensecontrolQuotaModifyModel alipayEbppInvoiceExpensecontrolQuotaModifyModel = default(AlipayEbppInvoiceExpensecontrolQuotaModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 修改余额/点券
        /// </summary>
        /// <remarks>
        /// 修改余额或点券
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceExpensecontrolQuotaModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceExpensecontrolQuotaModifyResponseModel</returns>
        ApiResponse<AlipayEbppInvoiceExpensecontrolQuotaModifyResponseModel> ModifyWithHttpInfo(AlipayEbppInvoiceExpensecontrolQuotaModifyModel alipayEbppInvoiceExpensecontrolQuotaModifyModel = default(AlipayEbppInvoiceExpensecontrolQuotaModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 查询余额/点券
        /// </summary>
        /// <remarks>
        /// 查询余额或者点券
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceExpensecontrolQuotaQueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceExpensecontrolQuotaQueryResponseModel</returns>
        AlipayEbppInvoiceExpensecontrolQuotaQueryResponseModel Query(AlipayEbppInvoiceExpensecontrolQuotaQueryModel alipayEbppInvoiceExpensecontrolQuotaQueryModel = default(AlipayEbppInvoiceExpensecontrolQuotaQueryModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询余额/点券
        /// </summary>
        /// <remarks>
        /// 查询余额或者点券
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceExpensecontrolQuotaQueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceExpensecontrolQuotaQueryResponseModel</returns>
        ApiResponse<AlipayEbppInvoiceExpensecontrolQuotaQueryResponseModel> QueryWithHttpInfo(AlipayEbppInvoiceExpensecontrolQuotaQueryModel alipayEbppInvoiceExpensecontrolQuotaQueryModel = default(AlipayEbppInvoiceExpensecontrolQuotaQueryModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayEbppInvoiceExpensecontrolQuotaApi : IAlipayEbppInvoiceExpensecontrolQuotaApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayEbppInvoiceExpensecontrolQuotaApi : IAlipayEbppInvoiceExpensecontrolQuotaApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpensecontrolQuotaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayEbppInvoiceExpensecontrolQuotaApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpensecontrolQuotaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayEbppInvoiceExpensecontrolQuotaApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpensecontrolQuotaApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayEbppInvoiceExpensecontrolQuotaApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpensecontrolQuotaApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayEbppInvoiceExpensecontrolQuotaApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 创建余额/点券 创建余额或者点券
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceExpensecontrolQuotaCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel</returns>
        public AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel Create(AlipayEbppInvoiceExpensecontrolQuotaCreateModel alipayEbppInvoiceExpensecontrolQuotaCreateModel = default(AlipayEbppInvoiceExpensecontrolQuotaCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel> localVarResponse = CreateWithHttpInfo(alipayEbppInvoiceExpensecontrolQuotaCreateModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 创建余额/点券 创建余额或者点券
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceExpensecontrolQuotaCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel> CreateWithHttpInfo(AlipayEbppInvoiceExpensecontrolQuotaCreateModel alipayEbppInvoiceExpensecontrolQuotaCreateModel = default(AlipayEbppInvoiceExpensecontrolQuotaCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.RequestOptions localVarRequestOptions = new AlipaySDKNet.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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

            //自定义body内容
            if (customizedParams != null && !string.IsNullOrEmpty(customizedParams.BodyContent))
            {
                localVarRequestOptions.Data = customizedParams.BodyContent;
            }
            else
            {
                localVarRequestOptions.Data = alipayEbppInvoiceExpensecontrolQuotaCreateModel;
            }

            localVarRequestOptions.Operation = "AlipayEbppInvoiceExpensecontrolQuotaApi.Create";
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
            var localVarResponse = this.Client.Post<AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel>("/v3/alipay/ebpp/invoice/expensecontrol/quota/create", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Create", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayEbppInvoiceExpensecontrolQuotaCreateDefaultResponse.FromJson(exception.ErrorContent.ToString());
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

        /// <summary>
        /// 修改余额/点券 修改余额或点券
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceExpensecontrolQuotaModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceExpensecontrolQuotaModifyResponseModel</returns>
        public AlipayEbppInvoiceExpensecontrolQuotaModifyResponseModel Modify(AlipayEbppInvoiceExpensecontrolQuotaModifyModel alipayEbppInvoiceExpensecontrolQuotaModifyModel = default(AlipayEbppInvoiceExpensecontrolQuotaModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceExpensecontrolQuotaModifyResponseModel> localVarResponse = ModifyWithHttpInfo(alipayEbppInvoiceExpensecontrolQuotaModifyModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 修改余额/点券 修改余额或点券
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceExpensecontrolQuotaModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceExpensecontrolQuotaModifyResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceExpensecontrolQuotaModifyResponseModel> ModifyWithHttpInfo(AlipayEbppInvoiceExpensecontrolQuotaModifyModel alipayEbppInvoiceExpensecontrolQuotaModifyModel = default(AlipayEbppInvoiceExpensecontrolQuotaModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.RequestOptions localVarRequestOptions = new AlipaySDKNet.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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

            //自定义body内容
            if (customizedParams != null && !string.IsNullOrEmpty(customizedParams.BodyContent))
            {
                localVarRequestOptions.Data = customizedParams.BodyContent;
            }
            else
            {
                localVarRequestOptions.Data = alipayEbppInvoiceExpensecontrolQuotaModifyModel;
            }

            localVarRequestOptions.Operation = "AlipayEbppInvoiceExpensecontrolQuotaApi.Modify";
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
            var localVarResponse = this.Client.Post<AlipayEbppInvoiceExpensecontrolQuotaModifyResponseModel>("/v3/alipay/ebpp/invoice/expensecontrol/quota/modify", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Modify", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayEbppInvoiceExpensecontrolQuotaModifyDefaultResponse.FromJson(exception.ErrorContent.ToString());
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

        /// <summary>
        /// 查询余额/点券 查询余额或者点券
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceExpensecontrolQuotaQueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceExpensecontrolQuotaQueryResponseModel</returns>
        public AlipayEbppInvoiceExpensecontrolQuotaQueryResponseModel Query(AlipayEbppInvoiceExpensecontrolQuotaQueryModel alipayEbppInvoiceExpensecontrolQuotaQueryModel = default(AlipayEbppInvoiceExpensecontrolQuotaQueryModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceExpensecontrolQuotaQueryResponseModel> localVarResponse = QueryWithHttpInfo(alipayEbppInvoiceExpensecontrolQuotaQueryModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询余额/点券 查询余额或者点券
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceExpensecontrolQuotaQueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceExpensecontrolQuotaQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceExpensecontrolQuotaQueryResponseModel> QueryWithHttpInfo(AlipayEbppInvoiceExpensecontrolQuotaQueryModel alipayEbppInvoiceExpensecontrolQuotaQueryModel = default(AlipayEbppInvoiceExpensecontrolQuotaQueryModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.RequestOptions localVarRequestOptions = new AlipaySDKNet.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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

            //自定义body内容
            if (customizedParams != null && !string.IsNullOrEmpty(customizedParams.BodyContent))
            {
                localVarRequestOptions.Data = customizedParams.BodyContent;
            }
            else
            {
                localVarRequestOptions.Data = alipayEbppInvoiceExpensecontrolQuotaQueryModel;
            }

            localVarRequestOptions.Operation = "AlipayEbppInvoiceExpensecontrolQuotaApi.Query";
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
            var localVarResponse = this.Client.Post<AlipayEbppInvoiceExpensecontrolQuotaQueryResponseModel>("/v3/alipay/ebpp/invoice/expensecontrol/quota/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayEbppInvoiceExpensecontrolQuotaQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
