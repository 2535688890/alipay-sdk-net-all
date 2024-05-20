/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2024-05-20
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
    /// AlipayOpenMiniInnerversionAuditCancelErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerversionAuditCancelErrorResponseModel")]
    public partial class AlipayOpenMiniInnerversionAuditCancelErrorResponseModel : IEquatable<AlipayOpenMiniInnerversionAuditCancelErrorResponseModel>, IValidatableObject
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
            /// Enum VERSIONISBLANK for value: VERSION_IS_BLANK
            /// </summary>
            [EnumMember(Value = "VERSION_IS_BLANK")]
            VERSIONISBLANK = 2,

            /// <summary>
            /// Enum APPINFONOTEXIST for value: APP_INFO_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "APP_INFO_NOT_EXIST")]
            APPINFONOTEXIST = 3,

            /// <summary>
            /// Enum APPLICATIONTYPENOTMINIAPP for value: APPLICATION_TYPE_NOT_MINIAPP
            /// </summary>
            [EnumMember(Value = "APPLICATION_TYPE_NOT_MINIAPP")]
            APPLICATIONTYPENOTMINIAPP = 4,

            /// <summary>
            /// Enum MINIAPPNOTONLINE for value: MINI_APP_NOT_ONLINE
            /// </summary>
            [EnumMember(Value = "MINI_APP_NOT_ONLINE")]
            MINIAPPNOTONLINE = 5,

            /// <summary>
            /// Enum MINIAPPPACKAGEINFONOTEXIST for value: MINI_APP_PACKAGE_INFO_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "MINI_APP_PACKAGE_INFO_NOT_EXIST")]
            MINIAPPPACKAGEINFONOTEXIST = 6,

            /// <summary>
            /// Enum TINYAPPSTATUSINVALID for value: TINYAPP_STATUS_INVALID
            /// </summary>
            [EnumMember(Value = "TINYAPP_STATUS_INVALID")]
            TINYAPPSTATUSINVALID = 7,

            /// <summary>
            /// Enum MULTICLIENTNOTPACKAGEDSTATUS for value: MULTI_CLIENT_NOT_PACKAGED_STATUS
            /// </summary>
            [EnumMember(Value = "MULTI_CLIENT_NOT_PACKAGED_STATUS")]
            MULTICLIENTNOTPACKAGEDSTATUS = 8,

            /// <summary>
            /// Enum APPSTORERPCINVOKEERROR for value: APPSTORE_RPC_INVOKE_ERROR
            /// </summary>
            [EnumMember(Value = "APPSTORE_RPC_INVOKE_ERROR")]
            APPSTORERPCINVOKEERROR = 9,

            /// <summary>
            /// Enum NOPERMISSION for value: NO_PERMISSION
            /// </summary>
            [EnumMember(Value = "NO_PERMISSION")]
            NOPERMISSION = 10,

            /// <summary>
            /// Enum APPORIGINNOTEXIST for value: APP_ORIGIN_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "APP_ORIGIN_NOT_EXIST")]
            APPORIGINNOTEXIST = 11,

            /// <summary>
            /// Enum BUNDLEIDNOTEXIST for value: BUNDLE_ID_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "BUNDLE_ID_NOT_EXIST")]
            BUNDLEIDNOTEXIST = 12

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionAuditCancelErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenMiniInnerversionAuditCancelErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionAuditCancelErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenMiniInnerversionAuditCancelErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenMiniInnerversionAuditCancelErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenMiniInnerversionAuditCancelErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenMiniInnerversionAuditCancelErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerversionAuditCancelErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerversionAuditCancelErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerversionAuditCancelErrorResponseModel input)
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
