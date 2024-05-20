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
    /// QuotaQueryResponse
    /// </summary>
    [DataContract(Name = "QuotaQueryResponse")]
    public partial class QuotaQueryResponse : IEquatable<QuotaQueryResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaQueryResponse" /> class.
        /// </summary>
        /// <param name="agreementNo">协议号.</param>
        /// <param name="errorCode">单个协议查询结果错误码.</param>
        /// <param name="failReason">单个协议响应错误描述.</param>
        /// <param name="quotaDetails">quotaDetails.</param>
        /// <param name="success">单个协议查询结果是否成功.</param>
        public QuotaQueryResponse(string agreementNo = default(string), string errorCode = default(string), string failReason = default(string), AccountQuotaDetail quotaDetails = default(AccountQuotaDetail), string success = default(string))
        {
            this.AgreementNo = agreementNo;
            this.ErrorCode = errorCode;
            this.FailReason = failReason;
            this.QuotaDetails = quotaDetails;
            this.Success = success;
        }

        /// <summary>
        /// 协议号
        /// </summary>
        /// <value>协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 单个协议查询结果错误码
        /// </summary>
        /// <value>单个协议查询结果错误码</value>
        [DataMember(Name = "error_code", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 单个协议响应错误描述
        /// </summary>
        /// <value>单个协议响应错误描述</value>
        [DataMember(Name = "fail_reason", EmitDefaultValue = false)]
        public string FailReason { get; set; }

        /// <summary>
        /// Gets or Sets QuotaDetails
        /// </summary>
        [DataMember(Name = "quota_details", EmitDefaultValue = false)]
        public AccountQuotaDetail QuotaDetails { get; set; }

        /// <summary>
        /// 单个协议查询结果是否成功
        /// </summary>
        /// <value>单个协议查询结果是否成功</value>
        [DataMember(Name = "success", EmitDefaultValue = false)]
        public string Success { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuotaQueryResponse {\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  FailReason: ").Append(FailReason).Append("\n");
            sb.Append("  QuotaDetails: ").Append(QuotaDetails).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
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
            return this.Equals(input as QuotaQueryResponse);
        }

        /// <summary>
        /// Returns true if QuotaQueryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of QuotaQueryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuotaQueryResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.FailReason == input.FailReason ||
                    (this.FailReason != null &&
                    this.FailReason.Equals(input.FailReason))
                ) && 
                (
                    this.QuotaDetails == input.QuotaDetails ||
                    (this.QuotaDetails != null &&
                    this.QuotaDetails.Equals(input.QuotaDetails))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
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
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.ErrorCode != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
                }
                if (this.FailReason != null)
                {
                    hashCode = (hashCode * 59) + this.FailReason.GetHashCode();
                }
                if (this.QuotaDetails != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaDetails.GetHashCode();
                }
                if (this.Success != null)
                {
                    hashCode = (hashCode * 59) + this.Success.GetHashCode();
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
