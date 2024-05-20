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
    public interface IAlipayEbppInvoiceOrderApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 根据外部订单号查询发票信息
        /// </summary>
        /// <remarks>
        /// 根据外部订单号查询发票详情信息，适用于外部商户无开票申请ID场景
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderNo">开票申请时所传入订单号，不限于支付宝体内交易订单号。如：20200520110046966071 (optional)</param>
        /// <param name="mShortName">定义商户的一级简称,用于标识商户品牌，对应于商户入驻时填写的\&quot;商户品牌简称\&quot;。 如：肯德基：KFC (optional)</param>
        /// <param name="subMShortName">定义商户的二级简称,用于标识商户品牌下的分支机构，如门店，对应于商户入驻时填写的\&quot;商户门店简称\&quot;。 如：肯德基-杭州西湖区文一西路店：KFC-HZ-19003 要求：\&quot;商户品牌简称+商户门店简称\&quot;作为确定商户及其下属机构的唯一标识，不可重复。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceOrderQueryResponseModel</returns>
        AlipayEbppInvoiceOrderQueryResponseModel Query(string orderNo = default(string), string mShortName = default(string), string subMShortName = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 根据外部订单号查询发票信息
        /// </summary>
        /// <remarks>
        /// 根据外部订单号查询发票详情信息，适用于外部商户无开票申请ID场景
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderNo">开票申请时所传入订单号，不限于支付宝体内交易订单号。如：20200520110046966071 (optional)</param>
        /// <param name="mShortName">定义商户的一级简称,用于标识商户品牌，对应于商户入驻时填写的\&quot;商户品牌简称\&quot;。 如：肯德基：KFC (optional)</param>
        /// <param name="subMShortName">定义商户的二级简称,用于标识商户品牌下的分支机构，如门店，对应于商户入驻时填写的\&quot;商户门店简称\&quot;。 如：肯德基-杭州西湖区文一西路店：KFC-HZ-19003 要求：\&quot;商户品牌简称+商户门店简称\&quot;作为确定商户及其下属机构的唯一标识，不可重复。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceOrderQueryResponseModel</returns>
        ApiResponse<AlipayEbppInvoiceOrderQueryResponseModel> QueryWithHttpInfo(string orderNo = default(string), string mShortName = default(string), string subMShortName = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayEbppInvoiceOrderApi : IAlipayEbppInvoiceOrderApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayEbppInvoiceOrderApi : IAlipayEbppInvoiceOrderApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceOrderApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayEbppInvoiceOrderApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceOrderApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayEbppInvoiceOrderApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceOrderApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayEbppInvoiceOrderApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceOrderApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayEbppInvoiceOrderApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 根据外部订单号查询发票信息 根据外部订单号查询发票详情信息，适用于外部商户无开票申请ID场景
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderNo">开票申请时所传入订单号，不限于支付宝体内交易订单号。如：20200520110046966071 (optional)</param>
        /// <param name="mShortName">定义商户的一级简称,用于标识商户品牌，对应于商户入驻时填写的\&quot;商户品牌简称\&quot;。 如：肯德基：KFC (optional)</param>
        /// <param name="subMShortName">定义商户的二级简称,用于标识商户品牌下的分支机构，如门店，对应于商户入驻时填写的\&quot;商户门店简称\&quot;。 如：肯德基-杭州西湖区文一西路店：KFC-HZ-19003 要求：\&quot;商户品牌简称+商户门店简称\&quot;作为确定商户及其下属机构的唯一标识，不可重复。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceOrderQueryResponseModel</returns>
        public AlipayEbppInvoiceOrderQueryResponseModel Query(string orderNo = default(string), string mShortName = default(string), string subMShortName = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceOrderQueryResponseModel> localVarResponse = QueryWithHttpInfo(orderNo, mShortName, subMShortName, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 根据外部订单号查询发票信息 根据外部订单号查询发票详情信息，适用于外部商户无开票申请ID场景
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderNo">开票申请时所传入订单号，不限于支付宝体内交易订单号。如：20200520110046966071 (optional)</param>
        /// <param name="mShortName">定义商户的一级简称,用于标识商户品牌，对应于商户入驻时填写的\&quot;商户品牌简称\&quot;。 如：肯德基：KFC (optional)</param>
        /// <param name="subMShortName">定义商户的二级简称,用于标识商户品牌下的分支机构，如门店，对应于商户入驻时填写的\&quot;商户门店简称\&quot;。 如：肯德基-杭州西湖区文一西路店：KFC-HZ-19003 要求：\&quot;商户品牌简称+商户门店简称\&quot;作为确定商户及其下属机构的唯一标识，不可重复。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceOrderQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceOrderQueryResponseModel> QueryWithHttpInfo(string orderNo = default(string), string mShortName = default(string), string subMShortName = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (orderNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "order_no", orderNo));
            }
            if (mShortName != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "m_short_name", mShortName));
            }
            if (subMShortName != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "sub_m_short_name", subMShortName));
            }

            localVarRequestOptions.Operation = "AlipayEbppInvoiceOrderApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayEbppInvoiceOrderQueryResponseModel>("/v3/alipay/ebpp/invoice/order/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayEbppInvoiceOrderQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
