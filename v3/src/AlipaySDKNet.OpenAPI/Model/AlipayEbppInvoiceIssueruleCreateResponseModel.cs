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
    /// AlipayEbppInvoiceIssueruleCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceIssueruleCreateResponseModel")]
    public partial class AlipayEbppInvoiceIssueruleCreateResponseModel : IEquatable<AlipayEbppInvoiceIssueruleCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceIssueruleCreateResponseModel" /> class.
        /// </summary>
        /// <param name="issueRuleId">创建的发放规则ID.</param>
        public AlipayEbppInvoiceIssueruleCreateResponseModel(string issueRuleId = default(string))
        {
            this.IssueRuleId = issueRuleId;
        }

        /// <summary>
        /// 创建的发放规则ID
        /// </summary>
        /// <value>创建的发放规则ID</value>
        [DataMember(Name = "issue_rule_id", EmitDefaultValue = false)]
        public string IssueRuleId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceIssueruleCreateResponseModel {\n");
            sb.Append("  IssueRuleId: ").Append(IssueRuleId).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceIssueruleCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceIssueruleCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceIssueruleCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceIssueruleCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IssueRuleId == input.IssueRuleId ||
                    (this.IssueRuleId != null &&
                    this.IssueRuleId.Equals(input.IssueRuleId))
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
                if (this.IssueRuleId != null)
                {
                    hashCode = (hashCode * 59) + this.IssueRuleId.GetHashCode();
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
