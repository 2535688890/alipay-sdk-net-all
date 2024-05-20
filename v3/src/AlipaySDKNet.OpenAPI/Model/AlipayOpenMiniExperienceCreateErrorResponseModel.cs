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
    /// AlipayOpenMiniExperienceCreateErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniExperienceCreateErrorResponseModel")]
    public partial class AlipayOpenMiniExperienceCreateErrorResponseModel : IEquatable<AlipayOpenMiniExperienceCreateErrorResponseModel>, IValidatableObject
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
            /// Enum APPVERSIONISBLANK for value: APP_VERSION_IS_BLANK
            /// </summary>
            [EnumMember(Value = "APP_VERSION_IS_BLANK")]
            APPVERSIONISBLANK = 2,

            /// <summary>
            /// Enum APPLICATIONTYPENOTMINIAPP for value: APPLICATION_TYPE_NOT_MINIAPP
            /// </summary>
            [EnumMember(Value = "APPLICATION_TYPE_NOT_MINIAPP")]
            APPLICATIONTYPENOTMINIAPP = 3,

            /// <summary>
            /// Enum MINIAPPPACKAGEINFONOTEXIST for value: MINI_APP_PACKAGE_INFO_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "MINI_APP_PACKAGE_INFO_NOT_EXIST")]
            MINIAPPPACKAGEINFONOTEXIST = 4,

            /// <summary>
            /// Enum CANNOTSETEXPREPEAT for value: CAN_NOT_SET_EXP_REPEAT
            /// </summary>
            [EnumMember(Value = "CAN_NOT_SET_EXP_REPEAT")]
            CANNOTSETEXPREPEAT = 5,

            /// <summary>
            /// Enum CANNOTSETEXPINVALIDSTATUS for value: CAN_NOT_SET_EXP_INVALID_STATUS
            /// </summary>
            [EnumMember(Value = "CAN_NOT_SET_EXP_INVALID_STATUS")]
            CANNOTSETEXPINVALIDSTATUS = 6,

            /// <summary>
            /// Enum CANNOTSETWITHOUTSCANPASS for value: CAN_NOT_SET_WITHOUT_SCAN_PASS
            /// </summary>
            [EnumMember(Value = "CAN_NOT_SET_WITHOUT_SCAN_PASS")]
            CANNOTSETWITHOUTSCANPASS = 7,

            /// <summary>
            /// Enum INVALIDPARAMS for value: INVALID_PARAMS
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMS")]
            INVALIDPARAMS = 8,

            /// <summary>
            /// Enum APPINFONOTEXIST for value: APP_INFO_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "APP_INFO_NOT_EXIST")]
            APPINFONOTEXIST = 9,

            /// <summary>
            /// Enum MINIAPPNOTONLINE for value: MINI_APP_NOT_ONLINE
            /// </summary>
            [EnumMember(Value = "MINI_APP_NOT_ONLINE")]
            MINIAPPNOTONLINE = 10,

            /// <summary>
            /// Enum CLIENTTYPEREQUIRED for value: CLIENT_TYPE_REQUIRED
            /// </summary>
            [EnumMember(Value = "CLIENT_TYPE_REQUIRED")]
            CLIENTTYPEREQUIRED = 11,

            /// <summary>
            /// Enum CANNOTSETEXPWITHONLINEDSTATUS for value: CAN_NOT_SET_EXP_WITH_ONLINED_STATUS
            /// </summary>
            [EnumMember(Value = "CAN_NOT_SET_EXP_WITH_ONLINED_STATUS")]
            CANNOTSETEXPWITHONLINEDSTATUS = 12,

            /// <summary>
            /// Enum MINIAPPVERSIONITERATIONEXIST for value: MINI_APP_VERSION_ITERATION_EXIST
            /// </summary>
            [EnumMember(Value = "MINI_APP_VERSION_ITERATION_EXIST")]
            MINIAPPVERSIONITERATIONEXIST = 13

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniExperienceCreateErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenMiniExperienceCreateErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniExperienceCreateErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenMiniExperienceCreateErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenMiniExperienceCreateErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenMiniExperienceCreateErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenMiniExperienceCreateErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniExperienceCreateErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniExperienceCreateErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniExperienceCreateErrorResponseModel input)
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
