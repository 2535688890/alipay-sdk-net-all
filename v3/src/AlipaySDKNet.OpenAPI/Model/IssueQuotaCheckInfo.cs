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
    /// IssueQuotaCheckInfo
    /// </summary>
    [DataContract(Name = "IssueQuotaCheckInfo")]
    public partial class IssueQuotaCheckInfo : IEquatable<IssueQuotaCheckInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueQuotaCheckInfo" /> class.
        /// </summary>
        /// <param name="issueQuota">发放金额.</param>
        /// <param name="message">校验结果的原因.</param>
        /// <param name="ownerId">入参的 owner_id.</param>
        /// <param name="ownerOpenId">入参的  owner_open_id.</param>
        /// <param name="ownerType">owner_type.</param>
        /// <param name="result">校验结果.</param>
        /// <param name="userName">用户姓名.</param>
        public IssueQuotaCheckInfo(string issueQuota = default(string), string message = default(string), string ownerId = default(string), string ownerOpenId = default(string), string ownerType = default(string), bool result = default(bool), string userName = default(string))
        {
            this.IssueQuota = issueQuota;
            this.Message = message;
            this.OwnerId = ownerId;
            this.OwnerOpenId = ownerOpenId;
            this.OwnerType = ownerType;
            this.Result = result;
            this.UserName = userName;
        }

        /// <summary>
        /// 发放金额
        /// </summary>
        /// <value>发放金额</value>
        [DataMember(Name = "issue_quota", EmitDefaultValue = false)]
        public string IssueQuota { get; set; }

        /// <summary>
        /// 校验结果的原因
        /// </summary>
        /// <value>校验结果的原因</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// 入参的 owner_id
        /// </summary>
        /// <value>入参的 owner_id</value>
        [DataMember(Name = "owner_id", EmitDefaultValue = false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// 入参的  owner_open_id
        /// </summary>
        /// <value>入参的  owner_open_id</value>
        [DataMember(Name = "owner_open_id", EmitDefaultValue = false)]
        public string OwnerOpenId { get; set; }

        /// <summary>
        /// owner_type
        /// </summary>
        /// <value>owner_type</value>
        [DataMember(Name = "owner_type", EmitDefaultValue = false)]
        public string OwnerType { get; set; }

        /// <summary>
        /// 校验结果
        /// </summary>
        /// <value>校验结果</value>
        [DataMember(Name = "result", EmitDefaultValue = true)]
        public bool Result { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        /// <value>用户姓名</value>
        [DataMember(Name = "user_name", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IssueQuotaCheckInfo {\n");
            sb.Append("  IssueQuota: ").Append(IssueQuota).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  OwnerOpenId: ").Append(OwnerOpenId).Append("\n");
            sb.Append("  OwnerType: ").Append(OwnerType).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
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
            return this.Equals(input as IssueQuotaCheckInfo);
        }

        /// <summary>
        /// Returns true if IssueQuotaCheckInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of IssueQuotaCheckInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssueQuotaCheckInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IssueQuota == input.IssueQuota ||
                    (this.IssueQuota != null &&
                    this.IssueQuota.Equals(input.IssueQuota))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.OwnerOpenId == input.OwnerOpenId ||
                    (this.OwnerOpenId != null &&
                    this.OwnerOpenId.Equals(input.OwnerOpenId))
                ) && 
                (
                    this.OwnerType == input.OwnerType ||
                    (this.OwnerType != null &&
                    this.OwnerType.Equals(input.OwnerType))
                ) && 
                (
                    this.Result == input.Result ||
                    this.Result.Equals(input.Result)
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
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
                if (this.IssueQuota != null)
                {
                    hashCode = (hashCode * 59) + this.IssueQuota.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                if (this.OwnerOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerOpenId.GetHashCode();
                }
                if (this.OwnerType != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Result.GetHashCode();
                if (this.UserName != null)
                {
                    hashCode = (hashCode * 59) + this.UserName.GetHashCode();
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
