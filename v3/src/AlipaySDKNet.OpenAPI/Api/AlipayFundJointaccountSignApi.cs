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
    public interface IAlipayFundJointaccountSignApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 企业签约结果查询
        /// </summary>
        /// <remarks>
        /// 通过外部订单号（out_biz_no）主动查询企业签约结果，可用于未收到签约结果通知的补偿操作
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">产品码，默认值 ENTERPRISE_PAY (optional)</param>
        /// <param name="bizScene">场景码，联系支付宝分配 (optional)</param>
        /// <param name="outBizNo">外部业务号，查询对应账户状态，优先级高于account_id (optional)</param>
        /// <param name="accountId">企业签约账户ID,用于外部商户已获取企业签约ID，查询账户状态 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayFundJointaccountSignQueryResponseModel</returns>
        AlipayFundJointaccountSignQueryResponseModel Query(string productCode = default(string), string bizScene = default(string), string outBizNo = default(string), string accountId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 企业签约结果查询
        /// </summary>
        /// <remarks>
        /// 通过外部订单号（out_biz_no）主动查询企业签约结果，可用于未收到签约结果通知的补偿操作
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">产品码，默认值 ENTERPRISE_PAY (optional)</param>
        /// <param name="bizScene">场景码，联系支付宝分配 (optional)</param>
        /// <param name="outBizNo">外部业务号，查询对应账户状态，优先级高于account_id (optional)</param>
        /// <param name="accountId">企业签约账户ID,用于外部商户已获取企业签约ID，查询账户状态 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayFundJointaccountSignQueryResponseModel</returns>
        ApiResponse<AlipayFundJointaccountSignQueryResponseModel> QueryWithHttpInfo(string productCode = default(string), string bizScene = default(string), string outBizNo = default(string), string accountId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayFundJointaccountSignApi : IAlipayFundJointaccountSignApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayFundJointaccountSignApi : IAlipayFundJointaccountSignApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountSignApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayFundJointaccountSignApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountSignApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayFundJointaccountSignApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountSignApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayFundJointaccountSignApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountSignApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayFundJointaccountSignApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 企业签约结果查询 通过外部订单号（out_biz_no）主动查询企业签约结果，可用于未收到签约结果通知的补偿操作
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">产品码，默认值 ENTERPRISE_PAY (optional)</param>
        /// <param name="bizScene">场景码，联系支付宝分配 (optional)</param>
        /// <param name="outBizNo">外部业务号，查询对应账户状态，优先级高于account_id (optional)</param>
        /// <param name="accountId">企业签约账户ID,用于外部商户已获取企业签约ID，查询账户状态 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayFundJointaccountSignQueryResponseModel</returns>
        public AlipayFundJointaccountSignQueryResponseModel Query(string productCode = default(string), string bizScene = default(string), string outBizNo = default(string), string accountId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayFundJointaccountSignQueryResponseModel> localVarResponse = QueryWithHttpInfo(productCode, bizScene, outBizNo, accountId, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 企业签约结果查询 通过外部订单号（out_biz_no）主动查询企业签约结果，可用于未收到签约结果通知的补偿操作
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">产品码，默认值 ENTERPRISE_PAY (optional)</param>
        /// <param name="bizScene">场景码，联系支付宝分配 (optional)</param>
        /// <param name="outBizNo">外部业务号，查询对应账户状态，优先级高于account_id (optional)</param>
        /// <param name="accountId">企业签约账户ID,用于外部商户已获取企业签约ID，查询账户状态 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayFundJointaccountSignQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayFundJointaccountSignQueryResponseModel> QueryWithHttpInfo(string productCode = default(string), string bizScene = default(string), string outBizNo = default(string), string accountId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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
            if (outBizNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "out_biz_no", outBizNo));
            }
            if (accountId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "account_id", accountId));
            }

            localVarRequestOptions.Operation = "AlipayFundJointaccountSignApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayFundJointaccountSignQueryResponseModel>("/v3/alipay/fund/jointaccount/sign/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayFundJointaccountSignQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
