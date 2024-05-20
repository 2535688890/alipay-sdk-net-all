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
    /// AlipayOpenPublicMatchuserLabelDeleteErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicMatchuserLabelDeleteErrorResponseModel")]
    public partial class AlipayOpenPublicMatchuserLabelDeleteErrorResponseModel : IEquatable<AlipayOpenPublicMatchuserLabelDeleteErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum ILLEGALBIZPARAMS for value: ILLEGAL_BIZ_PARAMS
            /// </summary>
            [EnumMember(Value = "ILLEGAL_BIZ_PARAMS")]
            ILLEGALBIZPARAMS = 1,

            /// <summary>
            /// Enum MSGMATCHERINVALID for value: MSG_MATCHER_INVALID
            /// </summary>
            [EnumMember(Value = "MSG_MATCHER_INVALID")]
            MSGMATCHERINVALID = 2,

            /// <summary>
            /// Enum LABELIDISEMPTY for value: LABEL_ID_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "LABEL_ID_IS_EMPTY")]
            LABELIDISEMPTY = 3,

            /// <summary>
            /// Enum MATCHERPARAMSISEMPTY for value: MATCHER_PARAMS_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "MATCHER_PARAMS_IS_EMPTY")]
            MATCHERPARAMSISEMPTY = 4,

            /// <summary>
            /// Enum MOBILENOINVALID for value: MOBILE_NO_INVALID
            /// </summary>
            [EnumMember(Value = "MOBILE_NO_INVALID")]
            MOBILENOINVALID = 5,

            /// <summary>
            /// Enum IDENTITYCARDINVALID for value: IDENTITY_CARD_INVALID
            /// </summary>
            [EnumMember(Value = "IDENTITY_CARD_INVALID")]
            IDENTITYCARDINVALID = 6,

            /// <summary>
            /// Enum LABELNOTEXISTS for value: LABEL_NOT_EXISTS
            /// </summary>
            [EnumMember(Value = "LABEL_NOT_EXISTS")]
            LABELNOTEXISTS = 7,

            /// <summary>
            /// Enum NOTMATCHEDACCOUNT for value: NOT_MATCHED_ACCOUNT
            /// </summary>
            [EnumMember(Value = "NOT_MATCHED_ACCOUNT")]
            NOTMATCHEDACCOUNT = 8,

            /// <summary>
            /// Enum OPENIDISILLEGAL for value: OPEN_ID_IS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "OPEN_ID_IS_ILLEGAL")]
            OPENIDISILLEGAL = 9,

            /// <summary>
            /// Enum USERLABELNOTEXISTS for value: USER_LABEL_NOT_EXISTS
            /// </summary>
            [EnumMember(Value = "USER_LABEL_NOT_EXISTS")]
            USERLABELNOTEXISTS = 10

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicMatchuserLabelDeleteErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenPublicMatchuserLabelDeleteErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicMatchuserLabelDeleteErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenPublicMatchuserLabelDeleteErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenPublicMatchuserLabelDeleteErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenPublicMatchuserLabelDeleteErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenPublicMatchuserLabelDeleteErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicMatchuserLabelDeleteErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicMatchuserLabelDeleteErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicMatchuserLabelDeleteErrorResponseModel input)
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
