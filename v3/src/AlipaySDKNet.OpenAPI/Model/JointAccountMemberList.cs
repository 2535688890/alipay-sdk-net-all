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
    /// JointAccountMemberList
    /// </summary>
    [DataContract(Name = "JointAccountMemberList")]
    public partial class JointAccountMemberList : IEquatable<JointAccountMemberList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JointAccountMemberList" /> class.
        /// </summary>
        /// <param name="accountQuota">额度模型.</param>
        /// <param name="openId">成员openId.</param>
        /// <param name="userId">成员ID.</param>
        public JointAccountMemberList(List<JointAccountQuotaDTO> accountQuota = default(List<JointAccountQuotaDTO>), string openId = default(string), string userId = default(string))
        {
            this.AccountQuota = accountQuota;
            this.OpenId = openId;
            this.UserId = userId;
        }

        /// <summary>
        /// 额度模型
        /// </summary>
        /// <value>额度模型</value>
        [DataMember(Name = "account_quota", EmitDefaultValue = false)]
        public List<JointAccountQuotaDTO> AccountQuota { get; set; }

        /// <summary>
        /// 成员openId
        /// </summary>
        /// <value>成员openId</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 成员ID
        /// </summary>
        /// <value>成员ID</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JointAccountMemberList {\n");
            sb.Append("  AccountQuota: ").Append(AccountQuota).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as JointAccountMemberList);
        }

        /// <summary>
        /// Returns true if JointAccountMemberList instances are equal
        /// </summary>
        /// <param name="input">Instance of JointAccountMemberList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JointAccountMemberList input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountQuota == input.AccountQuota ||
                    this.AccountQuota != null &&
                    input.AccountQuota != null &&
                    this.AccountQuota.SequenceEqual(input.AccountQuota)
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.AccountQuota != null)
                {
                    hashCode = (hashCode * 59) + this.AccountQuota.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
