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
    public interface IAlipayFundJointaccountBillApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 因公付账单查询
        /// </summary>
        /// <remarks>
        /// 因公付账单查询
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">因公付产品码 (optional)</param>
        /// <param name="bizScene">业务场景 (optional)</param>
        /// <param name="accountId">账户ID (optional)</param>
        /// <param name="pageNum">采用分页查询，本参数为空或0默认显示第一页。如果输入的值大于总页数，则支付宝返回最后一页数据 (optional)</param>
        /// <param name="pageSize">每页大小，不传的情况下默认20条，超过20条默认按20条查询；不足20条则按实际记录数返回 (optional)</param>
        /// <param name="userId">员工ID (optional)</param>
        /// <param name="openId">员工的openId (optional)</param>
        /// <param name="startDate">起始日期 (optional)</param>
        /// <param name="endDate">截止日期 (optional)</param>
        /// <param name="agreementNo">授权协议号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayFundJointaccountBillQueryResponseModel</returns>
        AlipayFundJointaccountBillQueryResponseModel Query(string productCode = default(string), string bizScene = default(string), string accountId = default(string), string pageNum = default(string), string pageSize = default(string), string userId = default(string), string openId = default(string), string startDate = default(string), string endDate = default(string), string agreementNo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 因公付账单查询
        /// </summary>
        /// <remarks>
        /// 因公付账单查询
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">因公付产品码 (optional)</param>
        /// <param name="bizScene">业务场景 (optional)</param>
        /// <param name="accountId">账户ID (optional)</param>
        /// <param name="pageNum">采用分页查询，本参数为空或0默认显示第一页。如果输入的值大于总页数，则支付宝返回最后一页数据 (optional)</param>
        /// <param name="pageSize">每页大小，不传的情况下默认20条，超过20条默认按20条查询；不足20条则按实际记录数返回 (optional)</param>
        /// <param name="userId">员工ID (optional)</param>
        /// <param name="openId">员工的openId (optional)</param>
        /// <param name="startDate">起始日期 (optional)</param>
        /// <param name="endDate">截止日期 (optional)</param>
        /// <param name="agreementNo">授权协议号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayFundJointaccountBillQueryResponseModel</returns>
        ApiResponse<AlipayFundJointaccountBillQueryResponseModel> QueryWithHttpInfo(string productCode = default(string), string bizScene = default(string), string accountId = default(string), string pageNum = default(string), string pageSize = default(string), string userId = default(string), string openId = default(string), string startDate = default(string), string endDate = default(string), string agreementNo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayFundJointaccountBillApi : IAlipayFundJointaccountBillApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayFundJointaccountBillApi : IAlipayFundJointaccountBillApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountBillApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayFundJointaccountBillApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountBillApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayFundJointaccountBillApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountBillApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayFundJointaccountBillApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountBillApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayFundJointaccountBillApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 因公付账单查询 因公付账单查询
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">因公付产品码 (optional)</param>
        /// <param name="bizScene">业务场景 (optional)</param>
        /// <param name="accountId">账户ID (optional)</param>
        /// <param name="pageNum">采用分页查询，本参数为空或0默认显示第一页。如果输入的值大于总页数，则支付宝返回最后一页数据 (optional)</param>
        /// <param name="pageSize">每页大小，不传的情况下默认20条，超过20条默认按20条查询；不足20条则按实际记录数返回 (optional)</param>
        /// <param name="userId">员工ID (optional)</param>
        /// <param name="openId">员工的openId (optional)</param>
        /// <param name="startDate">起始日期 (optional)</param>
        /// <param name="endDate">截止日期 (optional)</param>
        /// <param name="agreementNo">授权协议号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayFundJointaccountBillQueryResponseModel</returns>
        public AlipayFundJointaccountBillQueryResponseModel Query(string productCode = default(string), string bizScene = default(string), string accountId = default(string), string pageNum = default(string), string pageSize = default(string), string userId = default(string), string openId = default(string), string startDate = default(string), string endDate = default(string), string agreementNo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayFundJointaccountBillQueryResponseModel> localVarResponse = QueryWithHttpInfo(productCode, bizScene, accountId, pageNum, pageSize, userId, openId, startDate, endDate, agreementNo, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 因公付账单查询 因公付账单查询
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">因公付产品码 (optional)</param>
        /// <param name="bizScene">业务场景 (optional)</param>
        /// <param name="accountId">账户ID (optional)</param>
        /// <param name="pageNum">采用分页查询，本参数为空或0默认显示第一页。如果输入的值大于总页数，则支付宝返回最后一页数据 (optional)</param>
        /// <param name="pageSize">每页大小，不传的情况下默认20条，超过20条默认按20条查询；不足20条则按实际记录数返回 (optional)</param>
        /// <param name="userId">员工ID (optional)</param>
        /// <param name="openId">员工的openId (optional)</param>
        /// <param name="startDate">起始日期 (optional)</param>
        /// <param name="endDate">截止日期 (optional)</param>
        /// <param name="agreementNo">授权协议号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayFundJointaccountBillQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayFundJointaccountBillQueryResponseModel> QueryWithHttpInfo(string productCode = default(string), string bizScene = default(string), string accountId = default(string), string pageNum = default(string), string pageSize = default(string), string userId = default(string), string openId = default(string), string startDate = default(string), string endDate = default(string), string agreementNo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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
            if (pageNum != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_num", pageNum));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "user_id", userId));
            }
            if (openId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "open_id", openId));
            }
            if (startDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "start_date", startDate));
            }
            if (endDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "end_date", endDate));
            }
            if (agreementNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "agreement_no", agreementNo));
            }

            localVarRequestOptions.Operation = "AlipayFundJointaccountBillApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayFundJointaccountBillQueryResponseModel>("/v3/alipay/fund/jointaccount/bill/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayFundJointaccountBillQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
