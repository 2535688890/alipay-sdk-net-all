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
    public interface IAlipayEbppInvoiceEnterpriseexctrlEmployertitleApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 批量查询企业抬头
        /// </summary>
        /// <remarks>
        /// 分页查询企业抬头列表
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel</returns>
        AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel Batchquery(AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel alipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel = default(AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 批量查询企业抬头
        /// </summary>
        /// <remarks>
        /// 分页查询企业抬头列表
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel</returns>
        ApiResponse<AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel> BatchqueryWithHttpInfo(AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel alipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel = default(AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 新增企业抬头
        /// </summary>
        /// <remarks>
        /// 新增一条企业开票抬头
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel</returns>
        AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel Create(AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel alipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel = default(AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 新增企业抬头
        /// </summary>
        /// <remarks>
        /// 新增一条企业开票抬头
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel</returns>
        ApiResponse<AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel> CreateWithHttpInfo(AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel alipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel = default(AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 修改企业抬头
        /// </summary>
        /// <remarks>
        /// 修改企业开票抬头
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyResponseModel</returns>
        AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyResponseModel Modify(AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel alipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel = default(AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 修改企业抬头
        /// </summary>
        /// <remarks>
        /// 修改企业开票抬头
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyResponseModel</returns>
        ApiResponse<AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyResponseModel> ModifyWithHttpInfo(AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel alipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel = default(AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 查询企业抬头
        /// </summary>
        /// <remarks>
        /// 根据抬头ID查询企业抬头详情
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">企业共同账户id (optional)</param>
        /// <param name="enterpriseId">企业id (optional)</param>
        /// <param name="agreementNo">授权签约协议号 (optional)</param>
        /// <param name="titleId">抬头ID (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel</returns>
        AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel Query(string accountId = default(string), string enterpriseId = default(string), string agreementNo = default(string), string titleId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询企业抬头
        /// </summary>
        /// <remarks>
        /// 根据抬头ID查询企业抬头详情
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">企业共同账户id (optional)</param>
        /// <param name="enterpriseId">企业id (optional)</param>
        /// <param name="agreementNo">授权签约协议号 (optional)</param>
        /// <param name="titleId">抬头ID (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel</returns>
        ApiResponse<AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel> QueryWithHttpInfo(string accountId = default(string), string enterpriseId = default(string), string agreementNo = default(string), string titleId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayEbppInvoiceEnterpriseexctrlEmployertitleApi : IAlipayEbppInvoiceEnterpriseexctrlEmployertitleApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi : IAlipayEbppInvoiceEnterpriseexctrlEmployertitleApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 批量查询企业抬头 分页查询企业抬头列表
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel</returns>
        public AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel Batchquery(AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel alipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel = default(AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel> localVarResponse = BatchqueryWithHttpInfo(alipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 批量查询企业抬头 分页查询企业抬头列表
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel> BatchqueryWithHttpInfo(AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel alipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel = default(AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel), int operationIndex = 0, CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = alipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryModel;
            }

            localVarRequestOptions.Operation = "AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi.Batchquery";
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
            var localVarResponse = this.Client.Post<AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel>("/v3/alipay/ebpp/invoice/enterpriseexctrl/employertitle/batchquery", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Batchquery", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 新增企业抬头 新增一条企业开票抬头
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel</returns>
        public AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel Create(AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel alipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel = default(AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel> localVarResponse = CreateWithHttpInfo(alipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 新增企业抬头 新增一条企业开票抬头
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel> CreateWithHttpInfo(AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel alipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel = default(AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = alipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel;
            }

            localVarRequestOptions.Operation = "AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi.Create";
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
            var localVarResponse = this.Client.Post<AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel>("/v3/alipay/ebpp/invoice/enterpriseexctrl/employertitle/create", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Create", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 修改企业抬头 修改企业开票抬头
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyResponseModel</returns>
        public AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyResponseModel Modify(AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel alipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel = default(AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyResponseModel> localVarResponse = ModifyWithHttpInfo(alipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 修改企业抬头 修改企业开票抬头
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyResponseModel> ModifyWithHttpInfo(AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel alipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel = default(AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = alipayEbppInvoiceEnterpriseexctrlEmployertitleModifyModel;
            }

            localVarRequestOptions.Operation = "AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi.Modify";
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
            var localVarResponse = this.Client.Put<AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyResponseModel>("/v3/alipay/ebpp/invoice/enterpriseexctrl/employertitle", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Modify", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayEbppInvoiceEnterpriseexctrlEmployertitleModifyDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 查询企业抬头 根据抬头ID查询企业抬头详情
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">企业共同账户id (optional)</param>
        /// <param name="enterpriseId">企业id (optional)</param>
        /// <param name="agreementNo">授权签约协议号 (optional)</param>
        /// <param name="titleId">抬头ID (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel</returns>
        public AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel Query(string accountId = default(string), string enterpriseId = default(string), string agreementNo = default(string), string titleId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel> localVarResponse = QueryWithHttpInfo(accountId, enterpriseId, agreementNo, titleId, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询企业抬头 根据抬头ID查询企业抬头详情
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">企业共同账户id (optional)</param>
        /// <param name="enterpriseId">企业id (optional)</param>
        /// <param name="agreementNo">授权签约协议号 (optional)</param>
        /// <param name="titleId">抬头ID (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel> QueryWithHttpInfo(string accountId = default(string), string enterpriseId = default(string), string agreementNo = default(string), string titleId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (accountId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "account_id", accountId));
            }
            if (enterpriseId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "enterprise_id", enterpriseId));
            }
            if (agreementNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "agreement_no", agreementNo));
            }
            if (titleId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "title_id", titleId));
            }

            localVarRequestOptions.Operation = "AlipayEbppInvoiceEnterpriseexctrlEmployertitleApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryResponseModel>("/v3/alipay/ebpp/invoice/enterpriseexctrl/employertitle/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayEbppInvoiceEnterpriseexctrlEmployertitleQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
