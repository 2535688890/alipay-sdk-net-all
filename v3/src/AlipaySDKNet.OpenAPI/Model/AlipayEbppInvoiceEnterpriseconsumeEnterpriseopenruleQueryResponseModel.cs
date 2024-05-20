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
    /// AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel")]
    public partial class AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel : IEquatable<AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel" /> class.
        /// </summary>
        /// <param name="enterpriseOpenRuleInfo">enterpriseOpenRuleInfo.</param>
        public AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel(EnterpriseOpenRuleInfo enterpriseOpenRuleInfo = default(EnterpriseOpenRuleInfo))
        {
            this.EnterpriseOpenRuleInfo = enterpriseOpenRuleInfo;
        }

        /// <summary>
        /// Gets or Sets EnterpriseOpenRuleInfo
        /// </summary>
        [DataMember(Name = "enterprise_open_rule_info", EmitDefaultValue = false)]
        public EnterpriseOpenRuleInfo EnterpriseOpenRuleInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel {\n");
            sb.Append("  EnterpriseOpenRuleInfo: ").Append(EnterpriseOpenRuleInfo).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EnterpriseOpenRuleInfo == input.EnterpriseOpenRuleInfo ||
                    (this.EnterpriseOpenRuleInfo != null &&
                    this.EnterpriseOpenRuleInfo.Equals(input.EnterpriseOpenRuleInfo))
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
                if (this.EnterpriseOpenRuleInfo != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseOpenRuleInfo.GetHashCode();
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
