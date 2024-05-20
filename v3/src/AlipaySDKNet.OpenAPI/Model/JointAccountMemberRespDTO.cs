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
    /// JointAccountMemberRespDTO
    /// </summary>
    [DataContract(Name = "JointAccountMemberRespDTO")]
    public partial class JointAccountMemberRespDTO : IEquatable<JointAccountMemberRespDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JointAccountMemberRespDTO" /> class.
        /// </summary>
        /// <param name="accountQuota">额度模型.</param>
        /// <param name="logonId">成员支付宝登录号.</param>
        /// <param name="name">姓名.</param>
        /// <param name="status">员工当前状态：  邀请中（PROCESSING）、正常（NORMAL）.</param>
        /// <param name="userId">用户支付宝会员号.</param>
        public JointAccountMemberRespDTO(List<JointAccountQuotaDTO> accountQuota = default(List<JointAccountQuotaDTO>), string logonId = default(string), string name = default(string), string status = default(string), string userId = default(string))
        {
            this.AccountQuota = accountQuota;
            this.LogonId = logonId;
            this.Name = name;
            this.Status = status;
            this.UserId = userId;
        }

        /// <summary>
        /// 额度模型
        /// </summary>
        /// <value>额度模型</value>
        [DataMember(Name = "account_quota", EmitDefaultValue = false)]
        public List<JointAccountQuotaDTO> AccountQuota { get; set; }

        /// <summary>
        /// 成员支付宝登录号
        /// </summary>
        /// <value>成员支付宝登录号</value>
        [DataMember(Name = "logon_id", EmitDefaultValue = false)]
        public string LogonId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        /// <value>姓名</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 员工当前状态：  邀请中（PROCESSING）、正常（NORMAL）
        /// </summary>
        /// <value>员工当前状态：  邀请中（PROCESSING）、正常（NORMAL）</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 用户支付宝会员号
        /// </summary>
        /// <value>用户支付宝会员号</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JointAccountMemberRespDTO {\n");
            sb.Append("  AccountQuota: ").Append(AccountQuota).Append("\n");
            sb.Append("  LogonId: ").Append(LogonId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as JointAccountMemberRespDTO);
        }

        /// <summary>
        /// Returns true if JointAccountMemberRespDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of JointAccountMemberRespDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JointAccountMemberRespDTO input)
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
                    this.LogonId == input.LogonId ||
                    (this.LogonId != null &&
                    this.LogonId.Equals(input.LogonId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.LogonId != null)
                {
                    hashCode = (hashCode * 59) + this.LogonId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
