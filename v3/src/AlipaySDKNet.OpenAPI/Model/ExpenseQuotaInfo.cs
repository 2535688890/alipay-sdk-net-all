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
    /// ExpenseQuotaInfo
    /// </summary>
    [DataContract(Name = "ExpenseQuotaInfo")]
    public partial class ExpenseQuotaInfo : IEquatable<ExpenseQuotaInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseQuotaInfo" /> class.
        /// </summary>
        /// <param name="effectiveEndDate">额度失效时间.</param>
        /// <param name="effectiveStartDate">额度生效时间.</param>
        /// <param name="enterpriseId">企业ID.</param>
        /// <param name="freeze">额度是否冻结，冻结后因公付不可用.</param>
        /// <param name="ownerId">额度所属者ID owner_type为EMPLOYEE时为员工支付宝ID owner_type为ENTERPRISE_PAY_UID时为员工企业码ID owner_type为PHONE时为员工手机号 owner_type为ENTERPRISE时为企业ID.</param>
        /// <param name="ownerOpenId">owner_type为EMPLOYEE时为员工open_id owner_type为PHONE时为员工手机号 owner_type为ENTERPRISE_PAY_UID时为员工企业码ID.</param>
        /// <param name="ownerType">额度所属者id类型.</param>
        /// <param name="quotaAvailable">可用金额（单位分）.</param>
        /// <param name="quotaId">额度ID.</param>
        /// <param name="quotaLocked">锁定金额（单位分）.</param>
        /// <param name="quotaTotal">总金额（单位分）.</param>
        /// <param name="quotaType">额度类型.</param>
        /// <param name="quotaUsed">已用金额（单位分）.</param>
        /// <param name="targetId">额度维度ID 当 target_type&#x3D;EXPENSE_TYPE 时，值为 MEAL（工作餐） 当target_type&#x3D;RULE_GROUP_AGGREGATION 时，值为费控规则聚合ID 当target_type&#x3D;INSTITUTION 时，值为制度ID.</param>
        /// <param name="targetType">额度维度.</param>
        public ExpenseQuotaInfo(string effectiveEndDate = default(string), string effectiveStartDate = default(string), string enterpriseId = default(string), bool freeze = default(bool), string ownerId = default(string), string ownerOpenId = default(string), string ownerType = default(string), string quotaAvailable = default(string), string quotaId = default(string), string quotaLocked = default(string), string quotaTotal = default(string), string quotaType = default(string), string quotaUsed = default(string), string targetId = default(string), string targetType = default(string))
        {
            this.EffectiveEndDate = effectiveEndDate;
            this.EffectiveStartDate = effectiveStartDate;
            this.EnterpriseId = enterpriseId;
            this.Freeze = freeze;
            this.OwnerId = ownerId;
            this.OwnerOpenId = ownerOpenId;
            this.OwnerType = ownerType;
            this.QuotaAvailable = quotaAvailable;
            this.QuotaId = quotaId;
            this.QuotaLocked = quotaLocked;
            this.QuotaTotal = quotaTotal;
            this.QuotaType = quotaType;
            this.QuotaUsed = quotaUsed;
            this.TargetId = targetId;
            this.TargetType = targetType;
        }

        /// <summary>
        /// 额度失效时间
        /// </summary>
        /// <value>额度失效时间</value>
        [DataMember(Name = "effective_end_date", EmitDefaultValue = false)]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 额度生效时间
        /// </summary>
        /// <value>额度生效时间</value>
        [DataMember(Name = "effective_start_date", EmitDefaultValue = false)]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        /// <value>企业ID</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 额度是否冻结，冻结后因公付不可用
        /// </summary>
        /// <value>额度是否冻结，冻结后因公付不可用</value>
        [DataMember(Name = "freeze", EmitDefaultValue = true)]
        public bool Freeze { get; set; }

        /// <summary>
        /// 额度所属者ID owner_type为EMPLOYEE时为员工支付宝ID owner_type为ENTERPRISE_PAY_UID时为员工企业码ID owner_type为PHONE时为员工手机号 owner_type为ENTERPRISE时为企业ID
        /// </summary>
        /// <value>额度所属者ID owner_type为EMPLOYEE时为员工支付宝ID owner_type为ENTERPRISE_PAY_UID时为员工企业码ID owner_type为PHONE时为员工手机号 owner_type为ENTERPRISE时为企业ID</value>
        [DataMember(Name = "owner_id", EmitDefaultValue = false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// owner_type为EMPLOYEE时为员工open_id owner_type为PHONE时为员工手机号 owner_type为ENTERPRISE_PAY_UID时为员工企业码ID
        /// </summary>
        /// <value>owner_type为EMPLOYEE时为员工open_id owner_type为PHONE时为员工手机号 owner_type为ENTERPRISE_PAY_UID时为员工企业码ID</value>
        [DataMember(Name = "owner_open_id", EmitDefaultValue = false)]
        public string OwnerOpenId { get; set; }

        /// <summary>
        /// 额度所属者id类型
        /// </summary>
        /// <value>额度所属者id类型</value>
        [DataMember(Name = "owner_type", EmitDefaultValue = false)]
        public string OwnerType { get; set; }

        /// <summary>
        /// 可用金额（单位分）
        /// </summary>
        /// <value>可用金额（单位分）</value>
        [DataMember(Name = "quota_available", EmitDefaultValue = false)]
        public string QuotaAvailable { get; set; }

        /// <summary>
        /// 额度ID
        /// </summary>
        /// <value>额度ID</value>
        [DataMember(Name = "quota_id", EmitDefaultValue = false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// 锁定金额（单位分）
        /// </summary>
        /// <value>锁定金额（单位分）</value>
        [DataMember(Name = "quota_locked", EmitDefaultValue = false)]
        public string QuotaLocked { get; set; }

        /// <summary>
        /// 总金额（单位分）
        /// </summary>
        /// <value>总金额（单位分）</value>
        [DataMember(Name = "quota_total", EmitDefaultValue = false)]
        public string QuotaTotal { get; set; }

        /// <summary>
        /// 额度类型
        /// </summary>
        /// <value>额度类型</value>
        [DataMember(Name = "quota_type", EmitDefaultValue = false)]
        public string QuotaType { get; set; }

        /// <summary>
        /// 已用金额（单位分）
        /// </summary>
        /// <value>已用金额（单位分）</value>
        [DataMember(Name = "quota_used", EmitDefaultValue = false)]
        public string QuotaUsed { get; set; }

        /// <summary>
        /// 额度维度ID 当 target_type&#x3D;EXPENSE_TYPE 时，值为 MEAL（工作餐） 当target_type&#x3D;RULE_GROUP_AGGREGATION 时，值为费控规则聚合ID 当target_type&#x3D;INSTITUTION 时，值为制度ID
        /// </summary>
        /// <value>额度维度ID 当 target_type&#x3D;EXPENSE_TYPE 时，值为 MEAL（工作餐） 当target_type&#x3D;RULE_GROUP_AGGREGATION 时，值为费控规则聚合ID 当target_type&#x3D;INSTITUTION 时，值为制度ID</value>
        [DataMember(Name = "target_id", EmitDefaultValue = false)]
        public string TargetId { get; set; }

        /// <summary>
        /// 额度维度
        /// </summary>
        /// <value>额度维度</value>
        [DataMember(Name = "target_type", EmitDefaultValue = false)]
        public string TargetType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExpenseQuotaInfo {\n");
            sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
            sb.Append("  EffectiveStartDate: ").Append(EffectiveStartDate).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  Freeze: ").Append(Freeze).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  OwnerOpenId: ").Append(OwnerOpenId).Append("\n");
            sb.Append("  OwnerType: ").Append(OwnerType).Append("\n");
            sb.Append("  QuotaAvailable: ").Append(QuotaAvailable).Append("\n");
            sb.Append("  QuotaId: ").Append(QuotaId).Append("\n");
            sb.Append("  QuotaLocked: ").Append(QuotaLocked).Append("\n");
            sb.Append("  QuotaTotal: ").Append(QuotaTotal).Append("\n");
            sb.Append("  QuotaType: ").Append(QuotaType).Append("\n");
            sb.Append("  QuotaUsed: ").Append(QuotaUsed).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  TargetType: ").Append(TargetType).Append("\n");
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
            return this.Equals(input as ExpenseQuotaInfo);
        }

        /// <summary>
        /// Returns true if ExpenseQuotaInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpenseQuotaInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpenseQuotaInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EffectiveEndDate == input.EffectiveEndDate ||
                    (this.EffectiveEndDate != null &&
                    this.EffectiveEndDate.Equals(input.EffectiveEndDate))
                ) && 
                (
                    this.EffectiveStartDate == input.EffectiveStartDate ||
                    (this.EffectiveStartDate != null &&
                    this.EffectiveStartDate.Equals(input.EffectiveStartDate))
                ) && 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.Freeze == input.Freeze ||
                    this.Freeze.Equals(input.Freeze)
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
                    this.QuotaAvailable == input.QuotaAvailable ||
                    (this.QuotaAvailable != null &&
                    this.QuotaAvailable.Equals(input.QuotaAvailable))
                ) && 
                (
                    this.QuotaId == input.QuotaId ||
                    (this.QuotaId != null &&
                    this.QuotaId.Equals(input.QuotaId))
                ) && 
                (
                    this.QuotaLocked == input.QuotaLocked ||
                    (this.QuotaLocked != null &&
                    this.QuotaLocked.Equals(input.QuotaLocked))
                ) && 
                (
                    this.QuotaTotal == input.QuotaTotal ||
                    (this.QuotaTotal != null &&
                    this.QuotaTotal.Equals(input.QuotaTotal))
                ) && 
                (
                    this.QuotaType == input.QuotaType ||
                    (this.QuotaType != null &&
                    this.QuotaType.Equals(input.QuotaType))
                ) && 
                (
                    this.QuotaUsed == input.QuotaUsed ||
                    (this.QuotaUsed != null &&
                    this.QuotaUsed.Equals(input.QuotaUsed))
                ) && 
                (
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
                ) && 
                (
                    this.TargetType == input.TargetType ||
                    (this.TargetType != null &&
                    this.TargetType.Equals(input.TargetType))
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
                if (this.EffectiveEndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveEndDate.GetHashCode();
                }
                if (this.EffectiveStartDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveStartDate.GetHashCode();
                }
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Freeze.GetHashCode();
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
                if (this.QuotaAvailable != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaAvailable.GetHashCode();
                }
                if (this.QuotaId != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaId.GetHashCode();
                }
                if (this.QuotaLocked != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaLocked.GetHashCode();
                }
                if (this.QuotaTotal != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaTotal.GetHashCode();
                }
                if (this.QuotaType != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaType.GetHashCode();
                }
                if (this.QuotaUsed != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaUsed.GetHashCode();
                }
                if (this.TargetId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetId.GetHashCode();
                }
                if (this.TargetType != null)
                {
                    hashCode = (hashCode * 59) + this.TargetType.GetHashCode();
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
