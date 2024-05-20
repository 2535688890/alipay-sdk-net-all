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
    /// AlipayFundEnterprisepayGroupAddResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundEnterprisepayGroupAddResponseModel")]
    public partial class AlipayFundEnterprisepayGroupAddResponseModel : IEquatable<AlipayFundEnterprisepayGroupAddResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundEnterprisepayGroupAddResponseModel" /> class.
        /// </summary>
        /// <param name="accountId">因公付账户ID.</param>
        /// <param name="fundGroupId">资金群组号.</param>
        /// <param name="outGroupId">外部群组号，业务号.</param>
        public AlipayFundEnterprisepayGroupAddResponseModel(string accountId = default(string), string fundGroupId = default(string), string outGroupId = default(string))
        {
            this.AccountId = accountId;
            this.FundGroupId = fundGroupId;
            this.OutGroupId = outGroupId;
        }

        /// <summary>
        /// 因公付账户ID
        /// </summary>
        /// <value>因公付账户ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 资金群组号
        /// </summary>
        /// <value>资金群组号</value>
        [DataMember(Name = "fund_group_id", EmitDefaultValue = false)]
        public string FundGroupId { get; set; }

        /// <summary>
        /// 外部群组号，业务号
        /// </summary>
        /// <value>外部群组号，业务号</value>
        [DataMember(Name = "out_group_id", EmitDefaultValue = false)]
        public string OutGroupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundEnterprisepayGroupAddResponseModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  FundGroupId: ").Append(FundGroupId).Append("\n");
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
            return this.Equals(input as AlipayFundEnterprisepayGroupAddResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundEnterprisepayGroupAddResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundEnterprisepayGroupAddResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundEnterprisepayGroupAddResponseModel input)
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
