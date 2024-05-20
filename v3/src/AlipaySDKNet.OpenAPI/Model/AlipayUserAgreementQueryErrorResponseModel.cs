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
    /// AlipayUserAgreementQueryErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayUserAgreementQueryErrorResponseModel")]
    public partial class AlipayUserAgreementQueryErrorResponseModel : IEquatable<AlipayUserAgreementQueryErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum USERNOTEXISTERROR for value: USER_NOT_EXIST_ERROR
            /// </summary>
            [EnumMember(Value = "USER_NOT_EXIST_ERROR")]
            USERNOTEXISTERROR = 1,

            /// <summary>
            /// Enum PRODUCTCODENOTSUPPORTEDERROR for value: PRODUCT_CODE_NOT_SUPPORTED_ERROR
            /// </summary>
            [EnumMember(Value = "PRODUCT_CODE_NOT_SUPPORTED_ERROR")]
            PRODUCTCODENOTSUPPORTEDERROR = 2,

            /// <summary>
            /// Enum USERAGREEMENTNOTEXIST for value: USER_AGREEMENT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "USER_AGREEMENT_NOT_EXIST")]
            USERAGREEMENTNOTEXIST = 3,

            /// <summary>
            /// Enum INVALIDPARAMETER for value: INVALID_PARAMETER
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMETER")]
            INVALIDPARAMETER = 4,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 5,

            /// <summary>
            /// Enum AUTHOREEISNOTMATCH for value: AUTHOREE_IS_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "AUTHOREE_IS_NOT_MATCH")]
            AUTHOREEISNOTMATCH = 6,

            /// <summary>
            /// Enum USERNOTEXSITERROR for value: USER_NOT_EXSIT_ERROR
            /// </summary>
            [EnumMember(Value = "USER_NOT_EXSIT_ERROR")]
            USERNOTEXSITERROR = 7,

            /// <summary>
            /// Enum LOGONIDISREPEATED for value: LOGONID_IS_REPEATED
            /// </summary>
            [EnumMember(Value = "LOGONID_IS_REPEATED")]
            LOGONIDISREPEATED = 8,

            /// <summary>
            /// Enum AGREEMENTHASUNSIGNED for value: AGREEMENT_HAS_UNSIGNED
            /// </summary>
            [EnumMember(Value = "AGREEMENT_HAS_UNSIGNED")]
            AGREEMENTHASUNSIGNED = 9,

            /// <summary>
            /// Enum PARENTMERCHANTQUERYFAIL for value: PARENT_MERCHANT_QUERY_FAIL
            /// </summary>
            [EnumMember(Value = "PARENT_MERCHANT_QUERY_FAIL")]
            PARENTMERCHANTQUERYFAIL = 10,

            /// <summary>
            /// Enum MERCHANTSTATUSISNOTNORMAL for value: MERCHANT_STATUS_IS_NOT_NORMAL
            /// </summary>
            [EnumMember(Value = "MERCHANT_STATUS_IS_NOT_NORMAL")]
            MERCHANTSTATUSISNOTNORMAL = 11

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayUserAgreementQueryErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayUserAgreementQueryErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayUserAgreementQueryErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayUserAgreementQueryErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayUserAgreementQueryErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayUserAgreementQueryErrorResponseModel {\n");
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
            return this.Equals(input as AlipayUserAgreementQueryErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayUserAgreementQueryErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayUserAgreementQueryErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayUserAgreementQueryErrorResponseModel input)
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
