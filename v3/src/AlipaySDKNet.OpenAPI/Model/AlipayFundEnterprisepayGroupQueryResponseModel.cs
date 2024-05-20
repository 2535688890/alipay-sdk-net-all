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
    /// AlipayFundEnterprisepayGroupQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundEnterprisepayGroupQueryResponseModel")]
    public partial class AlipayFundEnterprisepayGroupQueryResponseModel : IEquatable<AlipayFundEnterprisepayGroupQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundEnterprisepayGroupQueryResponseModel" /> class.
        /// </summary>
        /// <param name="accountId">企业签约账户ID.</param>
        /// <param name="fundGroupId">内部群组号.</param>
        /// <param name="fundIdentity">该群所对应的出资主体账号.</param>
        /// <param name="groupName">群组名称.</param>
        /// <param name="outGroupId">外部群组号.</param>
        public AlipayFundEnterprisepayGroupQueryResponseModel(string accountId = default(string), string fundGroupId = default(string), string fundIdentity = default(string), string groupName = default(string), string outGroupId = default(string))
        {
            this.AccountId = accountId;
            this.FundGroupId = fundGroupId;
            this.FundIdentity = fundIdentity;
            this.GroupName = groupName;
            this.OutGroupId = outGroupId;
        }

        /// <summary>
        /// 企业签约账户ID
        /// </summary>
        /// <value>企业签约账户ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 内部群组号
        /// </summary>
        /// <value>内部群组号</value>
        [DataMember(Name = "fund_group_id", EmitDefaultValue = false)]
        public string FundGroupId { get; set; }

        /// <summary>
        /// 该群所对应的出资主体账号
        /// </summary>
        /// <value>该群所对应的出资主体账号</value>
        [DataMember(Name = "fund_identity", EmitDefaultValue = false)]
        public string FundIdentity { get; set; }

        /// <summary>
        /// 群组名称
        /// </summary>
        /// <value>群组名称</value>
        [DataMember(Name = "group_name", EmitDefaultValue = false)]
        public string GroupName { get; set; }

        /// <summary>
        /// 外部群组号
        /// </summary>
        /// <value>外部群组号</value>
        [DataMember(Name = "out_group_id", EmitDefaultValue = false)]
        public string OutGroupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundEnterprisepayGroupQueryResponseModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  FundGroupId: ").Append(FundGroupId).Append("\n");
            sb.Append("  FundIdentity: ").Append(FundIdentity).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  OutGroupId: ").Append(OutGroupId).Append("\n");
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
            return this.Equals(input as AlipayFundEnterprisepayGroupQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundEnterprisepayGroupQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundEnterprisepayGroupQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundEnterprisepayGroupQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.FundGroupId == input.FundGroupId ||
                    (this.FundGroupId != null &&
                    this.FundGroupId.Equals(input.FundGroupId))
                ) && 
                (
                    this.FundIdentity == input.FundIdentity ||
                    (this.FundIdentity != null &&
                    this.FundIdentity.Equals(input.FundIdentity))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.OutGroupId == input.OutGroupId ||
                    (this.OutGroupId != null &&
                    this.OutGroupId.Equals(input.OutGroupId))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.FundGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.FundGroupId.GetHashCode();
                }
                if (this.FundIdentity != null)
                {
                    hashCode = (hashCode * 59) + this.FundIdentity.GetHashCode();
                }
                if (this.GroupName != null)
                {
                    hashCode = (hashCode * 59) + this.GroupName.GetHashCode();
                }
                if (this.OutGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.OutGroupId.GetHashCode();
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
