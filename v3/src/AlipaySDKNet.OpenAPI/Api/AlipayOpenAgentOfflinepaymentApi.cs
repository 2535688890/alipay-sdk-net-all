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
    public interface IAlipayOpenAgentOfflinepaymentApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 代签约当面付快捷版产品
        /// </summary>
        /// <remarks>
        /// 三方应用代理签约当面付快捷版产品，需要配合开启事务接口使用
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessLicensePic"> (optional)</param>
        /// <param name="data"> (optional)</param>
        /// <param name="shopScenePic"> (optional)</param>
        /// <param name="shopSignBoardPic"> (optional)</param>
        /// <param name="specialLicensePic"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Object</returns>
        Object Sign(System.IO.Stream businessLicensePic = default(System.IO.Stream), AlipayOpenAgentOfflinepaymentSignModel data = default(AlipayOpenAgentOfflinepaymentSignModel), System.IO.Stream shopScenePic = default(System.IO.Stream), System.IO.Stream shopSignBoardPic = default(System.IO.Stream), System.IO.Stream specialLicensePic = default(System.IO.Stream), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 代签约当面付快捷版产品
        /// </summary>
        /// <remarks>
        /// 三方应用代理签约当面付快捷版产品，需要配合开启事务接口使用
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessLicensePic"> (optional)</param>
        /// <param name="data"> (optional)</param>
        /// <param name="shopScenePic"> (optional)</param>
        /// <param name="shopSignBoardPic"> (optional)</param>
        /// <param name="specialLicensePic"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> SignWithHttpInfo(System.IO.Stream businessLicensePic = default(System.IO.Stream), AlipayOpenAgentOfflinepaymentSignModel data = default(AlipayOpenAgentOfflinepaymentSignModel), System.IO.Stream shopScenePic = default(System.IO.Stream), System.IO.Stream shopSignBoardPic = default(System.IO.Stream), System.IO.Stream specialLicensePic = default(System.IO.Stream), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayOpenAgentOfflinepaymentApi : IAlipayOpenAgentOfflinepaymentApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayOpenAgentOfflinepaymentApi : IAlipayOpenAgentOfflinepaymentApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAgentOfflinepaymentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayOpenAgentOfflinepaymentApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAgentOfflinepaymentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayOpenAgentOfflinepaymentApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAgentOfflinepaymentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayOpenAgentOfflinepaymentApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayOpenAgentOfflinepaymentApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayOpenAgentOfflinepaymentApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 代签约当面付快捷版产品 三方应用代理签约当面付快捷版产品，需要配合开启事务接口使用
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessLicensePic"> (optional)</param>
        /// <param name="data"> (optional)</param>
        /// <param name="shopScenePic"> (optional)</param>
        /// <param name="shopSignBoardPic"> (optional)</param>
        /// <param name="specialLicensePic"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Object</returns>
        public Object Sign(System.IO.Stream businessLicensePic = default(System.IO.Stream), AlipayOpenAgentOfflinepaymentSignModel data = default(AlipayOpenAgentOfflinepaymentSignModel), System.IO.Stream shopScenePic = default(System.IO.Stream), System.IO.Stream shopSignBoardPic = default(System.IO.Stream), System.IO.Stream specialLicensePic = default(System.IO.Stream), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<Object> localVarResponse = SignWithHttpInfo(businessLicensePic, data, shopScenePic, shopSignBoardPic, specialLicensePic, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 代签约当面付快捷版产品 三方应用代理签约当面付快捷版产品，需要配合开启事务接口使用
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessLicensePic"> (optional)</param>
        /// <param name="data"> (optional)</param>
        /// <param name="shopScenePic"> (optional)</param>
        /// <param name="shopSignBoardPic"> (optional)</param>
        /// <param name="specialLicensePic"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of Object</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<Object> SignWithHttpInfo(System.IO.Stream businessLicensePic = default(System.IO.Stream), AlipayOpenAgentOfflinepaymentSignModel data = default(AlipayOpenAgentOfflinepaymentSignModel), System.IO.Stream shopScenePic = default(System.IO.Stream), System.IO.Stream shopSignBoardPic = default(System.IO.Stream), System.IO.Stream specialLicensePic = default(System.IO.Stream), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.RequestOptions localVarRequestOptions = new AlipaySDKNet.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
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

            if (businessLicensePic != null)
            {
                localVarRequestOptions.FileParameters.Add("business_license_pic", businessLicensePic);
            }
            if (data != null)
            {
                localVarRequestOptions.FormParameters.Add("data", AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToString(data)); // form parameter
            }
            //自定义body内容
            if (customizedParams != null && !string.IsNullOrEmpty(customizedParams.BodyContent))
            {
                localVarRequestOptions.FormParameters.Add("data", customizedParams.BodyContent); // form parameter
            }
            if (shopScenePic != null)
            {
                localVarRequestOptions.FileParameters.Add("shop_scene_pic", shopScenePic);
            }
            if (shopSignBoardPic != null)
            {
                localVarRequestOptions.FileParameters.Add("shop_sign_board_pic", shopSignBoardPic);
            }
            if (specialLicensePic != null)
            {
                localVarRequestOptions.FileParameters.Add("special_license_pic", specialLicensePic);
            }

            localVarRequestOptions.Operation = "AlipayOpenAgentOfflinepaymentApi.Sign";
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
            var localVarResponse = this.Client.Post<Object>("/v3/alipay/open/agent/offlinepayment/sign", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Sign", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayOpenAgentOfflinepaymentSignDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
