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
    public interface IAlipayEbppInvoiceExpensecomsueOutsourceApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 同步外部额度变更（交易形式）
        /// </summary>
        /// <remarks>
        /// 外部和企业码进行额度共管的时候，外部以交易的形式（支付、退款）将外部发生的额度变更同步给企业码
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceExpensecomsueOutsourceNotifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceExpensecomsueOutsourceNotifyResponseModel</returns>
        AlipayEbppInvoiceExpensecomsueOutsourceNotifyResponseModel Notify(AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel alipayEbppInvoiceExpensecomsueOutsourceNotifyModel = default(AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 同步外部额度变更（交易形式）
        /// </summary>
        /// <remarks>
        /// 外部和企业码进行额度共管的时候，外部以交易的形式（支付、退款）将外部发生的额度变更同步给企业码
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceExpensecomsueOutsourceNotifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceExpensecomsueOutsourceNotifyResponseModel</returns>
        ApiResponse<AlipayEbppInvoiceExpensecomsueOutsourceNotifyResponseModel> NotifyWithHttpInfo(AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel alipayEbppInvoiceExpensecomsueOutsourceNotifyModel = default(AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayEbppInvoiceExpensecomsueOutsourceApi : IAlipayEbppInvoiceExpensecomsueOutsourceApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayEbppInvoiceExpensecomsueOutsourceApi : IAlipayEbppInvoiceExpensecomsueOutsourceApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpensecomsueOutsourceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayEbppInvoiceExpensecomsueOutsourceApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpensecomsueOutsourceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayEbppInvoiceExpensecomsueOutsourceApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpensecomsueOutsourceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayEbppInvoiceExpensecomsueOutsourceApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpensecomsueOutsourceApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayEbppInvoiceExpensecomsueOutsourceApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 同步外部额度变更（交易形式） 外部和企业码进行额度共管的时候，外部以交易的形式（支付、退款）将外部发生的额度变更同步给企业码
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceExpensecomsueOutsourceNotifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceExpensecomsueOutsourceNotifyResponseModel</returns>
        public AlipayEbppInvoiceExpensecomsueOutsourceNotifyResponseModel Notify(AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel alipayEbppInvoiceExpensecomsueOutsourceNotifyModel = default(AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceExpensecomsueOutsourceNotifyResponseModel> localVarResponse = NotifyWithHttpInfo(alipayEbppInvoiceExpensecomsueOutsourceNotifyModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 同步外部额度变更（交易形式） 外部和企业码进行额度共管的时候，外部以交易的形式（支付、退款）将外部发生的额度变更同步给企业码
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceExpensecomsueOutsourceNotifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceExpensecomsueOutsourceNotifyResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceExpensecomsueOutsourceNotifyResponseModel> NotifyWithHttpInfo(AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel alipayEbppInvoiceExpensecomsueOutsourceNotifyModel = default(AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel), int operationIndex = 0, CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = alipayEbppInvoiceExpensecomsueOutsourceNotifyModel;
            }

            localVarRequestOptions.Operation = "AlipayEbppInvoiceExpensecomsueOutsourceApi.Notify";
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
            var localVarResponse = this.Client.Post<AlipayEbppInvoiceExpensecomsueOutsourceNotifyResponseModel>("/v3/alipay/ebpp/invoice/expensecomsue/outsource/notify", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Notify", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayEbppInvoiceExpensecomsueOutsourceNotifyDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
