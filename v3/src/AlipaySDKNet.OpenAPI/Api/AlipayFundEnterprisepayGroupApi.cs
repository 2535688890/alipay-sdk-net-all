/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2024-10-16
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
    public interface IAlipayFundEnterprisepayGroupApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 因公付新增账户下群组
        /// </summary>
        /// <remarks>
        /// 创建因公付群组，包含群组信息和出资信息
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayFundEnterprisepayGroupAddModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayFundEnterprisepayGroupAddResponseModel</returns>
        AlipayFundEnterprisepayGroupAddResponseModel Add(AlipayFundEnterprisepayGroupAddModel alipayFundEnterprisepayGroupAddModel = default(AlipayFundEnterprisepayGroupAddModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 因公付新增账户下群组
        /// </summary>
        /// <remarks>
        /// 创建因公付群组，包含群组信息和出资信息
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayFundEnterprisepayGroupAddModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayFundEnterprisepayGroupAddResponseModel</returns>
        ApiResponse<AlipayFundEnterprisepayGroupAddResponseModel> AddWithHttpInfo(AlipayFundEnterprisepayGroupAddModel alipayFundEnterprisepayGroupAddModel = default(AlipayFundEnterprisepayGroupAddModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 因公付删除账户下群组
        /// </summary>
        /// <remarks>
        /// 因公付删除账户下群组
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">产品码，默认值 ENTERPRISE_PAY (optional)</param>
        /// <param name="bizScene">场景码，联系支付宝分配 (optional)</param>
        /// <param name="accountId">企业签约账户ID (optional)</param>
        /// <param name="agreementNo">平台和企业的三方授权协议号 (optional)</param>
        /// <param name="outBizNo">外部业务号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Object</returns>
        Object Delete(string productCode = default(string), string bizScene = default(string), string accountId = default(string), string agreementNo = default(string), string outBizNo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 因公付删除账户下群组
        /// </summary>
        /// <remarks>
        /// 因公付删除账户下群组
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">产品码，默认值 ENTERPRISE_PAY (optional)</param>
        /// <param name="bizScene">场景码，联系支付宝分配 (optional)</param>
        /// <param name="accountId">企业签约账户ID (optional)</param>
        /// <param name="agreementNo">平台和企业的三方授权协议号 (optional)</param>
        /// <param name="outBizNo">外部业务号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DeleteWithHttpInfo(string productCode = default(string), string bizScene = default(string), string accountId = default(string), string agreementNo = default(string), string outBizNo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 因公付更新账户下群组
        /// </summary>
        /// <remarks>
        /// 因公付更新账户下群组
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayFundEnterprisepayGroupModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Object</returns>
        Object Modify(AlipayFundEnterprisepayGroupModifyModel alipayFundEnterprisepayGroupModifyModel = default(AlipayFundEnterprisepayGroupModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 因公付更新账户下群组
        /// </summary>
        /// <remarks>
        /// 因公付更新账户下群组
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayFundEnterprisepayGroupModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ModifyWithHttpInfo(AlipayFundEnterprisepayGroupModifyModel alipayFundEnterprisepayGroupModifyModel = default(AlipayFundEnterprisepayGroupModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 因公付查询账户下群组
        /// </summary>
        /// <remarks>
        /// 查询因公付群组，包含群组信息和对应的出资主体
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">产品码，默认值 ENTERPRISE_PAY (optional)</param>
        /// <param name="bizScene">场景码，联系支付宝分配 (optional)</param>
        /// <param name="accountId">企业签约账户ID (optional)</param>
        /// <param name="agreementNo">平台和企业的三方授权协议号 (optional)</param>
        /// <param name="outBizNo">外部业务号，外部群组号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayFundEnterprisepayGroupQueryResponseModel</returns>
        AlipayFundEnterprisepayGroupQueryResponseModel Query(string productCode = default(string), string bizScene = default(string), string accountId = default(string), string agreementNo = default(string), string outBizNo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 因公付查询账户下群组
        /// </summary>
        /// <remarks>
        /// 查询因公付群组，包含群组信息和对应的出资主体
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">产品码，默认值 ENTERPRISE_PAY (optional)</param>
        /// <param name="bizScene">场景码，联系支付宝分配 (optional)</param>
        /// <param name="accountId">企业签约账户ID (optional)</param>
        /// <param name="agreementNo">平台和企业的三方授权协议号 (optional)</param>
        /// <param name="outBizNo">外部业务号，外部群组号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayFundEnterprisepayGroupQueryResponseModel</returns>
        ApiResponse<AlipayFundEnterprisepayGroupQueryResponseModel> QueryWithHttpInfo(string productCode = default(string), string bizScene = default(string), string accountId = default(string), string agreementNo = default(string), string outBizNo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayFundEnterprisepayGroupApi : IAlipayFundEnterprisepayGroupApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayFundEnterprisepayGroupApi : IAlipayFundEnterprisepayGroupApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundEnterprisepayGroupApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayFundEnterprisepayGroupApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundEnterprisepayGroupApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayFundEnterprisepayGroupApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundEnterprisepayGroupApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayFundEnterprisepayGroupApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayFundEnterprisepayGroupApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayFundEnterprisepayGroupApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 因公付新增账户下群组 创建因公付群组，包含群组信息和出资信息
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayFundEnterprisepayGroupAddModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayFundEnterprisepayGroupAddResponseModel</returns>
        public AlipayFundEnterprisepayGroupAddResponseModel Add(AlipayFundEnterprisepayGroupAddModel alipayFundEnterprisepayGroupAddModel = default(AlipayFundEnterprisepayGroupAddModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayFundEnterprisepayGroupAddResponseModel> localVarResponse = AddWithHttpInfo(alipayFundEnterprisepayGroupAddModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 因公付新增账户下群组 创建因公付群组，包含群组信息和出资信息
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayFundEnterprisepayGroupAddModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayFundEnterprisepayGroupAddResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayFundEnterprisepayGroupAddResponseModel> AddWithHttpInfo(AlipayFundEnterprisepayGroupAddModel alipayFundEnterprisepayGroupAddModel = default(AlipayFundEnterprisepayGroupAddModel), int operationIndex = 0, CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = alipayFundEnterprisepayGroupAddModel;
            }

            localVarRequestOptions.Operation = "AlipayFundEnterprisepayGroupApi.Add";
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
            var localVarResponse = this.Client.Post<AlipayFundEnterprisepayGroupAddResponseModel>("/v3/alipay/fund/enterprisepay/group/add", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Add", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayFundEnterprisepayGroupAddDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 因公付删除账户下群组 因公付删除账户下群组
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">产品码，默认值 ENTERPRISE_PAY (optional)</param>
        /// <param name="bizScene">场景码，联系支付宝分配 (optional)</param>
        /// <param name="accountId">企业签约账户ID (optional)</param>
        /// <param name="agreementNo">平台和企业的三方授权协议号 (optional)</param>
        /// <param name="outBizNo">外部业务号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Object</returns>
        public Object Delete(string productCode = default(string), string bizScene = default(string), string accountId = default(string), string agreementNo = default(string), string outBizNo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<Object> localVarResponse = DeleteWithHttpInfo(productCode, bizScene, accountId, agreementNo, outBizNo, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 因公付删除账户下群组 因公付删除账户下群组
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">产品码，默认值 ENTERPRISE_PAY (optional)</param>
        /// <param name="bizScene">场景码，联系支付宝分配 (optional)</param>
        /// <param name="accountId">企业签约账户ID (optional)</param>
        /// <param name="agreementNo">平台和企业的三方授权协议号 (optional)</param>
        /// <param name="outBizNo">外部业务号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of Object</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<Object> DeleteWithHttpInfo(string productCode = default(string), string bizScene = default(string), string accountId = default(string), string agreementNo = default(string), string outBizNo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (productCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "product_code", productCode));
            }
            if (bizScene != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "biz_scene", bizScene));
            }
            if (accountId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "account_id", accountId));
            }
            if (agreementNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "agreement_no", agreementNo));
            }
            if (outBizNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "out_biz_no", outBizNo));
            }

            localVarRequestOptions.Operation = "AlipayFundEnterprisepayGroupApi.Delete";
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
            var localVarResponse = this.Client.Delete<Object>("/v3/alipay/fund/enterprisepay/group/delete", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Delete", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayFundEnterprisepayGroupDeleteDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 因公付更新账户下群组 因公付更新账户下群组
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayFundEnterprisepayGroupModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Object</returns>
        public Object Modify(AlipayFundEnterprisepayGroupModifyModel alipayFundEnterprisepayGroupModifyModel = default(AlipayFundEnterprisepayGroupModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<Object> localVarResponse = ModifyWithHttpInfo(alipayFundEnterprisepayGroupModifyModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 因公付更新账户下群组 因公付更新账户下群组
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayFundEnterprisepayGroupModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of Object</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<Object> ModifyWithHttpInfo(AlipayFundEnterprisepayGroupModifyModel alipayFundEnterprisepayGroupModifyModel = default(AlipayFundEnterprisepayGroupModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = alipayFundEnterprisepayGroupModifyModel;
            }

            localVarRequestOptions.Operation = "AlipayFundEnterprisepayGroupApi.Modify";
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
            var localVarResponse = this.Client.Post<Object>("/v3/alipay/fund/enterprisepay/group/modify", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Modify", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayFundEnterprisepayGroupModifyDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 因公付查询账户下群组 查询因公付群组，包含群组信息和对应的出资主体
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">产品码，默认值 ENTERPRISE_PAY (optional)</param>
        /// <param name="bizScene">场景码，联系支付宝分配 (optional)</param>
        /// <param name="accountId">企业签约账户ID (optional)</param>
        /// <param name="agreementNo">平台和企业的三方授权协议号 (optional)</param>
        /// <param name="outBizNo">外部业务号，外部群组号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayFundEnterprisepayGroupQueryResponseModel</returns>
        public AlipayFundEnterprisepayGroupQueryResponseModel Query(string productCode = default(string), string bizScene = default(string), string accountId = default(string), string agreementNo = default(string), string outBizNo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayFundEnterprisepayGroupQueryResponseModel> localVarResponse = QueryWithHttpInfo(productCode, bizScene, accountId, agreementNo, outBizNo, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 因公付查询账户下群组 查询因公付群组，包含群组信息和对应的出资主体
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">产品码，默认值 ENTERPRISE_PAY (optional)</param>
        /// <param name="bizScene">场景码，联系支付宝分配 (optional)</param>
        /// <param name="accountId">企业签约账户ID (optional)</param>
        /// <param name="agreementNo">平台和企业的三方授权协议号 (optional)</param>
        /// <param name="outBizNo">外部业务号，外部群组号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayFundEnterprisepayGroupQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayFundEnterprisepayGroupQueryResponseModel> QueryWithHttpInfo(string productCode = default(string), string bizScene = default(string), string accountId = default(string), string agreementNo = default(string), string outBizNo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (productCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "product_code", productCode));
            }
            if (bizScene != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "biz_scene", bizScene));
            }
            if (accountId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "account_id", accountId));
            }
            if (agreementNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "agreement_no", agreementNo));
            }
            if (outBizNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "out_biz_no", outBizNo));
            }

            localVarRequestOptions.Operation = "AlipayFundEnterprisepayGroupApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayFundEnterprisepayGroupQueryResponseModel>("/v3/alipay/fund/enterprisepay/group/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayFundEnterprisepayGroupQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
