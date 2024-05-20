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
    /// AlipayMarketingCampaignCashDetailQueryErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingCampaignCashDetailQueryErrorResponseModel")]
    public partial class AlipayMarketingCampaignCashDetailQueryErrorResponseModel : IEquatable<AlipayMarketingCampaignCashDetailQueryErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum UNKNOWSYSTEMERROR for value: UNKNOW_SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "UNKNOW_SYSTEM_ERROR")]
            UNKNOWSYSTEMERROR = 1,

            /// <summary>
            /// Enum CASHCAMPAIGNNOTEXIST for value: CASH_CAMPAIGN_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "CASH_CAMPAIGN_NOT_EXIST")]
            CASHCAMPAIGNNOTEXIST = 2,

            /// <summary>
            /// Enum BIZCONTENTISEMPTY for value: BIZ_CONTENT_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "BIZ_CONTENT_IS_EMPTY")]
            BIZCONTENTISEMPTY = 3,

            /// <summary>
            /// Enum BIZCONTENTFORMATERROR for value: BIZ_CONTENT_FORMAT_ERROR
            /// </summary>
            [EnumMember(Value = "BIZ_CONTENT_FORMAT_ERROR")]
            BIZCONTENTFORMATERROR = 4,

            /// <summary>
            /// Enum PRODUCTISNOTOPENED for value: PRODUCT_IS_NOT_OPENED
            /// </summary>
            [EnumMember(Value = "PRODUCT_IS_NOT_OPENED")]
            PRODUCTISNOTOPENED = 5,

            /// <summary>
            /// Enum CALLTOOFREQUENCY for value: CALL_TOO_FREQUENCY
            /// </summary>
            [EnumMember(Value = "CALL_TOO_FREQUENCY")]
            CALLTOOFREQUENCY = 6,

            /// <summary>
            /// Enum CAMPOPERATORILLEGAL for value: CAMP_OPERATOR_ILLEGAL
            /// </summary>
            [EnumMember(Value = "CAMP_OPERATOR_ILLEGAL")]
            CAMPOPERATORILLEGAL = 7

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCampaignCashDetailQueryErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayMarketingCampaignCashDetailQueryErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCampaignCashDetailQueryErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayMarketingCampaignCashDetailQueryErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayMarketingCampaignCashDetailQueryErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayMarketingCampaignCashDetailQueryErrorResponseModel {\n");
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
            return this.Equals(input as AlipayMarketingCampaignCashDetailQueryErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingCampaignCashDetailQueryErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingCampaignCashDetailQueryErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingCampaignCashDetailQueryErrorResponseModel input)
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
