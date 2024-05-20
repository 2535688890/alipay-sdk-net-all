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
    public interface IAlipayOpenPublicMessageLabelApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 根据标签组发消息接口
        /// </summary>
        /// <remarks>
        /// 开发者可以通过标签运算圈定一批用户，并且向这批用户推送消息。关于标签组发有以下注意点：  除了商户自定义标签，还支持支付宝用户标签，我们将陆续开放用户画像标签，目前支持的支付宝标签及说明请查看支付宝开放标签；  用户及标签数据有1天的缓存时间，即昨天开发者给M用户打了a标签，今天给有a标签的用户组发消息，M能够收到消息；但是如果开发者今天给M用户打了a标签，然后向有a标签的用户组发消息，M不能收到消息；  与群发消息接口类似，该接口调用之后，消息发送系统会处理一段时间，调用接口到发送成功存在一定的时延，几分钟到半个小时不等；  对于同一个用户而言，一周只能收到一条群发或者标签组发的消息；  消息组发接口一周最多调用5次。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayOpenPublicMessageLabelSendModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Object</returns>
        Object Send(AlipayOpenPublicMessageLabelSendModel alipayOpenPublicMessageLabelSendModel = default(AlipayOpenPublicMessageLabelSendModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 根据标签组发消息接口
        /// </summary>
        /// <remarks>
        /// 开发者可以通过标签运算圈定一批用户，并且向这批用户推送消息。关于标签组发有以下注意点：  除了商户自定义标签，还支持支付宝用户标签，我们将陆续开放用户画像标签，目前支持的支付宝标签及说明请查看支付宝开放标签；  用户及标签数据有1天的缓存时间，即昨天开发者给M用户打了a标签，今天给有a标签的用户组发消息，M能够收到消息；但是如果开发者今天给M用户打了a标签，然后向有a标签的用户组发消息，M不能收到消息；  与群发消息接口类似，该接口调用之后，消息发送系统会处理一段时间，调用接口到发送成功存在一定的时延，几分钟到半个小时不等；  对于同一个用户而言，一周只能收到一条群发或者标签组发的消息；  消息组发接口一周最多调用5次。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayOpenPublicMessageLabelSendModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> SendWithHttpInfo(AlipayOpenPublicMessageLabelSendModel alipayOpenPublicMessageLabelSendModel = default(AlipayOpenPublicMessageLabelSendModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayOpenPublicMessageLabelApi : IAlipayOpenPublicMessageLabelApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayOpenPublicMessageLabelApi : IAlipayOpenPublicMessageLabelApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicMessageLabelApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayOpenPublicMessageLabelApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicMessageLabelApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayOpenPublicMessageLabelApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicMessageLabelApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayOpenPublicMessageLabelApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayOpenPublicMessageLabelApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayOpenPublicMessageLabelApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 根据标签组发消息接口 开发者可以通过标签运算圈定一批用户，并且向这批用户推送消息。关于标签组发有以下注意点：  除了商户自定义标签，还支持支付宝用户标签，我们将陆续开放用户画像标签，目前支持的支付宝标签及说明请查看支付宝开放标签；  用户及标签数据有1天的缓存时间，即昨天开发者给M用户打了a标签，今天给有a标签的用户组发消息，M能够收到消息；但是如果开发者今天给M用户打了a标签，然后向有a标签的用户组发消息，M不能收到消息；  与群发消息接口类似，该接口调用之后，消息发送系统会处理一段时间，调用接口到发送成功存在一定的时延，几分钟到半个小时不等；  对于同一个用户而言，一周只能收到一条群发或者标签组发的消息；  消息组发接口一周最多调用5次。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayOpenPublicMessageLabelSendModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Object</returns>
        public Object Send(AlipayOpenPublicMessageLabelSendModel alipayOpenPublicMessageLabelSendModel = default(AlipayOpenPublicMessageLabelSendModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<Object> localVarResponse = SendWithHttpInfo(alipayOpenPublicMessageLabelSendModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 根据标签组发消息接口 开发者可以通过标签运算圈定一批用户，并且向这批用户推送消息。关于标签组发有以下注意点：  除了商户自定义标签，还支持支付宝用户标签，我们将陆续开放用户画像标签，目前支持的支付宝标签及说明请查看支付宝开放标签；  用户及标签数据有1天的缓存时间，即昨天开发者给M用户打了a标签，今天给有a标签的用户组发消息，M能够收到消息；但是如果开发者今天给M用户打了a标签，然后向有a标签的用户组发消息，M不能收到消息；  与群发消息接口类似，该接口调用之后，消息发送系统会处理一段时间，调用接口到发送成功存在一定的时延，几分钟到半个小时不等；  对于同一个用户而言，一周只能收到一条群发或者标签组发的消息；  消息组发接口一周最多调用5次。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayOpenPublicMessageLabelSendModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of Object</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<Object> SendWithHttpInfo(AlipayOpenPublicMessageLabelSendModel alipayOpenPublicMessageLabelSendModel = default(AlipayOpenPublicMessageLabelSendModel), int operationIndex = 0, CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = alipayOpenPublicMessageLabelSendModel;
            }

            localVarRequestOptions.Operation = "AlipayOpenPublicMessageLabelApi.Send";
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
            var localVarResponse = this.Client.Post<Object>("/v3/alipay/open/public/message/label/send", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Send", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayOpenPublicMessageLabelSendDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
