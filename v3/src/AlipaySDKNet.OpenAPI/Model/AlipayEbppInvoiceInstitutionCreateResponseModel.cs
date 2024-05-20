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
    /// AlipayEbppInvoiceInstitutionCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceInstitutionCreateResponseModel")]
    public partial class AlipayEbppInvoiceInstitutionCreateResponseModel : IEquatable<AlipayEbppInvoiceInstitutionCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceInstitutionCreateResponseModel" /> class.
        /// </summary>
        /// <param name="institutionId">制度id.</param>
        /// <param name="issueRuleIdInfoList">发放规则id列表.</param>
        /// <param name="standardIdInfoList">使用规则id列表.</param>
        public AlipayEbppInvoiceInstitutionCreateResponseModel(string institutionId = default(string), List<IssueRuleIdInfo> issueRuleIdInfoList = default(List<IssueRuleIdInfo>), List<StandardIdInfo> standardIdInfoList = default(List<StandardIdInfo>))
        {
            this.InstitutionId = institutionId;
            this.IssueRuleIdInfoList = issueRuleIdInfoList;
            this.StandardIdInfoList = standardIdInfoList;
        }

        /// <summary>
        /// 制度id
        /// </summary>
        /// <value>制度id</value>
        [DataMember(Name = "institution_id", EmitDefaultValue = false)]
        public string InstitutionId { get; set; }

        /// <summary>
        /// 发放规则id列表
        /// </summary>
        /// <value>发放规则id列表</value>
        [DataMember(Name = "issue_rule_id_info_list", EmitDefaultValue = false)]
        public List<IssueRuleIdInfo> IssueRuleIdInfoList { get; set; }

        /// <summary>
        /// 使用规则id列表
        /// </summary>
        /// <value>使用规则id列表</value>
        [DataMember(Name = "standard_id_info_list", EmitDefaultValue = false)]
        public List<StandardIdInfo> StandardIdInfoList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceInstitutionCreateResponseModel {\n");
            sb.Append("  InstitutionId: ").Append(InstitutionId).Append("\n");
            sb.Append("  IssueRuleIdInfoList: ").Append(IssueRuleIdInfoList).Append("\n");
            sb.Append("  StandardIdInfoList: ").Append(StandardIdInfoList).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceInstitutionCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceInstitutionCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceInstitutionCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceInstitutionCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InstitutionId == input.InstitutionId ||
                    (this.InstitutionId != null &&
                    this.InstitutionId.Equals(input.InstitutionId))
                ) && 
                (
                    this.IssueRuleIdInfoList == input.IssueRuleIdInfoList ||
                    this.IssueRuleIdInfoList != null &&
                    input.IssueRuleIdInfoList != null &&
                    this.IssueRuleIdInfoList.SequenceEqual(input.IssueRuleIdInfoList)
                ) && 
                (
                    this.StandardIdInfoList == input.StandardIdInfoList ||
                    this.StandardIdInfoList != null &&
                    input.StandardIdInfoList != null &&
                    this.StandardIdInfoList.SequenceEqual(input.StandardIdInfoList)
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
                if (this.InstitutionId != null)
                {
                    hashCode = (hashCode * 59) + this.InstitutionId.GetHashCode();
                }
                if (this.IssueRuleIdInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.IssueRuleIdInfoList.GetHashCode();
                }
                if (this.StandardIdInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.StandardIdInfoList.GetHashCode();
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
