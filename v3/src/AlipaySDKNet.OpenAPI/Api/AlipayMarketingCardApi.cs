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
    public interface IAlipayMarketingCardApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 会员卡删卡
        /// </summary>
        /// <remarks>
        /// 通过 API 接口删除商家会员卡。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outSerialNo">商户端删卡业务流水号，商户自定义且需确保流水号唯一性。 (optional)</param>
        /// <param name="targetCardNo">支付宝业务卡号。即开卡接口返回结果中的card_info.biz_card_no。 (optional)</param>
        /// <param name="targetCardNoType">卡号ID类型 (optional)</param>
        /// <param name="reasonCode">删卡原因  USER_UNBUND：用户解绑（可以重新绑定）  CANCEL：销户（完成销户后，就不能再重新绑定）  PRESENT：转赠（可以重新绑定） (optional)</param>
        /// <param name="extInfo">删卡扩展参数，json格式。  用于商户的特定业务信息的传递，只有商户与支付宝约定了传递此参数且约定了参数含义，此参数才有效。  目前支持如下key：  new_card_no：新卡号  donee_user_id：受赠人userId (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingCardDeleteResponseModel</returns>
        AlipayMarketingCardDeleteResponseModel Delete(string outSerialNo = default(string), string targetCardNo = default(string), string targetCardNoType = default(string), string reasonCode = default(string), string extInfo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 会员卡删卡
        /// </summary>
        /// <remarks>
        /// 通过 API 接口删除商家会员卡。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outSerialNo">商户端删卡业务流水号，商户自定义且需确保流水号唯一性。 (optional)</param>
        /// <param name="targetCardNo">支付宝业务卡号。即开卡接口返回结果中的card_info.biz_card_no。 (optional)</param>
        /// <param name="targetCardNoType">卡号ID类型 (optional)</param>
        /// <param name="reasonCode">删卡原因  USER_UNBUND：用户解绑（可以重新绑定）  CANCEL：销户（完成销户后，就不能再重新绑定）  PRESENT：转赠（可以重新绑定） (optional)</param>
        /// <param name="extInfo">删卡扩展参数，json格式。  用于商户的特定业务信息的传递，只有商户与支付宝约定了传递此参数且约定了参数含义，此参数才有效。  目前支持如下key：  new_card_no：新卡号  donee_user_id：受赠人userId (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingCardDeleteResponseModel</returns>
        ApiResponse<AlipayMarketingCardDeleteResponseModel> DeleteWithHttpInfo(string outSerialNo = default(string), string targetCardNo = default(string), string targetCardNoType = default(string), string reasonCode = default(string), string extInfo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 会员卡开卡
        /// </summary>
        /// <remarks>
        /// 商户通过API接口，进行会员卡开卡。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">用户授权令牌 (optional)</param>
        /// <param name="alipayMarketingCardOpenModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingCardOpenResponseModel</returns>
        AlipayMarketingCardOpenResponseModel Open(string authToken = default(string), AlipayMarketingCardOpenModel alipayMarketingCardOpenModel = default(AlipayMarketingCardOpenModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 会员卡开卡
        /// </summary>
        /// <remarks>
        /// 商户通过API接口，进行会员卡开卡。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">用户授权令牌 (optional)</param>
        /// <param name="alipayMarketingCardOpenModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingCardOpenResponseModel</returns>
        ApiResponse<AlipayMarketingCardOpenResponseModel> OpenWithHttpInfo(string authToken = default(string), AlipayMarketingCardOpenModel alipayMarketingCardOpenModel = default(AlipayMarketingCardOpenModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 会员卡查询
        /// </summary>
        /// <remarks>
        /// 根据卡号或者持卡人信息查询会员卡信息
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayMarketingCardQueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingCardQueryResponseModel</returns>
        AlipayMarketingCardQueryResponseModel Query(AlipayMarketingCardQueryModel alipayMarketingCardQueryModel = default(AlipayMarketingCardQueryModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 会员卡查询
        /// </summary>
        /// <remarks>
        /// 根据卡号或者持卡人信息查询会员卡信息
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayMarketingCardQueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingCardQueryResponseModel</returns>
        ApiResponse<AlipayMarketingCardQueryResponseModel> QueryWithHttpInfo(AlipayMarketingCardQueryModel alipayMarketingCardQueryModel = default(AlipayMarketingCardQueryModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 会员卡更新
        /// </summary>
        /// <remarks>
        /// 会员卡更新
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayMarketingCardUpdateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingCardUpdateResponseModel</returns>
        AlipayMarketingCardUpdateResponseModel Update(AlipayMarketingCardUpdateModel alipayMarketingCardUpdateModel = default(AlipayMarketingCardUpdateModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 会员卡更新
        /// </summary>
        /// <remarks>
        /// 会员卡更新
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayMarketingCardUpdateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingCardUpdateResponseModel</returns>
        ApiResponse<AlipayMarketingCardUpdateResponseModel> UpdateWithHttpInfo(AlipayMarketingCardUpdateModel alipayMarketingCardUpdateModel = default(AlipayMarketingCardUpdateModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayMarketingCardApi : IAlipayMarketingCardApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayMarketingCardApi : IAlipayMarketingCardApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCardApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayMarketingCardApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCardApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayMarketingCardApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCardApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayMarketingCardApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayMarketingCardApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayMarketingCardApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 会员卡删卡 通过 API 接口删除商家会员卡。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outSerialNo">商户端删卡业务流水号，商户自定义且需确保流水号唯一性。 (optional)</param>
        /// <param name="targetCardNo">支付宝业务卡号。即开卡接口返回结果中的card_info.biz_card_no。 (optional)</param>
        /// <param name="targetCardNoType">卡号ID类型 (optional)</param>
        /// <param name="reasonCode">删卡原因  USER_UNBUND：用户解绑（可以重新绑定）  CANCEL：销户（完成销户后，就不能再重新绑定）  PRESENT：转赠（可以重新绑定） (optional)</param>
        /// <param name="extInfo">删卡扩展参数，json格式。  用于商户的特定业务信息的传递，只有商户与支付宝约定了传递此参数且约定了参数含义，此参数才有效。  目前支持如下key：  new_card_no：新卡号  donee_user_id：受赠人userId (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingCardDeleteResponseModel</returns>
        public AlipayMarketingCardDeleteResponseModel Delete(string outSerialNo = default(string), string targetCardNo = default(string), string targetCardNoType = default(string), string reasonCode = default(string), string extInfo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingCardDeleteResponseModel> localVarResponse = DeleteWithHttpInfo(outSerialNo, targetCardNo, targetCardNoType, reasonCode, extInfo, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 会员卡删卡 通过 API 接口删除商家会员卡。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outSerialNo">商户端删卡业务流水号，商户自定义且需确保流水号唯一性。 (optional)</param>
        /// <param name="targetCardNo">支付宝业务卡号。即开卡接口返回结果中的card_info.biz_card_no。 (optional)</param>
        /// <param name="targetCardNoType">卡号ID类型 (optional)</param>
        /// <param name="reasonCode">删卡原因  USER_UNBUND：用户解绑（可以重新绑定）  CANCEL：销户（完成销户后，就不能再重新绑定）  PRESENT：转赠（可以重新绑定） (optional)</param>
        /// <param name="extInfo">删卡扩展参数，json格式。  用于商户的特定业务信息的传递，只有商户与支付宝约定了传递此参数且约定了参数含义，此参数才有效。  目前支持如下key：  new_card_no：新卡号  donee_user_id：受赠人userId (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingCardDeleteResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingCardDeleteResponseModel> DeleteWithHttpInfo(string outSerialNo = default(string), string targetCardNo = default(string), string targetCardNoType = default(string), string reasonCode = default(string), string extInfo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (outSerialNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "out_serial_no", outSerialNo));
            }
            if (targetCardNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "target_card_no", targetCardNo));
            }
            if (targetCardNoType != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "target_card_no_type", targetCardNoType));
            }
            if (reasonCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "reason_code", reasonCode));
            }
            if (extInfo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "ext_info", extInfo));
            }

            localVarRequestOptions.Operation = "AlipayMarketingCardApi.Delete";
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
            var localVarResponse = this.Client.Delete<AlipayMarketingCardDeleteResponseModel>("/v3/alipay/marketing/card/delete", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Delete", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayMarketingCardDeleteDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 会员卡开卡 商户通过API接口，进行会员卡开卡。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">用户授权令牌 (optional)</param>
        /// <param name="alipayMarketingCardOpenModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingCardOpenResponseModel</returns>
        public AlipayMarketingCardOpenResponseModel Open(string authToken = default(string), AlipayMarketingCardOpenModel alipayMarketingCardOpenModel = default(AlipayMarketingCardOpenModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingCardOpenResponseModel> localVarResponse = OpenWithHttpInfo(authToken, alipayMarketingCardOpenModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 会员卡开卡 商户通过API接口，进行会员卡开卡。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authToken">用户授权令牌 (optional)</param>
        /// <param name="alipayMarketingCardOpenModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingCardOpenResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingCardOpenResponseModel> OpenWithHttpInfo(string authToken = default(string), AlipayMarketingCardOpenModel alipayMarketingCardOpenModel = default(AlipayMarketingCardOpenModel), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (authToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "auth_token", authToken));
            }
            //自定义body内容
            if (customizedParams != null && !string.IsNullOrEmpty(customizedParams.BodyContent))
            {
                localVarRequestOptions.Data = customizedParams.BodyContent;
            }
            else
            {
                localVarRequestOptions.Data = alipayMarketingCardOpenModel;
            }

            localVarRequestOptions.Operation = "AlipayMarketingCardApi.Open";
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
            var localVarResponse = this.Client.Post<AlipayMarketingCardOpenResponseModel>("/v3/alipay/marketing/card/open", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Open", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayMarketingCardOpenDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 会员卡查询 根据卡号或者持卡人信息查询会员卡信息
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayMarketingCardQueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingCardQueryResponseModel</returns>
        public AlipayMarketingCardQueryResponseModel Query(AlipayMarketingCardQueryModel alipayMarketingCardQueryModel = default(AlipayMarketingCardQueryModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingCardQueryResponseModel> localVarResponse = QueryWithHttpInfo(alipayMarketingCardQueryModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 会员卡查询 根据卡号或者持卡人信息查询会员卡信息
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayMarketingCardQueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingCardQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingCardQueryResponseModel> QueryWithHttpInfo(AlipayMarketingCardQueryModel alipayMarketingCardQueryModel = default(AlipayMarketingCardQueryModel), int operationIndex = 0, CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = alipayMarketingCardQueryModel;
            }

            localVarRequestOptions.Operation = "AlipayMarketingCardApi.Query";
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
            var localVarResponse = this.Client.Post<AlipayMarketingCardQueryResponseModel>("/v3/alipay/marketing/card/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayMarketingCardQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 会员卡更新 会员卡更新
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayMarketingCardUpdateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingCardUpdateResponseModel</returns>
        public AlipayMarketingCardUpdateResponseModel Update(AlipayMarketingCardUpdateModel alipayMarketingCardUpdateModel = default(AlipayMarketingCardUpdateModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingCardUpdateResponseModel> localVarResponse = UpdateWithHttpInfo(alipayMarketingCardUpdateModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 会员卡更新 会员卡更新
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayMarketingCardUpdateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingCardUpdateResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingCardUpdateResponseModel> UpdateWithHttpInfo(AlipayMarketingCardUpdateModel alipayMarketingCardUpdateModel = default(AlipayMarketingCardUpdateModel), int operationIndex = 0, CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = alipayMarketingCardUpdateModel;
            }

            localVarRequestOptions.Operation = "AlipayMarketingCardApi.Update";
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
            var localVarResponse = this.Client.Post<AlipayMarketingCardUpdateResponseModel>("/v3/alipay/marketing/card/update", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Update", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayMarketingCardUpdateDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
