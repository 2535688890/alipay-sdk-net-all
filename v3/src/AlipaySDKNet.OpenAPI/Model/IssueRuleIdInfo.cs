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
    /// IssueRuleIdInfo
    /// </summary>
    [DataContract(Name = "IssueRuleIdInfo")]
    public partial class IssueRuleIdInfo : IEquatable<IssueRuleIdInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueRuleIdInfo" /> class.
        /// </summary>
        /// <param name="issueRuleId">发放规则id.</param>
        /// <param name="outerSourceId">外部发放规则id.</param>
        public IssueRuleIdInfo(string issueRuleId = default(string), string outerSourceId = default(string))
        {
            this.IssueRuleId = issueRuleId;
            this.OuterSourceId = outerSourceId;
        }

        /// <summary>
        /// 发放规则id
        /// </summary>
        /// <value>发放规则id</value>
        [DataMember(Name = "issue_rule_id", EmitDefaultValue = false)]
        public string IssueRuleId { get; set; }

        /// <summary>
        /// 外部发放规则id
        /// </summary>
        /// <value>外部发放规则id</value>
        [DataMember(Name = "outer_source_id", EmitDefaultValue = false)]
        public string OuterSourceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IssueRuleIdInfo {\n");
            sb.Append("  IssueRuleId: ").Append(IssueRuleId).Append("\n");
            sb.Append("  OuterSourceId: ").Append(OuterSourceId).Append("\n");
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
            return this.Equals(input as IssueRuleIdInfo);
        }

        /// <summary>
        /// Returns true if IssueRuleIdInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of IssueRuleIdInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssueRuleIdInfo input)
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
                ) && 
                (
                    this.OuterSourceId == input.OuterSourceId ||
                    (this.OuterSourceId != null &&
                    this.OuterSourceId.Equals(input.OuterSourceId))
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
                if (this.OuterSourceId != null)
                {
                    hashCode = (hashCode * 59) + this.OuterSourceId.GetHashCode();
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
