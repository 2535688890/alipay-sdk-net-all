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
    /// AlipayOpenMiniInnerversionConditionBatchqueryErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerversionConditionBatchqueryErrorResponseModel")]
    public partial class AlipayOpenMiniInnerversionConditionBatchqueryErrorResponseModel : IEquatable<AlipayOpenMiniInnerversionConditionBatchqueryErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum APPIDISBLANK for value: APPID_IS_BLANK
            /// </summary>
            [EnumMember(Value = "APPID_IS_BLANK")]
            APPIDISBLANK = 1,

            /// <summary>
            /// Enum VERSIONSTATUSLISTISBLANK for value: VERSION_STATUS_LIST_IS_BLANK
            /// </summary>
            [EnumMember(Value = "VERSION_STATUS_LIST_IS_BLANK")]
            VERSIONSTATUSLISTISBLANK = 2,

            /// <summary>
            /// Enum APPORIGINISBLANK for value: APP_ORIGIN_IS_BLANK
            /// </summary>
            [EnumMember(Value = "APP_ORIGIN_IS_BLANK")]
            APPORIGINISBLANK = 3,

            /// <summary>
            /// Enum BUNDLEIDISBLANK for value: BUNDLE_ID_IS_BLANK
            /// </summary>
            [EnumMember(Value = "BUNDLE_ID_IS_BLANK")]
            BUNDLEIDISBLANK = 4,

            /// <summary>
            /// Enum NOPERMISSION for value: NO_PERMISSION
            /// </summary>
            [EnumMember(Value = "NO_PERMISSION")]
            NOPERMISSION = 5,

            /// <summary>
            /// Enum INVALIDPAGENUM for value: INVALID_PAGE_NUM
            /// </summary>
            [EnumMember(Value = "INVALID_PAGE_NUM")]
            INVALIDPAGENUM = 6,

            /// <summary>
            /// Enum INVALIDPAGESIZE for value: INVALID_PAGE_SIZE
            /// </summary>
            [EnumMember(Value = "INVALID_PAGE_SIZE")]
            INVALIDPAGESIZE = 7,

            /// <summary>
            /// Enum PAGENUMLESSONE for value: PAGE_NUM_LESS_ONE
            /// </summary>
            [EnumMember(Value = "PAGE_NUM_LESS_ONE")]
            PAGENUMLESSONE = 8,

            /// <summary>
            /// Enum PAGESIZEMORETEN for value: PAGE_SIZE_MORE_TEN
            /// </summary>
            [EnumMember(Value = "PAGE_SIZE_MORE_TEN")]
            PAGESIZEMORETEN = 9,

            /// <summary>
            /// Enum PAGESIZELESSZERO for value: PAGE_SIZE_LESS_ZERO
            /// </summary>
            [EnumMember(Value = "PAGE_SIZE_LESS_ZERO")]
            PAGESIZELESSZERO = 10,

            /// <summary>
            /// Enum INVALIDVERSIONSTATUS for value: INVALID_VERSION_STATUS
            /// </summary>
            [EnumMember(Value = "INVALID_VERSION_STATUS")]
            INVALIDVERSIONSTATUS = 11,

            /// <summary>
            /// Enum MINICOREINVOKEERROR for value: MINICORE_INVOKE_ERROR
            /// </summary>
            [EnumMember(Value = "MINICORE_INVOKE_ERROR")]
            MINICOREINVOKEERROR = 12,

            /// <summary>
            /// Enum PAGENUMLESSZERO for value: PAGE_NUM_LESS_ZERO
            /// </summary>
            [EnumMember(Value = "PAGE_NUM_LESS_ZERO")]
            PAGENUMLESSZERO = 13,

            /// <summary>
            /// Enum BUNDLEIDNOTEXIST for value: BUNDLE_ID_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "BUNDLE_ID_NOT_EXIST")]
            BUNDLEIDNOTEXIST = 14

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionConditionBatchqueryErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenMiniInnerversionConditionBatchqueryErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionConditionBatchqueryErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenMiniInnerversionConditionBatchqueryErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenMiniInnerversionConditionBatchqueryErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenMiniInnerversionConditionBatchqueryErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenMiniInnerversionConditionBatchqueryErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerversionConditionBatchqueryErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerversionConditionBatchqueryErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerversionConditionBatchqueryErrorResponseModel input)
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
