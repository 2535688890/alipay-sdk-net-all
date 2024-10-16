/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2024-10-16
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = AlipaySDKNet.OpenAPI.Client.OpenAPIDateConverter;

namespace AlipaySDKNet.OpenAPI.Model
{
    /// <summary>
    /// ZhimaMerchantZmgoTemplateCreateErrorResponseModel
    /// </summary>
    [DataContract(Name = "ZhimaMerchantZmgoTemplateCreateErrorResponseModel")]
    public partial class ZhimaMerchantZmgoTemplateCreateErrorResponseModel : IEquatable<ZhimaMerchantZmgoTemplateCreateErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 1,

            /// <summary>
            /// Enum INVALIDPARAMETER for value: INVALID_PARAMETER
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMETER")]
            INVALIDPARAMETER = 2,

            /// <summary>
            /// Enum CHECKDEFAULTVALUEFAIL for value: CHECK_DEFAULT_VALUE_FAIL
            /// </summary>
            [EnumMember(Value = "CHECK_DEFAULT_VALUE_FAIL")]
            CHECKDEFAULTVALUEFAIL = 3,

            /// <summary>
            /// Enum INVALIDCYCLEFLEXWITHHOLDCONFIG for value: INVALID_CYCLE_FLEX_WITHHOLD_CONFIG
            /// </summary>
            [EnumMember(Value = "INVALID_CYCLE_FLEX_WITHHOLD_CONFIG")]
            INVALIDCYCLEFLEXWITHHOLDCONFIG = 4,

            /// <summary>
            /// Enum INVALIDFULFILLTIMESSETTLEPLAN for value: INVALID_FULFILL_TIMES_SETTLE_PLAN
            /// </summary>
            [EnumMember(Value = "INVALID_FULFILL_TIMES_SETTLE_PLAN")]
            INVALIDFULFILLTIMESSETTLEPLAN = 5,

            /// <summary>
            /// Enum INVALIDFREEZEAMOUNT for value: INVALID_FREEZE_AMOUNT
            /// </summary>
            [EnumMember(Value = "INVALID_FREEZE_AMOUNT")]
            INVALIDFREEZEAMOUNT = 6,

            /// <summary>
            /// Enum INVALIDCUSTOMOPENTIPLIST for value: INVALID_CUSTOM_OPEN_TIP_LIST
            /// </summary>
            [EnumMember(Value = "INVALID_CUSTOM_OPEN_TIP_LIST")]
            INVALIDCUSTOMOPENTIPLIST = 7,

            /// <summary>
            /// Enum INVALIDSETTLEMENTTYPE for value: INVALID_SETTLEMENT_TYPE
            /// </summary>
            [EnumMember(Value = "INVALID_SETTLEMENT_TYPE")]
            INVALIDSETTLEMENTTYPE = 8,

            /// <summary>
            /// Enum INVALIDQUITTYPE for value: INVALID_QUIT_TYPE
            /// </summary>
            [EnumMember(Value = "INVALID_QUIT_TYPE")]
            INVALIDQUITTYPE = 9,

            /// <summary>
            /// Enum INVALIDBIZTYPE for value: INVALID_BIZ_TYPE
            /// </summary>
            [EnumMember(Value = "INVALID_BIZ_TYPE")]
            INVALIDBIZTYPE = 10,

            /// <summary>
            /// Enum INVALIDPERIODMODE for value: INVALID_PERIOD_MODE
            /// </summary>
            [EnumMember(Value = "INVALID_PERIOD_MODE")]
            INVALIDPERIODMODE = 11,

            /// <summary>
            /// Enum INVALIDAPPOINTDATE for value: INVALID_APPOINT_DATE
            /// </summary>
            [EnumMember(Value = "INVALID_APPOINT_DATE")]
            INVALIDAPPOINTDATE = 12,

            /// <summary>
            /// Enum INVALIDPERIODTIME for value: INVALID_PERIOD_TIME
            /// </summary>
            [EnumMember(Value = "INVALID_PERIOD_TIME")]
            INVALIDPERIODTIME = 13,

            /// <summary>
            /// Enum REQUESTACCESSILLEGAL for value: REQUEST_ACCESS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "REQUEST_ACCESS_ILLEGAL")]
            REQUESTACCESSILLEGAL = 14,

            /// <summary>
            /// Enum INVALIDTEXTCONTENTFILLVARIABLE for value: INVALID_TEXT_CONTENT_FILL_VARIABLE
            /// </summary>
            [EnumMember(Value = "INVALID_TEXT_CONTENT_FILL_VARIABLE")]
            INVALIDTEXTCONTENTFILLVARIABLE = 15,

            /// <summary>
            /// Enum INVALIDTEXTCONTENTFILLRULEID for value: INVALID_TEXT_CONTENT_FILL_RULEID
            /// </summary>
            [EnumMember(Value = "INVALID_TEXT_CONTENT_FILL_RULEID")]
            INVALIDTEXTCONTENTFILLRULEID = 16,

            /// <summary>
            /// Enum CUSTOMMERCHANTLOGOPREFIXILLEGAL for value: CUSTOM_MERCHANT_LOGO_PREFIX_ILLEGAL
            /// </summary>
            [EnumMember(Value = "CUSTOM_MERCHANT_LOGO_PREFIX_ILLEGAL")]
            CUSTOMMERCHANTLOGOPREFIXILLEGAL = 17,

            /// <summary>
            /// Enum CONTENTSECCHECKFAIL for value: CONTENT_SEC_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "CONTENT_SEC_CHECK_FAIL")]
            CONTENTSECCHECKFAIL = 18

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaMerchantZmgoTemplateCreateErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ZhimaMerchantZmgoTemplateCreateErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaMerchantZmgoTemplateCreateErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public ZhimaMerchantZmgoTemplateCreateErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for ZhimaMerchantZmgoTemplateCreateErrorResponseModel and cannot be null");
            // }
            this.Message = message;
            this.Links = links;
        }

        /// <summary>
        /// 解决方案链接
        /// </summary>
        /// <value>解决方案链接</value>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public string Links { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        /// <value>错误描述</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaMerchantZmgoTemplateCreateErrorResponseModel {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ZhimaMerchantZmgoTemplateCreateErrorResponseModel);
        }

        /// <summary>
        /// Returns true if ZhimaMerchantZmgoTemplateCreateErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaMerchantZmgoTemplateCreateErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaMerchantZmgoTemplateCreateErrorResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    this.Code.Equals(input.Code)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Code.GetHashCode();
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
