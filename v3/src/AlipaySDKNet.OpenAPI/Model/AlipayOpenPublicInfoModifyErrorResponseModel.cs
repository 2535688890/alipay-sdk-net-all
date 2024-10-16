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
    /// AlipayOpenPublicInfoModifyErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicInfoModifyErrorResponseModel")]
    public partial class AlipayOpenPublicInfoModifyErrorResponseModel : IEquatable<AlipayOpenPublicInfoModifyErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum PUBLICMODIFYPARAMILLEGAL for value: PUBLIC_MODIFY_PARAM_ILLEGAL
            /// </summary>
            [EnumMember(Value = "PUBLIC_MODIFY_PARAM_ILLEGAL")]
            PUBLICMODIFYPARAMILLEGAL = 1,

            /// <summary>
            /// Enum APPINFONOTEXIST for value: APPINFO_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "APPINFO_NOT_EXIST")]
            APPINFONOTEXIST = 2,

            /// <summary>
            /// Enum PUBLICGREETINGOVERLIMT for value: PUBLIC_GREETING_OVERLIMT
            /// </summary>
            [EnumMember(Value = "PUBLIC_GREETING_OVERLIMT")]
            PUBLICGREETINGOVERLIMT = 3,

            /// <summary>
            /// Enum APPORDERAUDINGEXIST for value: APP_ORDER_AUDING_EXIST
            /// </summary>
            [EnumMember(Value = "APP_ORDER_AUDING_EXIST")]
            APPORDERAUDINGEXIST = 4,

            /// <summary>
            /// Enum PUBLICORDERDAYLIMIT for value: PUBLIC_ORDER_DAY_LIMIT
            /// </summary>
            [EnumMember(Value = "PUBLIC_ORDER_DAY_LIMIT")]
            PUBLICORDERDAYLIMIT = 5,

            /// <summary>
            /// Enum ILLEGALLOGOURL for value: ILLEGAL_LOGO_URL
            /// </summary>
            [EnumMember(Value = "ILLEGAL_LOGO_URL")]
            ILLEGALLOGOURL = 6,

            /// <summary>
            /// Enum PUBLICLOGONOTNULL for value: PUBLIC_LOGO_NOT_NULL
            /// </summary>
            [EnumMember(Value = "PUBLIC_LOGO_NOT_NULL")]
            PUBLICLOGONOTNULL = 7,

            /// <summary>
            /// Enum ILLEGALLICENSEURL for value: ILLEGAL_LICENSE_URL
            /// </summary>
            [EnumMember(Value = "ILLEGAL_LICENSE_URL")]
            ILLEGALLICENSEURL = 8,

            /// <summary>
            /// Enum PUBLICGREETINGILLEGAL for value: PUBLIC_GREETING_ILLEGAL
            /// </summary>
            [EnumMember(Value = "PUBLIC_GREETING_ILLEGAL")]
            PUBLICGREETINGILLEGAL = 9,

            /// <summary>
            /// Enum APPNAMELENGTHLIMIT for value: APP_NAME_LENGTH_LIMIT
            /// </summary>
            [EnumMember(Value = "APP_NAME_LENGTH_LIMIT")]
            APPNAMELENGTHLIMIT = 10,

            /// <summary>
            /// Enum APPNAMEILLEGAL for value: APP_NAME_ILLEGAL
            /// </summary>
            [EnumMember(Value = "APP_NAME_ILLEGAL")]
            APPNAMEILLEGAL = 11,

            /// <summary>
            /// Enum APPNAMEEXIST for value: APP_NAME_EXIST
            /// </summary>
            [EnumMember(Value = "APP_NAME_EXIST")]
            APPNAMEEXIST = 12,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 13,

            /// <summary>
            /// Enum PUBLICNAMEMODIFYLIMIT for value: PUBLIC_NAME_MODIFY_LIMIT
            /// </summary>
            [EnumMember(Value = "PUBLIC_NAME_MODIFY_LIMIT")]
            PUBLICNAMEMODIFYLIMIT = 14,

            /// <summary>
            /// Enum INTRODUCTIONLENGTHLIMIT for value: INTRODUCTION_LENGTH_LIMIT
            /// </summary>
            [EnumMember(Value = "INTRODUCTION_LENGTH_LIMIT")]
            INTRODUCTIONLENGTHLIMIT = 15,

            /// <summary>
            /// Enum ILLEGALBACKGROUNDURL for value: ILLEGAL_BACKGROUND_URL
            /// </summary>
            [EnumMember(Value = "ILLEGAL_BACKGROUND_URL")]
            ILLEGALBACKGROUNDURL = 16

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicInfoModifyErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenPublicInfoModifyErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicInfoModifyErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenPublicInfoModifyErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenPublicInfoModifyErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenPublicInfoModifyErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenPublicInfoModifyErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicInfoModifyErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicInfoModifyErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicInfoModifyErrorResponseModel input)
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
