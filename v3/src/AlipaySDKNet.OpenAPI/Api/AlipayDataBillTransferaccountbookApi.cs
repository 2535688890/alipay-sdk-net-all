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
    public interface IAlipayDataBillTransferaccountbookApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 子账本充提转账单查询(incubating)
        /// </summary>
        /// <remarks>
        /// 子账本充提转账单查询（子账本业务定制接口）
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">充值、转账、提现流水业务时间的起始范围 (optional)</param>
        /// <param name="endTime">充值、转账、提现流水业务时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间 (optional)</param>
        /// <param name="type">转账类型：充值-DEPOSIT，提现-WITHDRAW，转账-TRANSFER。 (optional)</param>
        /// <param name="agreementNo">协议号 (optional)</param>
        /// <param name="storeNo">子账本号，或者子账本名称。模糊查询 (optional)</param>
        /// <param name="pageNo">分页号，从1开始 (optional)</param>
        /// <param name="pageSize">分页大小1000-2000，默认2000 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayDataBillTransferaccountbookQueryResponseModel</returns>
        AlipayDataBillTransferaccountbookQueryResponseModel Query(string startTime = default(string), string endTime = default(string), string type = default(string), string agreementNo = default(string), string storeNo = default(string), string pageNo = default(string), string pageSize = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 子账本充提转账单查询(incubating)
        /// </summary>
        /// <remarks>
        /// 子账本充提转账单查询（子账本业务定制接口）
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">充值、转账、提现流水业务时间的起始范围 (optional)</param>
        /// <param name="endTime">充值、转账、提现流水业务时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间 (optional)</param>
        /// <param name="type">转账类型：充值-DEPOSIT，提现-WITHDRAW，转账-TRANSFER。 (optional)</param>
        /// <param name="agreementNo">协议号 (optional)</param>
        /// <param name="storeNo">子账本号，或者子账本名称。模糊查询 (optional)</param>
        /// <param name="pageNo">分页号，从1开始 (optional)</param>
        /// <param name="pageSize">分页大小1000-2000，默认2000 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayDataBillTransferaccountbookQueryResponseModel</returns>
        ApiResponse<AlipayDataBillTransferaccountbookQueryResponseModel> QueryWithHttpInfo(string startTime = default(string), string endTime = default(string), string type = default(string), string agreementNo = default(string), string storeNo = default(string), string pageNo = default(string), string pageSize = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayDataBillTransferaccountbookApi : IAlipayDataBillTransferaccountbookApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayDataBillTransferaccountbookApi : IAlipayDataBillTransferaccountbookApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayDataBillTransferaccountbookApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayDataBillTransferaccountbookApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayDataBillTransferaccountbookApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayDataBillTransferaccountbookApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayDataBillTransferaccountbookApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayDataBillTransferaccountbookApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayDataBillTransferaccountbookApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayDataBillTransferaccountbookApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 子账本充提转账单查询(incubating) 子账本充提转账单查询（子账本业务定制接口）
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">充值、转账、提现流水业务时间的起始范围 (optional)</param>
        /// <param name="endTime">充值、转账、提现流水业务时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间 (optional)</param>
        /// <param name="type">转账类型：充值-DEPOSIT，提现-WITHDRAW，转账-TRANSFER。 (optional)</param>
        /// <param name="agreementNo">协议号 (optional)</param>
        /// <param name="storeNo">子账本号，或者子账本名称。模糊查询 (optional)</param>
        /// <param name="pageNo">分页号，从1开始 (optional)</param>
        /// <param name="pageSize">分页大小1000-2000，默认2000 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayDataBillTransferaccountbookQueryResponseModel</returns>
        public AlipayDataBillTransferaccountbookQueryResponseModel Query(string startTime = default(string), string endTime = default(string), string type = default(string), string agreementNo = default(string), string storeNo = default(string), string pageNo = default(string), string pageSize = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayDataBillTransferaccountbookQueryResponseModel> localVarResponse = QueryWithHttpInfo(startTime, endTime, type, agreementNo, storeNo, pageNo, pageSize, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 子账本充提转账单查询(incubating) 子账本充提转账单查询（子账本业务定制接口）
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">充值、转账、提现流水业务时间的起始范围 (optional)</param>
        /// <param name="endTime">充值、转账、提现流水业务时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间 (optional)</param>
        /// <param name="type">转账类型：充值-DEPOSIT，提现-WITHDRAW，转账-TRANSFER。 (optional)</param>
        /// <param name="agreementNo">协议号 (optional)</param>
        /// <param name="storeNo">子账本号，或者子账本名称。模糊查询 (optional)</param>
        /// <param name="pageNo">分页号，从1开始 (optional)</param>
        /// <param name="pageSize">分页大小1000-2000，默认2000 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayDataBillTransferaccountbookQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayDataBillTransferaccountbookQueryResponseModel> QueryWithHttpInfo(string startTime = default(string), string endTime = default(string), string type = default(string), string agreementNo = default(string), string storeNo = default(string), string pageNo = default(string), string pageSize = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (startTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "start_time", startTime));
            }
            if (endTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "end_time", endTime));
            }
            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "type", type));
            }
            if (agreementNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "agreement_no", agreementNo));
            }
            if (storeNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "store_no", storeNo));
            }
            if (pageNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_no", pageNo));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }

            localVarRequestOptions.Operation = "AlipayDataBillTransferaccountbookApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayDataBillTransferaccountbookQueryResponseModel>("/v3/alipay/data/bill/transferaccountbook/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayDataBillTransferaccountbookQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
